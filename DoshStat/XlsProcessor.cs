﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DoshStat
{
    class XlsProcessor : ITextProcessor
    {
        // Make it into a singleton
        private static readonly ITextProcessor _instance = new XlsProcessor();
        public static ITextProcessor GetInstance() { return _instance; }
        private XlsProcessor() { }

        private const string SheetEntryName = @"xl/worksheets/sheet(\d+)\.xml";
        private const string SharedStringsEntryName = @"xl/sharedStrings.xml";

        public string GetAllText(string path)
        {
            return Extract(new FileInfo(path).OpenRead());
        }

        public string Extract(Stream stream)
        {
            var result = new StringBuilder();

            using (var zipArchive = new ZipArchive(stream))
            {
                var sharedStringsEntry = zipArchive.Entries.SingleOrDefault(x => x.FullName == SharedStringsEntryName);
                var sharedStrings = GetSharedStrings(sharedStringsEntry);

                var sheetEntries = zipArchive.Entries
                                             .Where(x => Regex.IsMatch(x.FullName, SheetEntryName))
                                             .OrderBy(x => x.Name)
                                             .ToList();

                foreach (var sheetEntry in sheetEntries)
                    ExtractTextFromSheet(sheetEntry, sharedStrings, result);
            }

            return result.ToString();
        }

        private string[] GetSharedStrings(ZipArchiveEntry sharedStringsEntry)
        {
            if (sharedStringsEntry == null)
                return null;

            using (var sharedStringsEntryStream = sharedStringsEntry.Open())
            {
                var document = XDocument.Load(sharedStringsEntryStream);
                var defaultNamespace = document.Root.GetDefaultNamespace();

                var sharedStrings = document.Descendants(XName.Get("si", defaultNamespace.NamespaceName));

                return sharedStrings.Select(x => x.Value)
                                    .ToArray();
            }
        }

        private void ExtractTextFromSheet(ZipArchiveEntry sheetEntry, string[] sharedStrings, StringBuilder result)
        {
            if (sheetEntry == null)
                return;

            using (var sheetEntryStream = sheetEntry.Open())
            {
                var document = XDocument.Load(sheetEntryStream);
                var defaultNamespace = document.Root.GetDefaultNamespace();

                foreach (var row in document.Descendants(XName.Get("row", defaultNamespace.NamespaceName)))
                {
                    var columnValues = row.Descendants(XName.Get("c", defaultNamespace.NamespaceName))
                                          .Select(x => GetColumnValue(x, sharedStrings));

                    result.AppendLine(string.Join(" ", columnValues));
                }
            }
        }

        private string GetColumnValue(XElement column, string[] sharedStrings)
        {
            var typeAttribute = column.Attribute("t");

            if (typeAttribute == null)
                return column.Value;

            if (typeAttribute.Value != "s")
                return null;

            return sharedStrings[int.Parse(column.Value)];
        }
    }
}

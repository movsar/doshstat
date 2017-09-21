using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DocFrequencies
{
    /// <summary>
    ///     Экстрактор текста из файлов .odt
    /// </summary>
    public class OdtProcessor
    {
        private const string ContentFileName = "content.xml";

        public string GetAllText()
        {
            var form = Form.ActiveForm as frmMain;
            form.lblStatus.Text = "Читаю Odt ... ";
            form.Refresh();

            string allText = "";
            foreach (string filePath in (new Utils()).FindFilesRecursively("*.odt"))
            {
                    allText += Extract(new FileInfo(filePath).OpenRead());
            }

            return allText;
        }


        public string Extract(Stream stream)
        {
            using (var zipArchive = new ZipArchive(stream))
            {
                var contentEntry = zipArchive.Entries.SingleOrDefault(x => x.Name == ContentFileName);

                if (contentEntry == null)
                    throw new InvalidOperationException("Can not find content.xml in ODT file");

                using (var contentEntryStream = contentEntry.Open())
                {
                    var document = XDocument.Load(contentEntryStream);

                    return document.Root?.Value;
                }
            }
        }
    }
}
using HtmlAgilityPack;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DocFrequencies
{
    class HtmProcessor : IContentExtractor
    {
        public string GetAllText()
        {
            var form = Form.ActiveForm as frmMain;
            form.lblStatus.Text = "Читаю Htm и Html ... ";
            form.Refresh();

            string allText = "";

            foreach (string filePath in (new Utils()).FindFilesRecursively("*.htm?"))
            {
                allText += Extract(new FileInfo(filePath).OpenRead());
            }
            return allText;
        }


    public string Extract(Stream stream)
        {
            using (var reader = new StreamReader(stream))
            {
                var fileContent = reader.ReadToEnd();

                if (fileContent.StartsWith("<?xml"))
                {
                    var document = XDocument.Parse(fileContent);
                    stream.Seek(0, SeekOrigin.Begin);
                    using (var xmlStream = new StreamReader(stream, Encoding.GetEncoding(document.Declaration.Encoding)))
                    {
                        var xmlContent = xmlStream.ReadToEnd();
                        var xDocument = XDocument.Parse(xmlContent);

                        var metaNodes = xDocument.Descendants().Where(x => x.Name == "documentMetas");
                        foreach (var metaNode in metaNodes.ToList())
                            metaNode.Remove();

                        var result = new StringBuilder();

                        foreach (var element in xDocument.Descendants())
                        {
                            if (element.Descendants().Any())
                                continue;

                            result.Append(element.Value);
                            result.AppendLine();
                        }

                        return result.ToString();
                    }
                }

                var htmlDocument = new HtmlAgilityPack.HtmlDocument();

                htmlDocument.LoadHtml(fileContent);

                var scriptNodes = htmlDocument.DocumentNode.SelectNodes("//script");

                if (scriptNodes != null)
                    foreach (var scriptNode in scriptNodes)
                        scriptNode.Remove();

                var styleNodes = htmlDocument.DocumentNode.SelectNodes("//style");

                if (styleNodes != null)
                    foreach (var styleNode in styleNodes)
                        styleNode.Remove();

                return HttpUtility.HtmlDecode(htmlDocument.DocumentNode.InnerText).Trim();
            }
        }
    }
}

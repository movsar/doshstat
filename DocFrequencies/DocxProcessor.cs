namespace DoshStat
{
    public sealed class DocxProcessor : ITextProcessor
    {
        // Make it into a singleton
        private static readonly ITextProcessor _instance = new DocxProcessor();
        public static ITextProcessor GetInstance() { return _instance; }
        private DocxProcessor() { }

        public string GetAllText(string path)
        {
            CSUsingOpenXmlPlainText.GetWordPlainText docxReaderObj = new CSUsingOpenXmlPlainText.GetWordPlainText(path);
            return docxReaderObj.ReadWordDocument();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DocFrequencies
{
    public class RtfProcessor
    {

        public string GetAllText()
        {
            var form = Form.ActiveForm as frmMain;
            form.lblStatus.Text = "Читаю Rtf ... ";
            form.Refresh();

            string allText = "";

            RichTextBox rtb = new RichTextBox();
            foreach (string filePath in (new Utils()).FindFilesRecursively("*.rtf"))
            {
                rtb.Rtf = File.ReadAllText(filePath);
                allText += rtb.Text;
            }

            return allText;
        }
    }
}

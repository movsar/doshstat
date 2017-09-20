using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DocFrequencies
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            /*  ANNOTATION
             *  The software should be able to read pdf,doc,txt and odf
             *  The software should take all files in the input folder and read them one at a time
             *  The software should prepare lists of words with their frequencie
             *  The software should be awesome
             *  
             *  TODO:
             *  1.  Import doc, docx reader library
             *  2.  Import pdf reader library
             *  3.  Import odf reader library
             *  4.  Create functions for each supporting format
             *  5.  Create open file dialog to show the location of files
             *  6.  List the files filtering the extension
             *  7.  Take a file, read all of its contents
             *  8.  Scan through file and create a list of frequencies for each file
             *  9.  Sum-up the frequency files
             *  10. Voila!
            */


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Utils.WorkDirPath = Environment.CurrentDirectory + "\\input\\";
            txtWorkingDir.Text = Utils.WorkDirPath;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Do not allow the user to create new files via the FolderBrowserDialog.
            fbWorkingDir.ShowNewFolderButton = false;
            fbWorkingDir.RootFolder = Environment.SpecialFolder.Personal;
            DialogResult result = fbWorkingDir.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtWorkingDir.Text = fbWorkingDir.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string everything = "";
            DocProcessor docProcessor = new DocProcessor();
            everything += docProcessor.GetAllText();
            PdfProcessor pdfProcessor = new PdfProcessor();
            everything += pdfProcessor.GetAllText();
            TxtProcessor txtProcessor = new TxtProcessor();
            everything += txtProcessor.GetAllText();

            File.WriteAllText("output.txt", everything, Encoding.UTF8);
            MessageBox.Show("Ok");

        }
    }
}

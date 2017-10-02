using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrangeWords
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
            comboBox1.Items.Add("Автоопределение");
            foreach (var enc in System.Text.Encoding.GetEncodings()) {
                comboBox1.Items.Add(enc.Name);
            }
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {


            if (Utils.StgGetInt("TxtCodepage") == 0) {
                comboBox1.Text = "Автоопределение";
            } else {
                // Saved encoding
                Encoding enc = Encoding.GetEncoding(Utils.StgGetInt("TxtCodepage"));
                comboBox1.Text = enc.WebName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                Utils.StgSet("TxtCodepage", 0);
            else
                Utils.StgSet("TxtCodepage", Encoding.GetEncoding(comboBox1.Text).CodePage);

             Close();
        }
    }
}

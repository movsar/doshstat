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

namespace wFrequencies
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
            comboBox1.Items.Add("Автоопределение");
            foreach (var enc in System.Text.Encoding.GetEncodings())
            {
                comboBox1.Items.Add(enc.Name);
            }
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default["TxtCodepage"].ToString() == "0")
            {
                comboBox1.Text = "Автоопределение";
            }
            else
            {
                // Saved encoding
                Encoding enc = Encoding.GetEncoding(Convert.ToInt32(Properties.Settings.Default["TxtCodepage"].ToString()));
                comboBox1.Text = enc.WebName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                Properties.Settings.Default["TxtCodepage"] = 0;
            else
                Properties.Settings.Default["TxtCodepage"] = Encoding.GetEncoding(comboBox1.Text).CodePage;


            Properties.Settings.Default.Save(); // Saves settings in application configuration file
            Close();
        }
    }
}

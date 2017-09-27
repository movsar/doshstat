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
            comboBox1.Items.Add("auto");
            foreach (var enc in System.Text.Encoding.GetEncodings())
            {
                comboBox1.Items.Add(enc.Name);
            }
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            string settings = "";
            settings = Properties.Settings.Default["TxtCodepage"].ToString();
            if (Properties.Settings.Default["TxtCodepage"].ToString() == "auto")
            {
                comboBox1.SelectedItem = "auto";
            }
            else
            {
                comboBox1.SelectedItem = Encoding.GetEncoding(Properties.Settings.Default["TxtCodepage"]);
            }
            Debug.WriteLine(settings);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                Properties.Settings.Default["TxtCodepage"] = "auto";
            else
                Properties.Settings.Default["TxtCodepage"] = Encoding.GetEncoding(comboBox1.SelectedItem.ToString()).CodePage;


            Properties.Settings.Default.Save(); // Saves settings in application configuration file
        }
    }
}

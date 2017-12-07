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

namespace DoshStat
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
            comboBox2.SelectedIndex = Utils.StgGetInt("ExStyle");
            checkBox1.Checked = Utils.StgGetBool("ShowResultsImmediately");
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
            /*----------------------------------------
             * 0 Такой же как в программе
             * 1 Синий
             * 2 Зеленый
             * 3 Оранжевый
             * 4 Без стиля
             ----------------------------------------*/

            if (comboBox1.SelectedIndex == 0)
                Utils.StgSet("TxtCodepage", 0);
            else
                Utils.StgSet("TxtCodepage", Encoding.GetEncoding(comboBox1.Text).CodePage);

            Utils.StgSet("ExStyle", comboBox2.SelectedIndex);

            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Utils.StgSet("ShowResultsImmediately",checkBox1.Checked);            
        }
    }
}

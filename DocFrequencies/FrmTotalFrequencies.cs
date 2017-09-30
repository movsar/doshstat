using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wFrequencies
{
    public partial class FrmTotalFrequencies : Form
    {
        public FrmTotalFrequencies()
        {
            InitializeComponent();
        }

        private void TotalFrequencies_Load(object sender, EventArgs e)
        {
            olvTotalFrequencies.SetObjects(DbHelper.GetTotalFrequencies());
        }
    }
}

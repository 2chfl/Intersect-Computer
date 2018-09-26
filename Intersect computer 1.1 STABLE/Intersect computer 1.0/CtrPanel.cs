using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Intersect_computer_1._0
{
    public partial class CtrPanel : Form
    {
        Run run = new Run();
        public CtrPanel()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
                this.BackgroundImage = global::Intersect_computer_1._0.Properties.Resources.Activate2;
                run.Show();
                button2.Visible = false;
                button2.Enabled = false;
                this.Invalidate();
        }

        private void CtrPanel_Load(object sender, EventArgs e)
        {
            MainForm.PanelIsRun = true;
        }

        private void CtrPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.PanelIsRun = false;
            if (MainForm.RunIsRun == true)
            {
                run.Close();
                MainForm.RunIsRun = false;
            }
        }

    }
}

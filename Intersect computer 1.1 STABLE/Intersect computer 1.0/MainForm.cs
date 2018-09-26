using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Intersect_computer_1._0
{
    public partial class MainForm : Form
    {
        public static string FontName = "Arial";
        public static int FontSize = 35;
        public static int delayShow = 25, delayWord = 0;


        public MainForm()
        {
            InitializeComponent();
            this.Hide();
            LoadForm LF = new LoadForm();
            LF.Show();
            Thread.Sleep(1500);
            LF.Close();
            this.Show();
            RunIsRun = false; 
            PanelIsRun = false;
            this.BackgroundImage = global::Intersect_computer_1._0.Properties.Resources.MainForm;
        }

        public static bool RunIsRun;
        public static bool PanelIsRun;
        public static bool AddTxtIsRun;
        public static bool SettIsRun;
        public static bool AboutIsRun;

        private void button1_Click(object sender, EventArgs e)
        {
            CtrPanel CP = new CtrPanel();
            if (PanelIsRun == false)
            {
                CP.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddText AT = new AddText();
            if (AddTxtIsRun == false)
            {
                AT.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            if (SettIsRun == false)
            {
                set.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            About about = new About();
            if (AboutIsRun == false)
            {
                about.Show();
            }
        }




        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Intersect_computer_1._0
{
    public partial class Settings : Form
    {
        public string[] colorNames;
        public Settings()
        {
            InitializeComponent();
            FontList.Text = MainForm.FontName;
            SizeList.Text = Convert.ToString(MainForm.FontSize);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            MainForm.SettIsRun = true;
            System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
            foreach (FontFamily font in fonts.Families)
            {
                FontList.Items.Add(font.Name);
            }
            textBox1.Text = Convert.ToString(MainForm.delayShow); 
            textBox2.Text = Convert.ToString(MainForm.delayWord);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.FontName = FontList.Text;
            MainForm.FontSize = Convert.ToInt32(SizeList.Text);
            if (MainForm.FontSize < 0 || MainForm.FontSize > 120)
            {
                MainForm.FontSize = 35;
            }
            MainForm.delayShow = Convert.ToInt32(textBox1.Text);
            if (MainForm.delayShow < 0)
            {
                MainForm.delayShow = 0;
            }
            MainForm.delayWord = Convert.ToInt32(textBox2.Text);
            if (MainForm.delayWord < 0)
            {
                MainForm.delayWord = 0;
            }
            this.Close();
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.SettIsRun = false;
        }

    }
}

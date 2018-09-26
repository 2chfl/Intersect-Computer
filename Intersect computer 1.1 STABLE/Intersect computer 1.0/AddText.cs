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
    public partial class AddText : Form
    {
        public static string[] links = new string[100];
        public static string[][] texts = new string[100][];
        public static int TxtsCntr = 0;

        public AddText()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (File.Exists(LinkAdd.Text))
            {
                TxtsCntr++;
                if (TxtsCntr == 100)
                {
                    add.Enabled = false;
                }
                links[TxtsCntr] = LinkAdd.Text;
                LogBox.Text += "Файл " + LinkAdd.Text + " добавлен.\n";
                LinkAdd.Text = "";
            }
            else
            {
                LogBox.Text += "Ошибка. Файл " + LinkAdd.Text + " не был добавлен.\nПроверьте директорию.\n";
                LinkAdd.Text = "";
            }
        }

        private void Mix_Click(object sender, EventArgs e)
        {
            if (TxtsCntr > 1)
            {
                using (var sw = new StreamWriter(@"sublims.txt", append: false))
                {
                    sw.WriteLine("");
                }

                int counter = 0;
                for (counter = 1; counter < TxtsCntr; counter++)
                {
                    texts[counter] = System.IO.File.ReadAllLines(links[counter]);
                }

                int[] TextLineCounters = new int[TxtsCntr - 1];
                for (counter = 0; counter < TxtsCntr - 1; counter++)
                {
                    TextLineCounters[counter] = 1;
                }

                bool[] TextIsRead = new bool[TxtsCntr - 1];
                for (counter = 0; counter < TxtsCntr - 1; counter++)
                {
                    TextIsRead[counter] = false;
                }

                int biggest = 0;
                for (counter = 1; counter < TxtsCntr; counter++)
                {
                    if (texts[counter].Length > biggest)
                    {
                        biggest = texts[counter].Length;
                    }
                }

                counter = 0;

                bool allRead = false;

                while (allRead == false)
                {
                    for (counter = 1; counter < TxtsCntr; counter++)
                    {
                        if (TextLineCounters[counter - 1] < texts[counter].Length)
                        {
                            using (var sw = new StreamWriter("sublims.txt", append: true))
                            {
                                if (!String.IsNullOrWhiteSpace(texts[counter][TextLineCounters[counter - 1]]))
                                {
                                    sw.WriteLine(texts[counter][TextLineCounters[counter - 1]]);
                                }
                            }
                            TextLineCounters[counter - 1]++;
                        }
                        else
                        {
                            TextIsRead[counter - 1] = true;
                            TextLineCounters[counter - 1] = 0;
                        }
                    }

                    for (int i = 0; i < TxtsCntr - 1; i++)
                    {
                        if (!TextIsRead[i])
                        {
                            allRead = false;
                            break;
                        }
                        else
                        {
                            allRead = true;
                        }
                    }
                }
            }
            else if (TxtsCntr == 1)
            {
                using (var sw = new StreamWriter(@"sublims.txt", append: false))
                {
                    sw.WriteLine("");
                }

                texts[0] = System.IO.File.ReadAllLines(links[1]);
                for (int counter = 0; counter < texts[0].Length; counter++)
                {
                    using (var sw = new StreamWriter("sublims.txt", append: true))
                    {
                        if (!String.IsNullOrWhiteSpace(texts[0][counter]))
                        {
                            sw.WriteLine(texts[0][counter]);
                        }
                    }
                }

            }
            this.Close();
            MainForm.AddTxtIsRun = false;
        }

        private void AddText_Load(object sender, EventArgs e)
        {
            MainForm.AddTxtIsRun = true;
        }

        private void AddText_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.AddTxtIsRun = false;
        }

    }
}

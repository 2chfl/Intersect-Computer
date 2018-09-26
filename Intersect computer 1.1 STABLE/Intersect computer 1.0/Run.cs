using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Intersect_computer_1._0
{
    public partial class Run : Form
    {

        String[] sublims;
        bool StartSublim = false;
        Brush[] FntColour = {   Brushes.AliceBlue, Brushes.AntiqueWhite, Brushes.Aqua, Brushes.Aquamarine, Brushes.Azure, Brushes.Beige, Brushes.Bisque, Brushes.Black, Brushes.BlanchedAlmond, Brushes.Blue, 
                                Brushes.BlueViolet, Brushes.Brown, Brushes.BurlyWood, Brushes.CadetBlue, Brushes.Chartreuse, Brushes.Chocolate, Brushes.Coral, Brushes.CornflowerBlue, Brushes.Cornsilk, 
                                Brushes.Crimson, Brushes.Cyan, Brushes.DarkBlue, Brushes.DarkCyan, Brushes.DarkGoldenrod, Brushes.DarkGray, Brushes.DarkGreen, Brushes.DarkKhaki, Brushes.DarkMagenta, 
                                Brushes.DarkOliveGreen, Brushes.DarkOrange, Brushes.DarkOrchid, Brushes.DarkRed, Brushes.DarkSalmon, Brushes.DarkSeaGreen, Brushes.DarkSlateBlue, Brushes.DarkSlateGray, 
                                Brushes.DarkTurquoise, Brushes.DarkViolet, Brushes.DeepPink, Brushes.DeepSkyBlue, Brushes.DimGray, Brushes.DodgerBlue, Brushes.Firebrick, Brushes.FloralWhite, 
                                Brushes.ForestGreen, Brushes.Fuchsia, Brushes.Gainsboro, Brushes.GhostWhite, Brushes.Gold, Brushes.Goldenrod, Brushes.Gray, Brushes.Green, Brushes.GreenYellow, 
                                Brushes.Honeydew, Brushes.HotPink, Brushes.IndianRed, Brushes.Indigo, Brushes.Ivory, Brushes.Khaki, Brushes.Lavender, Brushes.LavenderBlush, Brushes.LawnGreen, 
                                Brushes.LemonChiffon, Brushes.LightBlue, Brushes.LightCoral, Brushes.LightCyan, Brushes.LightGoldenrodYellow, Brushes.LightGray, Brushes.LightGreen, Brushes.LightPink, 
                                Brushes.LightSalmon, Brushes.LightSeaGreen, Brushes.LightSkyBlue, Brushes.LightSlateGray, Brushes.LightSteelBlue, Brushes.LightYellow, Brushes.Lime, Brushes.LimeGreen, 
                                Brushes.Linen, Brushes.Magenta, Brushes.Maroon, Brushes.MediumAquamarine, Brushes.MediumBlue, Brushes.MediumOrchid, Brushes.MediumPurple, Brushes.MediumSeaGreen, 
                                Brushes.MediumSlateBlue, Brushes.MediumSpringGreen, Brushes.MediumTurquoise, Brushes.MediumVioletRed, Brushes.MidnightBlue, Brushes.MintCream, Brushes.MistyRose, 
                                Brushes.Moccasin, Brushes.NavajoWhite, Brushes.Navy, Brushes.OldLace, Brushes.Olive, Brushes.OliveDrab, Brushes.Orange, Brushes.OrangeRed, Brushes.Orchid, 
                                Brushes.PaleGoldenrod, Brushes.PaleGreen, Brushes.PaleTurquoise, Brushes.PaleVioletRed, Brushes.PapayaWhip, Brushes.PeachPuff, Brushes.Peru, Brushes.Pink, 
                                Brushes.Plum, Brushes.PowderBlue, Brushes.Purple, Brushes.Red, Brushes.RosyBrown, Brushes.RoyalBlue, Brushes.SaddleBrown, Brushes.Salmon, Brushes.SandyBrown, 
                                Brushes.SeaGreen, Brushes.SeaShell, Brushes.Sienna, Brushes.Silver, Brushes.SkyBlue, Brushes.SlateBlue, Brushes.SlateGray, Brushes.Snow, Brushes.SpringGreen, 
                                Brushes.SteelBlue, Brushes.Tan, Brushes.Teal, Brushes.Thistle, Brushes.Tomato, Brushes.Turquoise, Brushes.Violet, Brushes.Wheat, Brushes.White, Brushes.WhiteSmoke, 
                                Brushes.Yellow, Brushes.YellowGreen};
        int Number;
        Random pos = new Random();
        int x, y;
        Font LOH = new Font(MainForm.FontName, MainForm.FontSize);
        int sc = 0;

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        private const int ExStyle = -20;

        private const int Transparent = 0x20;

        private const int Layered = 0x80000;

        private int initialStyle;

        public Run()
        {
            InitializeComponent();
            initialStyle = GetWindowLong(Handle, ExStyle);
            TransparencyKey = BackColor;
            SetWindowLong(Handle, ExStyle, initialStyle | Layered | Transparent);
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            TopMost = true;
            MainForm.RunIsRun = true;
        }

        private void Run_Load(object sender, EventArgs e)
        {
            bool close = false;
            try
            {
                sublims = System.IO.File.ReadAllLines("sublims.txt");
                if (String.IsNullOrWhiteSpace(sublims[3]))
                {
                    if (close == false)
                    {
                        this.Close();
                        close = true;
                    }
                    MessageBox.Show("NO DATA", "ERROR", MessageBoxButtons.OK);
                }
                else
                {
                    StartSublim = true;
                    this.Invalidate();
                }
            }
            catch (Exception)
            {
                if (close == false)
                {
                    this.Close();
                    close = true;
                }
                MessageBox.Show("NO DATA", "ERROR", MessageBoxButtons.OK);
            }

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (StartSublim == true)
            {
                Thread.Sleep(MainForm.delayWord);
                sc++;
                if (sc == sublims.Length)
                {
                    sc = 0;
                }
                x = pos.Next(-500, 500);
                y = pos.Next(1, 1050);
                int huita = pos.Next(3);
                if (huita > 1) { this.Invalidate(); }
                Number = pos.Next(0, FntColour.Length - 1);
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                e.Graphics.DrawString(sublims[sc], LOH, FntColour[Number], x, y);
                Thread.Sleep(MainForm.delayShow);
                this.Invalidate();
            }
        }

        const int WM_NCHITTEST = 0x0084;
        const int HTTRANSPARENT = -1;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)HTTRANSPARENT;
                return;
            }
            base.WndProc(ref m);
        }

    }
}

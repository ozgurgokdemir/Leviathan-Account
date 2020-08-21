using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Leviathan_Account
{
    public partial class Form1 : Form
    {
        public FormMenu formMenu = new FormMenu();
        public Panel pnFormMenu = new Panel();
        public FormSettings formSettings = new FormSettings();
        public Panel pnFormSettings = new Panel();
        public Form1()
        {
            InitializeComponent();
            displayPanel.Controls.Add(formMenu.pnFormMenu);
            displayPanel.Controls.Add(formSettings.pnFormSettings);
        }
        public struct RGBColors
        {
            // Colored
            public static Color colorBlue = Color.FromArgb(62, 166, 255);
            // Dark Theme
            public static Color color1 = Color.FromArgb(24, 24, 24);
            public static Color color2 = Color.FromArgb(28, 28, 28);
            public static Color color3 = Color.FromArgb(32, 32, 32);
            // Cheme 2
            public static Color color4 = Color.FromArgb(16, 20, 43);
            public static Color color5 = Color.FromArgb(20, 25, 53);
            public static Color color6 = Color.FromArgb(28, 35, 64);
        }
        #region "Title"
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            formSettings.pnFormSettings.BringToFront();
        }
        #endregion
    }
}

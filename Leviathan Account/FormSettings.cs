using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leviathan_Account
{
    public partial class FormSettings : Form
    {
        public Form1 form1;
        public FormMenu formMenu;
        public FormSettings()
        {
            InitializeComponent();
            pnEmail.Location = new Point((pnFormSettings.Width / 2) - (pnEmail.Width / 2), (pnFormSettings.Height / 2) - (pnEmail.Height / 2));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnFormSettings.SendToBack();
        }
    }
}

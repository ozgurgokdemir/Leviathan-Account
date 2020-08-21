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
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
            pnAccount.Location = new Point((pnFormAccount.Width / 2) - (pnAccount.Width / 2), (pnFormAccount.Height / 2) - (pnAccount.Height / 2));
            title.Location = new Point((titlePanel.Width / 2) - (title.Width / 2), (titlePanel.Height / 2) - (title.Height / 2));
        }
    }
}

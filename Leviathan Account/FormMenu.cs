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
    public partial class FormMenu : Form
    {
        public FormAdd formAdd;
        public FormMenu formMenu;
        public FormMenu()
        {
            InitializeComponent();
            title.Location = new Point((pnTitle.Width / 2) - (title.Width / 2), (pnTitle.Height / 2) - (title.Height / 2));
            formMenu = this;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            formAdd = new FormAdd(formMenu);
            displayPanel.Controls.Add(formAdd.pnFormAdd);
        }
    }
}

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
    public partial class FormAdd : Form
    {
        private FormMenu _formMenu;
        public static int buttonCount;
        public FormAdd(FormMenu formMenu)
        {
            InitializeComponent();
            pnSaveAcc.Location = new Point((pnFormAdd.Width / 2) - (pnSaveAcc.Width / 2), (pnFormAdd.Height / 2) - (pnSaveAcc.Height / 2));
            title.Location = new Point((titlePanel.Width / 2) - (title.Width / 2), (titlePanel.Height / 2) - (title.Height / 2));
            _formMenu = formMenu;
        }
        private void SaveAccount()
        {
            _formMenu.pnAccounts.Height += 50;
            Button account = new Button();
            _formMenu.pnAccounts.Controls.Add(account);
            account.Dock = DockStyle.Top;
            account.Height = 49;
            account.FlatStyle = FlatStyle.Flat;
            account.FlatAppearance.BorderSize = 0;
            account.ForeColor = Color.FromArgb(197, 197, 197);
            account.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            string buttonName = tbInfo.Text;
            string accountInfo = "     Account Info: " + tbInfo.Text + Environment.NewLine +
                                 Environment.NewLine + "     User Name: " + tbUsername.Text + Environment.NewLine +
                                 Environment.NewLine + "     Password: " + tbPassword.Text + Environment.NewLine;
            account.Text = buttonName;
            account.Name = buttonName;
            account.Click += (s, e) => { MessageBox.Show(accountInfo, "ACCOUNT", MessageBoxButtons.OK, MessageBoxIcon.Information); };
            account.BringToFront();
            Panel shadow = new Panel();
            _formMenu.pnAccounts.Controls.Add(shadow);
            shadow.Dock = DockStyle.Top;
            shadow.Height = 1;
            shadow.BackColor = Color.FromArgb(24, 24, 24);
            shadow.BringToFront();
            buttonCount++;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbInfo.Text != "")
                SaveAccount();
            else
                MessageBox.Show("You need to type the information!");
        }
    }
}
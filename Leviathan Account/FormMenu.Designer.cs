using System.Drawing;

namespace Leviathan_Account
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnAccounts = new System.Windows.Forms.Panel();
            this.shadow1 = new System.Windows.Forms.Panel();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.pnFormMenu = new System.Windows.Forms.Panel();
            this.shadow2 = new System.Windows.Forms.Panel();
            this.pnMenu.SuspendLayout();
            this.pnTitle.SuspendLayout();
            this.pnFormMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnMenu.Controls.Add(this.pnAccounts);
            this.pnMenu.Controls.Add(this.shadow2);
            this.pnMenu.Controls.Add(this.btnAdd);
            this.pnMenu.Controls.Add(this.shadow1);
            this.pnMenu.Controls.Add(this.pnTitle);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(200, 570);
            this.pnMenu.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::Leviathan_Account.Properties.Resources.add_32px;
            this.btnAdd.Location = new System.Drawing.Point(0, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 50);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnAccounts
            // 
            this.pnAccounts.AutoScroll = true;
            this.pnAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAccounts.Location = new System.Drawing.Point(0, 102);
            this.pnAccounts.MaximumSize = new System.Drawing.Size(0, 448);
            this.pnAccounts.Name = "pnAccounts";
            this.pnAccounts.Size = new System.Drawing.Size(200, 0);
            this.pnAccounts.TabIndex = 2;
            // 
            // shadow1
            // 
            this.shadow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.shadow1.Dock = System.Windows.Forms.DockStyle.Top;
            this.shadow1.Location = new System.Drawing.Point(0, 50);
            this.shadow1.Name = "shadow1";
            this.shadow1.Size = new System.Drawing.Size(200, 1);
            this.shadow1.TabIndex = 1;
            // 
            // pnTitle
            // 
            this.pnTitle.Controls.Add(this.title);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(200, 50);
            this.pnTitle.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.title.Location = new System.Drawing.Point(45, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(110, 25);
            this.title.TabIndex = 0;
            this.title.Text = "ACCOUNTS";
            // 
            // displayPanel
            // 
            this.displayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.displayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayPanel.Location = new System.Drawing.Point(200, 0);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(800, 570);
            this.displayPanel.TabIndex = 5;
            // 
            // pnFormMenu
            // 
            this.pnFormMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pnFormMenu.Controls.Add(this.displayPanel);
            this.pnFormMenu.Controls.Add(this.pnMenu);
            this.pnFormMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFormMenu.Location = new System.Drawing.Point(0, 0);
            this.pnFormMenu.Name = "pnFormMenu";
            this.pnFormMenu.Size = new System.Drawing.Size(1000, 570);
            this.pnFormMenu.TabIndex = 6;
            // 
            // shadow2
            // 
            this.shadow2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.shadow2.Dock = System.Windows.Forms.DockStyle.Top;
            this.shadow2.Location = new System.Drawing.Point(0, 101);
            this.shadow2.Name = "shadow2";
            this.shadow2.Size = new System.Drawing.Size(200, 1);
            this.shadow2.TabIndex = 6;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 570);
            this.Controls.Add(this.pnFormMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.pnMenu.ResumeLayout(false);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.pnFormMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel shadow1;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label title;
        public System.Windows.Forms.Panel pnFormMenu;
        public System.Windows.Forms.Panel displayPanel;
        public System.Windows.Forms.Panel pnAccounts;
        public System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel shadow2;
    }
}
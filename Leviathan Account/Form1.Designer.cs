using System.Drawing;

namespace Leviathan_Account
{
    partial class Form1
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
            this.pnTitle = new System.Windows.Forms.Panel();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnTitle.Controls.Add(this.btnSet);
            this.pnTitle.Controls.Add(this.btnMin);
            this.pnTitle.Controls.Add(this.btnExit);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1000, 30);
            this.pnTitle.TabIndex = 0;
            this.pnTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitle_MouseDown);
            // 
            // displayPanel
            // 
            this.displayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.displayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayPanel.Location = new System.Drawing.Point(0, 30);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(1000, 570);
            this.displayPanel.TabIndex = 1;
            // 
            // btnSet
            // 
            this.btnSet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSet.FlatAppearance.BorderSize = 0;
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Image = global::Leviathan_Account.Properties.Resources.wrench_16px1;
            this.btnSet.Location = new System.Drawing.Point(850, 0);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(50, 30);
            this.btnSet.TabIndex = 4;
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::Leviathan_Account.Properties.Resources.subtract_16px;
            this.btnMin.Location = new System.Drawing.Point(900, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 30);
            this.btnMin.TabIndex = 3;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::Leviathan_Account.Properties.Resources.delete_16px;
            this.btnExit.Location = new System.Drawing.Point(950, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.pnTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSet;
        public System.Windows.Forms.Panel displayPanel;
    }
}


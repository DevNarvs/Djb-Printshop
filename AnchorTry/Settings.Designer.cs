namespace AnchorTry
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnVideoke = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.White;
            this.btnAdd.BorderThickness = 2;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(92, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(230, 36);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Change Pricing";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.guna2Panel1.Controls.Add(this.guna2Button2);
            this.guna2Panel1.Controls.Add(this.btnVideoke);
            this.guna2Panel1.Controls.Add(this.btnAdd);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(2, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(402, 549);
            this.guna2Panel1.TabIndex = 35;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderColor = System.Drawing.Color.Red;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.Red;
            this.guna2Button2.Location = new System.Drawing.Point(365, 0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(37, 31);
            this.guna2Button2.TabIndex = 36;
            this.guna2Button2.Text = "X";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnVideoke
            // 
            this.btnVideoke.BorderColor = System.Drawing.Color.White;
            this.btnVideoke.BorderThickness = 2;
            this.btnVideoke.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVideoke.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVideoke.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVideoke.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVideoke.FillColor = System.Drawing.Color.Transparent;
            this.btnVideoke.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVideoke.ForeColor = System.Drawing.Color.White;
            this.btnVideoke.Location = new System.Drawing.Point(92, 152);
            this.btnVideoke.Name = "btnVideoke";
            this.btnVideoke.Size = new System.Drawing.Size(230, 36);
            this.btnVideoke.TabIndex = 35;
            this.btnVideoke.Text = "Add Videoke";
            this.btnVideoke.Click += new System.EventHandler(this.btnVideoke_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(407, 554);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnVideoke;
    }
}
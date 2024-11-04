namespace AnchorTry
{
    partial class ChangePricing
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPaper = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tblPriceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbsetPriceList = new AnchorTry.dbsetPriceList();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnChange = new Guna.UI2.WinForms.Guna2Button();
            this.tbl_PriceListTableAdapter = new AnchorTry.dbsetPriceListTableAdapters.tbl_PriceListTableAdapter();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnOnOff = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVideokePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCurrPrice = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblPriceListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsetPriceList)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(183, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update Pricing";
            // 
            // cbPaper
            // 
            this.cbPaper.BackColor = System.Drawing.Color.Transparent;
            this.cbPaper.DataSource = this.tblPriceListBindingSource;
            this.cbPaper.DisplayMember = "ItemName";
            this.cbPaper.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPaper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaper.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPaper.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPaper.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPaper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPaper.ItemHeight = 30;
            this.cbPaper.Location = new System.Drawing.Point(209, 102);
            this.cbPaper.Name = "cbPaper";
            this.cbPaper.Size = new System.Drawing.Size(219, 36);
            this.cbPaper.TabIndex = 2;
            this.cbPaper.SelectedIndexChanged += new System.EventHandler(this.cbPaper_SelectedIndexChanged);
            // 
            // tblPriceListBindingSource
            // 
            this.tblPriceListBindingSource.DataMember = "tbl_PriceList";
            this.tblPriceListBindingSource.DataSource = this.dbsetPriceList;
            // 
            // dbsetPriceList
            // 
            this.dbsetPriceList.DataSetName = "dbsetPriceList";
            this.dbsetPriceList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(356, 198);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(120, 36);
            this.txtPrice.TabIndex = 36;
            // 
            // btnChange
            // 
            this.btnChange.BorderColor = System.Drawing.Color.White;
            this.btnChange.BorderThickness = 2;
            this.btnChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChange.FillColor = System.Drawing.Color.Transparent;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(223, 356);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(151, 36);
            this.btnChange.TabIndex = 37;
            this.btnChange.Text = "Update";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // tbl_PriceListTableAdapter
            // 
            this.tbl_PriceListTableAdapter.ClearBeforeFill = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.guna2Panel1.Controls.Add(this.btnOnOff);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.txtVideokePrice);
            this.guna2Panel1.Controls.Add(this.txtCurrPrice);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btnChange);
            this.guna2Panel1.Controls.Add(this.txtPrice);
            this.guna2Panel1.Controls.Add(this.cbPaper);
            this.guna2Panel1.Location = new System.Drawing.Point(1, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(629, 412);
            this.guna2Panel1.TabIndex = 38;
            // 
            // btnOnOff
            // 
            this.btnOnOff.AutoSize = true;
            this.btnOnOff.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnOnOff.CheckedState.BorderRadius = 0;
            this.btnOnOff.CheckedState.BorderThickness = 0;
            this.btnOnOff.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOnOff.Location = new System.Drawing.Point(223, 310);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(15, 14);
            this.btnOnOff.TabIndex = 44;
            this.btnOnOff.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.btnOnOff.UncheckedState.BorderRadius = 0;
            this.btnOnOff.UncheckedState.BorderThickness = 0;
            this.btnOnOff.UncheckedState.FillColor = System.Drawing.Color.White;
            this.btnOnOff.CheckedChanged += new System.EventHandler(this.btnOnOff_CheckedChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(244, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "Videoke Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(336, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Enter New Price ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(150, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Current Price ";
            // 
            // txtVideokePrice
            // 
            this.txtVideokePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVideokePrice.DefaultText = "";
            this.txtVideokePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVideokePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVideokePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVideokePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVideokePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVideokePrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtVideokePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVideokePrice.Location = new System.Drawing.Point(254, 300);
            this.txtVideokePrice.Name = "txtVideokePrice";
            this.txtVideokePrice.PasswordChar = '\0';
            this.txtVideokePrice.PlaceholderText = "";
            this.txtVideokePrice.SelectedText = "";
            this.txtVideokePrice.Size = new System.Drawing.Size(120, 36);
            this.txtVideokePrice.TabIndex = 41;
            // 
            // txtCurrPrice
            // 
            this.txtCurrPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrPrice.DefaultText = "";
            this.txtCurrPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurrPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurrPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCurrPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrPrice.Location = new System.Drawing.Point(154, 198);
            this.txtCurrPrice.Name = "txtCurrPrice";
            this.txtCurrPrice.PasswordChar = '\0';
            this.txtCurrPrice.PlaceholderText = "";
            this.txtCurrPrice.ReadOnly = true;
            this.txtCurrPrice.SelectedText = "";
            this.txtCurrPrice.Size = new System.Drawing.Size(120, 36);
            this.txtCurrPrice.TabIndex = 38;
            // 
            // ChangePricing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 416);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePricing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePricing";
            this.Load += new System.EventHandler(this.ChangePricing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPriceListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsetPriceList)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbPaper;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2Button btnChange;
        private dbsetPriceList dbsetPriceList;
        private System.Windows.Forms.BindingSource tblPriceListBindingSource;
        private dbsetPriceListTableAdapters.tbl_PriceListTableAdapter tbl_PriceListTableAdapter;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtVideokePrice;
        private Guna.UI2.WinForms.Guna2CheckBox btnOnOff;
    }
}
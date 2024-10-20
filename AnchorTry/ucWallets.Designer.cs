namespace AnchorTry
{
    partial class ucWallets
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGcash = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnMaya = new Guna.UI2.WinForms.Guna2TileButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCashIn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnCashOut = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnBills = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTotal = new Guna.UI2.WinForms.Guna2Button();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPayment = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtChange = new Guna.UI2.WinForms.Guna2TextBox();
            this.dbDatasetEWallet = new AnchorTry.dbDatasetEWallet();
            this.tbleWalletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_eWalletTableAdapter = new AnchorTry.dbDatasetEWalletTableAdapters.tbl_eWalletTableAdapter();
            this.dgvTransactionWallet = new System.Windows.Forms.DataGridView();
            this.tbleWalletBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dbSetWALLETwReference = new AnchorTry.dbSetWALLETwReference();
            this.tbleWalletBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.txtReference = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbleWalletBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_eWalletTableAdapter1 = new AnchorTry.dbSetWALLETwReferenceTableAdapters.tbl_eWalletTableAdapter();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.walletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEWallet = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlWalletType = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dbDatasetEWallet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbleWalletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionWallet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbleWalletBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSetWALLETwReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbleWalletBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbleWalletBindingSource2)).BeginInit();
            this.pnlEWallet.SuspendLayout();
            this.pnlWalletType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(169, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "e-Wallet";
            // 
            // btnGcash
            // 
            this.btnGcash.BackgroundImage = global::AnchorTry.Properties.Resources.gcash;
            this.btnGcash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGcash.BorderColor = System.Drawing.Color.Transparent;
            this.btnGcash.BorderThickness = 2;
            this.btnGcash.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnGcash.CheckedState.BorderColor = System.Drawing.Color.Maroon;
            this.btnGcash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGcash.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGcash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGcash.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGcash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGcash.FillColor = System.Drawing.Color.Empty;
            this.btnGcash.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGcash.ForeColor = System.Drawing.Color.White;
            this.btnGcash.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnGcash.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnGcash.Location = new System.Drawing.Point(50, 120);
            this.btnGcash.Name = "btnGcash";
            this.btnGcash.Size = new System.Drawing.Size(146, 71);
            this.btnGcash.TabIndex = 15;
            this.btnGcash.Click += new System.EventHandler(this.btnGcash_Click);
            // 
            // btnMaya
            // 
            this.btnMaya.BackgroundImage = global::AnchorTry.Properties.Resources.maya;
            this.btnMaya.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaya.BorderColor = System.Drawing.Color.Transparent;
            this.btnMaya.BorderThickness = 2;
            this.btnMaya.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMaya.CheckedState.BorderColor = System.Drawing.Color.Maroon;
            this.btnMaya.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaya.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMaya.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMaya.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMaya.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMaya.FillColor = System.Drawing.Color.Empty;
            this.btnMaya.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMaya.ForeColor = System.Drawing.Color.White;
            this.btnMaya.Location = new System.Drawing.Point(263, 120);
            this.btnMaya.Name = "btnMaya";
            this.btnMaya.Size = new System.Drawing.Size(146, 71);
            this.btnMaya.TabIndex = 16;
            this.btnMaya.Click += new System.EventHandler(this.btnMaya_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Type : ";
            // 
            // btnCashIn
            // 
            this.btnCashIn.AutoSize = true;
            this.btnCashIn.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnCashIn.CheckedState.BorderThickness = 0;
            this.btnCashIn.CheckedState.FillColor = System.Drawing.Color.Maroon;
            this.btnCashIn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnCashIn.CheckedState.InnerOffset = -4;
            this.btnCashIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashIn.ForeColor = System.Drawing.Color.White;
            this.btnCashIn.Location = new System.Drawing.Point(104, 32);
            this.btnCashIn.Name = "btnCashIn";
            this.btnCashIn.Size = new System.Drawing.Size(82, 24);
            this.btnCashIn.TabIndex = 18;
            this.btnCashIn.Text = "Cash In";
            this.btnCashIn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnCashIn.UncheckedState.BorderThickness = 2;
            this.btnCashIn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnCashIn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.btnCashIn.CheckedChanged += new System.EventHandler(this.btnCashIn_CheckedChanged);
            // 
            // btnCashOut
            // 
            this.btnCashOut.AutoSize = true;
            this.btnCashOut.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnCashOut.CheckedState.BorderThickness = 0;
            this.btnCashOut.CheckedState.FillColor = System.Drawing.Color.Maroon;
            this.btnCashOut.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnCashOut.CheckedState.InnerOffset = -4;
            this.btnCashOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashOut.ForeColor = System.Drawing.Color.White;
            this.btnCashOut.Location = new System.Drawing.Point(221, 32);
            this.btnCashOut.Name = "btnCashOut";
            this.btnCashOut.Size = new System.Drawing.Size(94, 24);
            this.btnCashOut.TabIndex = 19;
            this.btnCashOut.Text = "Cash Out";
            this.btnCashOut.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnCashOut.UncheckedState.BorderThickness = 2;
            this.btnCashOut.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnCashOut.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.btnCashOut.CheckedChanged += new System.EventHandler(this.btnCashOut_CheckedChanged);
            // 
            // btnBills
            // 
            this.btnBills.AutoSize = true;
            this.btnBills.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnBills.CheckedState.BorderThickness = 0;
            this.btnBills.CheckedState.FillColor = System.Drawing.Color.Maroon;
            this.btnBills.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnBills.CheckedState.InnerOffset = -4;
            this.btnBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBills.ForeColor = System.Drawing.Color.White;
            this.btnBills.Location = new System.Drawing.Point(347, 32);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(55, 24);
            this.btnBills.TabIndex = 20;
            this.btnBills.Text = "Bills";
            this.btnBills.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnBills.UncheckedState.BorderThickness = 2;
            this.btnBills.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnBills.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.btnBills.CheckedChanged += new System.EventHandler(this.btnBills_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(40, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Amount :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(63, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Total :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(28, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Payment :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(37, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "Change :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTotal
            // 
            this.btnTotal.AutoRoundedCorners = true;
            this.btnTotal.BorderColor = System.Drawing.Color.White;
            this.btnTotal.BorderRadius = 21;
            this.btnTotal.BorderThickness = 2;
            this.btnTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTotal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTotal.FillColor = System.Drawing.Color.Transparent;
            this.btnTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.ForeColor = System.Drawing.Color.White;
            this.btnTotal.Location = new System.Drawing.Point(299, 159);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(94, 45);
            this.btnTotal.TabIndex = 25;
            this.btnTotal.Text = "Total";
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.BorderRadius = 10;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Location = new System.Drawing.Point(159, 93);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(233, 36);
            this.txtAmount.TabIndex = 27;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.BorderRadius = 10;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Location = new System.Drawing.Point(159, 164);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.SelectedText = "";
            this.txtTotal.Size = new System.Drawing.Size(134, 36);
            this.txtTotal.TabIndex = 28;
            // 
            // txtPayment
            // 
            this.txtPayment.BorderRadius = 10;
            this.txtPayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPayment.DefaultText = "";
            this.txtPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPayment.Location = new System.Drawing.Point(159, 247);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.PasswordChar = '\0';
            this.txtPayment.PlaceholderText = "";
            this.txtPayment.SelectedText = "";
            this.txtPayment.Size = new System.Drawing.Size(233, 36);
            this.txtPayment.TabIndex = 29;
            this.txtPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayment_KeyPress);
            // 
            // txtChange
            // 
            this.txtChange.BorderRadius = 10;
            this.txtChange.Cursor = System.Windows.Forms.Cursors.No;
            this.txtChange.DefaultText = "";
            this.txtChange.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChange.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChange.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtChange.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChange.Location = new System.Drawing.Point(159, 326);
            this.txtChange.Name = "txtChange";
            this.txtChange.PasswordChar = '\0';
            this.txtChange.PlaceholderText = "";
            this.txtChange.ReadOnly = true;
            this.txtChange.SelectedText = "";
            this.txtChange.Size = new System.Drawing.Size(234, 36);
            this.txtChange.TabIndex = 30;
            // 
            // dbDatasetEWallet
            // 
            this.dbDatasetEWallet.DataSetName = "dbDatasetEWallet";
            this.dbDatasetEWallet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbleWalletBindingSource
            // 
            this.tbleWalletBindingSource.DataMember = "tbl_eWallet";
            this.tbleWalletBindingSource.DataSource = this.dbDatasetEWallet;
            // 
            // tbl_eWalletTableAdapter
            // 
            this.tbl_eWalletTableAdapter.ClearBeforeFill = true;
            // 
            // dgvTransactionWallet
            // 
            this.dgvTransactionWallet.AllowUserToAddRows = false;
            this.dgvTransactionWallet.AllowUserToDeleteRows = false;
            this.dgvTransactionWallet.AllowUserToResizeColumns = false;
            this.dgvTransactionWallet.AllowUserToResizeRows = false;
            this.dgvTransactionWallet.AutoGenerateColumns = false;
            this.dgvTransactionWallet.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvTransactionWallet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTransactionWallet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactionWallet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTransactionWallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTransactionWallet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.walletDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn,
            this.changeDataGridViewTextBoxColumn,
            this.referenceDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgvTransactionWallet.DataSource = this.tbleWalletBindingSource3;
            this.dgvTransactionWallet.GridColor = System.Drawing.Color.Navy;
            this.dgvTransactionWallet.Location = new System.Drawing.Point(435, 120);
            this.dgvTransactionWallet.MultiSelect = false;
            this.dgvTransactionWallet.Name = "dgvTransactionWallet";
            this.dgvTransactionWallet.ReadOnly = true;
            this.dgvTransactionWallet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvTransactionWallet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTransactionWallet.Size = new System.Drawing.Size(705, 761);
            this.dgvTransactionWallet.TabIndex = 31;
            // 
            // tbleWalletBindingSource3
            // 
            this.tbleWalletBindingSource3.DataMember = "tbl_eWallet";
            this.tbleWalletBindingSource3.DataSource = this.dbSetWALLETwReference;
            // 
            // dbSetWALLETwReference
            // 
            this.dbSetWALLETwReference.DataSetName = "dbSetWALLETwReference";
            this.dbSetWALLETwReference.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbleWalletBindingSource1
            // 
            this.tbleWalletBindingSource1.DataMember = "tbl_eWallet";
            this.tbleWalletBindingSource1.DataSource = this.dbDatasetEWallet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(662, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 37);
            this.label7.TabIndex = 32;
            this.label7.Text = "Transactions";
            // 
            // txtNumber
            // 
            this.txtNumber.BorderRadius = 10;
            this.txtNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumber.DefaultText = "";
            this.txtNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumber.Location = new System.Drawing.Point(159, 22);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.PasswordChar = '\0';
            this.txtNumber.PlaceholderText = "";
            this.txtNumber.SelectedText = "";
            this.txtNumber.Size = new System.Drawing.Size(233, 36);
            this.txtNumber.TabIndex = 34;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(34, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 29);
            this.label8.TabIndex = 33;
            this.label8.Text = "Number :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPay
            // 
            this.btnPay.AutoRoundedCorners = true;
            this.btnPay.BorderColor = System.Drawing.Color.White;
            this.btnPay.BorderRadius = 21;
            this.btnPay.BorderThickness = 2;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.Transparent;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(162, 485);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(113, 45);
            this.btnPay.TabIndex = 26;
            this.btnPay.Text = "Pay";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtReference
            // 
            this.txtReference.BorderRadius = 10;
            this.txtReference.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReference.DefaultText = "";
            this.txtReference.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReference.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReference.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReference.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReference.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReference.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReference.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReference.Location = new System.Drawing.Point(162, 407);
            this.txtReference.Name = "txtReference";
            this.txtReference.PasswordChar = '\0';
            this.txtReference.PlaceholderText = "";
            this.txtReference.SelectedText = "";
            this.txtReference.Size = new System.Drawing.Size(231, 36);
            this.txtReference.TabIndex = 36;
            this.txtReference.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReference_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(9, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 29);
            this.label9.TabIndex = 35;
            this.label9.Text = "Reference :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbleWalletBindingSource2
            // 
            this.tbleWalletBindingSource2.DataMember = "tbl_eWallet";
            this.tbleWalletBindingSource2.DataSource = this.dbSetWALLETwReference;
            // 
            // tbl_eWalletTableAdapter1
            // 
            this.tbl_eWalletTableAdapter1.ClearBeforeFill = true;
            // 
            // btnClear
            // 
            this.btnClear.AutoRoundedCorners = true;
            this.btnClear.BorderColor = System.Drawing.Color.White;
            this.btnClear.BorderRadius = 21;
            this.btnClear.BorderThickness = 2;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(281, 485);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 45);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // walletDataGridViewTextBoxColumn
            // 
            this.walletDataGridViewTextBoxColumn.DataPropertyName = "Wallet";
            this.walletDataGridViewTextBoxColumn.HeaderText = "Wallet";
            this.walletDataGridViewTextBoxColumn.Name = "walletDataGridViewTextBoxColumn";
            this.walletDataGridViewTextBoxColumn.ReadOnly = true;
            this.walletDataGridViewTextBoxColumn.Width = 50;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 70;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 65;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 55;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 55;
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "Payment";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            this.paymentDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentDataGridViewTextBoxColumn.Width = 60;
            // 
            // changeDataGridViewTextBoxColumn
            // 
            this.changeDataGridViewTextBoxColumn.DataPropertyName = "Change";
            this.changeDataGridViewTextBoxColumn.HeaderText = "Change";
            this.changeDataGridViewTextBoxColumn.Name = "changeDataGridViewTextBoxColumn";
            this.changeDataGridViewTextBoxColumn.ReadOnly = true;
            this.changeDataGridViewTextBoxColumn.Width = 55;
            // 
            // referenceDataGridViewTextBoxColumn
            // 
            this.referenceDataGridViewTextBoxColumn.DataPropertyName = "Reference";
            this.referenceDataGridViewTextBoxColumn.HeaderText = "Reference";
            this.referenceDataGridViewTextBoxColumn.Name = "referenceDataGridViewTextBoxColumn";
            this.referenceDataGridViewTextBoxColumn.ReadOnly = true;
            this.referenceDataGridViewTextBoxColumn.Width = 105;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // pnlEWallet
            // 
            this.pnlEWallet.Controls.Add(this.btnClear);
            this.pnlEWallet.Controls.Add(this.txtReference);
            this.pnlEWallet.Controls.Add(this.label9);
            this.pnlEWallet.Controls.Add(this.txtNumber);
            this.pnlEWallet.Controls.Add(this.label8);
            this.pnlEWallet.Controls.Add(this.label3);
            this.pnlEWallet.Controls.Add(this.label4);
            this.pnlEWallet.Controls.Add(this.label5);
            this.pnlEWallet.Controls.Add(this.txtChange);
            this.pnlEWallet.Controls.Add(this.label6);
            this.pnlEWallet.Controls.Add(this.txtPayment);
            this.pnlEWallet.Controls.Add(this.btnTotal);
            this.pnlEWallet.Controls.Add(this.txtTotal);
            this.pnlEWallet.Controls.Add(this.btnPay);
            this.pnlEWallet.Controls.Add(this.txtAmount);
            this.pnlEWallet.Location = new System.Drawing.Point(15, 330);
            this.pnlEWallet.Name = "pnlEWallet";
            this.pnlEWallet.Size = new System.Drawing.Size(414, 551);
            this.pnlEWallet.TabIndex = 38;
            // 
            // pnlWalletType
            // 
            this.pnlWalletType.Controls.Add(this.btnCashOut);
            this.pnlWalletType.Controls.Add(this.btnBills);
            this.pnlWalletType.Controls.Add(this.label2);
            this.pnlWalletType.Controls.Add(this.btnCashIn);
            this.pnlWalletType.Location = new System.Drawing.Point(15, 227);
            this.pnlWalletType.Name = "pnlWalletType";
            this.pnlWalletType.Size = new System.Drawing.Size(414, 83);
            this.pnlWalletType.TabIndex = 39;
            // 
            // ucWallets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.pnlWalletType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvTransactionWallet);
            this.Controls.Add(this.btnMaya);
            this.Controls.Add(this.btnGcash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlEWallet);
            this.Name = "ucWallets";
            this.Size = new System.Drawing.Size(1153, 894);
            this.Load += new System.EventHandler(this.ucWallets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDatasetEWallet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbleWalletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionWallet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbleWalletBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSetWALLETwReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbleWalletBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbleWalletBindingSource2)).EndInit();
            this.pnlEWallet.ResumeLayout(false);
            this.pnlEWallet.PerformLayout();
            this.pnlWalletType.ResumeLayout(false);
            this.pnlWalletType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TileButton btnGcash;
        private Guna.UI2.WinForms.Guna2TileButton btnMaya;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2RadioButton btnCashIn;
        private Guna.UI2.WinForms.Guna2RadioButton btnCashOut;
        private Guna.UI2.WinForms.Guna2RadioButton btnBills;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnTotal;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private Guna.UI2.WinForms.Guna2TextBox txtPayment;
        private Guna.UI2.WinForms.Guna2TextBox txtChange;
        private System.Windows.Forms.BindingSource tbleWalletBindingSource;
        private dbDatasetEWallet dbDatasetEWallet;
        private dbDatasetEWalletTableAdapters.tbl_eWalletTableAdapter tbl_eWalletTableAdapter;
        private System.Windows.Forms.DataGridView dgvTransactionWallet;
        private System.Windows.Forms.BindingSource tbleWalletBindingSource1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtNumber;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2TextBox txtReference;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource tbleWalletBindingSource3;
        private dbSetWALLETwReference dbSetWALLETwReference;
        private System.Windows.Forms.BindingSource tbleWalletBindingSource2;
        private dbSetWALLETwReferenceTableAdapters.tbl_eWalletTableAdapter tbl_eWalletTableAdapter1;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn walletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Panel pnlEWallet;
        private Guna.UI2.WinForms.Guna2Panel pnlWalletType;
    }
}

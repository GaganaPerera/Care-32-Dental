namespace Care_32_Dental
{
    partial class patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btndelete = new Zeroit.Framework.Metro.ZeroitMetroButton();
            this.btnsearch = new Zeroit.Framework.Metro.ZeroitMetroButton();
            this.btnupdate = new Zeroit.Framework.Metro.ZeroitMetroButton();
            this.btnadd = new Zeroit.Framework.Metro.ZeroitMetroButton();
            this.txtmobile = new Zeroit.Framework.Metro.ZeroitMetroTextbox();
            this.txtname = new Zeroit.Framework.Metro.ZeroitMetroTextbox();
            this.txtregnumber = new Zeroit.Framework.Metro.ZeroitMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuThinButton23 = new ns1.BunifuThinButton2();
            this.bunifuThinButton22 = new ns1.BunifuThinButton2();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new ns1.BunifuGradientPanel();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.care32DentalClinicDataSet = new Care_32_Dental.Care32DentalClinicDataSet();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new Care_32_Dental.Care32DentalClinicDataSetTableAdapters.PatientsTableAdapter();
            this.patientlist = new ns1.BunifuCustomDataGrid();
            this.dtpvisitdate = new System.Windows.Forms.DateTimePicker();
            this.txtage = new Zeroit.Framework.Metro.ZeroitMetroTextbox();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.care32DentalClinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btndelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btndelete.DefaultColor = System.Drawing.Color.DodgerBlue;
            this.btndelete.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btndelete.DrawBorder = false;
            this.btndelete.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.HoverColor = System.Drawing.Color.White;
            this.btndelete.IsRound = true;
            this.btndelete.Location = new System.Drawing.Point(666, 80);
            this.btndelete.Name = "btndelete";
            this.btndelete.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btndelete.RoundingArc = 39;
            this.btndelete.Size = new System.Drawing.Size(133, 39);
            this.btndelete.TabIndex = 92;
            this.btndelete.Text = "Delete";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Transparent;
            this.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnsearch.DefaultColor = System.Drawing.Color.DodgerBlue;
            this.btnsearch.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnsearch.DrawBorder = false;
            this.btnsearch.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.HoverColor = System.Drawing.Color.White;
            this.btnsearch.IsRound = true;
            this.btnsearch.Location = new System.Drawing.Point(666, 24);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnsearch.RoundingArc = 39;
            this.btnsearch.Size = new System.Drawing.Size(133, 39);
            this.btnsearch.TabIndex = 91;
            this.btnsearch.Text = "Search";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnupdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnupdate.DefaultColor = System.Drawing.Color.DodgerBlue;
            this.btnupdate.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnupdate.DrawBorder = false;
            this.btnupdate.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.HoverColor = System.Drawing.Color.White;
            this.btnupdate.IsRound = true;
            this.btnupdate.Location = new System.Drawing.Point(666, 393);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnupdate.RoundingArc = 39;
            this.btnupdate.Size = new System.Drawing.Size(133, 39);
            this.btnupdate.TabIndex = 90;
            this.btnupdate.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Transparent;
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnadd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnadd.DefaultColor = System.Drawing.Color.DodgerBlue;
            this.btnadd.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnadd.DrawBorder = false;
            this.btnadd.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.HoverColor = System.Drawing.Color.White;
            this.btnadd.IsRound = true;
            this.btnadd.Location = new System.Drawing.Point(666, 453);
            this.btnadd.Name = "btnadd";
            this.btnadd.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnadd.RoundingArc = 39;
            this.btnadd.Size = new System.Drawing.Size(133, 39);
            this.btnadd.TabIndex = 89;
            this.btnadd.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtmobile
            // 
            this.txtmobile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtmobile.BanIllegalChars = true;
            this.txtmobile.Border = 1;
            this.txtmobile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtmobile.DefaultColor = System.Drawing.Color.White;
            this.txtmobile.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtmobile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmobile.HideSelection = false;
            this.txtmobile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtmobile.LineOnly = true;
            this.txtmobile.Location = new System.Drawing.Point(405, 186);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.PasswordChar = '\0';
            this.txtmobile.Size = new System.Drawing.Size(241, 36);
            this.txtmobile.TabIndex = 83;
            this.txtmobile.Watermark = "Eg.071 4123567";
            // 
            // txtname
            // 
            this.txtname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtname.BanIllegalChars = true;
            this.txtname.Border = 1;
            this.txtname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtname.DefaultColor = System.Drawing.Color.White;
            this.txtname.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.HideSelection = false;
            this.txtname.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtname.LineOnly = true;
            this.txtname.Location = new System.Drawing.Point(404, 83);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.Size = new System.Drawing.Size(241, 36);
            this.txtname.TabIndex = 82;
            this.txtname.Watermark = "Eg.Tom";
            // 
            // txtregnumber
            // 
            this.txtregnumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtregnumber.BanIllegalChars = true;
            this.txtregnumber.Border = 1;
            this.txtregnumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtregnumber.DefaultColor = System.Drawing.Color.White;
            this.txtregnumber.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtregnumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtregnumber.HideSelection = false;
            this.txtregnumber.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtregnumber.IllegalChars = " !/#%$^&*()_+";
            this.txtregnumber.LineOnly = true;
            this.txtregnumber.Location = new System.Drawing.Point(404, 24);
            this.txtregnumber.Name = "txtregnumber";
            this.txtregnumber.PasswordChar = '\0';
            this.txtregnumber.Size = new System.Drawing.Size(241, 36);
            this.txtregnumber.TabIndex = 81;
            this.txtregnumber.Watermark = "Eg.001";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(244, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 23);
            this.label8.TabIndex = 80;
            this.label8.Text = "Patient Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 75;
            this.label3.Text = "Contact Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 23);
            this.label2.TabIndex = 74;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 73;
            this.label1.Text = "Reg Number";
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton23.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Bill Generation";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton23.Location = new System.Drawing.Point(7, 348);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(202, 41);
            this.bunifuThinButton23.TabIndex = 96;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Doctor Management";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton22.Location = new System.Drawing.Point(7, 287);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(202, 41);
            this.bunifuThinButton22.TabIndex = 95;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Case Management";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.Location = new System.Drawing.Point(7, 225);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(202, 41);
            this.bunifuThinButton21.TabIndex = 94;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Care_32_Dental.Properties.Resources.Blue_Modern_Dental_Clinic_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.SystemColors.Menu;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.MediumBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DeepSkyBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(216, 518);
            this.bunifuGradientPanel1.TabIndex = 97;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // care32DentalClinicDataSet
            // 
            this.care32DentalClinicDataSet.DataSetName = "Care32DentalClinicDataSet";
            this.care32DentalClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.care32DentalClinicDataSet;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // patientlist
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.patientlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.patientlist.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.patientlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patientlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.patientlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientlist.DoubleBuffered = true;
            this.patientlist.EnableHeadersVisualStyles = false;
            this.patientlist.HeaderBgColor = System.Drawing.Color.RoyalBlue;
            this.patientlist.HeaderForeColor = System.Drawing.Color.DodgerBlue;
            this.patientlist.Location = new System.Drawing.Point(248, 287);
            this.patientlist.Name = "patientlist";
            this.patientlist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.patientlist.Size = new System.Drawing.Size(397, 205);
            this.patientlist.TabIndex = 100;
            // 
            // dtpvisitdate
            // 
            this.dtpvisitdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpvisitdate.Location = new System.Drawing.Point(405, 243);
            this.dtpvisitdate.Name = "dtpvisitdate";
            this.dtpvisitdate.Size = new System.Drawing.Size(241, 22);
            this.dtpvisitdate.TabIndex = 101;
            // 
            // txtage
            // 
            this.txtage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtage.BanIllegalChars = true;
            this.txtage.Border = 1;
            this.txtage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtage.DefaultColor = System.Drawing.Color.White;
            this.txtage.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.HideSelection = false;
            this.txtage.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtage.LineOnly = true;
            this.txtage.Location = new System.Drawing.Point(404, 137);
            this.txtage.Name = "txtage";
            this.txtage.PasswordChar = '\0';
            this.txtage.Size = new System.Drawing.Size(241, 36);
            this.txtage.TabIndex = 102;
            this.txtage.Watermark = "Eg.14(Only Numbers)";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.Image = global::Care_32_Dental.Properties.Resources.filled_cancel_removebg_preview;
            this.btnclose.Location = new System.Drawing.Point(802, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(42, 41);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnclose.TabIndex = 103;
            this.btnclose.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 104;
            this.label4.Text = "Date Joined";
            // 
            // patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 519);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.dtpvisitdate);
            this.Controls.Add(this.patientlist);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtmobile);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtregnumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "patient";
            this.Text = "patient";
            this.Load += new System.EventHandler(this.patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.care32DentalClinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuThinButton2 bunifuThinButton23;
        private ns1.BunifuThinButton2 bunifuThinButton22;
        private ns1.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Zeroit.Framework.Metro.ZeroitMetroButton btndelete;
        private Zeroit.Framework.Metro.ZeroitMetroButton btnsearch;
        private Zeroit.Framework.Metro.ZeroitMetroButton btnupdate;
        private Zeroit.Framework.Metro.ZeroitMetroButton btnadd;
        private Zeroit.Framework.Metro.ZeroitMetroTextbox txtmobile;
        private Zeroit.Framework.Metro.ZeroitMetroTextbox txtname;
        private Zeroit.Framework.Metro.ZeroitMetroTextbox txtregnumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuGradientPanel bunifuGradientPanel1;
        private ns1.BunifuElipse bunifuElipse1;
        private Care32DentalClinicDataSet care32DentalClinicDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private Care32DentalClinicDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private ns1.BunifuCustomDataGrid patientlist;
        private Zeroit.Framework.Metro.ZeroitMetroTextbox txtage;
        private System.Windows.Forms.DateTimePicker dtpvisitdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnclose;
    }
}
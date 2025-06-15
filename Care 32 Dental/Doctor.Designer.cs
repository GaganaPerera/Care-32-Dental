using System;
using System.Windows.Forms;

namespace Care_32_Dental
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.btndelete = new Zeroit.Framework.Metro.ZeroitMetroButton();
            this.btnsearch = new Zeroit.Framework.Metro.ZeroitMetroButton();
            this.btnupdate = new Zeroit.Framework.Metro.ZeroitMetroButton();
            this.btnadd = new Zeroit.Framework.Metro.ZeroitMetroButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtemail = new Zeroit.Framework.Metro.ZeroitMetroTextbox();
            this.cmbspecailization = new System.Windows.Forms.ComboBox();
            this.txtaddress = new Zeroit.Framework.Metro.ZeroitMetroTextbox();
            this.txtsalary = new Zeroit.Framework.Metro.ZeroitMetroTextbox();
            this.txtcontact = new Zeroit.Framework.Metro.ZeroitMetroTextbox();
            this.txtdocname = new Zeroit.Framework.Metro.ZeroitMetroTextbox();
            this.txtdocid = new Zeroit.Framework.Metro.ZeroitMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuElipse2 = new ns1.BunifuElipse(this.components);
            this.bunifuThinButton22 = new ns1.BunifuThinButton2();
            this.bunifuElipse3 = new ns1.BunifuElipse(this.components);
            this.bunifuThinButton23 = new ns1.BunifuThinButton2();
            this.bunifuElipse4 = new ns1.BunifuElipse(this.components);
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new ns1.BunifuGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btndelete.Location = new System.Drawing.Point(666, 102);
            this.btndelete.Name = "btndelete";
            this.btndelete.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btndelete.RoundingArc = 39;
            this.btndelete.Size = new System.Drawing.Size(133, 39);
            this.btndelete.TabIndex = 66;
            this.btndelete.Text = "Delete";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
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
            this.btnsearch.Location = new System.Drawing.Point(666, 46);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnsearch.RoundingArc = 39;
            this.btnsearch.Size = new System.Drawing.Size(133, 39);
            this.btnsearch.TabIndex = 65;
            this.btnsearch.Text = "Search";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click_1);
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
            this.btnupdate.Location = new System.Drawing.Point(666, 391);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnupdate.RoundingArc = 39;
            this.btnupdate.Size = new System.Drawing.Size(133, 39);
            this.btnupdate.TabIndex = 64;
            this.btnupdate.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
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
            this.btnadd.Location = new System.Drawing.Point(666, 451);
            this.btnadd.Name = "btnadd";
            this.btnadd.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnadd.RoundingArc = 39;
            this.btnadd.Size = new System.Drawing.Size(133, 39);
            this.btnadd.TabIndex = 63;
            this.btnadd.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(404, 165);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(241, 22);
            this.dtpDOB.TabIndex = 61;
            // 
            // txtemail
            // 
            this.txtemail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtemail.BanIllegalChars = true;
            this.txtemail.Border = 1;
            this.txtemail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtemail.DefaultColor = System.Drawing.Color.White;
            this.txtemail.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtemail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.HideSelection = false;
            this.txtemail.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtemail.LineOnly = true;
            this.txtemail.Location = new System.Drawing.Point(404, 329);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.Size = new System.Drawing.Size(241, 36);
            this.txtemail.TabIndex = 60;
            this.txtemail.Watermark = "Eg.you@gmail.com";
            // 
            // cmbspecailization
            // 
            this.cmbspecailization.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbspecailization.FormattingEnabled = true;
            this.cmbspecailization.Items.AddRange(new object[] {
            "Small animal",
            "Large animal",
            "Aqua culture",
            "Birds",
            "Other"});
            this.cmbspecailization.Location = new System.Drawing.Point(404, 214);
            this.cmbspecailization.Name = "cmbspecailization";
            this.cmbspecailization.Size = new System.Drawing.Size(241, 27);
            this.cmbspecailization.TabIndex = 58;
            // 
            // txtaddress
            // 
            this.txtaddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtaddress.BanIllegalChars = true;
            this.txtaddress.Border = 1;
            this.txtaddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtaddress.DefaultColor = System.Drawing.Color.White;
            this.txtaddress.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.HideSelection = false;
            this.txtaddress.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtaddress.LineOnly = true;
            this.txtaddress.Location = new System.Drawing.Point(404, 390);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.Size = new System.Drawing.Size(241, 36);
            this.txtaddress.TabIndex = 57;
            this.txtaddress.Watermark = "Eg-No.1 anniwatte";
            // 
            // txtsalary
            // 
            this.txtsalary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtsalary.Border = 1;
            this.txtsalary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtsalary.DefaultColor = System.Drawing.Color.White;
            this.txtsalary.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtsalary.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary.HideSelection = false;
            this.txtsalary.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtsalary.LineOnly = true;
            this.txtsalary.Location = new System.Drawing.Point(404, 453);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.PasswordChar = '\0';
            this.txtsalary.Size = new System.Drawing.Size(241, 36);
            this.txtsalary.TabIndex = 56;
            this.txtsalary.Watermark = "Eg-Rs.60000";
            // 
            // txtcontact
            // 
            this.txtcontact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtcontact.BanIllegalChars = true;
            this.txtcontact.Border = 1;
            this.txtcontact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtcontact.DefaultColor = System.Drawing.Color.White;
            this.txtcontact.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtcontact.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.HideSelection = false;
            this.txtcontact.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtcontact.LineOnly = true;
            this.txtcontact.Location = new System.Drawing.Point(404, 267);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.PasswordChar = '\0';
            this.txtcontact.Size = new System.Drawing.Size(241, 36);
            this.txtcontact.TabIndex = 55;
            this.txtcontact.Watermark = "Eg.071 4123567";
            // 
            // txtdocname
            // 
            this.txtdocname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtdocname.BanIllegalChars = true;
            this.txtdocname.Border = 1;
            this.txtdocname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtdocname.DefaultColor = System.Drawing.Color.White;
            this.txtdocname.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtdocname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocname.HideSelection = false;
            this.txtdocname.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtdocname.LineOnly = true;
            this.txtdocname.Location = new System.Drawing.Point(404, 105);
            this.txtdocname.Name = "txtdocname";
            this.txtdocname.PasswordChar = '\0';
            this.txtdocname.Size = new System.Drawing.Size(241, 36);
            this.txtdocname.TabIndex = 54;
            this.txtdocname.Watermark = "Eg.Tom";
            // 
            // txtdocid
            // 
            this.txtdocid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtdocid.BanIllegalChars = true;
            this.txtdocid.Border = 1;
            this.txtdocid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtdocid.DefaultColor = System.Drawing.Color.White;
            this.txtdocid.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtdocid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocid.HideSelection = false;
            this.txtdocid.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtdocid.IllegalChars = " !/#%$^&*()_+";
            this.txtdocid.LineOnly = true;
            this.txtdocid.Location = new System.Drawing.Point(404, 46);
            this.txtdocid.Name = "txtdocid";
            this.txtdocid.PasswordChar = '\0';
            this.txtdocid.Size = new System.Drawing.Size(241, 36);
            this.txtdocid.TabIndex = 53;
            this.txtdocid.Watermark = "Eg.001";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(244, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 23);
            this.label8.TabIndex = 52;
            this.label8.Text = "Doctor Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 23);
            this.label7.TabIndex = 51;
            this.label7.Text = "Specailization";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(244, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 50;
            this.label6.Text = "Email ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 49;
            this.label5.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 48;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 47;
            this.label3.Text = "Contact Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "Date of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 45;
            this.label1.Text = "Doctor ID";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.bunifuThinButton22;
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
            this.bunifuThinButton22.ButtonText = "Case Management";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton22.Location = new System.Drawing.Point(7, 285);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(202, 41);
            this.bunifuThinButton22.TabIndex = 69;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this.bunifuThinButton23;
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
            this.bunifuThinButton23.Location = new System.Drawing.Point(7, 346);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(202, 41);
            this.bunifuThinButton23.TabIndex = 70;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 5;
            this.bunifuElipse4.TargetControl = this.bunifuThinButton21;
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
            this.bunifuThinButton21.ButtonText = "Patient Management";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.Location = new System.Drawing.Point(7, 223);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(202, 41);
            this.bunifuThinButton21.TabIndex = 68;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.Image = global::Care_32_Dental.Properties.Resources.filled_cancel_removebg_preview;
            this.btnclose.Location = new System.Drawing.Point(783, 5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(42, 41);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnclose.TabIndex = 71;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Care_32_Dental.Properties.Resources.Blue_Modern_Dental_Clinic_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
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
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, -2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(216, 518);
            this.bunifuGradientPanel1.TabIndex = 72;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(829, 517);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.cmbspecailization);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtdocname);
            this.Controls.Add(this.txtdocid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private Zeroit.Framework.Metro.ZeroitMetroButton btndelete;
        private Zeroit.Framework.Metro.ZeroitMetroButton btnsearch;
        private Zeroit.Framework.Metro.ZeroitMetroButton btnupdate;
        private Zeroit.Framework.Metro.ZeroitMetroButton btnadd;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private Zeroit.Framework.Metro.ZeroitMetroTextbox txtemail;
        private System.Windows.Forms.ComboBox cmbspecailization;
        private Zeroit.Framework.Metro.ZeroitMetroTextbox txtaddress;
        private Zeroit.Framework.Metro.ZeroitMetroTextbox txtsalary;
        private Zeroit.Framework.Metro.ZeroitMetroTextbox txtcontact;
        private Zeroit.Framework.Metro.ZeroitMetroTextbox txtdocname;
        private Zeroit.Framework.Metro.ZeroitMetroTextbox txtdocid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuThinButton2 bunifuThinButton21;
        private ns1.BunifuThinButton2 bunifuThinButton22;
        private ns1.BunifuThinButton2 bunifuThinButton23;
        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox btnclose;
        private ns1.BunifuGradientPanel bunifuGradientPanel1;
        private ns1.BunifuElipse bunifuElipse2;
        private ns1.BunifuElipse bunifuElipse3;
        private ns1.BunifuElipse bunifuElipse4;
    }
}
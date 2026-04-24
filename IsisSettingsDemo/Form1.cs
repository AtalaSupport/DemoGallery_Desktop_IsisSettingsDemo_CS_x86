using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Atalasoft.Isis;
using Atalasoft.Imaging.Metadata;

namespace IsisSettingsDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Drawing.Color _overscanColor = Color.Empty;
		private Atalasoft.Isis.IsisController _controller;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnRestore;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboDevice;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.ComboBox cboScanType;
		private System.Windows.Forms.CheckBox chkScanAhead;
		private System.Windows.Forms.CheckBox chkMixedScanning;
		private System.Windows.Forms.ComboBox cboJobSeparation;
		private System.Windows.Forms.ComboBox cboFileType;
		private System.Windows.Forms.ComboBox cboDataOrientation;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown numAreaLeft;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown numAreaTop;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.NumericUpDown numAreaWidth;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.NumericUpDown numAreaHeight;
		private System.Windows.Forms.ComboBox cboColorFormat;
		private System.Windows.Forms.ComboBox cboPageSize;
		private System.Windows.Forms.ComboBox cboResolutionUnit;
		private System.Windows.Forms.ComboBox cboResolution;
		private System.Windows.Forms.NumericUpDown numScanAheadCount;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label lblFeederExists;
		private System.Windows.Forms.Label lblFeederPageCount;
		private System.Windows.Forms.Label lblFeederPageDetect;
		private System.Windows.Forms.Label lblFeederPause;
		private System.Windows.Forms.CheckBox chkFeederStopPause;
		private System.Windows.Forms.CheckBox chkFeederImmediateStop;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.NumericUpDown numFeederTimeout;
		private System.Windows.Forms.CheckBox chkBarcodeFrontSide;
		private System.Windows.Forms.CheckBox chkBarcodeBackSide;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.ComboBox cboBarcodeEmphasis;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.ComboBox cboBarcodeImageQuality;
		private System.Windows.Forms.CheckBox chkBarcodeLinearSearch;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.ComboBox cboBarcodeSearchDirection;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.ComboBox cboBarcodeSearchMode;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.CheckBox chkBarcodeVerifyChecksum;
		private System.Windows.Forms.ComboBox cboBarcodeSearchOrientation;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.NumericUpDown numContrastRed;
		private System.Windows.Forms.NumericUpDown numContrastGreen;
		private System.Windows.Forms.NumericUpDown numContrastBlue;
		private System.Windows.Forms.ComboBox cboContrast;
		private System.Windows.Forms.ComboBox cboBrightness;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.NumericUpDown numBrightnessBlue;
		private System.Windows.Forms.NumericUpDown numBrightnessGreen;
		private System.Windows.Forms.NumericUpDown numBrightnessRed;
		private System.Windows.Forms.ComboBox cboDither;
		private System.Windows.Forms.ComboBox cboEmphasis;
		private System.Windows.Forms.ComboBox cboGamma;
		private System.Windows.Forms.ComboBox cboSharpness;
		private System.Windows.Forms.Button btnOverscanColor;
		private System.Windows.Forms.CheckBox chkOutline;
		private System.Windows.Forms.Button btnScan;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ListBox listSettings;
        private Button buttonAbout;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnScan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numBrightnessBlue = new System.Windows.Forms.NumericUpDown();
            this.numBrightnessGreen = new System.Windows.Forms.NumericUpDown();
            this.numBrightnessRed = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numContrastBlue = new System.Windows.Forms.NumericUpDown();
            this.numContrastGreen = new System.Windows.Forms.NumericUpDown();
            this.numContrastRed = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numScanAheadCount = new System.Windows.Forms.NumericUpDown();
            this.cboResolution = new System.Windows.Forms.ComboBox();
            this.cboResolutionUnit = new System.Windows.Forms.ComboBox();
            this.cboPageSize = new System.Windows.Forms.ComboBox();
            this.cboColorFormat = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numAreaHeight = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numAreaWidth = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numAreaTop = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numAreaLeft = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cboDataOrientation = new System.Windows.Forms.ComboBox();
            this.cboFileType = new System.Windows.Forms.ComboBox();
            this.cboJobSeparation = new System.Windows.Forms.ComboBox();
            this.chkMixedScanning = new System.Windows.Forms.CheckBox();
            this.chkScanAhead = new System.Windows.Forms.CheckBox();
            this.cboScanType = new System.Windows.Forms.ComboBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.chkOutline = new System.Windows.Forms.CheckBox();
            this.btnOverscanColor = new System.Windows.Forms.Button();
            this.cboSharpness = new System.Windows.Forms.ComboBox();
            this.cboGamma = new System.Windows.Forms.ComboBox();
            this.cboEmphasis = new System.Windows.Forms.ComboBox();
            this.cboDither = new System.Windows.Forms.ComboBox();
            this.cboBrightness = new System.Windows.Forms.ComboBox();
            this.cboContrast = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.numFeederTimeout = new System.Windows.Forms.NumericUpDown();
            this.chkFeederImmediateStop = new System.Windows.Forms.CheckBox();
            this.chkFeederStopPause = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblFeederPause = new System.Windows.Forms.Label();
            this.lblFeederPageDetect = new System.Windows.Forms.Label();
            this.lblFeederPageCount = new System.Windows.Forms.Label();
            this.lblFeederExists = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chkBarcodeVerifyChecksum = new System.Windows.Forms.CheckBox();
            this.cboBarcodeSearchOrientation = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.cboBarcodeSearchMode = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.cboBarcodeSearchDirection = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.chkBarcodeLinearSearch = new System.Windows.Forms.CheckBox();
            this.cboBarcodeImageQuality = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.cboBarcodeEmphasis = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.chkBarcodeBackSide = new System.Windows.Forms.CheckBox();
            this.chkBarcodeFrontSide = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listSettings = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBrightnessBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrightnessGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrightnessRed)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numContrastBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numContrastGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numContrastRed)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScanAheadCount)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAreaHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAreaWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAreaTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAreaLeft)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFeederTimeout)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(384, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 24);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Settings";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRestore.Location = new System.Drawing.Point(496, 24);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(96, 24);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "Restore Settings";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Device:";
            // 
            // cboDevice
            // 
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.Location = new System.Drawing.Point(72, 24);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(184, 21);
            this.cboDevice.Sorted = true;
            this.cboDevice.TabIndex = 4;
            this.cboDevice.SelectedIndexChanged += new System.EventHandler(this.cboDevice_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnScan);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnRestore);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboDevice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 56);
            this.panel1.TabIndex = 5;
            // 
            // btnScan
            // 
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnScan.Location = new System.Drawing.Point(272, 24);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(96, 24);
            this.btnScan.TabIndex = 5;
            this.btnScan.Text = "Scan";
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(40, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Brightness:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Location = new System.Drawing.Point(24, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Color Format:";
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(320, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contrast:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numBrightnessBlue);
            this.groupBox1.Controls.Add(this.numBrightnessGreen);
            this.groupBox1.Controls.Add(this.numBrightnessRed);
            this.groupBox1.Controls.Add(this.label38);
            this.groupBox1.Controls.Add(this.label39);
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(40, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 104);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custom Brightness";
            // 
            // numBrightnessBlue
            // 
            this.numBrightnessBlue.Location = new System.Drawing.Point(64, 72);
            this.numBrightnessBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBrightnessBlue.Name = "numBrightnessBlue";
            this.numBrightnessBlue.Size = new System.Drawing.Size(48, 20);
            this.numBrightnessBlue.TabIndex = 11;
            // 
            // numBrightnessGreen
            // 
            this.numBrightnessGreen.Location = new System.Drawing.Point(64, 48);
            this.numBrightnessGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBrightnessGreen.Name = "numBrightnessGreen";
            this.numBrightnessGreen.Size = new System.Drawing.Size(48, 20);
            this.numBrightnessGreen.TabIndex = 10;
            // 
            // numBrightnessRed
            // 
            this.numBrightnessRed.Location = new System.Drawing.Point(64, 24);
            this.numBrightnessRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBrightnessRed.Name = "numBrightnessRed";
            this.numBrightnessRed.Size = new System.Drawing.Size(48, 20);
            this.numBrightnessRed.TabIndex = 9;
            // 
            // label38
            // 
            this.label38.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label38.Location = new System.Drawing.Point(16, 72);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(32, 16);
            this.label38.TabIndex = 8;
            this.label38.Text = "Blue:";
            // 
            // label39
            // 
            this.label39.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label39.Location = new System.Drawing.Point(16, 48);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(48, 16);
            this.label39.TabIndex = 7;
            this.label39.Text = "Green:";
            // 
            // label40
            // 
            this.label40.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label40.Location = new System.Drawing.Point(16, 24);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(40, 16);
            this.label40.TabIndex = 6;
            this.label40.Text = "Red:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numContrastBlue);
            this.groupBox2.Controls.Add(this.numContrastGreen);
            this.groupBox2.Controls.Add(this.numContrastRed);
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(320, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 104);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom Contrast";
            // 
            // numContrastBlue
            // 
            this.numContrastBlue.Location = new System.Drawing.Point(64, 72);
            this.numContrastBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numContrastBlue.Name = "numContrastBlue";
            this.numContrastBlue.Size = new System.Drawing.Size(48, 20);
            this.numContrastBlue.TabIndex = 5;
            // 
            // numContrastGreen
            // 
            this.numContrastGreen.Location = new System.Drawing.Point(64, 48);
            this.numContrastGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numContrastGreen.Name = "numContrastGreen";
            this.numContrastGreen.Size = new System.Drawing.Size(48, 20);
            this.numContrastGreen.TabIndex = 4;
            // 
            // numContrastRed
            // 
            this.numContrastRed.Location = new System.Drawing.Point(64, 24);
            this.numContrastRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numContrastRed.Name = "numContrastRed";
            this.numContrastRed.Size = new System.Drawing.Size(48, 20);
            this.numContrastRed.TabIndex = 3;
            // 
            // label37
            // 
            this.label37.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label37.Location = new System.Drawing.Point(16, 74);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(32, 16);
            this.label37.TabIndex = 2;
            this.label37.Text = "Blue:";
            // 
            // label36
            // 
            this.label36.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label36.Location = new System.Drawing.Point(16, 50);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(48, 16);
            this.label36.TabIndex = 1;
            this.label36.Text = "Green:";
            // 
            // label35
            // 
            this.label35.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label35.Location = new System.Drawing.Point(16, 26);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(40, 16);
            this.label35.TabIndex = 0;
            this.label35.Text = "Red:";
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Location = new System.Drawing.Point(328, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Data Orientation:";
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Location = new System.Drawing.Point(40, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dither:";
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Location = new System.Drawing.Point(40, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Emphasis:";
            // 
            // label9
            // 
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Location = new System.Drawing.Point(328, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "File Type:";
            // 
            // label10
            // 
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Location = new System.Drawing.Point(40, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Gamma:";
            // 
            // label11
            // 
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Location = new System.Drawing.Point(24, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Job Separator Detection:";
            // 
            // label15
            // 
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label15.Location = new System.Drawing.Point(320, 220);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 16);
            this.label15.TabIndex = 17;
            this.label15.Text = "Overscan Color:";
            // 
            // label17
            // 
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label17.Location = new System.Drawing.Point(328, 184);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 16);
            this.label17.TabIndex = 19;
            this.label17.Text = "Page Size:";
            // 
            // label18
            // 
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label18.Location = new System.Drawing.Point(24, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 16);
            this.label18.TabIndex = 20;
            this.label18.Text = "Resolution:";
            // 
            // label19
            // 
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label19.Location = new System.Drawing.Point(24, 138);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 16);
            this.label19.TabIndex = 21;
            this.label19.Text = "Resolution Unit:";
            // 
            // label21
            // 
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label21.Location = new System.Drawing.Point(24, 232);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 16);
            this.label21.TabIndex = 23;
            this.label21.Text = "Scan Ahead Count:";
            // 
            // label24
            // 
            this.label24.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label24.Location = new System.Drawing.Point(24, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 16);
            this.label24.TabIndex = 26;
            this.label24.Text = "Scan Type:";
            // 
            // label25
            // 
            this.label25.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label25.Location = new System.Drawing.Point(320, 186);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 16);
            this.label25.TabIndex = 27;
            this.label25.Text = "Sharpness:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(592, 320);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonAbout);
            this.tabPage1.Controls.Add(this.numScanAheadCount);
            this.tabPage1.Controls.Add(this.cboResolution);
            this.tabPage1.Controls.Add(this.cboResolutionUnit);
            this.tabPage1.Controls.Add(this.cboPageSize);
            this.tabPage1.Controls.Add(this.cboColorFormat);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.cboDataOrientation);
            this.tabPage1.Controls.Add(this.cboFileType);
            this.tabPage1.Controls.Add(this.cboJobSeparation);
            this.tabPage1.Controls.Add(this.chkMixedScanning);
            this.tabPage1.Controls.Add(this.chkScanAhead);
            this.tabPage1.Controls.Add(this.cboScanType);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(584, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            // 
            // numScanAheadCount
            // 
            this.numScanAheadCount.Location = new System.Drawing.Point(152, 230);
            this.numScanAheadCount.Name = "numScanAheadCount";
            this.numScanAheadCount.Size = new System.Drawing.Size(64, 20);
            this.numScanAheadCount.TabIndex = 38;
            // 
            // cboResolution
            // 
            this.cboResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResolution.Location = new System.Drawing.Point(112, 98);
            this.cboResolution.Name = "cboResolution";
            this.cboResolution.Size = new System.Drawing.Size(120, 21);
            this.cboResolution.TabIndex = 37;
            // 
            // cboResolutionUnit
            // 
            this.cboResolutionUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResolutionUnit.Location = new System.Drawing.Point(112, 136);
            this.cboResolutionUnit.Name = "cboResolutionUnit";
            this.cboResolutionUnit.Size = new System.Drawing.Size(120, 21);
            this.cboResolutionUnit.TabIndex = 36;
            // 
            // cboPageSize
            // 
            this.cboPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPageSize.Location = new System.Drawing.Point(416, 182);
            this.cboPageSize.Name = "cboPageSize";
            this.cboPageSize.Size = new System.Drawing.Size(144, 21);
            this.cboPageSize.TabIndex = 35;
            this.cboPageSize.SelectedIndexChanged += new System.EventHandler(this.cboPageSize_SelectedIndexChanged);
            // 
            // cboColorFormat
            // 
            this.cboColorFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColorFormat.Location = new System.Drawing.Point(112, 60);
            this.cboColorFormat.Name = "cboColorFormat";
            this.cboColorFormat.Size = new System.Drawing.Size(120, 21);
            this.cboColorFormat.TabIndex = 34;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numAreaHeight);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.numAreaWidth);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.numAreaTop);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.numAreaLeft);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(328, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 144);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Scan Area";
            // 
            // numAreaHeight
            // 
            this.numAreaHeight.Location = new System.Drawing.Point(72, 111);
            this.numAreaHeight.Name = "numAreaHeight";
            this.numAreaHeight.Size = new System.Drawing.Size(56, 20);
            this.numAreaHeight.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label16.Location = new System.Drawing.Point(16, 113);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 6;
            this.label16.Text = "Height:";
            // 
            // numAreaWidth
            // 
            this.numAreaWidth.Location = new System.Drawing.Point(72, 82);
            this.numAreaWidth.Name = "numAreaWidth";
            this.numAreaWidth.Size = new System.Drawing.Size(56, 20);
            this.numAreaWidth.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Location = new System.Drawing.Point(16, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Width:";
            // 
            // numAreaTop
            // 
            this.numAreaTop.Location = new System.Drawing.Point(72, 53);
            this.numAreaTop.Name = "numAreaTop";
            this.numAreaTop.Size = new System.Drawing.Size(56, 20);
            this.numAreaTop.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.Location = new System.Drawing.Point(16, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Top:";
            // 
            // numAreaLeft
            // 
            this.numAreaLeft.Location = new System.Drawing.Point(72, 24);
            this.numAreaLeft.Name = "numAreaLeft";
            this.numAreaLeft.Size = new System.Drawing.Size(56, 20);
            this.numAreaLeft.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Location = new System.Drawing.Point(16, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Left:";
            // 
            // cboDataOrientation
            // 
            this.cboDataOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataOrientation.Location = new System.Drawing.Point(416, 206);
            this.cboDataOrientation.Name = "cboDataOrientation";
            this.cboDataOrientation.Size = new System.Drawing.Size(144, 21);
            this.cboDataOrientation.TabIndex = 32;
            // 
            // cboFileType
            // 
            this.cboFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFileType.Location = new System.Drawing.Point(416, 230);
            this.cboFileType.Name = "cboFileType";
            this.cboFileType.Size = new System.Drawing.Size(144, 21);
            this.cboFileType.TabIndex = 31;
            // 
            // cboJobSeparation
            // 
            this.cboJobSeparation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJobSeparation.Location = new System.Drawing.Point(152, 254);
            this.cboJobSeparation.Name = "cboJobSeparation";
            this.cboJobSeparation.Size = new System.Drawing.Size(128, 21);
            this.cboJobSeparation.TabIndex = 30;
            // 
            // chkMixedScanning
            // 
            this.chkMixedScanning.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkMixedScanning.Location = new System.Drawing.Point(24, 184);
            this.chkMixedScanning.Name = "chkMixedScanning";
            this.chkMixedScanning.Size = new System.Drawing.Size(112, 16);
            this.chkMixedScanning.TabIndex = 29;
            this.chkMixedScanning.Text = "Mixed Scanning";
            // 
            // chkScanAhead
            // 
            this.chkScanAhead.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkScanAhead.Location = new System.Drawing.Point(24, 208);
            this.chkScanAhead.Name = "chkScanAhead";
            this.chkScanAhead.Size = new System.Drawing.Size(88, 16);
            this.chkScanAhead.TabIndex = 28;
            this.chkScanAhead.Text = "Scan Ahead";
            // 
            // cboScanType
            // 
            this.cboScanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScanType.Location = new System.Drawing.Point(112, 22);
            this.cboScanType.Name = "cboScanType";
            this.cboScanType.Size = new System.Drawing.Size(120, 21);
            this.cboScanType.TabIndex = 27;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.chkOutline);
            this.tabPage6.Controls.Add(this.btnOverscanColor);
            this.tabPage6.Controls.Add(this.cboSharpness);
            this.tabPage6.Controls.Add(this.cboGamma);
            this.tabPage6.Controls.Add(this.cboEmphasis);
            this.tabPage6.Controls.Add(this.cboDither);
            this.tabPage6.Controls.Add(this.cboBrightness);
            this.tabPage6.Controls.Add(this.cboContrast);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Controls.Add(this.label4);
            this.tabPage6.Controls.Add(this.label2);
            this.tabPage6.Controls.Add(this.groupBox2);
            this.tabPage6.Controls.Add(this.groupBox1);
            this.tabPage6.Controls.Add(this.label25);
            this.tabPage6.Controls.Add(this.label15);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(584, 294);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Image Processing";
            // 
            // chkOutline
            // 
            this.chkOutline.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkOutline.Location = new System.Drawing.Point(320, 250);
            this.chkOutline.Name = "chkOutline";
            this.chkOutline.Size = new System.Drawing.Size(64, 16);
            this.chkOutline.TabIndex = 35;
            this.chkOutline.Text = "Outline";
            // 
            // btnOverscanColor
            // 
            this.btnOverscanColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOverscanColor.Location = new System.Drawing.Point(408, 216);
            this.btnOverscanColor.Name = "btnOverscanColor";
            this.btnOverscanColor.Size = new System.Drawing.Size(104, 24);
            this.btnOverscanColor.TabIndex = 34;
            this.btnOverscanColor.Text = "Choose Color...";
            this.btnOverscanColor.Click += new System.EventHandler(this.btnOverscanColor_Click);
            // 
            // cboSharpness
            // 
            this.cboSharpness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSharpness.Location = new System.Drawing.Point(408, 184);
            this.cboSharpness.Name = "cboSharpness";
            this.cboSharpness.Size = new System.Drawing.Size(104, 21);
            this.cboSharpness.TabIndex = 33;
            // 
            // cboGamma
            // 
            this.cboGamma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGamma.Location = new System.Drawing.Point(104, 248);
            this.cboGamma.Name = "cboGamma";
            this.cboGamma.Size = new System.Drawing.Size(128, 21);
            this.cboGamma.TabIndex = 32;
            // 
            // cboEmphasis
            // 
            this.cboEmphasis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmphasis.Location = new System.Drawing.Point(104, 216);
            this.cboEmphasis.Name = "cboEmphasis";
            this.cboEmphasis.Size = new System.Drawing.Size(128, 21);
            this.cboEmphasis.TabIndex = 31;
            // 
            // cboDither
            // 
            this.cboDither.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDither.Location = new System.Drawing.Point(104, 184);
            this.cboDither.Name = "cboDither";
            this.cboDither.Size = new System.Drawing.Size(128, 21);
            this.cboDither.TabIndex = 30;
            // 
            // cboBrightness
            // 
            this.cboBrightness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrightness.Location = new System.Drawing.Point(104, 24);
            this.cboBrightness.Name = "cboBrightness";
            this.cboBrightness.Size = new System.Drawing.Size(72, 21);
            this.cboBrightness.TabIndex = 29;
            // 
            // cboContrast
            // 
            this.cboContrast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboContrast.Location = new System.Drawing.Point(376, 24);
            this.cboContrast.Name = "cboContrast";
            this.cboContrast.Size = new System.Drawing.Size(72, 21);
            this.cboContrast.TabIndex = 28;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.label28);
            this.tabPage3.Controls.Add(this.numFeederTimeout);
            this.tabPage3.Controls.Add(this.chkFeederImmediateStop);
            this.tabPage3.Controls.Add(this.chkFeederStopPause);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(584, 294);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Feeder";
            // 
            // label29
            // 
            this.label29.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label29.Location = new System.Drawing.Point(224, 232);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(64, 16);
            this.label29.TabIndex = 5;
            this.label29.Text = "seconds";
            // 
            // label28
            // 
            this.label28.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label28.Location = new System.Drawing.Point(40, 232);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(128, 16);
            this.label28.TabIndex = 4;
            this.label28.Text = "Scan Attempt Timeout:";
            // 
            // numFeederTimeout
            // 
            this.numFeederTimeout.Location = new System.Drawing.Point(168, 230);
            this.numFeederTimeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numFeederTimeout.Name = "numFeederTimeout";
            this.numFeederTimeout.Size = new System.Drawing.Size(56, 20);
            this.numFeederTimeout.TabIndex = 3;
            // 
            // chkFeederImmediateStop
            // 
            this.chkFeederImmediateStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkFeederImmediateStop.Location = new System.Drawing.Point(40, 200);
            this.chkFeederImmediateStop.Name = "chkFeederImmediateStop";
            this.chkFeederImmediateStop.Size = new System.Drawing.Size(288, 16);
            this.chkFeederImmediateStop.TabIndex = 2;
            this.chkFeederImmediateStop.Text = "Stop immediately when the Stop button is pressed.";
            // 
            // chkFeederStopPause
            // 
            this.chkFeederStopPause.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkFeederStopPause.Location = new System.Drawing.Point(40, 168);
            this.chkFeederStopPause.Name = "chkFeederStopPause";
            this.chkFeederStopPause.Size = new System.Drawing.Size(200, 24);
            this.chkFeederStopPause.TabIndex = 1;
            this.chkFeederStopPause.Text = "Stop scan ahead feature on pause";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblFeederPause);
            this.groupBox4.Controls.Add(this.lblFeederPageDetect);
            this.groupBox4.Controls.Add(this.lblFeederPageCount);
            this.groupBox4.Controls.Add(this.lblFeederExists);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Location = new System.Drawing.Point(32, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 112);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Feeder Information";
            // 
            // lblFeederPause
            // 
            this.lblFeederPause.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFeederPause.Location = new System.Drawing.Point(152, 80);
            this.lblFeederPause.Name = "lblFeederPause";
            this.lblFeederPause.Size = new System.Drawing.Size(88, 16);
            this.lblFeederPause.TabIndex = 8;
            // 
            // lblFeederPageDetect
            // 
            this.lblFeederPageDetect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFeederPageDetect.Location = new System.Drawing.Point(152, 64);
            this.lblFeederPageDetect.Name = "lblFeederPageDetect";
            this.lblFeederPageDetect.Size = new System.Drawing.Size(88, 16);
            this.lblFeederPageDetect.TabIndex = 7;
            // 
            // lblFeederPageCount
            // 
            this.lblFeederPageCount.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFeederPageCount.Location = new System.Drawing.Point(152, 48);
            this.lblFeederPageCount.Name = "lblFeederPageCount";
            this.lblFeederPageCount.Size = new System.Drawing.Size(88, 16);
            this.lblFeederPageCount.TabIndex = 6;
            // 
            // lblFeederExists
            // 
            this.lblFeederExists.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFeederExists.Location = new System.Drawing.Point(152, 32);
            this.lblFeederExists.Name = "lblFeederExists";
            this.lblFeederExists.Size = new System.Drawing.Size(88, 16);
            this.lblFeederExists.TabIndex = 5;
            // 
            // label26
            // 
            this.label26.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label26.Location = new System.Drawing.Point(24, 80);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(88, 16);
            this.label26.TabIndex = 3;
            this.label26.Text = "Can Pause:";
            // 
            // label23
            // 
            this.label23.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label23.Location = new System.Drawing.Point(24, 64);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 16);
            this.label23.TabIndex = 2;
            this.label23.Text = "Page Detection:";
            // 
            // label22
            // 
            this.label22.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label22.Location = new System.Drawing.Point(24, 48);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 16);
            this.label22.TabIndex = 1;
            this.label22.Text = "Maximum Page Count:";
            // 
            // label20
            // 
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label20.Location = new System.Drawing.Point(24, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 16);
            this.label20.TabIndex = 0;
            this.label20.Text = "Exists:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chkBarcodeVerifyChecksum);
            this.tabPage4.Controls.Add(this.cboBarcodeSearchOrientation);
            this.tabPage4.Controls.Add(this.label34);
            this.tabPage4.Controls.Add(this.cboBarcodeSearchMode);
            this.tabPage4.Controls.Add(this.label33);
            this.tabPage4.Controls.Add(this.cboBarcodeSearchDirection);
            this.tabPage4.Controls.Add(this.label32);
            this.tabPage4.Controls.Add(this.chkBarcodeLinearSearch);
            this.tabPage4.Controls.Add(this.cboBarcodeImageQuality);
            this.tabPage4.Controls.Add(this.label31);
            this.tabPage4.Controls.Add(this.cboBarcodeEmphasis);
            this.tabPage4.Controls.Add(this.label30);
            this.tabPage4.Controls.Add(this.chkBarcodeBackSide);
            this.tabPage4.Controls.Add(this.chkBarcodeFrontSide);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(584, 294);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Barcode";
            // 
            // chkBarcodeVerifyChecksum
            // 
            this.chkBarcodeVerifyChecksum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkBarcodeVerifyChecksum.Location = new System.Drawing.Point(24, 128);
            this.chkBarcodeVerifyChecksum.Name = "chkBarcodeVerifyChecksum";
            this.chkBarcodeVerifyChecksum.Size = new System.Drawing.Size(120, 16);
            this.chkBarcodeVerifyChecksum.TabIndex = 13;
            this.chkBarcodeVerifyChecksum.Text = "Verify Checksum";
            // 
            // cboBarcodeSearchOrientation
            // 
            this.cboBarcodeSearchOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarcodeSearchOrientation.Location = new System.Drawing.Point(384, 32);
            this.cboBarcodeSearchOrientation.Name = "cboBarcodeSearchOrientation";
            this.cboBarcodeSearchOrientation.Size = new System.Drawing.Size(104, 21);
            this.cboBarcodeSearchOrientation.TabIndex = 12;
            // 
            // label34
            // 
            this.label34.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label34.Location = new System.Drawing.Point(280, 32);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(120, 16);
            this.label34.TabIndex = 11;
            this.label34.Text = "Search Orientation:";
            // 
            // cboBarcodeSearchMode
            // 
            this.cboBarcodeSearchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarcodeSearchMode.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical",
            "VerticalHorizontal",
            "HorizontalVertical"});
            this.cboBarcodeSearchMode.Location = new System.Drawing.Point(384, 96);
            this.cboBarcodeSearchMode.Name = "cboBarcodeSearchMode";
            this.cboBarcodeSearchMode.Size = new System.Drawing.Size(104, 21);
            this.cboBarcodeSearchMode.TabIndex = 10;
            // 
            // label33
            // 
            this.label33.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label33.Location = new System.Drawing.Point(280, 96);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(88, 16);
            this.label33.TabIndex = 9;
            this.label33.Text = "Search Mode:";
            // 
            // cboBarcodeSearchDirection
            // 
            this.cboBarcodeSearchDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarcodeSearchDirection.Items.AddRange(new object[] {
            "Forward",
            "Reverse"});
            this.cboBarcodeSearchDirection.Location = new System.Drawing.Point(384, 64);
            this.cboBarcodeSearchDirection.Name = "cboBarcodeSearchDirection";
            this.cboBarcodeSearchDirection.Size = new System.Drawing.Size(104, 21);
            this.cboBarcodeSearchDirection.TabIndex = 8;
            // 
            // label32
            // 
            this.label32.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label32.Location = new System.Drawing.Point(280, 64);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(120, 16);
            this.label32.TabIndex = 7;
            this.label32.Text = "Search Direction:";
            // 
            // chkBarcodeLinearSearch
            // 
            this.chkBarcodeLinearSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkBarcodeLinearSearch.Location = new System.Drawing.Point(24, 104);
            this.chkBarcodeLinearSearch.Name = "chkBarcodeLinearSearch";
            this.chkBarcodeLinearSearch.Size = new System.Drawing.Size(128, 16);
            this.chkBarcodeLinearSearch.TabIndex = 6;
            this.chkBarcodeLinearSearch.Text = "Linear Search";
            // 
            // cboBarcodeImageQuality
            // 
            this.cboBarcodeImageQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarcodeImageQuality.Items.AddRange(new object[] {
            "Auto",
            "Dot Matrix",
            "Dithered"});
            this.cboBarcodeImageQuality.Location = new System.Drawing.Point(384, 160);
            this.cboBarcodeImageQuality.Name = "cboBarcodeImageQuality";
            this.cboBarcodeImageQuality.Size = new System.Drawing.Size(104, 21);
            this.cboBarcodeImageQuality.TabIndex = 5;
            // 
            // label31
            // 
            this.label31.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label31.Location = new System.Drawing.Point(280, 162);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(104, 16);
            this.label31.TabIndex = 4;
            this.label31.Text = "Image Quality:";
            // 
            // cboBarcodeEmphasis
            // 
            this.cboBarcodeEmphasis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarcodeEmphasis.Items.AddRange(new object[] {
            "None",
            "White",
            "Black"});
            this.cboBarcodeEmphasis.Location = new System.Drawing.Point(384, 128);
            this.cboBarcodeEmphasis.Name = "cboBarcodeEmphasis";
            this.cboBarcodeEmphasis.Size = new System.Drawing.Size(104, 21);
            this.cboBarcodeEmphasis.TabIndex = 3;
            // 
            // label30
            // 
            this.label30.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label30.Location = new System.Drawing.Point(280, 130);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(96, 16);
            this.label30.TabIndex = 2;
            this.label30.Text = "Emphasis:";
            // 
            // chkBarcodeBackSide
            // 
            this.chkBarcodeBackSide.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkBarcodeBackSide.Location = new System.Drawing.Point(24, 64);
            this.chkBarcodeBackSide.Name = "chkBarcodeBackSide";
            this.chkBarcodeBackSide.Size = new System.Drawing.Size(120, 16);
            this.chkBarcodeBackSide.TabIndex = 1;
            this.chkBarcodeBackSide.Text = "Enable Back Side";
            // 
            // chkBarcodeFrontSide
            // 
            this.chkBarcodeFrontSide.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkBarcodeFrontSide.Location = new System.Drawing.Point(24, 40);
            this.chkBarcodeFrontSide.Name = "chkBarcodeFrontSide";
            this.chkBarcodeFrontSide.Size = new System.Drawing.Size(128, 16);
            this.chkBarcodeFrontSide.TabIndex = 0;
            this.chkBarcodeFrontSide.Text = "Enable Front Side";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listSettings);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(584, 294);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Supported Settings";
            // 
            // listSettings
            // 
            this.listSettings.Location = new System.Drawing.Point(128, 61);
            this.listSettings.Name = "listSettings";
            this.listSettings.Size = new System.Drawing.Size(328, 173);
            this.listSettings.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(72, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(440, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "This is a list of settings retrieved from the IsisController.GetSupportedSettings" +
                " method.";
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(497, 257);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 39;
            this.buttonAbout.Text = "About ...";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(624, 398);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Save and Restore Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numBrightnessBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrightnessGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrightnessRed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numContrastBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numContrastGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numContrastRed)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numScanAheadCount)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAreaHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAreaWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAreaTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAreaLeft)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numFeederTimeout)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.DoEvents();
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
            // This will throw an exception if there is no license.
            try
            {
                Atalasoft.Imaging.AtalaImage img = new Atalasoft.Imaging.AtalaImage();
                img.Dispose();

                _controller = new Atalasoft.Isis.IsisController();
            }
            catch (Atalasoft.Imaging.AtalasoftLicenseException)
            {
                MessageBox.Show("This demo requires a license for 'DotImage' and 'DotImage ISIS'.\r\n\r\nYou can get an evaluation license using the Activation utility or\r\nfrom http://www.atalasoft.com/portal/requestevaluation.aspx.", "No License Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            
			_controller.ImageAcquired += new IsisImageAcquiredEventHandler(_controller_ImageAcquired);
			_controller.ErrorNotification += new IsisErrorNotificationEventHandler(_controller_ErrorNotification);
			_controller.BarcodeDetected += new IsisBarcodeDetectedEventHandler(_controller_BarcodeDetected);

			if (_controller.Devices.Count > 0)
			{
				this.cboDevice.Items.AddRange(_controller.Devices.ToArray());
                IsisDevice defaultDev = _controller.Devices.Default;
                if (defaultDev != null)
                {
                    int index = this.cboDevice.Items.IndexOf(defaultDev);
                    if (index > -1) this.cboDevice.SelectedIndex = index;
                }
            }
			else
			{
				this.tabControl1.Enabled = false;
				this.btnScan.Enabled = false;
				this.btnSave.Enabled = false;
				this.btnRestore.Enabled = false;
				this.cboDevice.Enabled = false;

				MessageBox.Show("No ISIS devices were found on your system.", "No Devices", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			this.Text = "Atalasoft DotImage ISIS Settings Demo - Version " + GetDotImageIsisVersion();
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
            if (_controller != null)
			    _controller.Dispose();
		}

		#region Main Controls

		private void btnRestore_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "XML File (*.xml)|*.xml|INI File (*.ini)|*.ini";
			if (dlg.ShowDialog(this) == DialogResult.OK)
			{
				if (_controller.Open())
				{
					try
					{
						if (dlg.FilterIndex == 1)
							_controller.RestoreSettings(dlg.FileName);
						else
							_controller.RestoreIniSettings(dlg.FileName, "ScannerSettings");
						
						// Update the settings.
						FillControls();
					}
					finally
					{
						_controller.Close();
					}
				}
			}
			dlg.Dispose();
			
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.Filter = "XML File (*.xml)|*.xml|INI File (*.ini)|*.ini";
			if (dlg.ShowDialog(this) == DialogResult.OK)
			{
				if (_controller.Open())
				{
					try
					{
						SetDeviceSettings();

						// Normally you would not need to use the SaveSettings when you have your own
						// user interface for the driver.  This is here simply to provide an example.
						if (dlg.FilterIndex == 1)
							_controller.SaveSettings(dlg.FileName);
						else
							_controller.SaveIniSettings(dlg.FileName, "ScannerSettings");
					}
					finally
					{
						_controller.Close();
					}
				}
			}
			dlg.Dispose();
		}

		private void btnScan_Click(object sender, System.EventArgs e)
		{
			if (_controller.ActiveDevice.Open())
			{
				try
				{
					this.Cursor = Cursors.WaitCursor;
					SetDeviceSettings();

					if (_controller.ShowDeviceDialog(this))
						_controller.Acquire();
				}
				finally
				{
					_controller.ActiveDevice.Close();
					this.Cursor = Cursors.Default;
				}
			}
			else
				MessageBox.Show("We were unable to open an connection to the device.", "Open Failed");
		}

		private void cboDevice_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			_controller.ActiveDevice = (Atalasoft.Isis.IsisDevice)this.cboDevice.SelectedItem;
			FillControls();
		}

		private void cboPageSize_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (_controller.State == IsisState.Open) return;

			// If the scan area is supported, update the values.
			if (_controller.Open())
			{
				try
				{
					if (_controller.QuerySupport(IsisSetting.PositionX))
					{
						Rectangle rc = _controller.ActiveDevice.Settings.ScanArea;	
						this.numAreaLeft.Value = rc.X;
						this.numAreaTop.Value = rc.Y;
						this.numAreaWidth.Value = rc.Width;
						this.numAreaHeight.Value = rc.Height;
					}
				}
				finally
				{
					_controller.Close();
				}
			}
		}

		#endregion

		private void SetDeviceSettings()
		{
			if (_controller.ActiveDevice.State != IsisState.Open)
			{
				MessageBox.Show("The device must be open before calling SetDeviceSettings.", "Device Not Open");
				return;
			}

			IsisSettings settings = _controller.ActiveDevice.Settings;

			// General
			if (this.cboScanType.Enabled)
				settings.ScanType = (IsisScanType)this.cboScanType.SelectedItem;
			if (this.cboColorFormat.Enabled)
				settings.PixelFormat = (IsisPixelFormat)this.cboColorFormat.SelectedItem;
			if (this.cboPageSize.Enabled)
				settings.PageSize = this.cboPageSize.Text;
			if (this.cboResolutionUnit.Enabled)
				settings.ResolutionUnit = (IsisResolutionUnit)this.cboResolutionUnit.SelectedItem;
			if (this.cboResolution.Enabled)
				settings.Resolution = (Rational)this.cboResolution.SelectedItem;
			if (this.cboJobSeparation.Enabled)
				settings.JobSeparatorDetection = (IsisJobSeparatorDetection)this.cboJobSeparation.SelectedItem;
			if (this.cboDataOrientation.Enabled)
				settings.DataOrientation = (IsisOrientation)this.cboDataOrientation.SelectedItem;
			if (this.cboFileType.Enabled)
				settings.FileType = (IsisFileType)this.cboFileType.SelectedItem;

			settings.MixedScanning = this.chkMixedScanning.Checked;
			settings.ScanAhead = this.chkScanAhead.Checked;
			settings.ScanAheadCount = (int)this.numScanAheadCount.Value;

			if (this.numAreaLeft.Enabled)
			{
				int x = Convert.ToInt32(this.numAreaLeft.Value);
				int y = Convert.ToInt32(this.numAreaTop.Value);
				int w = Convert.ToInt32(this.numAreaWidth.Value);
				int h = Convert.ToInt32(this.numAreaHeight.Value);
				if (w != 0 && h != 0)
					settings.ScanArea = new Rectangle(x, y, w, h);
			}

			// Image Processing
			if (this.cboBrightness.Enabled)
				settings.Brightness = (IsisBrightness)this.cboBrightness.SelectedItem;
			if (this.cboContrast.Enabled)
				settings.Contrast = (int)this.cboContrast.SelectedItem;
			if (this.cboEmphasis.Enabled)
				settings.Emphasis = (IsisEmphasis)this.cboEmphasis.SelectedItem;
			if (this.cboGamma.Enabled)
				settings.Gamma = (int)this.cboGamma.SelectedItem;
			if (this.cboDither.Enabled)
				settings.Dither = (string)this.cboDither.SelectedItem;
			if (this.cboSharpness.Enabled)
				settings.Sharpness = (int)this.cboSharpness.SelectedItem;

			settings.Outline = this.chkOutline.Checked;
					
			if (this.btnOverscanColor.Enabled)
				settings.OverscanColor = _overscanColor;

			if (this.numBrightnessBlue.Enabled && this.numBrightnessGreen.Enabled && this.numBrightnessRed.Enabled)
				settings.CustomBrightness = new IsisCustomBrightnessContrast((int)this.numBrightnessRed.Value, (int)this.numBrightnessGreen.Value, (int)this.numBrightnessBlue.Value);

			if (this.numContrastBlue.Enabled && this.numContrastGreen.Enabled && this.numContrastRed.Enabled)
				settings.CustomContrast = new IsisCustomBrightnessContrast((int)this.numContrastRed.Value, (int)this.numContrastGreen.Value, (int)this.numContrastBlue.Value);

			// Feeder
			settings.DocumentFeeder.StopScanAheadOnPause = this.chkFeederStopPause.Checked;
			settings.DocumentFeeder.ImmediateStop = this.chkFeederImmediateStop.Checked;
			settings.DocumentFeeder.Timeout = Convert.ToInt32(this.numFeederTimeout.Value);

			// Barcode
			if (this.chkBarcodeBackSide.Enabled || this.chkBarcodeFrontSide.Enabled)
			{
				IsisBarcodeSupport barSupport = IsisBarcodeSupport.None;
				if (this.chkBarcodeFrontSide.Checked) barSupport = IsisBarcodeSupport.FrontSide;
				if (this.chkBarcodeBackSide.Checked) barSupport |= IsisBarcodeSupport.BackSide;
				settings.Barcode.Enabled = barSupport;

				if (this.chkBarcodeLinearSearch.Enabled)
					settings.Barcode.LinearSearch = this.chkBarcodeLinearSearch.Checked;
				if (this.chkBarcodeVerifyChecksum.Enabled)
					settings.Barcode.VerifyChecksum = this.chkBarcodeVerifyChecksum.Checked;
				if (this.cboBarcodeEmphasis.Enabled)
					settings.Barcode.Emphasis = (IsisBarcodeEmphasis)this.cboBarcodeEmphasis.SelectedItem;
				if (this.cboBarcodeImageQuality.Enabled)
					settings.Barcode.ImageQuality = (IsisBarcodeImageQuality)this.cboBarcodeImageQuality.SelectedItem;
				if (this.cboBarcodeSearchDirection.Enabled)
					settings.Barcode.SearchDirection = (IsisBarcodeSearchDirection)this.cboBarcodeSearchDirection.SelectedItem;
				if (this.cboBarcodeSearchMode.Enabled)
					settings.Barcode.SearchMode = (IsisBarcodeSearchMode)this.cboBarcodeSearchMode.SelectedItem;
				if (this.cboBarcodeSearchOrientation.Enabled)
					settings.Barcode.SearchOrientation = (IsisOrientation)this.cboBarcodeSearchOrientation.SelectedItem;
			}
		}

		private void FillControls()
		{
			ClearControls();

			bool closeDevice = _controller.ActiveDevice.State == IsisState.Closed;

			if (!closeDevice || _controller.ActiveDevice.Open())
			{
				try
				{
					this.Cursor = Cursors.WaitCursor;
					IsisSettings settings = _controller.ActiveDevice.Settings;

					this.listSettings.Items.Clear();
					IsisSetting[] allSettings = _controller.GetSupportedSettings(false);
					foreach (IsisSetting isg in allSettings)
						this.listSettings.Items.Add(isg);

					// Color format must always be supported.
					IsisPixelFormat[] formats = settings.GetSupportedColorFormats();
					foreach (IsisPixelFormat cf in formats)
						this.cboColorFormat.Items.Add(cf);

					this.cboColorFormat.SelectedIndex = this.cboColorFormat.Items.IndexOf(settings.PixelFormat);

					LoadComboBoxValues(this.cboScanType, IsisSetting.ScanType);
					LoadComboBoxValues(this.cboPageSize, IsisSetting.PageSize);
					LoadComboBoxValues(this.cboResolution, IsisSetting.ResolutionX);
					LoadComboBoxValues(this.cboResolutionUnit, IsisSetting.ResolutionUnit);
					LoadNumValue(this.numScanAheadCount, IsisSetting.ScanAheadCount);
					LoadComboBoxValues(this.cboJobSeparation, IsisSetting.JobSeparatorDetection);
					LoadComboBoxValues(this.cboDataOrientation, IsisSetting.DataOrientation);
					LoadComboBoxValues(this.cboFileType, IsisSetting.FileType);

					if (_controller.QuerySupport(IsisSetting.MixedScanning))
					{
						this.chkMixedScanning.Enabled = true;
						this.chkMixedScanning.Checked = settings.MixedScanning;
					}
					else
						this.chkMixedScanning.Enabled = false;

					if (_controller.QuerySupport(IsisSetting.ScanAhead))
					{
						this.chkScanAhead.Enabled = true;
						this.chkScanAhead.Checked = settings.ScanAhead;
					}
					else
						this.chkScanAhead.Enabled = false;

					Rectangle rc = settings.ScanArea;
					if (_controller.QuerySupport(IsisSetting.PositionX))
					{
						this.numAreaLeft.Enabled = true;
						this.numAreaLeft.Maximum = int.MaxValue;
						this.numAreaLeft.Value = rc.X;
					}
					else
						this.numAreaLeft.Enabled = false;

					if (_controller.QuerySupport(IsisSetting.PositionY))
					{
						this.numAreaTop.Enabled = true;
						this.numAreaTop.Maximum = int.MaxValue;
						this.numAreaTop.Value = rc.Y;
					}
					else
						this.numAreaTop.Enabled = false;

					if (_controller.QuerySupport(IsisSetting.ImageWidth))
					{
						this.numAreaWidth.Enabled = true;
						this.numAreaWidth.Maximum = int.MaxValue;
						this.numAreaWidth.Value = rc.Width;
					}
					else
						this.numAreaWidth.Enabled = false;

					if (_controller.QuerySupport(IsisSetting.ImageLength))
					{
						this.numAreaHeight.Enabled = true;
						this.numAreaHeight.Maximum = int.MaxValue;
						this.numAreaHeight.Value = rc.Height;
					}
					else
						this.numAreaHeight.Enabled = false;

					// Image Processing
					LoadComboBoxValues(this.cboBrightness, IsisSetting.Brightness);
					LoadComboBoxValues(this.cboContrast, IsisSetting.Contrast);
					LoadComboBoxValues(this.cboDither, IsisSetting.Dither);
					LoadComboBoxValues(this.cboGamma, IsisSetting.Gamma);
					LoadComboBoxValues(this.cboEmphasis, IsisSetting.Emphasis);
					LoadComboBoxValues(this.cboSharpness, IsisSetting.Sharpness);
					LoadNumValue(this.numBrightnessBlue, IsisSetting.BlueBrightness);
					LoadNumValue(this.numBrightnessGreen, IsisSetting.GreenBrightness);
					LoadNumValue(this.numBrightnessRed, IsisSetting.RedBrightness);
					LoadNumValue(this.numContrastBlue, IsisSetting.BlueContrast);
					LoadNumValue(this.numContrastGreen, IsisSetting.GreenContrast);
					LoadNumValue(this.numContrastRed, IsisSetting.RedContrast);

					if (_controller.QuerySupport(IsisSetting.OverscanColor))
					{
						this.btnOverscanColor.Enabled = true;
						_overscanColor = settings.OverscanColor;
						this.btnOverscanColor.Text = _overscanColor.Name;
					}
					else
						this.btnOverscanColor.Enabled = false;

					// Feeder settings
					this.lblFeederExists.Text = settings.DocumentFeeder.Exists.ToString();
					this.lblFeederPageCount.Text = settings.DocumentFeeder.MaximumPageCount.ToString();
					this.lblFeederPageDetect.Text = settings.DocumentFeeder.PageDetection.ToString();
					this.lblFeederPause.Text = settings.DocumentFeeder.CanPause.ToString();
					LoadNumValue(this.numFeederTimeout, IsisSetting.FeederTimeout);

					if (_controller.QuerySupport(IsisSetting.FeederStopMode))
					{
						this.chkFeederImmediateStop.Enabled = true;
						this.chkFeederImmediateStop.Checked = settings.DocumentFeeder.ImmediateStop;
					}
					else
						this.chkFeederImmediateStop.Enabled = false;

					if (_controller.QuerySupport(IsisSetting.FeederPauseMode))
					{
						this.chkFeederStopPause.Enabled = true;
						this.chkFeederStopPause.Checked = settings.DocumentFeeder.StopScanAheadOnPause;
					}
					else
						this.chkFeederStopPause.Enabled = false;

					// Barcode settings
					this.chkBarcodeBackSide.Enabled = false;
					this.chkBarcodeFrontSide.Enabled = false;
					this.chkBarcodeLinearSearch.Enabled = false;
					this.chkBarcodeVerifyChecksum.Enabled = false;

					if (settings.QuerySupport(IsisSetting.BarcodeAutoReadBack))
					{
						this.chkBarcodeBackSide.Enabled = true;
						this.chkBarcodeBackSide.Checked = ((settings.Barcode.Enabled & IsisBarcodeSupport.BackSide) == IsisBarcodeSupport.BackSide);
					}

					if (settings.QuerySupport(IsisSetting.BarcodeAutoReadFront) || settings.QuerySupport(IsisSetting.Barcode))
					{
						this.chkBarcodeFrontSide.Enabled = true;
						this.chkBarcodeFrontSide.Checked = ((settings.Barcode.Enabled & IsisBarcodeSupport.FrontSide) == IsisBarcodeSupport.FrontSide);
					}

					if (settings.QuerySupport(IsisSetting.BarcodeChecksum))
					{
						this.chkBarcodeVerifyChecksum.Enabled = true;
						this.chkBarcodeVerifyChecksum.Checked = settings.Barcode.VerifyChecksum;
					}

					if (settings.QuerySupport(IsisSetting.BarcodeSearchLinear))
					{
						this.chkBarcodeLinearSearch.Enabled = true;
						this.chkBarcodeLinearSearch.Checked = settings.Barcode.LinearSearch;
					}

					LoadComboBoxValues(this.cboBarcodeEmphasis, IsisSetting.BarcodeEmphasis);
					LoadComboBoxValues(this.cboBarcodeImageQuality, IsisSetting.BarcodeImageQuality);
					LoadComboBoxValues(this.cboBarcodeSearchDirection, IsisSetting.BarcodeSearchDirection);
					LoadComboBoxValues(this.cboBarcodeSearchMode, IsisSetting.BarcodeSearchMode);
					LoadComboBoxValues(this.cboBarcodeSearchOrientation, IsisSetting.BarcodeSearchOrientation);
				}
				finally
				{
					if (closeDevice)
						_controller.ActiveDevice.Close();
					
					this.Cursor = Cursors.Default;
				}
			}
			else
				MessageBox.Show("We were unable to open an connection to the device.", "Open Failed");

		}

		private void LoadNumValue(NumericUpDown ctrl, IsisSetting setting)
		{
			if (_controller.QuerySupport(setting))
			{
				ctrl.Enabled = true;
				int val = _controller.GetIntValue(setting, 0);

				// Just in case a driver returns a larger value than expected.
				if (val > ctrl.Maximum) ctrl.Maximum = val;
				if (val < ctrl.Minimum) ctrl.Minimum = val;
				ctrl.Value = val;
			}
			else
				ctrl.Enabled = false;
		}

		private void LoadComboBoxValues(ComboBox ctrl, IsisSetting setting)
		{
			ctrl.Items.Clear();

			object[] list = null;
			int selectedIndex = -1;
			
			ctrl.Enabled = _controller.GetSupportedListValues(setting, ref list, ref selectedIndex);
			
			if (list != null)
				ctrl.Items.AddRange(list);
			
			if (selectedIndex != -1)
				ctrl.SelectedIndex = selectedIndex;
		}

		private void ClearControls()
		{
			// General
			this.cboColorFormat.Items.Clear();
			this.chkMixedScanning.Checked = false;
			this.chkScanAhead.Checked = false;
			ClearNumberControl(this.numAreaHeight);
			ClearNumberControl(this.numAreaLeft);
			ClearNumberControl(this.numAreaTop);
			ClearNumberControl(this.numAreaWidth);
			ClearNumberControl(this.numScanAheadCount);

			// Image Processing
			this.chkOutline.Checked = false;
			this.numBrightnessBlue.Value = 0;
			this.numBrightnessGreen.Value = 0;
			this.numBrightnessRed.Value = 0;
			this.numContrastBlue.Value = 0;
			this.numContrastGreen.Value = 0;
			this.numContrastRed.Value = 0;
			this.btnOverscanColor.Text = "Choose Color...";

			// Feeder
			this.chkFeederImmediateStop.Checked = false;
			this.chkFeederStopPause.Checked = false;
			this.numFeederTimeout.Value = 0;
			this.lblFeederExists.Text = "";
			this.lblFeederPageCount.Text = "";
			this.lblFeederPageDetect.Text = "";
			this.lblFeederPause.Text = "";

			// Barcode
			this.chkBarcodeBackSide.Checked = false;
			this.chkBarcodeFrontSide.Checked = false;
			this.chkBarcodeLinearSearch.Checked = false;
			this.chkBarcodeVerifyChecksum.Checked = false;
		}

		private void ClearNumberControl(NumericUpDown ctrl)
		{
			ctrl.Minimum = 0;
			ctrl.Value = 0;
			ctrl.Maximum = 0;
		}

		private void btnOverscanColor_Click(object sender, System.EventArgs e)
		{
			ColorDialog dlg = new ColorDialog();
			dlg.Color = _overscanColor;

			if (dlg.ShowDialog(this) == DialogResult.OK)
			{
				_overscanColor = dlg.Color;
				this.btnOverscanColor.Text = dlg.Color.Name;
			}

			dlg.Dispose();
		}

		#region IsisController Events

		private void _controller_ImageAcquired(object sender, IsisImageAcquiredEventArgs e)
		{
			// We don't care about the image in this demo.
			if (e.Image != null) e.Image.Dispose();
		}

		private void _controller_ErrorNotification(object sender, IsisErrorNotificationEventArgs e)
		{
			MessageBox.Show(e.Message, "Exception Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void _controller_BarcodeDetected(object sender, IsisBarcodeDetectedEventArgs e)
		{
			MessageBox.Show("Code Type: " + e.CodeType.ToString(), "Barcode Detected");
		}

		#endregion

		private string GetDotImageIsisVersion()
		{
			try
			{
                // NOTE this is just stuff we do for the demo for showing you the vrsion and is not critical
                // the warning can be ignored
                System.Reflection.Assembly asm = System.Reflection.Assembly.Load("Atalasoft.dotImage.Isis", null);
				Version ver = asm.GetName().Version;
				return ver.ToString();
			}
			catch
			{
				return "unknown";
			}
		}

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AtalaDemos.AboutBox.About aboutBox = new AtalaDemos.AboutBox.About("Atalasoft DotImage ISIS Settings Demo", "ISIS Settings Demo");
            aboutBox.Description = "Explores control over ISIS scanning settings in greater depth than our ISIS Demo.\r\n\r\n" +
                                   "Unlike our ISIS Demo, this is an in-depth exploration of available ISIS settings when connected to a given scanner. It allows you to view and modify the settings for your scanner.\r\n\r\n" +
                                   "Note: While you can tell it to perform a scan, there's no viewer here. Please see the aforementioned ISIS Demo if you're looking for an example of handling the acquired images";
            aboutBox.ShowDialog();
        }

	}
}


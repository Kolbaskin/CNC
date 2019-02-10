using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;
using Mach4;
using Cnc;

namespace Cnc
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private IMach4 _mach;
		private IMyScriptObject _mInst;
		
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btStop;
		private System.Windows.Forms.Button btStart;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox imCutType2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.NumericUpDown vT1_H;
		private System.Windows.Forms.RadioButton vT1_DirectL;
		private System.Windows.Forms.RadioButton vT1_DirectW;
		private System.Windows.Forms.CheckBox vT1_2;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.NumericUpDown vT1_Podrez;
		private System.Windows.Forms.RadioButton vT2_t4;
		private System.Windows.Forms.RadioButton vT2_t3;
		private System.Windows.Forms.RadioButton vT2_t2;
		private System.Windows.Forms.RadioButton vT2_t1;
		private System.Windows.Forms.NumericUpDown vT2_Depth;
		private System.Windows.Forms.CheckBox vT2_noX;
		private System.Windows.Forms.NumericUpDown vT2_W;
		private System.Windows.Forms.NumericUpDown vT2_H;
		private System.Windows.Forms.NumericUpDown vT2_X;
		private System.Windows.Forms.NumericUpDown vT2_Count;
		private System.Windows.Forms.NumericUpDown vT2_t2Depth;
		private System.Windows.Forms.RadioButton vT3_t1;
		private System.Windows.Forms.NumericUpDown vT3_Depth;
		private System.Windows.Forms.NumericUpDown vT3_Count;
		private System.Windows.Forms.CheckBox vT3_noX;
		private System.Windows.Forms.NumericUpDown vT3_X;
		private System.Windows.Forms.NumericUpDown vT3_W;
		private System.Windows.Forms.TextBox vT3_L;
		private System.Windows.Forms.RadioButton vT3_t4;
		private System.Windows.Forms.RadioButton vT3_t3;
		private System.Windows.Forms.NumericUpDown vT4_Depth;
		private System.Windows.Forms.NumericUpDown vT4_D;
		private System.Windows.Forms.Label vT4_FileName;
		private System.Windows.Forms.NumericUpDown vT1_S;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TextBox codeLog;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btRun;
		private System.Windows.Forms.Button btReset;
		private System.Windows.Forms.Button btX0;
		private System.Windows.Forms.Button btY0;
		private System.Windows.Forms.Button btZ0;
		private System.Windows.Forms.Button btResetX;
		private System.Windows.Forms.NumericUpDown vT11_W;
		private System.Windows.Forms.NumericUpDown vT11_L;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TextBox vT5_Data;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox vT5_Depth;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();
		}

		// Получение текущих координат
		// x =_mInst.GetOEMDRO(800).ToString();
		// y =_mInst.GetOEMDRO(801).ToString();
		// z =_mInst.GetOEMDRO(802).ToString();

		private void GetMachInstance() 
		{
			try 
			{
				_mach = (IMach4) Marshal.GetActiveObject("Mach4.Document");
				_mInst = (IMyScriptObject) _mach.GetScriptDispatch();
			} 
			catch 
			{
				_mach = null;
				_mInst = null;
			}
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btResetX = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.vT1_S = new System.Windows.Forms.NumericUpDown();
			this.vT1_Podrez = new System.Windows.Forms.NumericUpDown();
			this.label16 = new System.Windows.Forms.Label();
			this.imCutType2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.vT1_H = new System.Windows.Forms.NumericUpDown();
			this.vT11_W = new System.Windows.Forms.NumericUpDown();
			this.vT11_L = new System.Windows.Forms.NumericUpDown();
			this.vT1_DirectL = new System.Windows.Forms.RadioButton();
			this.vT1_DirectW = new System.Windows.Forms.RadioButton();
			this.vT1_2 = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.vT2_t4 = new System.Windows.Forms.RadioButton();
			this.vT2_t2Depth = new System.Windows.Forms.NumericUpDown();
			this.vT2_t3 = new System.Windows.Forms.RadioButton();
			this.vT2_t2 = new System.Windows.Forms.RadioButton();
			this.vT2_t1 = new System.Windows.Forms.RadioButton();
			this.vT2_Depth = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.vT2_noX = new System.Windows.Forms.CheckBox();
			this.vT2_W = new System.Windows.Forms.NumericUpDown();
			this.vT2_H = new System.Windows.Forms.NumericUpDown();
			this.vT2_X = new System.Windows.Forms.NumericUpDown();
			this.vT2_Count = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.vT3_t4 = new System.Windows.Forms.RadioButton();
			this.vT3_t3 = new System.Windows.Forms.RadioButton();
			this.vT3_t1 = new System.Windows.Forms.RadioButton();
			this.vT3_Depth = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.vT3_Count = new System.Windows.Forms.NumericUpDown();
			this.label13 = new System.Windows.Forms.Label();
			this.vT3_noX = new System.Windows.Forms.CheckBox();
			this.vT3_X = new System.Windows.Forms.NumericUpDown();
			this.label12 = new System.Windows.Forms.Label();
			this.vT3_W = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.vT3_L = new System.Windows.Forms.TextBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.vT4_Depth = new System.Windows.Forms.NumericUpDown();
			this.label15 = new System.Windows.Forms.Label();
			this.vT4_D = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.vT4_FileName = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btRun = new System.Windows.Forms.Button();
			this.codeLog = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btZ0 = new System.Windows.Forms.Button();
			this.btY0 = new System.Windows.Forms.Button();
			this.btX0 = new System.Windows.Forms.Button();
			this.btReset = new System.Windows.Forms.Button();
			this.btStop = new System.Windows.Forms.Button();
			this.btStart = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.vT5_Data = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.vT5_Depth = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vT1_S)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vT1_Podrez)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vT1_H)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vT11_W)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vT11_L)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vT2_t2Depth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vT2_Depth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vT2_W)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vT2_H)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vT2_X)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vT2_Count)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vT3_Depth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vT3_Count)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vT3_X)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vT3_W)).BeginInit();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vT4_Depth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vT4_D)).BeginInit();
			this.tabPage5.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(5, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(686, 460);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btResetX);
			this.tabPage1.Controls.Add(this.label17);
			this.tabPage1.Controls.Add(this.vT1_S);
			this.tabPage1.Controls.Add(this.vT1_Podrez);
			this.tabPage1.Controls.Add(this.label16);
			this.tabPage1.Controls.Add(this.imCutType2);
			this.tabPage1.Controls.Add(this.pictureBox1);
			this.tabPage1.Controls.Add(this.vT1_H);
			this.tabPage1.Controls.Add(this.vT11_W);
			this.tabPage1.Controls.Add(this.vT11_L);
			this.tabPage1.Controls.Add(this.vT1_DirectL);
			this.tabPage1.Controls.Add(this.vT1_DirectW);
			this.tabPage1.Controls.Add(this.vT1_2);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(678, 434);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Раскрой";
			// 
			// btResetX
			// 
			this.btResetX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btResetX.Location = new System.Drawing.Point(512, 280);
			this.btResetX.Name = "btResetX";
			this.btResetX.Size = new System.Drawing.Size(112, 48);
			this.btResetX.TabIndex = 17;
			this.btResetX.Text = "Reset X";
			this.btResetX.Click += new System.EventHandler(this.btResetX_Click);
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label17.Location = new System.Drawing.Point(24, 144);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(32, 23);
			this.label17.TabIndex = 16;
			this.label17.Text = "S";
			// 
			// vT1_S
			// 
			this.vT1_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT1_S.Location = new System.Drawing.Point(64, 144);
			this.vT1_S.Maximum = new System.Decimal(new int[] {
																  1000,
																  0,
																  0,
																  0});
			this.vT1_S.Name = "vT1_S";
			this.vT1_S.Size = new System.Drawing.Size(176, 29);
			this.vT1_S.TabIndex = 15;
			// 
			// vT1_Podrez
			// 
			this.vT1_Podrez.Enabled = false;
			this.vT1_Podrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT1_Podrez.Location = new System.Drawing.Point(184, 304);
			this.vT1_Podrez.Name = "vT1_Podrez";
			this.vT1_Podrez.Size = new System.Drawing.Size(96, 29);
			this.vT1_Podrez.TabIndex = 14;
			this.vT1_Podrez.Value = new System.Decimal(new int[] {
																	 4,
																	 0,
																	 0,
																	 0});
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label16.Location = new System.Drawing.Point(16, 304);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(168, 23);
			this.label16.TabIndex = 13;
			this.label16.Text = "Глубина подреза";
			// 
			// imCutType2
			// 
			this.imCutType2.Image = ((System.Drawing.Image)(resources.GetObject("imCutType2.Image")));
			this.imCutType2.Location = new System.Drawing.Point(256, 16);
			this.imCutType2.Name = "imCutType2";
			this.imCutType2.Size = new System.Drawing.Size(408, 272);
			this.imCutType2.TabIndex = 12;
			this.imCutType2.TabStop = false;
			this.imCutType2.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(264, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(400, 248);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// vT1_H
			// 
			this.vT1_H.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT1_H.Location = new System.Drawing.Point(64, 104);
			this.vT1_H.Name = "vT1_H";
			this.vT1_H.Size = new System.Drawing.Size(176, 29);
			this.vT1_H.TabIndex = 10;
			this.vT1_H.Value = new System.Decimal(new int[] {
																20,
																0,
																0,
																0});
			// 
			// vT11_W
			// 
			this.vT11_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT11_W.Location = new System.Drawing.Point(64, 64);
			this.vT11_W.Maximum = new System.Decimal(new int[] {
																   1000,
																   0,
																   0,
																   0});
			this.vT11_W.Name = "vT11_W";
			this.vT11_W.Size = new System.Drawing.Size(176, 29);
			this.vT11_W.TabIndex = 9;
			// 
			// vT11_L
			// 
			this.vT11_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT11_L.Location = new System.Drawing.Point(64, 24);
			this.vT11_L.Maximum = new System.Decimal(new int[] {
																   1000,
																   0,
																   0,
																   0});
			this.vT11_L.Name = "vT11_L";
			this.vT11_L.Size = new System.Drawing.Size(176, 29);
			this.vT11_L.TabIndex = 8;
			// 
			// vT1_DirectL
			// 
			this.vT1_DirectL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT1_DirectL.Location = new System.Drawing.Point(48, 224);
			this.vT1_DirectL.Name = "vT1_DirectL";
			this.vT1_DirectL.Size = new System.Drawing.Size(152, 24);
			this.vT1_DirectL.TabIndex = 6;
			this.vT1_DirectL.Text = "рез вдоль";
			this.vT1_DirectL.CheckedChanged += new System.EventHandler(this.rdDirectL_CheckedChanged);
			// 
			// vT1_DirectW
			// 
			this.vT1_DirectW.Checked = true;
			this.vT1_DirectW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT1_DirectW.Location = new System.Drawing.Point(48, 192);
			this.vT1_DirectW.Name = "vT1_DirectW";
			this.vT1_DirectW.Size = new System.Drawing.Size(152, 24);
			this.vT1_DirectW.TabIndex = 5;
			this.vT1_DirectW.TabStop = true;
			this.vT1_DirectW.Text = "рез поперек";
			// 
			// vT1_2
			// 
			this.vT1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT1_2.Location = new System.Drawing.Point(48, 264);
			this.vT1_2.Name = "vT1_2";
			this.vT1_2.Size = new System.Drawing.Size(120, 24);
			this.vT1_2.TabIndex = 3;
			this.vT1_2.Text = "2 прохода";
			this.vT1_2.CheckedChanged += new System.EventHandler(this.vT1_2_CheckedChanged);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(24, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "H";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(24, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "W";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "L";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.vT2_t4);
			this.tabPage2.Controls.Add(this.vT2_t2Depth);
			this.tabPage2.Controls.Add(this.vT2_t3);
			this.tabPage2.Controls.Add(this.vT2_t2);
			this.tabPage2.Controls.Add(this.vT2_t1);
			this.tabPage2.Controls.Add(this.vT2_Depth);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.vT2_noX);
			this.tabPage2.Controls.Add(this.vT2_W);
			this.tabPage2.Controls.Add(this.vT2_H);
			this.tabPage2.Controls.Add(this.vT2_X);
			this.tabPage2.Controls.Add(this.vT2_Count);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.pictureBox2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(678, 434);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Присадка торцевая";
			// 
			// vT2_t4
			// 
			this.vT2_t4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT2_t4.Location = new System.Drawing.Point(280, 248);
			this.vT2_t4.Name = "vT2_t4";
			this.vT2_t4.Size = new System.Drawing.Size(400, 24);
			this.vT2_t4.TabIndex = 22;
			this.vT2_t4.Text = "только 2 под стяжки (меньший диаметр)";
			// 
			// vT2_t2Depth
			// 
			this.vT2_t2Depth.Enabled = false;
			this.vT2_t2Depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT2_t2Depth.Location = new System.Drawing.Point(512, 184);
			this.vT2_t2Depth.Name = "vT2_t2Depth";
			this.vT2_t2Depth.Size = new System.Drawing.Size(88, 29);
			this.vT2_t2Depth.TabIndex = 21;
			this.vT2_t2Depth.Value = new System.Decimal(new int[] {
																	  40,
																	  0,
																	  0,
																	  0});
			// 
			// vT2_t3
			// 
			this.vT2_t3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT2_t3.Location = new System.Drawing.Point(280, 216);
			this.vT2_t3.Name = "vT2_t3";
			this.vT2_t3.Size = new System.Drawing.Size(312, 24);
			this.vT2_t3.TabIndex = 20;
			this.vT2_t3.Text = "2 под стяжки пропустить";
			// 
			// vT2_t2
			// 
			this.vT2_t2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT2_t2.Location = new System.Drawing.Point(280, 184);
			this.vT2_t2.Name = "vT2_t2";
			this.vT2_t2.Size = new System.Drawing.Size(336, 24);
			this.vT2_t2.TabIndex = 19;
			this.vT2_t2.Text = "2 под стяжки глубже";
			// 
			// vT2_t1
			// 
			this.vT2_t1.Checked = true;
			this.vT2_t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT2_t1.Location = new System.Drawing.Point(280, 152);
			this.vT2_t1.Name = "vT2_t1";
			this.vT2_t1.Size = new System.Drawing.Size(224, 24);
			this.vT2_t1.TabIndex = 18;
			this.vT2_t1.TabStop = true;
			this.vT2_t1.Text = "Все одинаковые";
			// 
			// vT2_Depth
			// 
			this.vT2_Depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT2_Depth.Location = new System.Drawing.Point(24, 248);
			this.vT2_Depth.Name = "vT2_Depth";
			this.vT2_Depth.Size = new System.Drawing.Size(88, 29);
			this.vT2_Depth.TabIndex = 17;
			this.vT2_Depth.Value = new System.Decimal(new int[] {
																	16,
																	0,
																	0,
																	0});
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(24, 224);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(216, 23);
			this.label8.TabIndex = 16;
			this.label8.Text = "Глубина отверстий";
			// 
			// vT2_noX
			// 
			this.vT2_noX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT2_noX.Location = new System.Drawing.Point(144, 64);
			this.vT2_noX.Name = "vT2_noX";
			this.vT2_noX.Size = new System.Drawing.Size(152, 24);
			this.vT2_noX.TabIndex = 15;
			this.vT2_noX.Text = "отступить X";
			// 
			// vT2_W
			// 
			this.vT2_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT2_W.Location = new System.Drawing.Point(64, 24);
			this.vT2_W.Maximum = new System.Decimal(new int[] {
																  1000,
																  0,
																  0,
																  0});
			this.vT2_W.Name = "vT2_W";
			this.vT2_W.Size = new System.Drawing.Size(176, 29);
			this.vT2_W.TabIndex = 14;
			this.vT2_W.Value = new System.Decimal(new int[] {
																400,
																0,
																0,
																0});
			// 
			// vT2_H
			// 
			this.vT2_H.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT2_H.Location = new System.Drawing.Point(64, 104);
			this.vT2_H.Name = "vT2_H";
			this.vT2_H.Size = new System.Drawing.Size(176, 29);
			this.vT2_H.TabIndex = 13;
			this.vT2_H.Value = new System.Decimal(new int[] {
																20,
																0,
																0,
																0});
			// 
			// vT2_X
			// 
			this.vT2_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT2_X.Location = new System.Drawing.Point(64, 64);
			this.vT2_X.Maximum = new System.Decimal(new int[] {
																  1000,
																  0,
																  0,
																  0});
			this.vT2_X.Name = "vT2_X";
			this.vT2_X.Size = new System.Drawing.Size(72, 29);
			this.vT2_X.TabIndex = 12;
			// 
			// vT2_Count
			// 
			this.vT2_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT2_Count.Location = new System.Drawing.Point(24, 176);
			this.vT2_Count.Name = "vT2_Count";
			this.vT2_Count.Size = new System.Drawing.Size(88, 29);
			this.vT2_Count.TabIndex = 11;
			this.vT2_Count.Value = new System.Decimal(new int[] {
																	7,
																	0,
																	0,
																	0});
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(24, 152);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(216, 23);
			this.label7.TabIndex = 5;
			this.label7.Text = "Количество отверстий";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(24, 64);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(24, 23);
			this.label6.TabIndex = 4;
			this.label6.Text = "X";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(24, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 23);
			this.label5.TabIndex = 3;
			this.label5.Text = "H";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(24, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "W";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(280, 40);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(392, 104);
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.vT3_t4);
			this.tabPage3.Controls.Add(this.vT3_t3);
			this.tabPage3.Controls.Add(this.vT3_t1);
			this.tabPage3.Controls.Add(this.vT3_Depth);
			this.tabPage3.Controls.Add(this.label11);
			this.tabPage3.Controls.Add(this.vT3_Count);
			this.tabPage3.Controls.Add(this.label13);
			this.tabPage3.Controls.Add(this.vT3_noX);
			this.tabPage3.Controls.Add(this.vT3_X);
			this.tabPage3.Controls.Add(this.label12);
			this.tabPage3.Controls.Add(this.vT3_W);
			this.tabPage3.Controls.Add(this.label10);
			this.tabPage3.Controls.Add(this.label9);
			this.tabPage3.Controls.Add(this.vT3_L);
			this.tabPage3.Controls.Add(this.pictureBox3);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(678, 434);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Присадка фронтальная";
			// 
			// vT3_t4
			// 
			this.vT3_t4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT3_t4.Location = new System.Drawing.Point(288, 312);
			this.vT3_t4.Name = "vT3_t4";
			this.vT3_t4.Size = new System.Drawing.Size(400, 24);
			this.vT3_t4.TabIndex = 26;
			this.vT3_t4.Text = "только 2 под стяжки (меньший диаметр)";
			// 
			// vT3_t3
			// 
			this.vT3_t3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT3_t3.Location = new System.Drawing.Point(288, 280);
			this.vT3_t3.Name = "vT3_t3";
			this.vT3_t3.Size = new System.Drawing.Size(312, 24);
			this.vT3_t3.TabIndex = 25;
			this.vT3_t3.Text = "2 под стяжки пропустить";
			// 
			// vT3_t1
			// 
			this.vT3_t1.Checked = true;
			this.vT3_t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT3_t1.Location = new System.Drawing.Point(288, 248);
			this.vT3_t1.Name = "vT3_t1";
			this.vT3_t1.Size = new System.Drawing.Size(224, 32);
			this.vT3_t1.TabIndex = 24;
			this.vT3_t1.TabStop = true;
			this.vT3_t1.Text = "Все одинаковые";
			// 
			// vT3_Depth
			// 
			this.vT3_Depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT3_Depth.Location = new System.Drawing.Point(24, 280);
			this.vT3_Depth.Name = "vT3_Depth";
			this.vT3_Depth.Size = new System.Drawing.Size(96, 29);
			this.vT3_Depth.TabIndex = 23;
			this.vT3_Depth.Value = new System.Decimal(new int[] {
																	16,
																	0,
																	0,
																	0});
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(24, 256);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(216, 23);
			this.label11.TabIndex = 22;
			this.label11.Text = "Глубина отверстий";
			// 
			// vT3_Count
			// 
			this.vT3_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT3_Count.Location = new System.Drawing.Point(24, 208);
			this.vT3_Count.Name = "vT3_Count";
			this.vT3_Count.Size = new System.Drawing.Size(96, 29);
			this.vT3_Count.TabIndex = 21;
			this.vT3_Count.Value = new System.Decimal(new int[] {
																	7,
																	0,
																	0,
																	0});
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.Location = new System.Drawing.Point(24, 184);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(216, 23);
			this.label13.TabIndex = 20;
			this.label13.Text = "Количество отверстий";
			// 
			// vT3_noX
			// 
			this.vT3_noX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT3_noX.Location = new System.Drawing.Point(152, 152);
			this.vT3_noX.Name = "vT3_noX";
			this.vT3_noX.Size = new System.Drawing.Size(152, 24);
			this.vT3_noX.TabIndex = 19;
			this.vT3_noX.Text = "отступить X";
			// 
			// vT3_X
			// 
			this.vT3_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT3_X.Location = new System.Drawing.Point(72, 152);
			this.vT3_X.Maximum = new System.Decimal(new int[] {
																  1000,
																  0,
																  0,
																  0});
			this.vT3_X.Name = "vT3_X";
			this.vT3_X.Size = new System.Drawing.Size(72, 29);
			this.vT3_X.TabIndex = 18;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.Location = new System.Drawing.Point(32, 152);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(24, 23);
			this.label12.TabIndex = 17;
			this.label12.Text = "X";
			// 
			// vT3_W
			// 
			this.vT3_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT3_W.Location = new System.Drawing.Point(72, 112);
			this.vT3_W.Maximum = new System.Decimal(new int[] {
																  1000,
																  0,
																  0,
																  0});
			this.vT3_W.Name = "vT3_W";
			this.vT3_W.Size = new System.Drawing.Size(104, 29);
			this.vT3_W.TabIndex = 15;
			this.vT3_W.Value = new System.Decimal(new int[] {
																400,
																0,
																0,
																0});
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(32, 112);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(32, 23);
			this.label10.TabIndex = 4;
			this.label10.Text = "W";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 23);
			this.label9.TabIndex = 3;
			this.label9.Text = "L1,2..";
			// 
			// vT3_L
			// 
			this.vT3_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT3_L.Location = new System.Drawing.Point(72, 16);
			this.vT3_L.Multiline = true;
			this.vT3_L.Name = "vT3_L";
			this.vT3_L.Size = new System.Drawing.Size(100, 88);
			this.vT3_L.TabIndex = 1;
			this.vT3_L.Text = "";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(280, 8);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(408, 240);
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.vT4_Depth);
			this.tabPage4.Controls.Add(this.label15);
			this.tabPage4.Controls.Add(this.vT4_D);
			this.tabPage4.Controls.Add(this.label14);
			this.tabPage4.Controls.Add(this.vT4_FileName);
			this.tabPage4.Controls.Add(this.button1);
			this.tabPage4.Controls.Add(this.pictureBox4);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(678, 434);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Токарная обработка";
			// 
			// vT4_Depth
			// 
			this.vT4_Depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT4_Depth.Location = new System.Drawing.Point(56, 168);
			this.vT4_Depth.Maximum = new System.Decimal(new int[] {
																	  500,
																	  0,
																	  0,
																	  0});
			this.vT4_Depth.Name = "vT4_Depth";
			this.vT4_Depth.Size = new System.Drawing.Size(104, 29);
			this.vT4_Depth.TabIndex = 18;
			this.vT4_Depth.Value = new System.Decimal(new int[] {
																	10,
																	0,
																	0,
																	0});
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.Location = new System.Drawing.Point(24, 136);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(328, 23);
			this.label15.TabIndex = 17;
			this.label15.Text = "Максимальная глубина за проход";
			// 
			// vT4_D
			// 
			this.vT4_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT4_D.Location = new System.Drawing.Point(56, 88);
			this.vT4_D.Maximum = new System.Decimal(new int[] {
																  500,
																  0,
																  0,
																  0});
			this.vT4_D.Name = "vT4_D";
			this.vT4_D.Size = new System.Drawing.Size(104, 29);
			this.vT4_D.TabIndex = 16;
			this.vT4_D.Value = new System.Decimal(new int[] {
																40,
																0,
																0,
																0});
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.Location = new System.Drawing.Point(24, 88);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(24, 23);
			this.label14.TabIndex = 3;
			this.label14.Text = "D";
			// 
			// vT4_FileName
			// 
			this.vT4_FileName.Location = new System.Drawing.Point(232, 24);
			this.vT4_FileName.Name = "vT4_FileName";
			this.vT4_FileName.Size = new System.Drawing.Size(432, 23);
			this.vT4_FileName.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(24, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(184, 40);
			this.button1.TabIndex = 1;
			this.button1.Text = "Загрузить файл...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(360, 72);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(304, 208);
			this.pictureBox4.TabIndex = 0;
			this.pictureBox4.TabStop = false;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.panel2);
			this.tabPage5.Controls.Add(this.codeLog);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(678, 434);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Code";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btRun);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 290);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(678, 144);
			this.panel2.TabIndex = 1;
			// 
			// btRun
			// 
			this.btRun.Location = new System.Drawing.Point(16, 8);
			this.btRun.Name = "btRun";
			this.btRun.TabIndex = 0;
			this.btRun.Text = "Run code";
			this.btRun.Click += new System.EventHandler(this.btRun_Click);
			// 
			// codeLog
			// 
			this.codeLog.BackColor = System.Drawing.SystemColors.Window;
			this.codeLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.codeLog.Location = new System.Drawing.Point(0, 0);
			this.codeLog.Multiline = true;
			this.codeLog.Name = "codeLog";
			this.codeLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.codeLog.Size = new System.Drawing.Size(678, 434);
			this.codeLog.TabIndex = 0;
			this.codeLog.Text = "";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btZ0);
			this.panel1.Controls.Add(this.btY0);
			this.panel1.Controls.Add(this.btX0);
			this.panel1.Controls.Add(this.btReset);
			this.panel1.Controls.Add(this.btStop);
			this.panel1.Controls.Add(this.btStart);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(5, 361);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(686, 104);
			this.panel1.TabIndex = 5;
			// 
			// btZ0
			// 
			this.btZ0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btZ0.Location = new System.Drawing.Point(470, 64);
			this.btZ0.Name = "btZ0";
			this.btZ0.TabIndex = 5;
			this.btZ0.Text = "Z0";
			this.btZ0.Click += new System.EventHandler(this.btZ0_Click);
			// 
			// btY0
			// 
			this.btY0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btY0.Location = new System.Drawing.Point(470, 40);
			this.btY0.Name = "btY0";
			this.btY0.TabIndex = 4;
			this.btY0.Text = "Y0";
			this.btY0.Click += new System.EventHandler(this.btY0_Click);
			// 
			// btX0
			// 
			this.btX0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btX0.Location = new System.Drawing.Point(470, 16);
			this.btX0.Name = "btX0";
			this.btX0.TabIndex = 3;
			this.btX0.Text = "X0";
			this.btX0.Click += new System.EventHandler(this.btX0_Click);
			// 
			// btReset
			// 
			this.btReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btReset.Location = new System.Drawing.Point(566, 16);
			this.btReset.Name = "btReset";
			this.btReset.Size = new System.Drawing.Size(104, 72);
			this.btReset.TabIndex = 2;
			this.btReset.Text = "RESET";
			this.btReset.Click += new System.EventHandler(this.btReset_Click);
			// 
			// btStop
			// 
			this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btStop.Location = new System.Drawing.Point(176, 16);
			this.btStop.Name = "btStop";
			this.btStop.Size = new System.Drawing.Size(144, 72);
			this.btStop.TabIndex = 1;
			this.btStop.Text = "STOP";
			this.btStop.Click += new System.EventHandler(this.btStop_Click);
			// 
			// btStart
			// 
			this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btStart.Location = new System.Drawing.Point(16, 16);
			this.btStart.Name = "btStart";
			this.btStart.Size = new System.Drawing.Size(144, 72);
			this.btStart.TabIndex = 0;
			this.btStart.Text = "START";
			this.btStart.Click += new System.EventHandler(this.btStart_Click_1);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "G-Code(*.ngc)|*.ngc|Text files(*.txt)|*.txt|All files(*.*)|*.*";
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.label26);
			this.tabPage6.Controls.Add(this.label25);
			this.tabPage6.Controls.Add(this.label24);
			this.tabPage6.Controls.Add(this.label23);
			this.tabPage6.Controls.Add(this.label22);
			this.tabPage6.Controls.Add(this.label21);
			this.tabPage6.Controls.Add(this.label20);
			this.tabPage6.Controls.Add(this.label19);
			this.tabPage6.Controls.Add(this.vT5_Depth);
			this.tabPage6.Controls.Add(this.label18);
			this.tabPage6.Controls.Add(this.vT5_Data);
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(678, 434);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "Сверление";
			// 
			// vT5_Data
			// 
			this.vT5_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT5_Data.Location = new System.Drawing.Point(8, 8);
			this.vT5_Data.Multiline = true;
			this.vT5_Data.Name = "vT5_Data";
			this.vT5_Data.Size = new System.Drawing.Size(224, 248);
			this.vT5_Data.TabIndex = 0;
			this.vT5_Data.Text = "";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label18.Location = new System.Drawing.Point(16, 272);
			this.label18.Name = "label18";
			this.label18.TabIndex = 1;
			this.label18.Text = "Глубина";
			// 
			// vT5_Depth
			// 
			this.vT5_Depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT5_Depth.Location = new System.Drawing.Point(104, 272);
			this.vT5_Depth.Name = "vT5_Depth";
			this.vT5_Depth.Size = new System.Drawing.Size(128, 29);
			this.vT5_Depth.TabIndex = 2;
			this.vT5_Depth.Text = "";
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label19.Location = new System.Drawing.Point(240, 16);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(152, 23);
			this.label19.TabIndex = 3;
			this.label19.Text = "Формат строки";
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label20.Location = new System.Drawing.Point(240, 48);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(424, 48);
			this.label20.TabIndex = 4;
			this.label20.Text = "<X> <Y> [L<количество> I<сдвиг по X> J<сдвиг по Y> D<глубина>]";
			// 
			// label21
			// 
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label21.Location = new System.Drawing.Point(240, 96);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(152, 23);
			this.label21.TabIndex = 5;
			this.label21.Text = "Примеры";
			// 
			// label22
			// 
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label22.Location = new System.Drawing.Point(240, 128);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(424, 24);
			this.label22.TabIndex = 6;
			this.label22.Text = "Два отверстия общей глубины";
			
			// 
			// label23
			// 
			this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label23.Location = new System.Drawing.Point(248, 160);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(80, 48);
			this.label23.TabIndex = 7;
			this.label23.Text = "200 10   300 10";
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label24.Location = new System.Drawing.Point(240, 208);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(424, 56);
			this.label24.TabIndex = 8;
			this.label24.Text = "Одно отверстие Х200 и У10 общей глубины и 5 отверстий  вдоль оси Y глубиной 15 и " +
				"расстоянием между ними 30";
			// 
			// label25
			// 
			this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label25.Location = new System.Drawing.Point(256, 272);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(80, 16);
			this.label25.TabIndex = 9;
			this.label25.Text = "200 10 ";
			// 
			// label26
			// 
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label26.Location = new System.Drawing.Point(256, 296);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(384, 16);
			this.label26.TabIndex = 10;
			this.label26.Text = "300 10 L5 J30 D15 ";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(696, 470);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tabControl1);
			this.DockPadding.All = 5;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CNC";
			this.TopMost = true;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vT1_S)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vT1_Podrez)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vT1_H)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vT11_W)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vT11_L)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vT2_t2Depth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vT2_Depth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vT2_W)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vT2_H)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vT2_X)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vT2_Count)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vT3_Depth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vT3_Count)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vT3_X)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vT3_W)).EndInit();
			this.tabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vT4_Depth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vT4_D)).EndInit();
			this.tabPage5.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tabPage6.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void RunCode(string[] code) 
		{
			_mInst.DoOEMButton(169);
			using (StreamWriter outputFile = new StreamWriter("C:\\tmp\\gcode.txt"))
			{
				codeLog.Clear();
				foreach (string line in code) 
				{
					codeLog.AppendText(line + "\r\n");
					outputFile.WriteLine(line);
				}
			}			
			_mInst.LoadFile("C:\\tmp\\gcode.txt");
			System.Threading.Thread.Sleep(2000); // pause for the file loading
			_mInst.DoOEMButton(1000);
		}

		private void RunTestCode(string[] code) 
		{
			GetMachInstance();
			if(_mInst != null) 
			{
				foreach (string line in code) 
				{
					if(line != "") 
					{					    
						_mInst.Code(line);						
					}
				}
			}
		}
		
		private void DoCutting() 
		{	      
      
			RunCode(Cutting.getGCode(
				vT11_L.Value, 
				vT11_W.Value, 
				vT1_H.Value, 
				vT1_2.Checked, 
				vT1_DirectW.Checked, 
				vT1_Podrez.Value,
				vT1_S.Value
			));
    	}

		private void DoAdditiveButt()
		{
			int t = 1;

			if(vT2_t2.Checked) t = 2;
			else if(vT2_t3.Checked) t = 3; 
			else if(vT2_t4.Checked) t = 4;

			RunCode(AdditiveButt.getGCode(
				vT2_W.Value,
				vT2_X.Value,
				vT2_noX.Checked,
				vT2_H.Value,
				vT2_Count.Value,
				vT2_Depth.Value,
				t,
				vT2_t2Depth.Value
			));
		}

		private void DoAdditiveFront()
		{
			int t = 1;

			if(vT3_t3.Checked) t = 3; 
			else if(vT3_t4.Checked) t = 4;

			RunCode(AdditiveFront.getGCode(
				vT3_L.Lines,
				vT3_W.Value,
				vT3_X.Value,
				vT3_noX.Checked,				
				vT3_Count.Value,
				vT3_Depth.Value,
				t
			));
		}

		private void DoHoles()
		{
			
			RunCode(Holes.getGCode(
				vT5_Data.Lines,
				vT5_Depth.Text
			));
		}

		private void DoTurning()
		{
			if(vT4_FileName.Text == "")
				return;
			
			ArrayList code = new ArrayList();            
			StreamReader ReadFile = File.OpenText(vT4_FileName.Text);
			string Input = null;
			while ((Input = ReadFile.ReadLine()) != null) 
			{
				code.Add(Input);
			} 
			RunCode(Turning.getGCode(
				code.ToArray(typeof(string)) as string[],
				vT4_D.Value,
				vT4_Depth.Value
			));			
		}

		private void ClickButton(short code)
		{
			GetMachInstance();
			if(_mInst != null) 
			{
				_mInst.DoOEMButton(code);
			}
		}

		private void btStop_Click(object sender, System.EventArgs e)
		{
			StopWork();
			btStart.Focus();
		}

		private void StopWork()
		{
			ClickButton(1003);		
		}

		private void StartWork()
		{
			GetMachInstance();
			if(_mInst != null) 
			{
				//Console.WriteLine(tabControl1.SelectedIndex);
				switch(tabControl1.SelectedIndex) 
				{
					case 0: DoCutting();break;
					case 1: DoAdditiveButt();break;
					case 2: DoAdditiveFront();break; 
					case 3: DoTurning();break;
					case 4: DoHoles();break;
				}				
			}
		}



		private void btStart_Click_1(object sender, System.EventArgs e)
		{
			StartWork();
		}


		private void rdDirectL_CheckedChanged(object sender, System.EventArgs e)
		{
			imCutType2.Visible = vT1_DirectL.Checked;
		}


		private void vT1_2_CheckedChanged(object sender, System.EventArgs e)
		{
			vT1_Podrez.Enabled = vT1_2.Checked;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
				return;

			vT4_FileName.Text = openFileDialog1.FileName;
			btStart.Focus();
		}

		private void btRun_Click(object sender, System.EventArgs e)
		{
			RunTestCode(codeLog.Lines);
		}

		private void btX0_Click(object sender, System.EventArgs e)
		{
			ClickButton(1008);
			btStart.Focus();
		}

		private void btY0_Click(object sender, System.EventArgs e)
		{
			ClickButton(1009);
			btStart.Focus();
		}

		private void btZ0_Click(object sender, System.EventArgs e)
		{
			ClickButton(1010);
			btStart.Focus();
		}

		private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
				StartWork();
			else
			if(e.KeyCode == Keys.Escape)
				StopWork();
			
		}

		private void btReset_Click(object sender, System.EventArgs e)
		{
			ClickButton(1021);	
			btStart.Focus();
		}

		private void btResetX_Click(object sender, System.EventArgs e)
		{
			GetMachInstance();
			if(_mInst != null) 
			{
				//RunCode(new string[] {;
				_mInst.Code("G92 X0 Y0 Z0");
				System.Threading.Thread.Sleep(1000);
				_mInst.Code("G00 X-986");
				_mInst.Code("G92 X0 Y0 Z0");
			}
		}

		
	}
}

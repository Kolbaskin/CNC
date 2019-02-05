using System;
using System.Runtime.InteropServices;

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
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown numericUpDown7;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.NumericUpDown numericUpDown9;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown numericUpDown8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.NumericUpDown numericUpDown10;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton7;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lbTokarFile;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.NumericUpDown numericUpDown11;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.NumericUpDown numericUpDown12;
		private System.Windows.Forms.NumericUpDown vT1_H;
		private System.Windows.Forms.NumericUpDown vT1_W;
		private System.Windows.Forms.NumericUpDown vT1_L;
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
			this.imCutType2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.vT1_H = new System.Windows.Forms.NumericUpDown();
			this.vT1_W = new System.Windows.Forms.NumericUpDown();
			this.vT1_L = new System.Windows.Forms.NumericUpDown();
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
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.radioButton7 = new System.Windows.Forms.RadioButton();
			this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
			this.label13 = new System.Windows.Forms.Label();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
			this.label12 = new System.Windows.Forms.Label();
			this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
			this.label15 = new System.Windows.Forms.Label();
			this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.lbTokarFile = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btStop = new System.Windows.Forms.Button();
			this.btStart = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.label16 = new System.Windows.Forms.Label();
			this.vT1_Podrez = new System.Windows.Forms.NumericUpDown();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vT1_H)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vT1_W)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vT1_L)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vT2_t2Depth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vT2_Depth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vT2_W)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vT2_H)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vT2_X)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vT2_Count)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vT1_Podrez)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(696, 470);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.vT1_Podrez);
			this.tabPage1.Controls.Add(this.label16);
			this.tabPage1.Controls.Add(this.imCutType2);
			this.tabPage1.Controls.Add(this.pictureBox1);
			this.tabPage1.Controls.Add(this.vT1_H);
			this.tabPage1.Controls.Add(this.vT1_W);
			this.tabPage1.Controls.Add(this.vT1_L);
			this.tabPage1.Controls.Add(this.vT1_DirectL);
			this.tabPage1.Controls.Add(this.vT1_DirectW);
			this.tabPage1.Controls.Add(this.vT1_2);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(688, 444);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Раскрой";
			// 
			// imCutType2
			// 
			this.imCutType2.Image = ((System.Drawing.Image)(resources.GetObject("imCutType2.Image")));
			this.imCutType2.Location = new System.Drawing.Point(256, 24);
			this.imCutType2.Name = "imCutType2";
			this.imCutType2.Size = new System.Drawing.Size(416, 272);
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
			// vT1_W
			// 
			this.vT1_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT1_W.Location = new System.Drawing.Point(64, 64);
			this.vT1_W.Name = "vT1_W";
			this.vT1_W.Size = new System.Drawing.Size(176, 29);
			this.vT1_W.TabIndex = 9;
			// 
			// vT1_L
			// 
			this.vT1_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT1_L.Location = new System.Drawing.Point(64, 24);
			this.vT1_L.Name = "vT1_L";
			this.vT1_L.Size = new System.Drawing.Size(176, 29);
			this.vT1_L.TabIndex = 8;
			// 
			// vT1_DirectL
			// 
			this.vT1_DirectL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT1_DirectL.Location = new System.Drawing.Point(48, 184);
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
			this.vT1_DirectW.Location = new System.Drawing.Point(48, 152);
			this.vT1_DirectW.Name = "vT1_DirectW";
			this.vT1_DirectW.Size = new System.Drawing.Size(152, 24);
			this.vT1_DirectW.TabIndex = 5;
			this.vT1_DirectW.TabStop = true;
			this.vT1_DirectW.Text = "рез поперек";
			// 
			// vT1_2
			// 
			this.vT1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT1_2.Location = new System.Drawing.Point(48, 224);
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
			this.label2.Click += new System.EventHandler(this.label2_Click);
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
			this.tabPage2.Size = new System.Drawing.Size(688, 444);
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
																  500,
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
			this.vT2_W.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
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
			this.tabPage3.Controls.Add(this.radioButton5);
			this.tabPage3.Controls.Add(this.radioButton6);
			this.tabPage3.Controls.Add(this.radioButton7);
			this.tabPage3.Controls.Add(this.numericUpDown8);
			this.tabPage3.Controls.Add(this.label11);
			this.tabPage3.Controls.Add(this.numericUpDown10);
			this.tabPage3.Controls.Add(this.label13);
			this.tabPage3.Controls.Add(this.checkBox3);
			this.tabPage3.Controls.Add(this.numericUpDown9);
			this.tabPage3.Controls.Add(this.label12);
			this.tabPage3.Controls.Add(this.numericUpDown7);
			this.tabPage3.Controls.Add(this.label10);
			this.tabPage3.Controls.Add(this.label9);
			this.tabPage3.Controls.Add(this.textBox1);
			this.tabPage3.Controls.Add(this.pictureBox3);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(688, 444);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Присадка фронтальная";
			// 
			// radioButton5
			// 
			this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton5.Location = new System.Drawing.Point(288, 312);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(400, 24);
			this.radioButton5.TabIndex = 26;
			this.radioButton5.Text = "только 2 под стяжки (меньший диаметр)";
			// 
			// radioButton6
			// 
			this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton6.Location = new System.Drawing.Point(288, 280);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(312, 24);
			this.radioButton6.TabIndex = 25;
			this.radioButton6.Text = "2 под стяжки пропустить";
			// 
			// radioButton7
			// 
			this.radioButton7.Checked = true;
			this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton7.Location = new System.Drawing.Point(288, 248);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.Size = new System.Drawing.Size(224, 32);
			this.radioButton7.TabIndex = 24;
			this.radioButton7.TabStop = true;
			this.radioButton7.Text = "Все одинаковые";
			// 
			// numericUpDown8
			// 
			this.numericUpDown8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.numericUpDown8.Location = new System.Drawing.Point(24, 280);
			this.numericUpDown8.Name = "numericUpDown8";
			this.numericUpDown8.Size = new System.Drawing.Size(96, 29);
			this.numericUpDown8.TabIndex = 23;
			this.numericUpDown8.Value = new System.Decimal(new int[] {
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
			// numericUpDown10
			// 
			this.numericUpDown10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.numericUpDown10.Location = new System.Drawing.Point(24, 208);
			this.numericUpDown10.Name = "numericUpDown10";
			this.numericUpDown10.Size = new System.Drawing.Size(96, 29);
			this.numericUpDown10.TabIndex = 21;
			this.numericUpDown10.Value = new System.Decimal(new int[] {
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
			// checkBox3
			// 
			this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox3.Location = new System.Drawing.Point(152, 152);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(152, 24);
			this.checkBox3.TabIndex = 19;
			this.checkBox3.Text = "отступить X";
			// 
			// numericUpDown9
			// 
			this.numericUpDown9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.numericUpDown9.Location = new System.Drawing.Point(72, 152);
			this.numericUpDown9.Name = "numericUpDown9";
			this.numericUpDown9.Size = new System.Drawing.Size(72, 29);
			this.numericUpDown9.TabIndex = 18;
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
			// numericUpDown7
			// 
			this.numericUpDown7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.numericUpDown7.Location = new System.Drawing.Point(72, 112);
			this.numericUpDown7.Maximum = new System.Decimal(new int[] {
																		   500,
																		   0,
																		   0,
																		   0});
			this.numericUpDown7.Name = "numericUpDown7";
			this.numericUpDown7.Size = new System.Drawing.Size(104, 29);
			this.numericUpDown7.TabIndex = 15;
			this.numericUpDown7.Value = new System.Decimal(new int[] {
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
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(72, 16);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 88);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
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
			this.tabPage4.Controls.Add(this.numericUpDown12);
			this.tabPage4.Controls.Add(this.label15);
			this.tabPage4.Controls.Add(this.numericUpDown11);
			this.tabPage4.Controls.Add(this.label14);
			this.tabPage4.Controls.Add(this.lbTokarFile);
			this.tabPage4.Controls.Add(this.button1);
			this.tabPage4.Controls.Add(this.pictureBox4);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(688, 444);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Токарная обработка";
			// 
			// numericUpDown12
			// 
			this.numericUpDown12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.numericUpDown12.Location = new System.Drawing.Point(24, 160);
			this.numericUpDown12.Maximum = new System.Decimal(new int[] {
																			500,
																			0,
																			0,
																			0});
			this.numericUpDown12.Name = "numericUpDown12";
			this.numericUpDown12.Size = new System.Drawing.Size(104, 29);
			this.numericUpDown12.TabIndex = 18;
			this.numericUpDown12.Value = new System.Decimal(new int[] {
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
			// numericUpDown11
			// 
			this.numericUpDown11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.numericUpDown11.Location = new System.Drawing.Point(56, 88);
			this.numericUpDown11.Maximum = new System.Decimal(new int[] {
																			500,
																			0,
																			0,
																			0});
			this.numericUpDown11.Name = "numericUpDown11";
			this.numericUpDown11.Size = new System.Drawing.Size(104, 29);
			this.numericUpDown11.TabIndex = 16;
			this.numericUpDown11.Value = new System.Decimal(new int[] {
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
			// lbTokarFile
			// 
			this.lbTokarFile.Location = new System.Drawing.Point(232, 24);
			this.lbTokarFile.Name = "lbTokarFile";
			this.lbTokarFile.Size = new System.Drawing.Size(432, 23);
			this.lbTokarFile.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(24, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(184, 40);
			this.button1.TabIndex = 1;
			this.button1.Text = "Загрузить файл...";
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
			// panel1
			// 
			this.panel1.Controls.Add(this.btStop);
			this.panel1.Controls.Add(this.btStart);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 366);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(696, 104);
			this.panel1.TabIndex = 5;
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
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label16.Location = new System.Drawing.Point(16, 264);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(168, 23);
			this.label16.TabIndex = 13;
			this.label16.Text = "Глубина подреза";
			// 
			// vT1_Podrez
			// 
			this.vT1_Podrez.Enabled = false;
			this.vT1_Podrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vT1_Podrez.Location = new System.Drawing.Point(192, 264);
			this.vT1_Podrez.Name = "vT1_Podrez";
			this.vT1_Podrez.Size = new System.Drawing.Size(96, 29);
			this.vT1_Podrez.TabIndex = 14;
			this.vT1_Podrez.Value = new System.Decimal(new int[] {
																	 4,
																	 0,
																	 0,
																	 0});
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(696, 470);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "CNC";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vT1_H)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vT1_W)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vT1_L)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vT2_t2Depth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vT2_Depth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vT2_W)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vT2_H)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vT2_X)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vT2_Count)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
			this.tabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vT1_Podrez)).EndInit();
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
			foreach (string line in code) 
			{
				if(line != "")
					_mInst.Code(line);
			}
		}
		
		private void DoCutting() 
		{	
			RunCode(Cutting.getGCode(
				vT1_L.Value, 
				vT1_W.Value, 
				vT1_H.Value, 
				vT1_2.Checked, 
				vT1_DirectW.Checked, 
				vT1_Podrez.Value
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

		}

		private void DoTurning()
		{

		}


		private void btStop_Click(object sender, System.EventArgs e)
		{
			GetMachInstance();
			if(_mInst != null) 
			{
				_mInst.DoOEMButton(1003);
			}
		}

		private void btStart_Click_1(object sender, System.EventArgs e)
		{
			GetMachInstance();
			if(_mInst != null) 
			{
				Console.WriteLine(tabControl1.SelectedIndex);
				switch(tabControl1.SelectedIndex) 
				{
					case 0: DoCutting();break;
                    case 1: DoAdditiveButt();break;
                    case 2: DoAdditiveFront();break; 
					case 3: DoTurning();break;
				}
				
				
			}
		}

		private void label2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void rdDirectL_CheckedChanged(object sender, System.EventArgs e)
		{
			imCutType2.Visible = vT1_DirectL.Checked;
			
			//  (rdDirectL.Checked) 

		}

		private void numericUpDown4_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void vT1_2_CheckedChanged(object sender, System.EventArgs e)
		{
			vT1_Podrez.Enabled = vT1_2.Checked;
		}
	}
}

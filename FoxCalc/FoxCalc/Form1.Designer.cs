﻿namespace FoxCalc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainCalc = new System.Windows.Forms.TabPage();
            this.dec = new System.Windows.Forms.RadioButton();
            this.hex = new System.Windows.Forms.RadioButton();
            this.oct = new System.Windows.Forms.RadioButton();
            this.bin = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.sign = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ctg = new System.Windows.Forms.Button();
            this.tang = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.n9 = new System.Windows.Forms.Button();
            this.segment = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.box1 = new System.Windows.Forms.TextBox();
            this.StrokeCalc = new System.Windows.Forms.TabPage();
            this.reset = new System.Windows.Forms.Button();
            this.labelresult = new System.Windows.Forms.Label();
            this.cb7 = new System.Windows.Forms.CheckBox();
            this.cb6 = new System.Windows.Forms.CheckBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.stats = new System.Windows.Forms.CheckBox();
            this.lower = new System.Windows.Forms.CheckBox();
            this.upper = new System.Windows.Forms.CheckBox();
            this.strokelength = new System.Windows.Forms.CheckBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.ConvertCalc = new System.Windows.Forms.TabPage();
            this.ConvEqual = new System.Windows.Forms.Button();
            this.OutputPrice = new System.Windows.Forms.TextBox();
            this.FINPriceFuel = new System.Windows.Forms.Label();
            this.intakeLabel = new System.Windows.Forms.Label();
            this.UselessIntakeLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.UselessPriceFuel = new System.Windows.Forms.Label();
            this.ULVehlabel = new System.Windows.Forms.Label();
            this.ULFuelLabel = new System.Windows.Forms.Label();
            this.VehiclesBox = new System.Windows.Forms.ListBox();
            this.FuelBox = new System.Windows.Forms.ListBox();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.ClearButConv = new System.Windows.Forms.Button();
            this.inputDistance = new System.Windows.Forms.TextBox();
            this.bInputFile = new System.Windows.Forms.Button();
            this.bOutputFile = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.MainCalc.SuspendLayout();
            this.StrokeCalc.SuspendLayout();
            this.ConvertCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.MainCalc);
            this.tabControl1.Controls.Add(this.StrokeCalc);
            this.tabControl1.Controls.Add(this.ConvertCalc);
            this.tabControl1.Font = new System.Drawing.Font("Solomon Sans Normal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(462, 470);
            this.tabControl1.TabIndex = 29;
            // 
            // MainCalc
            // 
            this.MainCalc.BackColor = System.Drawing.Color.Transparent;
            this.MainCalc.BackgroundImage = global::FoxCalc.Properties.Resources.foxcalc10;
            this.MainCalc.Controls.Add(this.dec);
            this.MainCalc.Controls.Add(this.hex);
            this.MainCalc.Controls.Add(this.oct);
            this.MainCalc.Controls.Add(this.bin);
            this.MainCalc.Controls.Add(this.label3);
            this.MainCalc.Controls.Add(this.sign);
            this.MainCalc.Controls.Add(this.sqrt);
            this.MainCalc.Controls.Add(this.exp);
            this.MainCalc.Controls.Add(this.square);
            this.MainCalc.Controls.Add(this.button4);
            this.MainCalc.Controls.Add(this.ctg);
            this.MainCalc.Controls.Add(this.tang);
            this.MainCalc.Controls.Add(this.cos);
            this.MainCalc.Controls.Add(this.sin);
            this.MainCalc.Controls.Add(this.label2);
            this.MainCalc.Controls.Add(this.label1);
            this.MainCalc.Controls.Add(this.n9);
            this.MainCalc.Controls.Add(this.segment);
            this.MainCalc.Controls.Add(this.equal);
            this.MainCalc.Controls.Add(this.n0);
            this.MainCalc.Controls.Add(this.clear);
            this.MainCalc.Controls.Add(this.multiply);
            this.MainCalc.Controls.Add(this.n3);
            this.MainCalc.Controls.Add(this.n2);
            this.MainCalc.Controls.Add(this.n1);
            this.MainCalc.Controls.Add(this.minus);
            this.MainCalc.Controls.Add(this.n6);
            this.MainCalc.Controls.Add(this.n5);
            this.MainCalc.Controls.Add(this.n4);
            this.MainCalc.Controls.Add(this.plus);
            this.MainCalc.Controls.Add(this.n8);
            this.MainCalc.Controls.Add(this.n7);
            this.MainCalc.Controls.Add(this.box1);
            this.MainCalc.Location = new System.Drawing.Point(4, 30);
            this.MainCalc.Name = "MainCalc";
            this.MainCalc.Padding = new System.Windows.Forms.Padding(3);
            this.MainCalc.Size = new System.Drawing.Size(454, 436);
            this.MainCalc.TabIndex = 0;
            this.MainCalc.Text = "Основной";
            // 
            // dec
            // 
            this.dec.AutoSize = true;
            this.dec.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dec.Font = new System.Drawing.Font("Code Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dec.Location = new System.Drawing.Point(384, 58);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(58, 42);
            this.dec.TabIndex = 61;
            this.dec.Text = "dec";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.CheckedChanged += new System.EventHandler(this.Dec_CheckedChanged);
            // 
            // hex
            // 
            this.hex.AutoSize = true;
            this.hex.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hex.Font = new System.Drawing.Font("Code Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hex.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hex.Location = new System.Drawing.Point(386, 374);
            this.hex.Name = "hex";
            this.hex.Size = new System.Drawing.Size(54, 42);
            this.hex.TabIndex = 60;
            this.hex.Text = "hex";
            this.hex.UseVisualStyleBackColor = true;
            this.hex.CheckedChanged += new System.EventHandler(this.Hex_CheckedChanged);
            // 
            // oct
            // 
            this.oct.AutoSize = true;
            this.oct.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.oct.Font = new System.Drawing.Font("Code Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.oct.Location = new System.Drawing.Point(383, 270);
            this.oct.Name = "oct";
            this.oct.Size = new System.Drawing.Size(60, 42);
            this.oct.TabIndex = 59;
            this.oct.Text = "oct";
            this.oct.UseVisualStyleBackColor = true;
            this.oct.CheckedChanged += new System.EventHandler(this.Oct_CheckedChanged);
            // 
            // bin
            // 
            this.bin.AutoSize = true;
            this.bin.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bin.Font = new System.Drawing.Font("Code Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bin.Location = new System.Drawing.Point(387, 163);
            this.bin.Name = "bin";
            this.bin.Size = new System.Drawing.Size(51, 42);
            this.bin.TabIndex = 58;
            this.bin.Text = "bin";
            this.bin.UseVisualStyleBackColor = true;
            this.bin.CheckedChanged += new System.EventHandler(this.Bin_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(20, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 57;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.Color.Transparent;
            this.sign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sign.FlatAppearance.BorderSize = 0;
            this.sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign.Font = new System.Drawing.Font("Code Pro", 16F);
            this.sign.ForeColor = System.Drawing.Color.Transparent;
            this.sign.Location = new System.Drawing.Point(322, 164);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(55, 42);
            this.sign.TabIndex = 56;
            this.sign.TabStop = false;
            this.sign.Text = "+/-";
            this.sign.UseVisualStyleBackColor = false;
            this.sign.Click += new System.EventHandler(this.Sign_Click);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.Color.Transparent;
            this.sqrt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sqrt.FlatAppearance.BorderSize = 0;
            this.sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrt.Font = new System.Drawing.Font("Code Pro", 12F);
            this.sqrt.ForeColor = System.Drawing.Color.Transparent;
            this.sqrt.Location = new System.Drawing.Point(318, 378);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(60, 42);
            this.sqrt.TabIndex = 55;
            this.sqrt.TabStop = false;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = false;
            this.sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // exp
            // 
            this.exp.BackColor = System.Drawing.Color.Transparent;
            this.exp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exp.FlatAppearance.BorderSize = 0;
            this.exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exp.Font = new System.Drawing.Font("Code Pro", 12F);
            this.exp.ForeColor = System.Drawing.Color.Transparent;
            this.exp.Location = new System.Drawing.Point(324, 306);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(45, 42);
            this.exp.TabIndex = 54;
            this.exp.TabStop = false;
            this.exp.Text = "exp";
            this.exp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exp.UseVisualStyleBackColor = false;
            this.exp.Click += new System.EventHandler(this.Exp_Click);
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.Color.Transparent;
            this.square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.square.FlatAppearance.BorderSize = 0;
            this.square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.square.Font = new System.Drawing.Font("Code Pro", 14F);
            this.square.ForeColor = System.Drawing.Color.Transparent;
            this.square.Location = new System.Drawing.Point(321, 235);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(55, 42);
            this.square.TabIndex = 53;
            this.square.TabStop = false;
            this.square.Text = "X^2";
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.Square_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Code Pro", 14F);
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(318, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 42);
            this.button4.TabIndex = 52;
            this.button4.TabStop = false;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // ctg
            // 
            this.ctg.BackColor = System.Drawing.Color.Transparent;
            this.ctg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ctg.FlatAppearance.BorderSize = 0;
            this.ctg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctg.Font = new System.Drawing.Font("Code Pro", 14F);
            this.ctg.ForeColor = System.Drawing.Color.Transparent;
            this.ctg.Location = new System.Drawing.Point(256, 378);
            this.ctg.Name = "ctg";
            this.ctg.Size = new System.Drawing.Size(60, 42);
            this.ctg.TabIndex = 51;
            this.ctg.TabStop = false;
            this.ctg.Text = "ctg";
            this.ctg.UseVisualStyleBackColor = false;
            this.ctg.Click += new System.EventHandler(this.Ctg_Click);
            // 
            // tang
            // 
            this.tang.BackColor = System.Drawing.Color.Transparent;
            this.tang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tang.FlatAppearance.BorderSize = 0;
            this.tang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tang.Font = new System.Drawing.Font("Code Pro", 14F);
            this.tang.ForeColor = System.Drawing.Color.Transparent;
            this.tang.Location = new System.Drawing.Point(261, 306);
            this.tang.Name = "tang";
            this.tang.Size = new System.Drawing.Size(50, 42);
            this.tang.TabIndex = 50;
            this.tang.TabStop = false;
            this.tang.Text = "tg";
            this.tang.UseVisualStyleBackColor = false;
            this.tang.Click += new System.EventHandler(this.Tang_Click);
            // 
            // cos
            // 
            this.cos.BackColor = System.Drawing.Color.Transparent;
            this.cos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cos.FlatAppearance.BorderSize = 0;
            this.cos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cos.Font = new System.Drawing.Font("Code Pro", 14F);
            this.cos.ForeColor = System.Drawing.Color.Transparent;
            this.cos.Location = new System.Drawing.Point(256, 235);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(60, 42);
            this.cos.TabIndex = 49;
            this.cos.TabStop = false;
            this.cos.Text = "Cos";
            this.cos.UseVisualStyleBackColor = false;
            this.cos.Click += new System.EventHandler(this.Cos_Click);
            // 
            // sin
            // 
            this.sin.BackColor = System.Drawing.Color.Transparent;
            this.sin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sin.FlatAppearance.BorderSize = 0;
            this.sin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sin.Font = new System.Drawing.Font("Code Pro", 14F);
            this.sin.ForeColor = System.Drawing.Color.Transparent;
            this.sin.Location = new System.Drawing.Point(260, 163);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(50, 42);
            this.sin.TabIndex = 48;
            this.sin.TabStop = false;
            this.sin.Text = "Sin";
            this.sin.UseVisualStyleBackColor = false;
            this.sin.Click += new System.EventHandler(this.Sin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Code Pro", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(295, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 47;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Code Pro", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 46;
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.Color.Transparent;
            this.n9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n9.FlatAppearance.BorderSize = 0;
            this.n9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n9.Font = new System.Drawing.Font("Code Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.n9.ForeColor = System.Drawing.Color.Transparent;
            this.n9.Location = new System.Drawing.Point(147, 161);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(29, 42);
            this.n9.TabIndex = 45;
            this.n9.TabStop = false;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.N9_Click);
            // 
            // segment
            // 
            this.segment.BackColor = System.Drawing.Color.Transparent;
            this.segment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.segment.FlatAppearance.BorderSize = 0;
            this.segment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.segment.Font = new System.Drawing.Font("Code Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.segment.ForeColor = System.Drawing.Color.Transparent;
            this.segment.Location = new System.Drawing.Point(208, 375);
            this.segment.Name = "segment";
            this.segment.Size = new System.Drawing.Size(29, 42);
            this.segment.TabIndex = 44;
            this.segment.TabStop = false;
            this.segment.Text = "/";
            this.segment.UseVisualStyleBackColor = false;
            this.segment.Click += new System.EventHandler(this.Segment_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.Transparent;
            this.equal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.equal.FlatAppearance.BorderSize = 0;
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equal.Font = new System.Drawing.Font("Code Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.equal.ForeColor = System.Drawing.Color.Transparent;
            this.equal.Location = new System.Drawing.Point(147, 372);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(29, 42);
            this.equal.TabIndex = 43;
            this.equal.TabStop = false;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.Color.Transparent;
            this.n0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n0.FlatAppearance.BorderSize = 0;
            this.n0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n0.Font = new System.Drawing.Font("Code Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.n0.ForeColor = System.Drawing.Color.Transparent;
            this.n0.Location = new System.Drawing.Point(86, 375);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(29, 42);
            this.n0.TabIndex = 42;
            this.n0.TabStop = false;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.N0_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Transparent;
            this.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Code Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.clear.ForeColor = System.Drawing.Color.Transparent;
            this.clear.Location = new System.Drawing.Point(23, 375);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(29, 42);
            this.clear.TabIndex = 41;
            this.clear.TabStop = false;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.Transparent;
            this.multiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.multiply.FlatAppearance.BorderSize = 0;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiply.Font = new System.Drawing.Font("Code Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.multiply.ForeColor = System.Drawing.Color.Transparent;
            this.multiply.Location = new System.Drawing.Point(209, 304);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(29, 42);
            this.multiply.TabIndex = 40;
            this.multiply.TabStop = false;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.Color.Transparent;
            this.n3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n3.FlatAppearance.BorderSize = 0;
            this.n3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n3.Font = new System.Drawing.Font("Code Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.n3.ForeColor = System.Drawing.Color.Transparent;
            this.n3.Location = new System.Drawing.Point(147, 304);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(29, 42);
            this.n3.TabIndex = 39;
            this.n3.TabStop = false;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.N3_Click);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.Color.Transparent;
            this.n2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n2.FlatAppearance.BorderSize = 0;
            this.n2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n2.Font = new System.Drawing.Font("Code Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.n2.ForeColor = System.Drawing.Color.Transparent;
            this.n2.Location = new System.Drawing.Point(86, 304);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(29, 42);
            this.n2.TabIndex = 38;
            this.n2.TabStop = false;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.N2_Click);
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.Color.Transparent;
            this.n1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n1.FlatAppearance.BorderSize = 0;
            this.n1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n1.Font = new System.Drawing.Font("Code Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.n1.ForeColor = System.Drawing.Color.Transparent;
            this.n1.Location = new System.Drawing.Point(23, 303);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(29, 42);
            this.n1.TabIndex = 37;
            this.n1.TabStop = false;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.N1_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.Transparent;
            this.minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minus.FlatAppearance.BorderSize = 0;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Code Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.minus.ForeColor = System.Drawing.Color.Transparent;
            this.minus.Location = new System.Drawing.Point(209, 232);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(29, 42);
            this.minus.TabIndex = 36;
            this.minus.TabStop = false;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.Color.Transparent;
            this.n6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n6.FlatAppearance.BorderSize = 0;
            this.n6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n6.Font = new System.Drawing.Font("Code Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.n6.ForeColor = System.Drawing.Color.Transparent;
            this.n6.Location = new System.Drawing.Point(147, 232);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(29, 42);
            this.n6.TabIndex = 35;
            this.n6.TabStop = false;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.N6_Click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.Color.Transparent;
            this.n5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n5.FlatAppearance.BorderSize = 0;
            this.n5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n5.Font = new System.Drawing.Font("Code Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.n5.ForeColor = System.Drawing.Color.Transparent;
            this.n5.Location = new System.Drawing.Point(86, 232);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(29, 42);
            this.n5.TabIndex = 34;
            this.n5.TabStop = false;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.N5_Click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.Color.Transparent;
            this.n4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n4.FlatAppearance.BorderSize = 0;
            this.n4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n4.Font = new System.Drawing.Font("Code Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.n4.ForeColor = System.Drawing.Color.Transparent;
            this.n4.Location = new System.Drawing.Point(23, 232);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(29, 42);
            this.n4.TabIndex = 33;
            this.n4.TabStop = false;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.N4_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Transparent;
            this.plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Code Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.plus.ForeColor = System.Drawing.Color.Transparent;
            this.plus.Location = new System.Drawing.Point(209, 161);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(29, 42);
            this.plus.TabIndex = 32;
            this.plus.TabStop = false;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.Color.Transparent;
            this.n8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n8.FlatAppearance.BorderSize = 0;
            this.n8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n8.Font = new System.Drawing.Font("Code Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.n8.ForeColor = System.Drawing.Color.Transparent;
            this.n8.Location = new System.Drawing.Point(86, 161);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(29, 42);
            this.n8.TabIndex = 31;
            this.n8.TabStop = false;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.N8_Click);
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.Color.Transparent;
            this.n7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n7.FlatAppearance.BorderSize = 0;
            this.n7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n7.Font = new System.Drawing.Font("Code Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.n7.ForeColor = System.Drawing.Color.Transparent;
            this.n7.Location = new System.Drawing.Point(23, 161);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(29, 42);
            this.n7.TabIndex = 30;
            this.n7.TabStop = false;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.N7_Click);
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.box1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box1.Font = new System.Drawing.Font("Code Pro", 26F);
            this.box1.ForeColor = System.Drawing.Color.White;
            this.box1.Location = new System.Drawing.Point(68, 77);
            this.box1.Multiline = true;
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(251, 39);
            this.box1.TabIndex = 29;
            this.box1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StrokeCalc
            // 
            this.StrokeCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.StrokeCalc.BackgroundImage = global::FoxCalc.Properties.Resources.stroke;
            this.StrokeCalc.Controls.Add(this.reset);
            this.StrokeCalc.Controls.Add(this.labelresult);
            this.StrokeCalc.Controls.Add(this.cb7);
            this.StrokeCalc.Controls.Add(this.cb6);
            this.StrokeCalc.Controls.Add(this.cb5);
            this.StrokeCalc.Controls.Add(this.stats);
            this.StrokeCalc.Controls.Add(this.lower);
            this.StrokeCalc.Controls.Add(this.upper);
            this.StrokeCalc.Controls.Add(this.strokelength);
            this.StrokeCalc.Controls.Add(this.outputBox);
            this.StrokeCalc.Controls.Add(this.InputBox);
            this.StrokeCalc.Font = new System.Drawing.Font("Solomon Sans Normal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrokeCalc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StrokeCalc.Location = new System.Drawing.Point(4, 30);
            this.StrokeCalc.Name = "StrokeCalc";
            this.StrokeCalc.Padding = new System.Windows.Forms.Padding(3);
            this.StrokeCalc.Size = new System.Drawing.Size(454, 436);
            this.StrokeCalc.TabIndex = 1;
            this.StrokeCalc.Text = "Строковый";
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Transparent;
            this.reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reset.FlatAppearance.BorderSize = 0;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("Solomon Sans Normal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.reset.Location = new System.Drawing.Point(404, 374);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(27, 44);
            this.reset.TabIndex = 46;
            this.reset.TabStop = false;
            this.reset.Text = "C";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Font = new System.Drawing.Font("Solomon Sans Normal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelresult.ForeColor = System.Drawing.Color.White;
            this.labelresult.Location = new System.Drawing.Point(145, 168);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(0, 25);
            this.labelresult.TabIndex = 16;
            this.labelresult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb7
            // 
            this.cb7.AutoSize = true;
            this.cb7.Font = new System.Drawing.Font("Solomon Sans Normal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb7.ForeColor = System.Drawing.Color.Lime;
            this.cb7.Location = new System.Drawing.Point(17, 387);
            this.cb7.Name = "cb7";
            this.cb7.Size = new System.Drawing.Size(259, 22);
            this.cb7.TabIndex = 15;
            this.cb7.Text = "Исправление ошибок в строке";
            this.cb7.UseVisualStyleBackColor = true;
            this.cb7.CheckedChanged += new System.EventHandler(this.Cb7_CheckedChanged);
            // 
            // cb6
            // 
            this.cb6.AutoSize = true;
            this.cb6.Font = new System.Drawing.Font("Solomon Sans Normal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb6.ForeColor = System.Drawing.Color.Lime;
            this.cb6.Location = new System.Drawing.Point(17, 359);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(143, 22);
            this.cb6.TabIndex = 14;
            this.cb6.Text = "Преобр. строки";
            this.cb6.UseVisualStyleBackColor = true;
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.Font = new System.Drawing.Font("Solomon Sans Normal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb5.ForeColor = System.Drawing.Color.Lime;
            this.cb5.Location = new System.Drawing.Point(17, 331);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(271, 22);
            this.cb5.TabIndex = 13;
            this.cb5.Text = "Выделение из строки подстроки";
            this.cb5.UseVisualStyleBackColor = true;
            this.cb5.CheckedChanged += new System.EventHandler(this.Cb5_CheckedChanged);
            // 
            // stats
            // 
            this.stats.AutoSize = true;
            this.stats.Font = new System.Drawing.Font("Solomon Sans Normal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stats.ForeColor = System.Drawing.Color.Lime;
            this.stats.Location = new System.Drawing.Point(17, 303);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(111, 22);
            this.stats.TabIndex = 12;
            this.stats.Text = "Статистика";
            this.stats.UseVisualStyleBackColor = true;
            this.stats.CheckedChanged += new System.EventHandler(this.Stats_CheckedChanged);
            // 
            // lower
            // 
            this.lower.AutoSize = true;
            this.lower.Font = new System.Drawing.Font("Solomon Sans Normal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lower.ForeColor = System.Drawing.Color.Lime;
            this.lower.Location = new System.Drawing.Point(17, 275);
            this.lower.Name = "lower";
            this.lower.Size = new System.Drawing.Size(227, 22);
            this.lower.TabIndex = 11;
            this.lower.Text = "Преобр. буквы в строчные";
            this.lower.UseVisualStyleBackColor = true;
            this.lower.CheckedChanged += new System.EventHandler(this.Lower_CheckedChanged);
            // 
            // upper
            // 
            this.upper.AutoSize = true;
            this.upper.Font = new System.Drawing.Font("Solomon Sans Normal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upper.ForeColor = System.Drawing.Color.Lime;
            this.upper.Location = new System.Drawing.Point(17, 247);
            this.upper.Name = "upper";
            this.upper.Size = new System.Drawing.Size(225, 22);
            this.upper.TabIndex = 10;
            this.upper.Text = "Преоб. буквы в заглавные";
            this.upper.UseVisualStyleBackColor = true;
            this.upper.CheckedChanged += new System.EventHandler(this.Upper_CheckedChanged);
            // 
            // strokelength
            // 
            this.strokelength.AutoSize = true;
            this.strokelength.Font = new System.Drawing.Font("Solomon Sans Normal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strokelength.ForeColor = System.Drawing.Color.Lime;
            this.strokelength.Location = new System.Drawing.Point(17, 219);
            this.strokelength.Name = "strokelength";
            this.strokelength.Size = new System.Drawing.Size(168, 22);
            this.strokelength.TabIndex = 9;
            this.strokelength.Text = "Определить длину";
            this.strokelength.UseVisualStyleBackColor = true;
            this.strokelength.CheckedChanged += new System.EventHandler(this.Strokelength_CheckedChanged);
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputBox.Font = new System.Drawing.Font("Solomon Sans Normal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(17, 107);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(419, 42);
            this.outputBox.TabIndex = 8;
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputBox.Font = new System.Drawing.Font("Solomon Sans Normal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.Location = new System.Drawing.Point(17, 29);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InputBox.Size = new System.Drawing.Size(419, 42);
            this.InputBox.TabIndex = 0;
            // 
            // ConvertCalc
            // 
            this.ConvertCalc.BackgroundImage = global::FoxCalc.Properties.Resources.convert;
            this.ConvertCalc.Controls.Add(this.bOutputFile);
            this.ConvertCalc.Controls.Add(this.bInputFile);
            this.ConvertCalc.Controls.Add(this.ConvEqual);
            this.ConvertCalc.Controls.Add(this.OutputPrice);
            this.ConvertCalc.Controls.Add(this.FINPriceFuel);
            this.ConvertCalc.Controls.Add(this.intakeLabel);
            this.ConvertCalc.Controls.Add(this.UselessIntakeLabel);
            this.ConvertCalc.Controls.Add(this.PriceLabel);
            this.ConvertCalc.Controls.Add(this.UselessPriceFuel);
            this.ConvertCalc.Controls.Add(this.ULVehlabel);
            this.ConvertCalc.Controls.Add(this.ULFuelLabel);
            this.ConvertCalc.Controls.Add(this.VehiclesBox);
            this.ConvertCalc.Controls.Add(this.FuelBox);
            this.ConvertCalc.Controls.Add(this.DistanceLabel);
            this.ConvertCalc.Controls.Add(this.ClearButConv);
            this.ConvertCalc.Controls.Add(this.inputDistance);
            this.ConvertCalc.Location = new System.Drawing.Point(4, 30);
            this.ConvertCalc.Name = "ConvertCalc";
            this.ConvertCalc.Size = new System.Drawing.Size(454, 436);
            this.ConvertCalc.TabIndex = 2;
            this.ConvertCalc.Text = "Конверторы";
            this.ConvertCalc.UseVisualStyleBackColor = true;
            // 
            // ConvEqual
            // 
            this.ConvEqual.BackColor = System.Drawing.Color.Transparent;
            this.ConvEqual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConvEqual.FlatAppearance.BorderSize = 0;
            this.ConvEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvEqual.Font = new System.Drawing.Font("Solomon Sans Normal", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvEqual.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ConvEqual.Location = new System.Drawing.Point(132, 373);
            this.ConvEqual.Name = "ConvEqual";
            this.ConvEqual.Size = new System.Drawing.Size(195, 41);
            this.ConvEqual.TabIndex = 59;
            this.ConvEqual.TabStop = false;
            this.ConvEqual.Text = "Рассчитать";
            this.ConvEqual.UseVisualStyleBackColor = false;
            this.ConvEqual.Click += new System.EventHandler(this.ConvEqual_Click);
            // 
            // OutputPrice
            // 
            this.OutputPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.OutputPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputPrice.Font = new System.Drawing.Font("Solomon Sans Normal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputPrice.ForeColor = System.Drawing.Color.Transparent;
            this.OutputPrice.Location = new System.Drawing.Point(30, 316);
            this.OutputPrice.Multiline = true;
            this.OutputPrice.Name = "OutputPrice";
            this.OutputPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OutputPrice.Size = new System.Drawing.Size(328, 42);
            this.OutputPrice.TabIndex = 58;
            // 
            // FINPriceFuel
            // 
            this.FINPriceFuel.AutoSize = true;
            this.FINPriceFuel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.FINPriceFuel.Font = new System.Drawing.Font("Solomon Sans Normal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FINPriceFuel.ForeColor = System.Drawing.Color.Transparent;
            this.FINPriceFuel.Location = new System.Drawing.Point(25, 283);
            this.FINPriceFuel.Name = "FINPriceFuel";
            this.FINPriceFuel.Size = new System.Drawing.Size(252, 25);
            this.FINPriceFuel.TabIndex = 57;
            this.FINPriceFuel.Text = "Цена за поездку(руб.):";
            this.FINPriceFuel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // intakeLabel
            // 
            this.intakeLabel.AutoSize = true;
            this.intakeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.intakeLabel.Font = new System.Drawing.Font("Solomon Sans Normal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intakeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.intakeLabel.Location = new System.Drawing.Point(190, 236);
            this.intakeLabel.Name = "intakeLabel";
            this.intakeLabel.Size = new System.Drawing.Size(0, 25);
            this.intakeLabel.TabIndex = 56;
            this.intakeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UselessIntakeLabel
            // 
            this.UselessIntakeLabel.AutoSize = true;
            this.UselessIntakeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.UselessIntakeLabel.Font = new System.Drawing.Font("Solomon Sans Normal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UselessIntakeLabel.ForeColor = System.Drawing.Color.Transparent;
            this.UselessIntakeLabel.Location = new System.Drawing.Point(112, 215);
            this.UselessIntakeLabel.Name = "UselessIntakeLabel";
            this.UselessIntakeLabel.Size = new System.Drawing.Size(218, 18);
            this.UselessIntakeLabel.TabIndex = 55;
            this.UselessIntakeLabel.Text = "Расход бензина (на 100 км):";
            this.UselessIntakeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.PriceLabel.Font = new System.Drawing.Font("Solomon Sans Normal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.PriceLabel.Location = new System.Drawing.Point(190, 134);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(0, 25);
            this.PriceLabel.TabIndex = 54;
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UselessPriceFuel
            // 
            this.UselessPriceFuel.AutoSize = true;
            this.UselessPriceFuel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.UselessPriceFuel.Font = new System.Drawing.Font("Solomon Sans Normal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UselessPriceFuel.ForeColor = System.Drawing.Color.Transparent;
            this.UselessPriceFuel.Location = new System.Drawing.Point(112, 108);
            this.UselessPriceFuel.Name = "UselessPriceFuel";
            this.UselessPriceFuel.Size = new System.Drawing.Size(186, 18);
            this.UselessPriceFuel.TabIndex = 53;
            this.UselessPriceFuel.Text = "Цена бензина (за литр):";
            this.UselessPriceFuel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ULVehlabel
            // 
            this.ULVehlabel.AutoSize = true;
            this.ULVehlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ULVehlabel.Font = new System.Drawing.Font("Solomon Sans Normal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ULVehlabel.ForeColor = System.Drawing.Color.Transparent;
            this.ULVehlabel.Location = new System.Drawing.Point(304, 108);
            this.ULVehlabel.Name = "ULVehlabel";
            this.ULVehlabel.Size = new System.Drawing.Size(139, 25);
            this.ULVehlabel.TabIndex = 52;
            this.ULVehlabel.Text = "Транспорт   ";
            this.ULVehlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ULFuelLabel
            // 
            this.ULFuelLabel.AutoSize = true;
            this.ULFuelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ULFuelLabel.Font = new System.Drawing.Font("Solomon Sans Normal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ULFuelLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ULFuelLabel.Location = new System.Drawing.Point(11, 108);
            this.ULFuelLabel.Name = "ULFuelLabel";
            this.ULFuelLabel.Size = new System.Drawing.Size(98, 25);
            this.ULFuelLabel.TabIndex = 51;
            this.ULFuelLabel.Text = "Топливо";
            this.ULFuelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VehiclesBox
            // 
            this.VehiclesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.VehiclesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VehiclesBox.Font = new System.Drawing.Font("Solomon Sans Normal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehiclesBox.ForeColor = System.Drawing.Color.Transparent;
            this.VehiclesBox.FormattingEnabled = true;
            this.VehiclesBox.ItemHeight = 19;
            this.VehiclesBox.Items.AddRange(new object[] {
            "Легковое авто",
            "Мотоциклы",
            "Грузовик"});
            this.VehiclesBox.Location = new System.Drawing.Point(304, 136);
            this.VehiclesBox.Name = "VehiclesBox";
            this.VehiclesBox.Size = new System.Drawing.Size(139, 76);
            this.VehiclesBox.TabIndex = 50;
            // 
            // FuelBox
            // 
            this.FuelBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.FuelBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FuelBox.Font = new System.Drawing.Font("Solomon Sans Normal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuelBox.ForeColor = System.Drawing.Color.Transparent;
            this.FuelBox.FormattingEnabled = true;
            this.FuelBox.ItemHeight = 25;
            this.FuelBox.Items.AddRange(new object[] {
            "ГАЗ",
            "ДТ",
            "АИ-92",
            "АИ-95",
            "АИ-98"});
            this.FuelBox.Location = new System.Drawing.Point(11, 136);
            this.FuelBox.Name = "FuelBox";
            this.FuelBox.Size = new System.Drawing.Size(98, 125);
            this.FuelBox.TabIndex = 49;
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.DistanceLabel.Font = new System.Drawing.Font("Solomon Sans Normal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistanceLabel.ForeColor = System.Drawing.Color.Transparent;
            this.DistanceLabel.Location = new System.Drawing.Point(25, 15);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(285, 25);
            this.DistanceLabel.TabIndex = 48;
            this.DistanceLabel.Text = "Введите расстояние(КМ):";
            this.DistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClearButConv
            // 
            this.ClearButConv.BackColor = System.Drawing.Color.Transparent;
            this.ClearButConv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClearButConv.FlatAppearance.BorderSize = 0;
            this.ClearButConv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButConv.Font = new System.Drawing.Font("Solomon Sans Normal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButConv.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClearButConv.Location = new System.Drawing.Point(387, 46);
            this.ClearButConv.Name = "ClearButConv";
            this.ClearButConv.Size = new System.Drawing.Size(34, 50);
            this.ClearButConv.TabIndex = 47;
            this.ClearButConv.TabStop = false;
            this.ClearButConv.Text = "C";
            this.ClearButConv.UseVisualStyleBackColor = false;
            this.ClearButConv.Click += new System.EventHandler(this.ClearButConv_Click);
            // 
            // inputDistance
            // 
            this.inputDistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.inputDistance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputDistance.Font = new System.Drawing.Font("Solomon Sans Normal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDistance.ForeColor = System.Drawing.Color.Transparent;
            this.inputDistance.Location = new System.Drawing.Point(30, 49);
            this.inputDistance.Multiline = true;
            this.inputDistance.Name = "inputDistance";
            this.inputDistance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputDistance.Size = new System.Drawing.Size(328, 42);
            this.inputDistance.TabIndex = 1;
            // 
            // bInputFile
            // 
            this.bInputFile.BackColor = System.Drawing.Color.Transparent;
            this.bInputFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bInputFile.FlatAppearance.BorderSize = 0;
            this.bInputFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInputFile.Font = new System.Drawing.Font("Solomon Sans Normal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInputFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bInputFile.Location = new System.Drawing.Point(373, 215);
            this.bInputFile.Name = "bInputFile";
            this.bInputFile.Size = new System.Drawing.Size(70, 35);
            this.bInputFile.TabIndex = 60;
            this.bInputFile.TabStop = false;
            this.bInputFile.Text = "Input";
            this.bInputFile.UseVisualStyleBackColor = false;
            this.bInputFile.Click += new System.EventHandler(this.BInputFile_Click);
            // 
            // bOutputFile
            // 
            this.bOutputFile.BackColor = System.Drawing.Color.Transparent;
            this.bOutputFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bOutputFile.FlatAppearance.BorderSize = 0;
            this.bOutputFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOutputFile.Font = new System.Drawing.Font("Solomon Sans Normal", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOutputFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bOutputFile.Location = new System.Drawing.Point(378, 252);
            this.bOutputFile.Name = "bOutputFile";
            this.bOutputFile.Size = new System.Drawing.Size(59, 24);
            this.bOutputFile.TabIndex = 61;
            this.bOutputFile.TabStop = false;
            this.bOutputFile.Text = "Output";
            this.bOutputFile.UseVisualStyleBackColor = false;
            this.bOutputFile.Click += new System.EventHandler(this.BOutputFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::FoxCalc.Properties.Resources.foxcalc5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(460, 468);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "FoxCalc";
            this.tabControl1.ResumeLayout(false);
            this.MainCalc.ResumeLayout(false);
            this.MainCalc.PerformLayout();
            this.StrokeCalc.ResumeLayout(false);
            this.StrokeCalc.PerformLayout();
            this.ConvertCalc.ResumeLayout(false);
            this.ConvertCalc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MainCalc;
        private System.Windows.Forms.TabPage StrokeCalc;
        private System.Windows.Forms.TabPage ConvertCalc;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button exp;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ctg;
        private System.Windows.Forms.Button tang;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button segment;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton bin;
        private System.Windows.Forms.RadioButton hex;
        private System.Windows.Forms.RadioButton oct;
        private System.Windows.Forms.RadioButton dec;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.CheckBox cb7;
        private System.Windows.Forms.CheckBox cb6;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.CheckBox stats;
        private System.Windows.Forms.CheckBox lower;
        private System.Windows.Forms.CheckBox upper;
        private System.Windows.Forms.CheckBox strokelength;
        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Button ClearButConv;
        private System.Windows.Forms.TextBox inputDistance;
        private System.Windows.Forms.ListBox FuelBox;
        private System.Windows.Forms.Label ULFuelLabel;
        private System.Windows.Forms.ListBox VehiclesBox;
        private System.Windows.Forms.Label intakeLabel;
        private System.Windows.Forms.Label UselessIntakeLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label UselessPriceFuel;
        private System.Windows.Forms.Label ULVehlabel;
        private System.Windows.Forms.Button ConvEqual;
        private System.Windows.Forms.TextBox OutputPrice;
        private System.Windows.Forms.Label FINPriceFuel;
        private System.Windows.Forms.Button bOutputFile;
        private System.Windows.Forms.Button bInputFile;
    }
}


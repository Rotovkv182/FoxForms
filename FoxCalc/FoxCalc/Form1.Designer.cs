namespace FoxCalc
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
            this.box1 = new System.Windows.Forms.TextBox();
            this.box2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.Color.DimGray;
            this.box1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.box1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.box1.Location = new System.Drawing.Point(14, 180);
            this.box1.Multiline = true;
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(250, 30);
            this.box1.TabIndex = 0;
            this.box1.TextChanged += new System.EventHandler(this.Box1_TextChanged);
            // 
            // box2
            // 
            this.box2.BackColor = System.Drawing.Color.DimGray;
            this.box2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.box2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.box2.Location = new System.Drawing.Point(14, 254);
            this.box2.Multiline = true;
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(250, 30);
            this.box2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(14, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button2.ForeColor = System.Drawing.Color.OrangeRed;
            this.button2.Location = new System.Drawing.Point(78, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button3.ForeColor = System.Drawing.Color.OrangeRed;
            this.button3.Location = new System.Drawing.Point(142, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 47);
            this.button3.TabIndex = 4;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button4.ForeColor = System.Drawing.Color.OrangeRed;
            this.button4.Location = new System.Drawing.Point(206, 311);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 47);
            this.button4.TabIndex = 5;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button5.ForeColor = System.Drawing.Color.OrangeRed;
            this.button5.Location = new System.Drawing.Point(142, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 42);
            this.button5.TabIndex = 6;
            this.button5.Text = "=";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(114, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 59);
            this.label1.TabIndex = 7;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button6.ForeColor = System.Drawing.Color.OrangeRed;
            this.button6.Location = new System.Drawing.Point(78, 123);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 42);
            this.button6.TabIndex = 8;
            this.button6.Text = "C";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(128, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(278, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Name = "Form1";
            this.Text = "FoxCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.TextBox box2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
    }
}


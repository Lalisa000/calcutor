namespace calc
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
            this.summary = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.extraction = new System.Windows.Forms.Button();
            this.exponentiating = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.ctan = new System.Windows.Forms.Button();
            this.asin = new System.Windows.Forms.Button();
            this.acos = new System.Windows.Forms.Button();
            this.arctg = new System.Windows.Forms.Button();
            this.arcctg = new System.Windows.Forms.Button();
            this.abs = new System.Windows.Forms.Button();
            this.reverse = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.logtwo = new System.Windows.Forms.Button();
            this.arithmMean = new System.Windows.Forms.Button();
            this.geomMean = new System.Windows.Forms.Button();
            this.Degree = new System.Windows.Forms.Button();
            this.Negative = new System.Windows.Forms.Button();
            this.Degree10 = new System.Windows.Forms.Button();
            this.LogXY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // summary
            // 
            this.summary.Location = new System.Drawing.Point(12, 89);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(37, 28);
            this.summary.TabIndex = 0;
            this.summary.Text = "+";
            this.summary.UseVisualStyleBackColor = true;
            this.summary.Click += new System.EventHandler(this.Calculate);
            // 
            // subtraction
            // 
            this.subtraction.Location = new System.Drawing.Point(55, 89);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(37, 28);
            this.subtraction.TabIndex = 1;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.Calculate);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(12, 123);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(37, 28);
            this.multiplication.TabIndex = 2;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.Calculate);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(55, 123);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(37, 28);
            this.division.TabIndex = 3;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.Calculate);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Первый аргумент";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(132, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Второй аргумент";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(264, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Результат";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(264, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // extraction
            // 
            this.extraction.Location = new System.Drawing.Point(12, 157);
            this.extraction.Name = "extraction";
            this.extraction.Size = new System.Drawing.Size(37, 28);
            this.extraction.TabIndex = 11;
            this.extraction.Text = "√";
            this.extraction.UseVisualStyleBackColor = true;
            this.extraction.Click += new System.EventHandler(this.CalculateOne);
            // 
            // exponentiating
            // 
            this.exponentiating.Location = new System.Drawing.Point(55, 157);
            this.exponentiating.Name = "exponentiating";
            this.exponentiating.Size = new System.Drawing.Size(37, 28);
            this.exponentiating.TabIndex = 12;
            this.exponentiating.Text = "^";
            this.exponentiating.UseVisualStyleBackColor = true;
            this.exponentiating.Click += new System.EventHandler(this.CalculateOne);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(122, 89);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(44, 26);
            this.cos.TabIndex = 13;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.CalculateOne);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(172, 89);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(44, 26);
            this.sin.TabIndex = 14;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.CalculateOne);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(122, 121);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(44, 26);
            this.tan.TabIndex = 15;
            this.tan.Text = "tg";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.CalculateOne);
            // 
            // ctan
            // 
            this.ctan.Location = new System.Drawing.Point(172, 121);
            this.ctan.Name = "ctan";
            this.ctan.Size = new System.Drawing.Size(44, 26);
            this.ctan.TabIndex = 16;
            this.ctan.Text = "ctg";
            this.ctan.UseVisualStyleBackColor = true;
            this.ctan.Click += new System.EventHandler(this.CalculateOne);
            // 
            // asin
            // 
            this.asin.Location = new System.Drawing.Point(172, 153);
            this.asin.Name = "asin";
            this.asin.Size = new System.Drawing.Size(44, 26);
            this.asin.TabIndex = 17;
            this.asin.Text = "asin";
            this.asin.UseVisualStyleBackColor = true;
            this.asin.Click += new System.EventHandler(this.CalculateOne);
            // 
            // acos
            // 
            this.acos.Location = new System.Drawing.Point(122, 153);
            this.acos.Name = "acos";
            this.acos.Size = new System.Drawing.Size(44, 26);
            this.acos.TabIndex = 18;
            this.acos.Text = "acos";
            this.acos.UseVisualStyleBackColor = true;
            this.acos.Click += new System.EventHandler(this.CalculateOne);
            // 
            // arctg
            // 
            this.arctg.Location = new System.Drawing.Point(222, 91);
            this.arctg.Name = "arctg";
            this.arctg.Size = new System.Drawing.Size(44, 26);
            this.arctg.TabIndex = 19;
            this.arctg.Text = "arctg";
            this.arctg.UseVisualStyleBackColor = true;
            this.arctg.Click += new System.EventHandler(this.CalculateOne);
            // 
            // arcctg
            // 
            this.arcctg.Location = new System.Drawing.Point(222, 125);
            this.arcctg.Name = "arcctg";
            this.arcctg.Size = new System.Drawing.Size(44, 26);
            this.arcctg.TabIndex = 20;
            this.arcctg.Text = "arcctg";
            this.arcctg.UseVisualStyleBackColor = true;
            this.arcctg.Click += new System.EventHandler(this.CalculateOne);
            // 
            // abs
            // 
            this.abs.Location = new System.Drawing.Point(336, 91);
            this.abs.Name = "abs";
            this.abs.Size = new System.Drawing.Size(44, 26);
            this.abs.TabIndex = 21;
            this.abs.Text = "|  |";
            this.abs.UseVisualStyleBackColor = true;
            this.abs.Click += new System.EventHandler(this.CalculateOne);
            // 
            // reverse
            // 
            this.reverse.Location = new System.Drawing.Point(286, 91);
            this.reverse.Name = "reverse";
            this.reverse.Size = new System.Drawing.Size(44, 26);
            this.reverse.TabIndex = 22;
            this.reverse.Text = "1/x";
            this.reverse.UseVisualStyleBackColor = true;
            this.reverse.Click += new System.EventHandler(this.CalculateOne);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(286, 123);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(44, 26);
            this.ln.TabIndex = 23;
            this.ln.Text = "ln(x)";
            this.ln.UseVisualStyleBackColor = true;
            this.ln.Click += new System.EventHandler(this.CalculateOne);
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(336, 125);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(44, 26);
            this.exp.TabIndex = 24;
            this.exp.Text = "e^x";
            this.exp.UseVisualStyleBackColor = true;
            this.exp.Click += new System.EventHandler(this.CalculateOne);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(285, 157);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(44, 26);
            this.two.TabIndex = 25;
            this.two.Text = "2^x";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.CalculateOne);
            // 
            // logtwo
            // 
            this.logtwo.Location = new System.Drawing.Point(336, 159);
            this.logtwo.Name = "logtwo";
            this.logtwo.Size = new System.Drawing.Size(47, 26);
            this.logtwo.TabIndex = 26;
            this.logtwo.Text = "log2(x)";
            this.logtwo.UseVisualStyleBackColor = true;
            this.logtwo.Click += new System.EventHandler(this.CalculateOne);
            // 
            // arithmMean
            // 
            this.arithmMean.Location = new System.Drawing.Point(12, 203);
            this.arithmMean.Name = "arithmMean";
            this.arithmMean.Size = new System.Drawing.Size(80, 25);
            this.arithmMean.TabIndex = 27;
            this.arithmMean.Text = "arithmMean";
            this.arithmMean.UseVisualStyleBackColor = true;
            this.arithmMean.Click += new System.EventHandler(this.Calculate);
            // 
            // geomMean
            // 
            this.geomMean.Location = new System.Drawing.Point(12, 234);
            this.geomMean.Name = "geomMean";
            this.geomMean.Size = new System.Drawing.Size(80, 25);
            this.geomMean.TabIndex = 28;
            this.geomMean.Text = "geomMean";
            this.geomMean.UseVisualStyleBackColor = true;
            this.geomMean.Click += new System.EventHandler(this.Calculate);
            // 
            // Degree
            // 
            this.Degree.Location = new System.Drawing.Point(285, 189);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(44, 26);
            this.Degree.TabIndex = 29;
            this.Degree.Text = "x^y";
            this.Degree.UseVisualStyleBackColor = true;
            this.Degree.Click += new System.EventHandler(this.Calculate);
            // 
            // Negative
            // 
            this.Negative.Location = new System.Drawing.Point(336, 189);
            this.Negative.Name = "Negative";
            this.Negative.Size = new System.Drawing.Size(47, 26);
            this.Negative.TabIndex = 30;
            this.Negative.Text = "-x";
            this.Negative.UseVisualStyleBackColor = true;
            this.Negative.Click += new System.EventHandler(this.CalculateOne);
            // 
            // Degree10
            // 
            this.Degree10.Location = new System.Drawing.Point(283, 221);
            this.Degree10.Name = "Degree10";
            this.Degree10.Size = new System.Drawing.Size(47, 26);
            this.Degree10.TabIndex = 31;
            this.Degree10.Text = "10^x";
            this.Degree10.UseVisualStyleBackColor = true;
            this.Degree10.Click += new System.EventHandler(this.CalculateOne);
            // 
            // LogXY
            // 
            this.LogXY.Location = new System.Drawing.Point(333, 221);
            this.LogXY.Name = "LogXY";
            this.LogXY.Size = new System.Drawing.Size(47, 26);
            this.LogXY.TabIndex = 32;
            this.LogXY.Text = "logx(y)";
            this.LogXY.UseVisualStyleBackColor = true;
            this.LogXY.Click += new System.EventHandler(this.Calculate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 345);
            this.Controls.Add(this.LogXY);
            this.Controls.Add(this.Degree10);
            this.Controls.Add(this.Negative);
            this.Controls.Add(this.Degree);
            this.Controls.Add(this.geomMean);
            this.Controls.Add(this.arithmMean);
            this.Controls.Add(this.logtwo);
            this.Controls.Add(this.two);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.reverse);
            this.Controls.Add(this.abs);
            this.Controls.Add(this.arcctg);
            this.Controls.Add(this.arctg);
            this.Controls.Add(this.acos);
            this.Controls.Add(this.asin);
            this.Controls.Add(this.ctan);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.exponentiating);
            this.Controls.Add(this.extraction);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.summary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button summary;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button extraction;
        private System.Windows.Forms.Button exponentiating;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button ctan;
        private System.Windows.Forms.Button asin;
        private System.Windows.Forms.Button acos;
        private System.Windows.Forms.Button arctg;
        private System.Windows.Forms.Button arcctg;
        private System.Windows.Forms.Button abs;
        private System.Windows.Forms.Button reverse;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button exp;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button logtwo;
        private System.Windows.Forms.Button arithmMean;
        private System.Windows.Forms.Button geomMean;
        private System.Windows.Forms.Button Degree;
        private System.Windows.Forms.Button Negative;
        private System.Windows.Forms.Button Degree10;
        private System.Windows.Forms.Button LogXY;
    }
}


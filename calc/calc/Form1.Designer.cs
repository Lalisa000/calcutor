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
            this.SuspendLayout();
            // 
            // summary
            // 
            this.summary.Location = new System.Drawing.Point(12, 111);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(37, 28);
            this.summary.TabIndex = 0;
            this.summary.Text = "+";
            this.summary.UseVisualStyleBackColor = true;
            this.summary.Click += new System.EventHandler(this.unionsi);
            // 
            // subtraction
            // 
            this.subtraction.Location = new System.Drawing.Point(69, 111);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(37, 28);
            this.subtraction.TabIndex = 1;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.unionsi);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(135, 111);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(37, 28);
            this.multiplication.TabIndex = 2;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.unionsi);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(194, 111);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(37, 28);
            this.division.TabIndex = 3;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.unionsi);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 204);
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
    }
}


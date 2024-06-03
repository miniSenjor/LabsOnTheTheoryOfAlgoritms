namespace PermutationCiphers
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
            this.nUDSquareLength = new System.Windows.Forms.NumericUpDown();
            this.lblSquareLength = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSlogan = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cbCiphers = new System.Windows.Forms.ComboBox();
            this.chkClockwise = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblColumn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSquareLength)).BeginInit();
            this.SuspendLayout();
            // 
            // nUDSquareLength
            // 
            this.nUDSquareLength.Location = new System.Drawing.Point(621, 173);
            this.nUDSquareLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUDSquareLength.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nUDSquareLength.Name = "nUDSquareLength";
            this.nUDSquareLength.Size = new System.Drawing.Size(120, 22);
            this.nUDSquareLength.TabIndex = 23;
            this.nUDSquareLength.Visible = false;
            // 
            // lblSquareLength
            // 
            this.lblSquareLength.AutoSize = true;
            this.lblSquareLength.Location = new System.Drawing.Point(488, 175);
            this.lblSquareLength.Name = "lblSquareLength";
            this.lblSquareLength.Size = new System.Drawing.Size(122, 16);
            this.lblSquareLength.TabIndex = 22;
            this.lblSquareLength.Text = "Размер квадрата";
            this.lblSquareLength.Visible = false;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(513, 228);
            this.btnRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(116, 23);
            this.btnRun.TabIndex = 21;
            this.btnRun.Text = "Выполнить";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Шифр";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Location = new System.Drawing.Point(495, 114);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(54, 16);
            this.lblSlogan.TabIndex = 19;
            this.lblSlogan.Text = "Слоган";
            this.lblSlogan.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Вывод";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ввод";
            // 
            // txtSlogan
            // 
            this.txtSlogan.Location = new System.Drawing.Point(555, 108);
            this.txtSlogan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSlogan.Name = "txtSlogan";
            this.txtSlogan.Size = new System.Drawing.Size(197, 22);
            this.txtSlogan.TabIndex = 16;
            this.txtSlogan.Visible = false;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(96, 175);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(364, 22);
            this.txtOutput.TabIndex = 15;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(96, 112);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(364, 22);
            this.txtInput.TabIndex = 14;
            // 
            // cbCiphers
            // 
            this.cbCiphers.FormattingEnabled = true;
            this.cbCiphers.Items.AddRange(new object[] {
            "Простая одинарная",
            "Блочная одинарная",
            "Маршрутная перестановка",
            "Вертикальная перестановка",
            "Перекрёсток",
            "С использованием треугольников",
            "Поворотная решётка",
            "Магический квадрат",
            "Двойная перестановка"});
            this.cbCiphers.Location = new System.Drawing.Point(96, 43);
            this.cbCiphers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCiphers.Name = "cbCiphers";
            this.cbCiphers.Size = new System.Drawing.Size(213, 24);
            this.cbCiphers.TabIndex = 13;
            this.cbCiphers.SelectedIndexChanged += new System.EventHandler(this.cbCiphers_SelectedIndexChanged);
            // 
            // chkClockwise
            // 
            this.chkClockwise.AutoSize = true;
            this.chkClockwise.Location = new System.Drawing.Point(809, 107);
            this.chkClockwise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkClockwise.Name = "chkClockwise";
            this.chkClockwise.Size = new System.Drawing.Size(102, 20);
            this.chkClockwise.TabIndex = 24;
            this.chkClockwise.Text = "Почасовой";
            this.chkClockwise.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(555, 134);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 22);
            this.textBox1.TabIndex = 25;
            this.textBox1.Visible = false;
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Location = new System.Drawing.Point(488, 140);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(64, 16);
            this.lblColumn.TabIndex = 26;
            this.lblColumn.Text = "Столбцы";
            this.lblColumn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblColumn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chkClockwise);
            this.Controls.Add(this.nUDSquareLength);
            this.Controls.Add(this.lblSquareLength);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSlogan);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.cbCiphers);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "lr10";
            ((System.ComponentModel.ISupportInitialize)(this.nUDSquareLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUDSquareLength;
        private System.Windows.Forms.Label lblSquareLength;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSlogan;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox cbCiphers;
        private System.Windows.Forms.CheckBox chkClockwise;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblColumn;
    }
}


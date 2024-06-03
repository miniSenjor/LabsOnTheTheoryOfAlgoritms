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
            this.checkBoxEncrypt = new System.Windows.Forms.CheckBox();
            this.cbCiphers = new System.Windows.Forms.ComboBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtSlogan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblShift = new System.Windows.Forms.Label();
            this.nUDShift = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUDShift)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxEncrypt
            // 
            this.checkBoxEncrypt.AutoSize = true;
            this.checkBoxEncrypt.Checked = true;
            this.checkBoxEncrypt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEncrypt.Location = new System.Drawing.Point(260, 24);
            this.checkBoxEncrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxEncrypt.Name = "checkBoxEncrypt";
            this.checkBoxEncrypt.Size = new System.Drawing.Size(96, 17);
            this.checkBoxEncrypt.TabIndex = 0;
            this.checkBoxEncrypt.Text = "Зашифровать";
            this.checkBoxEncrypt.UseVisualStyleBackColor = true;
            // 
            // cbCiphers
            // 
            this.cbCiphers.FormattingEnabled = true;
            this.cbCiphers.Items.AddRange(new object[] {
            "Цезаря",
            "Атбаш",
            "Лозунговый",
            "Полибианский квадрат",
            "Трисемуса",
            "Playfair",
            "Виженера",
            "Хилла",
            "Вариантный",
            "Совмещённый"});
            this.cbCiphers.Location = new System.Drawing.Point(72, 23);
            this.cbCiphers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCiphers.Name = "cbCiphers";
            this.cbCiphers.Size = new System.Drawing.Size(161, 21);
            this.cbCiphers.TabIndex = 1;
            this.cbCiphers.SelectedIndexChanged += new System.EventHandler(this.cbCiphers_SelectedIndexChanged);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(72, 79);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(274, 20);
            this.txtInput.TabIndex = 2;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(72, 120);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(274, 20);
            this.txtOutput.TabIndex = 3;
            // 
            // txtSlogan
            // 
            this.txtSlogan.Location = new System.Drawing.Point(416, 76);
            this.txtSlogan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSlogan.Name = "txtSlogan";
            this.txtSlogan.Size = new System.Drawing.Size(149, 20);
            this.txtSlogan.TabIndex = 4;
            this.txtSlogan.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ввод";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вывод";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Location = new System.Drawing.Point(371, 81);
            this.lblSlogan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(43, 13);
            this.lblSlogan.TabIndex = 7;
            this.lblSlogan.Text = "Слоган";
            this.lblSlogan.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Шифр";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(385, 173);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(79, 19);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Выполнить";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Location = new System.Drawing.Point(376, 120);
            this.lblShift.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(37, 13);
            this.lblShift.TabIndex = 11;
            this.lblShift.Text = "Сдвиг";
            this.lblShift.Visible = false;
            // 
            // nUDShift
            // 
            this.nUDShift.Location = new System.Drawing.Point(416, 119);
            this.nUDShift.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nUDShift.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nUDShift.Name = "nUDShift";
            this.nUDShift.Size = new System.Drawing.Size(90, 20);
            this.nUDShift.TabIndex = 12;
            this.nUDShift.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.nUDShift);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSlogan);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.cbCiphers);
            this.Controls.Add(this.checkBoxEncrypt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUDShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEncrypt;
        private System.Windows.Forms.ComboBox cbCiphers;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtSlogan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.NumericUpDown nUDShift;
    }
}


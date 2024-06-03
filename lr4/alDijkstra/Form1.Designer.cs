namespace alDijkstra
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
            this.dgvBefore = new System.Windows.Forms.DataGridView();
            this.btnChangeCountVertex = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCountVertex = new System.Windows.Forms.Label();
            this.txtCountVertex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDijkstra = new System.Windows.Forms.DataGridView();
            this.btnMirror = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijkstra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBefore
            // 
            this.dgvBefore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBefore.Location = new System.Drawing.Point(26, 32);
            this.dgvBefore.Name = "dgvBefore";
            this.dgvBefore.RowHeadersWidth = 51;
            this.dgvBefore.RowTemplate.Height = 24;
            this.dgvBefore.Size = new System.Drawing.Size(442, 355);
            this.dgvBefore.TabIndex = 0;
            // 
            // btnChangeCountVertex
            // 
            this.btnChangeCountVertex.Location = new System.Drawing.Point(1122, 253);
            this.btnChangeCountVertex.Name = "btnChangeCountVertex";
            this.btnChangeCountVertex.Size = new System.Drawing.Size(90, 23);
            this.btnChangeCountVertex.TabIndex = 1;
            this.btnChangeCountVertex.Text = "Изменить";
            this.btnChangeCountVertex.UseVisualStyleBackColor = true;
            this.btnChangeCountVertex.Click += new System.EventHandler(this.btnChangeCountVertex_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(1122, 282);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(90, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Вычислить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(1112, 97);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(76, 22);
            this.txtStart.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1049, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Начало";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1049, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Конец";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(1112, 142);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(76, 22);
            this.txtEnd.TabIndex = 6;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(1112, 183);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(171, 22);
            this.txtPath.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1049, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Путь";
            // 
            // lblCountVertex
            // 
            this.lblCountVertex.AutoSize = true;
            this.lblCountVertex.Location = new System.Drawing.Point(1059, 231);
            this.lblCountVertex.Name = "lblCountVertex";
            this.lblCountVertex.Size = new System.Drawing.Size(103, 16);
            this.lblCountVertex.TabIndex = 10;
            this.lblCountVertex.Text = "Кол-во вершин";
            // 
            // txtCountVertex
            // 
            this.txtCountVertex.Location = new System.Drawing.Point(1168, 225);
            this.txtCountVertex.Name = "txtCountVertex";
            this.txtCountVertex.Size = new System.Drawing.Size(76, 22);
            this.txtCountVertex.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Дийкстра";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "До";
            // 
            // dgvDijkstra
            // 
            this.dgvDijkstra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDijkstra.Location = new System.Drawing.Point(496, 32);
            this.dgvDijkstra.Name = "dgvDijkstra";
            this.dgvDijkstra.RowHeadersWidth = 51;
            this.dgvDijkstra.RowTemplate.Height = 24;
            this.dgvDijkstra.Size = new System.Drawing.Size(442, 355);
            this.dgvDijkstra.TabIndex = 13;
            // 
            // btnMirror
            // 
            this.btnMirror.Location = new System.Drawing.Point(1016, 282);
            this.btnMirror.Name = "btnMirror";
            this.btnMirror.Size = new System.Drawing.Size(90, 23);
            this.btnMirror.TabIndex = 14;
            this.btnMirror.Text = "Отзеркалить";
            this.btnMirror.UseVisualStyleBackColor = true;
            this.btnMirror.Click += new System.EventHandler(this.btnMirror_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 450);
            this.Controls.Add(this.btnMirror);
            this.Controls.Add(this.dgvDijkstra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCountVertex);
            this.Controls.Add(this.txtCountVertex);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnChangeCountVertex);
            this.Controls.Add(this.dgvBefore);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijkstra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBefore;
        private System.Windows.Forms.Button btnChangeCountVertex;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCountVertex;
        private System.Windows.Forms.TextBox txtCountVertex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDijkstra;
        private System.Windows.Forms.Button btnMirror;
    }
}


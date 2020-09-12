namespace KMMLab1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.calcButton = new System.Windows.Forms.Button();
            this.aMatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.dMatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.accuracyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.xCountBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aMatrixDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMatrixDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // calcButton
            // 
            this.calcButton.Enabled = false;
            this.calcButton.Location = new System.Drawing.Point(361, 149);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(170, 34);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "Calc";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // aMatrixDataGridView
            // 
            this.aMatrixDataGridView.AllowUserToAddRows = false;
            this.aMatrixDataGridView.AllowUserToDeleteRows = false;
            this.aMatrixDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aMatrixDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.aMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aMatrixDataGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.aMatrixDataGridView.Location = new System.Drawing.Point(12, 33);
            this.aMatrixDataGridView.MultiSelect = false;
            this.aMatrixDataGridView.Name = "aMatrixDataGridView";
            this.aMatrixDataGridView.RowHeadersWidth = 40;
            this.aMatrixDataGridView.RowTemplate.DefaultCellStyle.Format = "N4";
            this.aMatrixDataGridView.RowTemplate.DefaultCellStyle.NullValue = "0";
            this.aMatrixDataGridView.RowTemplate.Height = 40;
            this.aMatrixDataGridView.ShowCellErrors = false;
            this.aMatrixDataGridView.ShowCellToolTips = false;
            this.aMatrixDataGridView.ShowEditingIcon = false;
            this.aMatrixDataGridView.ShowRowErrors = false;
            this.aMatrixDataGridView.Size = new System.Drawing.Size(240, 150);
            this.aMatrixDataGridView.TabIndex = 1;
            // 
            // dMatrixDataGridView
            // 
            this.dMatrixDataGridView.AllowUserToAddRows = false;
            this.dMatrixDataGridView.AllowUserToDeleteRows = false;
            this.dMatrixDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dMatrixDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dMatrixDataGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N6";
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dMatrixDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dMatrixDataGridView.Location = new System.Drawing.Point(258, 33);
            this.dMatrixDataGridView.MultiSelect = false;
            this.dMatrixDataGridView.Name = "dMatrixDataGridView";
            this.dMatrixDataGridView.RowTemplate.Height = 24;
            this.dMatrixDataGridView.ShowCellErrors = false;
            this.dMatrixDataGridView.ShowCellToolTips = false;
            this.dMatrixDataGridView.ShowEditingIcon = false;
            this.dMatrixDataGridView.ShowRowErrors = false;
            this.dMatrixDataGridView.Size = new System.Drawing.Size(94, 150);
            this.dMatrixDataGridView.TabIndex = 2;
            // 
            // accuracyTextBox
            // 
            this.accuracyTextBox.Location = new System.Drawing.Point(361, 119);
            this.accuracyTextBox.Name = "accuracyTextBox";
            this.accuracyTextBox.Size = new System.Drawing.Size(170, 22);
            this.accuracyTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Accuracy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "A matrix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "D vector";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(12, 228);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(519, 172);
            this.outputTextBox.TabIndex = 7;
            this.outputTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output";
            // 
            // xCountBox
            // 
            this.xCountBox.Location = new System.Drawing.Point(361, 52);
            this.xCountBox.Name = "xCountBox";
            this.xCountBox.Size = new System.Drawing.Size(77, 22);
            this.xCountBox.TabIndex = 9;
            this.xCountBox.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "X count";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 22);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.xCountBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accuracyTextBox);
            this.Controls.Add(this.dMatrixDataGridView);
            this.Controls.Add(this.aMatrixDataGridView);
            this.Controls.Add(this.calcButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.aMatrixDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMatrixDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.DataGridView aMatrixDataGridView;
        private System.Windows.Forms.DataGridView dMatrixDataGridView;
        private System.Windows.Forms.TextBox accuracyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xCountBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}


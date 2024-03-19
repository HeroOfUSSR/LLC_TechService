namespace LLC_TechService.Forms
{
    partial class PartView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            labelName = new Label();
            labelAmount = new Label();
            numericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(3, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(204, 20);
            labelName.TabIndex = 35;
            labelName.Text = "Наименование запчасти";
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAmount.ForeColor = Color.FromArgb(64, 64, 64);
            labelAmount.Location = new Point(3, 29);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(99, 20);
            labelAmount.TabIndex = 36;
            labelAmount.Text = "Количество";
            // 
            // numericUpDown
            // 
            numericUpDown.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown.Location = new Point(268, 13);
            numericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(120, 32);
            numericUpDown.TabIndex = 37;
            numericUpDown.ValueChanged += numericUpDown_ValueChanged;
            // 
            // PartView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numericUpDown);
            Controls.Add(labelAmount);
            Controls.Add(labelName);
            Name = "PartView";
            Size = new Size(398, 58);
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelAmount;
        private NumericUpDown numericUpDown;
    }
}

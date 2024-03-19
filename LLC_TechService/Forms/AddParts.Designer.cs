namespace LLC_TechService.Forms
{
    partial class AddParts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelEquip = new Label();
            textBoxPart = new TextBox();
            buttonCancel = new Button();
            buttonCreate = new Button();
            numericUpDown = new NumericUpDown();
            label1 = new Label();
            buttonAlready = new Button();
            comboPart = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // labelEquip
            // 
            labelEquip.AutoSize = true;
            labelEquip.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEquip.Location = new Point(25, 34);
            labelEquip.Name = "labelEquip";
            labelEquip.Size = new Size(129, 40);
            labelEquip.TabIndex = 24;
            labelEquip.Text = "Наименование\r\nдетали*";
            // 
            // textBoxPart
            // 
            textBoxPart.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPart.Location = new Point(160, 34);
            textBoxPart.Multiline = true;
            textBoxPart.Name = "textBoxPart";
            textBoxPart.Size = new Size(229, 40);
            textBoxPart.TabIndex = 23;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(58, 220);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(348, 34);
            buttonCancel.TabIndex = 29;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.Location = new Point(58, 180);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(348, 34);
            buttonCreate.TabIndex = 28;
            buttonCreate.Text = "Заказать детали";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // numericUpDown
            // 
            numericUpDown.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            numericUpDown.Location = new Point(223, 95);
            numericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(140, 32);
            numericUpDown.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(110, 97);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 39;
            label1.Text = "Количество*";
            // 
            // buttonAlready
            // 
            buttonAlready.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAlready.Location = new Point(395, 34);
            buttonAlready.Name = "buttonAlready";
            buttonAlready.Size = new Size(39, 41);
            buttonAlready.TabIndex = 40;
            buttonAlready.Text = "+\r\n";
            buttonAlready.UseVisualStyleBackColor = true;
            buttonAlready.Click += button1_Click;
            // 
            // comboPart
            // 
            comboPart.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboPart.FormattingEnabled = true;
            comboPart.Location = new Point(160, 41);
            comboPart.Name = "comboPart";
            comboPart.Size = new Size(229, 28);
            comboPart.TabIndex = 41;
            comboPart.SelectedIndexChanged += comboPart_SelectedIndexChanged;
            // 
            // AddParts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 272);
            Controls.Add(comboPart);
            Controls.Add(buttonAlready);
            Controls.Add(label1);
            Controls.Add(numericUpDown);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreate);
            Controls.Add(labelEquip);
            Controls.Add(textBoxPart);
            Name = "AddParts";
            Text = "Заказ деталей";
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEquip;
        private TextBox textBoxPart;
        private Button buttonCancel;
        private Button buttonCreate;
        private NumericUpDown numericUpDown;
        private Label label1;
        private Button buttonAlready;
        private ComboBox comboPart;
    }
}
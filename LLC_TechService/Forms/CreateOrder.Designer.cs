namespace LLC_TechService.Forms
{
    partial class CreateOrder
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
            label6 = new Label();
            textBoxDesc = new TextBox();
            labelMalfunction = new Label();
            textBoxProblem = new TextBox();
            labelEquip = new Label();
            textBoxEquip = new TextBox();
            buttonCreate = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            comboType = new ComboBox();
            label2 = new Label();
            textBoxSerial = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(70, 279);
            label6.Name = "label6";
            label6.Size = new Size(119, 40);
            label6.TabIndex = 26;
            label6.Text = "Комментарий\r\nк заказу\r\n";
            // 
            // textBoxDesc
            // 
            textBoxDesc.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDesc.Location = new Point(205, 279);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(246, 93);
            textBoxDesc.TabIndex = 25;
            // 
            // labelMalfunction
            // 
            labelMalfunction.AutoSize = true;
            labelMalfunction.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMalfunction.Location = new Point(70, 214);
            labelMalfunction.Name = "labelMalfunction";
            labelMalfunction.Size = new Size(96, 40);
            labelMalfunction.TabIndex = 24;
            labelMalfunction.Text = "Опишите \r\nпроблему*\r\n";
            // 
            // textBoxProblem
            // 
            textBoxProblem.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProblem.Location = new Point(205, 214);
            textBoxProblem.Multiline = true;
            textBoxProblem.Name = "textBoxProblem";
            textBoxProblem.Size = new Size(246, 40);
            textBoxProblem.TabIndex = 23;
            // 
            // labelEquip
            // 
            labelEquip.AutoSize = true;
            labelEquip.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEquip.Location = new Point(70, 50);
            labelEquip.Name = "labelEquip";
            labelEquip.Size = new Size(131, 60);
            labelEquip.TabIndex = 22;
            labelEquip.Text = "Наименование\r\nоборудования*\r\n\r\n";
            // 
            // textBoxEquip
            // 
            textBoxEquip.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEquip.Location = new Point(205, 50);
            textBoxEquip.Multiline = true;
            textBoxEquip.Name = "textBoxEquip";
            textBoxEquip.Size = new Size(246, 40);
            textBoxEquip.TabIndex = 21;
            // 
            // buttonCreate
            // 
            buttonCreate.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.Location = new Point(88, 412);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(348, 34);
            buttonCreate.TabIndex = 20;
            buttonCreate.Text = "Оформить заказ";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(88, 452);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(348, 34);
            buttonCancel.TabIndex = 27;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(70, 167);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 28;
            label1.Text = "Тип техники*";
            // 
            // comboType
            // 
            comboType.FormattingEnabled = true;
            comboType.Location = new Point(205, 167);
            comboType.Name = "comboType";
            comboType.Size = new Size(246, 23);
            comboType.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(70, 107);
            label2.Name = "label2";
            label2.Size = new Size(97, 40);
            label2.TabIndex = 31;
            label2.Text = "Серийный \r\nномер*";
            // 
            // textBoxSerial
            // 
            textBoxSerial.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSerial.Location = new Point(205, 107);
            textBoxSerial.Multiline = true;
            textBoxSerial.Name = "textBoxSerial";
            textBoxSerial.Size = new Size(246, 40);
            textBoxSerial.TabIndex = 30;
            // 
            // CreateOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 500);
            Controls.Add(label2);
            Controls.Add(textBoxSerial);
            Controls.Add(comboType);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(label6);
            Controls.Add(textBoxDesc);
            Controls.Add(labelMalfunction);
            Controls.Add(textBoxProblem);
            Controls.Add(labelEquip);
            Controls.Add(textBoxEquip);
            Controls.Add(buttonCreate);
            Name = "CreateOrder";
            Text = "Оформление заказа";
            Load += CreateOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox textBoxDesc;
        private Label labelMalfunction;
        private TextBox textBoxProblem;
        private Label labelEquip;
        private TextBox textBoxEquip;
        private Button buttonCreate;
        private Button buttonCancel;
        private Label label1;
        private ComboBox comboType;
        private Label label2;
        private TextBox textBoxSerial;
    }
}
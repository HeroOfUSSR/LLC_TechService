namespace LLC_TechService.Forms
{
    partial class EditOrder
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
            label2 = new Label();
            textBoxSerial = new TextBox();
            buttonCancel = new Button();
            label6 = new Label();
            textBoxDesc = new TextBox();
            labelMalfunction = new Label();
            textBoxProblem = new TextBox();
            labelEquip = new Label();
            textBoxEquip = new TextBox();
            buttonEdit = new Button();
            comboType = new ComboBox();
            label1 = new Label();
            comboStatus = new ComboBox();
            label3 = new Label();
            comboPriority = new ComboBox();
            label4 = new Label();
            comboMaster = new ComboBox();
            label5 = new Label();
            comboClient = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 91);
            label2.Name = "label2";
            label2.Size = new Size(97, 40);
            label2.TabIndex = 41;
            label2.Text = "Серийный \r\nномер*";
            // 
            // textBoxSerial
            // 
            textBoxSerial.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSerial.Location = new Point(204, 91);
            textBoxSerial.Multiline = true;
            textBoxSerial.Name = "textBoxSerial";
            textBoxSerial.Size = new Size(246, 40);
            textBoxSerial.TabIndex = 40;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(88, 593);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(348, 34);
            buttonCancel.TabIndex = 39;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(60, 434);
            label6.Name = "label6";
            label6.Size = new Size(119, 40);
            label6.TabIndex = 38;
            label6.Text = "Комментарий\r\nк заказу\r\n";
            // 
            // textBoxDesc
            // 
            textBoxDesc.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDesc.Location = new Point(204, 431);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(246, 93);
            textBoxDesc.TabIndex = 37;
            // 
            // labelMalfunction
            // 
            labelMalfunction.AutoSize = true;
            labelMalfunction.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMalfunction.Location = new Point(60, 194);
            labelMalfunction.Name = "labelMalfunction";
            labelMalfunction.Size = new Size(138, 20);
            labelMalfunction.TabIndex = 36;
            labelMalfunction.Text = "Неисправность*\r\n";
            // 
            // textBoxProblem
            // 
            textBoxProblem.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProblem.Location = new Point(204, 191);
            textBoxProblem.Name = "textBoxProblem";
            textBoxProblem.Size = new Size(246, 32);
            textBoxProblem.TabIndex = 35;
            // 
            // labelEquip
            // 
            labelEquip.AutoSize = true;
            labelEquip.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEquip.Location = new Point(60, 34);
            labelEquip.Name = "labelEquip";
            labelEquip.Size = new Size(131, 60);
            labelEquip.TabIndex = 34;
            labelEquip.Text = "Наименование\r\nоборудования*\r\n\r\n";
            // 
            // textBoxEquip
            // 
            textBoxEquip.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEquip.Location = new Point(204, 34);
            textBoxEquip.Multiline = true;
            textBoxEquip.Name = "textBoxEquip";
            textBoxEquip.Size = new Size(246, 40);
            textBoxEquip.TabIndex = 33;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(88, 553);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(348, 34);
            buttonEdit.TabIndex = 32;
            buttonEdit.Text = "Изменить заказ";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // comboType
            // 
            comboType.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboType.FormattingEnabled = true;
            comboType.Location = new Point(204, 148);
            comboType.Name = "comboType";
            comboType.Size = new Size(246, 28);
            comboType.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 151);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 42;
            label1.Text = "Тип техники*";
            // 
            // comboStatus
            // 
            comboStatus.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboStatus.FormattingEnabled = true;
            comboStatus.Location = new Point(204, 243);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(246, 28);
            comboStatus.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(60, 246);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 44;
            label3.Text = "Статус*";
            // 
            // comboPriority
            // 
            comboPriority.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboPriority.FormattingEnabled = true;
            comboPriority.Location = new Point(204, 290);
            comboPriority.Name = "comboPriority";
            comboPriority.Size = new Size(246, 28);
            comboPriority.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(60, 293);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 46;
            label4.Text = "Приоритет*";
            // 
            // comboMaster
            // 
            comboMaster.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboMaster.FormattingEnabled = true;
            comboMaster.Location = new Point(204, 336);
            comboMaster.Name = "comboMaster";
            comboMaster.Size = new Size(246, 28);
            comboMaster.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(60, 339);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 48;
            label5.Text = "Ответственный*";
            // 
            // comboClient
            // 
            comboClient.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboClient.FormattingEnabled = true;
            comboClient.Location = new Point(204, 380);
            comboClient.Name = "comboClient";
            comboClient.Size = new Size(246, 28);
            comboClient.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(60, 383);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 50;
            label7.Text = "Клиент*";
            // 
            // EditOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 651);
            Controls.Add(comboClient);
            Controls.Add(label7);
            Controls.Add(comboMaster);
            Controls.Add(label5);
            Controls.Add(comboPriority);
            Controls.Add(label4);
            Controls.Add(comboStatus);
            Controls.Add(label3);
            Controls.Add(comboType);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBoxSerial);
            Controls.Add(buttonCancel);
            Controls.Add(label6);
            Controls.Add(textBoxDesc);
            Controls.Add(labelMalfunction);
            Controls.Add(textBoxProblem);
            Controls.Add(labelEquip);
            Controls.Add(textBoxEquip);
            Controls.Add(buttonEdit);
            MaximumSize = new Size(534, 690);
            MinimumSize = new Size(534, 690);
            Name = "EditOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактировать заказ";
            Load += EditOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBoxSerial;
        private Button buttonCancel;
        private Label label6;
        private TextBox textBoxDesc;
        private Label labelMalfunction;
        private TextBox textBoxProblem;
        private Label labelEquip;
        private TextBox textBoxEquip;
        private Button buttonEdit;
        private ComboBox comboType;
        private Label label1;
        private ComboBox comboStatus;
        private Label label3;
        private ComboBox comboPriority;
        private Label label4;
        private ComboBox comboMaster;
        private Label label5;
        private ComboBox comboClient;
        private Label label7;
    }
}
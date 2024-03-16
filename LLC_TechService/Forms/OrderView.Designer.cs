namespace LLC_TechService.Forms
{
    partial class OrderView
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
            labelID = new Label();
            labelEquip = new Label();
            labelClient = new Label();
            labelMaster = new Label();
            labelStatus = new Label();
            labelPriority = new Label();
            buttonEdit = new Button();
            SuspendLayout();
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Lucida Sans Unicode", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelID.Location = new Point(22, 18);
            labelID.Name = "labelID";
            labelID.Size = new Size(85, 23);
            labelID.TabIndex = 2;
            labelID.Text = "Заказ №";
            // 
            // labelEquip
            // 
            labelEquip.AutoSize = true;
            labelEquip.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEquip.Location = new Point(22, 56);
            labelEquip.Name = "labelEquip";
            labelEquip.Size = new Size(127, 20);
            labelEquip.TabIndex = 3;
            labelEquip.Text = "Оборудование";
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelClient.Location = new Point(22, 92);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(70, 20);
            labelClient.TabIndex = 4;
            labelClient.Text = "Клиент:";
            // 
            // labelMaster
            // 
            labelMaster.AutoSize = true;
            labelMaster.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMaster.Location = new Point(22, 128);
            labelMaster.Name = "labelMaster";
            labelMaster.Size = new Size(73, 20);
            labelMaster.TabIndex = 5;
            labelMaster.Text = "Мастер:";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStatus.Location = new Point(441, 20);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(61, 20);
            labelStatus.TabIndex = 6;
            labelStatus.Text = "Статус";
            // 
            // labelPriority
            // 
            labelPriority.AutoSize = true;
            labelPriority.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPriority.Location = new Point(441, 55);
            labelPriority.Name = "labelPriority";
            labelPriority.Size = new Size(97, 20);
            labelPriority.TabIndex = 7;
            labelPriority.Text = "Приоритет";
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(441, 116);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(275, 32);
            buttonEdit.TabIndex = 8;
            buttonEdit.Text = "Редактировать заказ";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // OrderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(buttonEdit);
            Controls.Add(labelPriority);
            Controls.Add(labelStatus);
            Controls.Add(labelMaster);
            Controls.Add(labelClient);
            Controls.Add(labelEquip);
            Controls.Add(labelID);
            Name = "OrderView";
            Size = new Size(748, 178);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelID;
        private Label labelEquip;
        private Label labelClient;
        private Label labelMaster;
        private Label labelStatus;
        private Label labelPriority;
        private Button buttonEdit;
    }
}

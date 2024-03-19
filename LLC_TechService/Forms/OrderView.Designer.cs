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
            labelDesc = new Label();
            labelProblem = new Label();
            buttonDone = new Button();
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
            labelClient.Location = new Point(22, 167);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(70, 20);
            labelClient.TabIndex = 4;
            labelClient.Text = "Клиент:";
            // 
            // labelMaster
            // 
            labelMaster.AutoSize = true;
            labelMaster.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMaster.Location = new Point(22, 203);
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
            buttonEdit.Location = new Point(441, 155);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(275, 32);
            buttonEdit.TabIndex = 8;
            buttonEdit.Text = "Редактировать заказ";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDesc.ForeColor = Color.FromArgb(64, 64, 64);
            labelDesc.Location = new Point(22, 110);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(88, 20);
            labelDesc.TabIndex = 9;
            labelDesc.Text = "Описание";
            // 
            // labelProblem
            // 
            labelProblem.AutoSize = true;
            labelProblem.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelProblem.Location = new Point(22, 90);
            labelProblem.Name = "labelProblem";
            labelProblem.Size = new Size(80, 20);
            labelProblem.TabIndex = 10;
            labelProblem.Text = "Поломка";
            // 
            // buttonDone
            // 
            buttonDone.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDone.Location = new Point(441, 197);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(275, 32);
            buttonDone.TabIndex = 11;
            buttonDone.Text = "Завершить заказ";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // OrderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(buttonDone);
            Controls.Add(labelProblem);
            Controls.Add(labelDesc);
            Controls.Add(buttonEdit);
            Controls.Add(labelPriority);
            Controls.Add(labelStatus);
            Controls.Add(labelMaster);
            Controls.Add(labelClient);
            Controls.Add(labelEquip);
            Controls.Add(labelID);
            Name = "OrderView";
            Size = new Size(748, 241);
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
        private Label labelDesc;
        private Label labelProblem;
        private Button buttonDone;
    }
}

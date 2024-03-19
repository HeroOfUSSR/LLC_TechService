namespace LLC_TechService.Forms
{
    partial class CreateReport
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            labelMoney = new Label();
            textBoxMoney = new TextBox();
            buttonCancel = new Button();
            buttonEdit = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(60, 159);
            label6.Name = "label6";
            label6.Size = new Size(119, 40);
            label6.TabIndex = 42;
            label6.Text = "Комментарий\r\nк заказу\r\n";
            // 
            // textBoxDesc
            // 
            textBoxDesc.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDesc.Location = new Point(204, 159);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(259, 93);
            textBoxDesc.TabIndex = 41;
            // 
            // labelMalfunction
            // 
            labelMalfunction.AutoSize = true;
            labelMalfunction.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMalfunction.Location = new Point(60, 32);
            labelMalfunction.Name = "labelMalfunction";
            labelMalfunction.Size = new Size(138, 20);
            labelMalfunction.TabIndex = 40;
            labelMalfunction.Text = "Неисправность*\r\n";
            // 
            // textBoxProblem
            // 
            textBoxProblem.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProblem.Location = new Point(204, 32);
            textBoxProblem.Name = "textBoxProblem";
            textBoxProblem.Size = new Size(259, 32);
            textBoxProblem.TabIndex = 39;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(60, 300);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(403, 230);
            flowLayoutPanel1.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 277);
            label1.Name = "label1";
            label1.Size = new Size(218, 20);
            label1.TabIndex = 44;
            label1.Text = "Использованные запчасти";
            // 
            // labelMoney
            // 
            labelMoney.AutoSize = true;
            labelMoney.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMoney.Location = new Point(60, 93);
            labelMoney.Name = "labelMoney";
            labelMoney.Size = new Size(102, 20);
            labelMoney.TabIndex = 46;
            labelMoney.Text = "Стоимость*\r\n";
            // 
            // textBoxMoney
            // 
            textBoxMoney.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMoney.Location = new Point(204, 93);
            textBoxMoney.Name = "textBoxMoney";
            textBoxMoney.Size = new Size(259, 32);
            textBoxMoney.TabIndex = 45;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(88, 591);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(348, 34);
            buttonCancel.TabIndex = 48;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(88, 551);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(348, 34);
            buttonEdit.TabIndex = 47;
            buttonEdit.Text = "Завершить заказ";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // CreateReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 634);
            Controls.Add(buttonCancel);
            Controls.Add(buttonEdit);
            Controls.Add(labelMoney);
            Controls.Add(textBoxMoney);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label6);
            Controls.Add(textBoxDesc);
            Controls.Add(labelMalfunction);
            Controls.Add(textBoxProblem);
            Name = "CreateReport";
            Text = "Оформление отчётности";
            Load += CreateReport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox textBoxDesc;
        private Label labelMalfunction;
        private TextBox textBoxProblem;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label labelMoney;
        private TextBox textBoxMoney;
        private Button buttonCancel;
        private Button buttonEdit;
    }
}
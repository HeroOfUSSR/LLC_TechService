namespace LLC_TechService.Forms
{
    partial class Registration
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
            buttonReg = new Button();
            label2 = new Label();
            textBoxPassword = new TextBox();
            label1 = new Label();
            textBoxLogin = new TextBox();
            label3 = new Label();
            textBoxRepeat = new TextBox();
            buttonCancel = new Button();
            label4 = new Label();
            textBoxSurname = new TextBox();
            label5 = new Label();
            textBoxName = new TextBox();
            label6 = new Label();
            textBoxPatronimyc = new TextBox();
            SuspendLayout();
            // 
            // buttonReg
            // 
            buttonReg.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReg.Location = new Point(76, 384);
            buttonReg.Name = "buttonReg";
            buttonReg.Size = new Size(348, 34);
            buttonReg.TabIndex = 10;
            buttonReg.Text = "Зарегистрироваться";
            buttonReg.UseVisualStyleBackColor = true;
            buttonReg.Click += buttonReg_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(76, 252);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 9;
            label2.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(178, 249);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(246, 32);
            textBoxPassword.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 200);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 7;
            label1.Text = "Логин";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(178, 197);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(246, 32);
            textBoxLogin.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(76, 301);
            label3.Name = "label3";
            label3.Size = new Size(100, 40);
            label3.TabIndex = 12;
            label3.Text = "Повторите \r\nпароль";
            // 
            // textBoxRepeat
            // 
            textBoxRepeat.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRepeat.Location = new Point(178, 301);
            textBoxRepeat.Name = "textBoxRepeat";
            textBoxRepeat.PasswordChar = '*';
            textBoxRepeat.Size = new Size(246, 32);
            textBoxRepeat.TabIndex = 11;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(76, 424);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(348, 34);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(76, 97);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 17;
            label4.Text = "Фамилия";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSurname.Location = new Point(178, 94);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(246, 32);
            textBoxSurname.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(76, 45);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 15;
            label5.Text = "Имя";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(178, 42);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(246, 32);
            textBoxName.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(76, 147);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 19;
            label6.Text = "Отчество";
            // 
            // textBoxPatronimyc
            // 
            textBoxPatronimyc.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatronimyc.Location = new Point(178, 144);
            textBoxPatronimyc.Name = "textBoxPatronimyc";
            textBoxPatronimyc.Size = new Size(246, 32);
            textBoxPatronimyc.TabIndex = 18;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 479);
            Controls.Add(label6);
            Controls.Add(textBoxPatronimyc);
            Controls.Add(label4);
            Controls.Add(textBoxSurname);
            Controls.Add(label5);
            Controls.Add(textBoxName);
            Controls.Add(buttonCancel);
            Controls.Add(label3);
            Controls.Add(textBoxRepeat);
            Controls.Add(buttonReg);
            Controls.Add(label2);
            Controls.Add(textBoxPassword);
            Controls.Add(label1);
            Controls.Add(textBoxLogin);
            Name = "Registration";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReg;
        private Label label2;
        private TextBox textBoxPassword;
        private Label label1;
        private TextBox textBoxLogin;
        private Label label3;
        private TextBox textBoxRepeat;
        private Button buttonCancel;
        private Label label4;
        private TextBox textBoxSurname;
        private Label label5;
        private TextBox textBoxName;
        private Label label6;
        private TextBox textBoxPatronimyc;
    }
}
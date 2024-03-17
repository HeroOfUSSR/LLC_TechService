namespace LLC_TechService.Forms
{
    partial class Login
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
            logintextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            passwordtextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // logintextBox
            // 
            logintextBox.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logintextBox.Location = new Point(151, 86);
            logintextBox.Name = "logintextBox";
            logintextBox.Size = new Size(246, 32);
            logintextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 89);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 1;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 142);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // passwordtextBox
            // 
            passwordtextBox.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordtextBox.Location = new Point(151, 139);
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.PasswordChar = '*';
            passwordtextBox.Size = new Size(246, 32);
            passwordtextBox.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Sans Unicode", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(49, 222);
            button1.Name = "button1";
            button1.Size = new Size(348, 34);
            button1.TabIndex = 4;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(49, 262);
            button2.Name = "button2";
            button2.Size = new Size(348, 34);
            button2.TabIndex = 5;
            button2.Text = "Зарегистрироваться";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 328);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(passwordtextBox);
            Controls.Add(label1);
            Controls.Add(logintextBox);
            MaximumSize = new Size(456, 367);
            MinimumSize = new Size(456, 367);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox logintextBox;
        private Label label1;
        private Label label2;
        private TextBox passwordtextBox;
        private Button button1;
        private Button button2;
    }
}
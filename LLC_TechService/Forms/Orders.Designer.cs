namespace LLC_TechService.Forms
{
    partial class Orders
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
            panel1 = new Panel();
            buttonLogout = new Button();
            buttonRefresh = new Button();
            labelUser = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            buttonCreate = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(buttonLogout);
            panel1.Controls.Add(buttonRefresh);
            panel1.Controls.Add(labelUser);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 102);
            panel1.TabIndex = 0;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = SystemColors.Control;
            buttonLogout.BackgroundImage = Properties.Resources.Logout;
            buttonLogout.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogout.Location = new Point(930, 9);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(35, 32);
            buttonLogout.TabIndex = 13;
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = SystemColors.Control;
            buttonRefresh.BackgroundImage = Properties.Resources._211882_refresh_icon;
            buttonRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRefresh.Location = new Point(930, 64);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(35, 32);
            buttonRefresh.TabIndex = 12;
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUser.Location = new Point(12, 9);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(123, 20);
            labelUser.TabIndex = 6;
            labelUser.Text = "Пользователь:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 420);
            panel2.Name = "panel2";
            panel2.Size = new Size(974, 41);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(buttonCreate);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(774, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 318);
            panel3.TabIndex = 2;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = SystemColors.Control;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.Location = new Point(6, 6);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(185, 32);
            buttonCreate.TabIndex = 10;
            buttonCreate.Text = "Создать заказ";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 102);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(774, 318);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 461);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(990, 900);
            MinimumSize = new Size(990, 400);
            Name = "Orders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заказы";
            Load += Orders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelUser;
        private Button buttonCreate;
        private Button buttonLogout;
        private Button buttonRefresh;
    }
}
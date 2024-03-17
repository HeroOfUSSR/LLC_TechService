namespace LLC_TechService.Forms
{
    partial class ClientMenu
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
            buttonCreate = new Button();
            labelClient = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(buttonLogout);
            panel1.Controls.Add(buttonRefresh);
            panel1.Controls.Add(buttonCreate);
            panel1.Controls.Add(labelClient);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 118);
            panel1.TabIndex = 0;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = SystemColors.Control;
            buttonLogout.BackgroundImage = Properties.Resources.Logout;
            buttonLogout.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogout.Location = new Point(709, 9);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(35, 32);
            buttonLogout.TabIndex = 11;
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
            buttonRefresh.Location = new Point(709, 77);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(35, 32);
            buttonRefresh.TabIndex = 10;
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = SystemColors.Control;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.Location = new Point(229, 77);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(275, 32);
            buttonCreate.TabIndex = 9;
            buttonCreate.Text = "Оформить заказ";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelClient.Location = new Point(12, 9);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(70, 20);
            labelClient.TabIndex = 5;
            labelClient.Text = "Клиент:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 118);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(756, 343);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // ClientMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 461);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            MaximumSize = new Size(772, 900);
            MinimumSize = new Size(772, 300);
            Name = "ClientMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Личный кабинет";
            Load += ClientMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelClient;
        private Button buttonCreate;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonRefresh;
        private Button buttonLogout;
    }
}
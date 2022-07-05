namespace PBL3
{
    partial class MainForm
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.logOutButton = new FontAwesome.Sharp.IconButton();
            this.billButton = new FontAwesome.Sharp.IconButton();
            this.orderServiceButton = new FontAwesome.Sharp.IconButton();
            this.serviceButton = new FontAwesome.Sharp.IconButton();
            this.employeeButton = new FontAwesome.Sharp.IconButton();
            this.roomButton = new FontAwesome.Sharp.IconButton();
            this.reservationButton = new FontAwesome.Sharp.IconButton();
            this.dashboardButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.minimizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.maximizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new Guna.UI2.WinForms.Guna2Panel();
            this.menuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.menuPanel.Controls.Add(this.logOutButton);
            this.menuPanel.Controls.Add(this.billButton);
            this.menuPanel.Controls.Add(this.orderServiceButton);
            this.menuPanel.Controls.Add(this.serviceButton);
            this.menuPanel.Controls.Add(this.employeeButton);
            this.menuPanel.Controls.Add(this.roomButton);
            this.menuPanel.Controls.Add(this.reservationButton);
            this.menuPanel.Controls.Add(this.dashboardButton);
            this.menuPanel.Controls.Add(this.panel1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(220, 842);
            this.menuPanel.TabIndex = 0;
            // 
            // logOutButton
            // 
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.logOutButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.logOutButton.IconColor = System.Drawing.Color.Black;
            this.logOutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logOutButton.IconSize = 32;
            this.logOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.Location = new System.Drawing.Point(0, 560);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.logOutButton.Size = new System.Drawing.Size(220, 60);
            this.logOutButton.TabIndex = 8;
            this.logOutButton.Text = "Log out";
            this.logOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click_1);
            // 
            // billButton
            // 
            this.billButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.billButton.FlatAppearance.BorderSize = 0;
            this.billButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.billButton.IconChar = FontAwesome.Sharp.IconChar.Paypal;
            this.billButton.IconColor = System.Drawing.Color.Black;
            this.billButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.billButton.IconSize = 32;
            this.billButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billButton.Location = new System.Drawing.Point(0, 500);
            this.billButton.Name = "billButton";
            this.billButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.billButton.Size = new System.Drawing.Size(220, 60);
            this.billButton.TabIndex = 7;
            this.billButton.Text = "Bills";
            this.billButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // orderServiceButton
            // 
            this.orderServiceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderServiceButton.FlatAppearance.BorderSize = 0;
            this.orderServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderServiceButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.orderServiceButton.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.orderServiceButton.IconColor = System.Drawing.Color.Black;
            this.orderServiceButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.orderServiceButton.IconSize = 32;
            this.orderServiceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderServiceButton.Location = new System.Drawing.Point(0, 440);
            this.orderServiceButton.Name = "orderServiceButton";
            this.orderServiceButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.orderServiceButton.Size = new System.Drawing.Size(220, 60);
            this.orderServiceButton.TabIndex = 6;
            this.orderServiceButton.Text = "Order Service";
            this.orderServiceButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderServiceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.orderServiceButton.UseVisualStyleBackColor = true;
            this.orderServiceButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // serviceButton
            // 
            this.serviceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.serviceButton.FlatAppearance.BorderSize = 0;
            this.serviceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.serviceButton.IconChar = FontAwesome.Sharp.IconChar.ConciergeBell;
            this.serviceButton.IconColor = System.Drawing.Color.Black;
            this.serviceButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.serviceButton.IconSize = 32;
            this.serviceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serviceButton.Location = new System.Drawing.Point(0, 380);
            this.serviceButton.Name = "serviceButton";
            this.serviceButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.serviceButton.Size = new System.Drawing.Size(220, 60);
            this.serviceButton.TabIndex = 5;
            this.serviceButton.Text = "Service";
            this.serviceButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serviceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.serviceButton.UseVisualStyleBackColor = true;
            this.serviceButton.Click += new System.EventHandler(this.serviceButton_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeButton.FlatAppearance.BorderSize = 0;
            this.employeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.employeeButton.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.employeeButton.IconColor = System.Drawing.Color.Black;
            this.employeeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.employeeButton.IconSize = 32;
            this.employeeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeButton.Location = new System.Drawing.Point(0, 320);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.employeeButton.Size = new System.Drawing.Size(220, 60);
            this.employeeButton.TabIndex = 4;
            this.employeeButton.Text = "Employee";
            this.employeeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.employeeButton.UseVisualStyleBackColor = true;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // roomButton
            // 
            this.roomButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomButton.FlatAppearance.BorderSize = 0;
            this.roomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.roomButton.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.roomButton.IconColor = System.Drawing.Color.Black;
            this.roomButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roomButton.IconSize = 32;
            this.roomButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomButton.Location = new System.Drawing.Point(0, 260);
            this.roomButton.Name = "roomButton";
            this.roomButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.roomButton.Size = new System.Drawing.Size(220, 60);
            this.roomButton.TabIndex = 3;
            this.roomButton.Text = "Room";
            this.roomButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roomButton.UseVisualStyleBackColor = true;
            this.roomButton.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // reservationButton
            // 
            this.reservationButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reservationButton.FlatAppearance.BorderSize = 0;
            this.reservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservationButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.reservationButton.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.reservationButton.IconColor = System.Drawing.Color.Black;
            this.reservationButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reservationButton.IconSize = 32;
            this.reservationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reservationButton.Location = new System.Drawing.Point(0, 200);
            this.reservationButton.Name = "reservationButton";
            this.reservationButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.reservationButton.Size = new System.Drawing.Size(220, 60);
            this.reservationButton.TabIndex = 2;
            this.reservationButton.Text = "Reservation";
            this.reservationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reservationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reservationButton.UseVisualStyleBackColor = true;
            this.reservationButton.Click += new System.EventHandler(this.reservationButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.dashboardButton.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.dashboardButton.IconColor = System.Drawing.Color.Black;
            this.dashboardButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboardButton.IconSize = 32;
            this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.Location = new System.Drawing.Point(0, 140);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.dashboardButton.Size = new System.Drawing.Size(220, 60);
            this.dashboardButton.TabIndex = 1;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panel1.Size = new System.Drawing.Size(220, 140);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::PBL3.Properties.Resources.hotel;
            this.btnHome.Location = new System.Drawing.Point(12, 29);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(185, 92);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.minimizeButton);
            this.panelTitleBar.Controls.Add(this.maximizeButton);
            this.panelTitleBar.Controls.Add(this.exitButton);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1207, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minimizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minimizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minimizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minimizeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Image = global::PBL3.Properties.Resources.remove;
            this.minimizeButton.Location = new System.Drawing.Point(1110, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(32, 32);
            this.minimizeButton.TabIndex = 4;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.maximizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.maximizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.maximizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.maximizeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.maximizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maximizeButton.ForeColor = System.Drawing.Color.White;
            this.maximizeButton.Image = global::PBL3.Properties.Resources.expand_arrows;
            this.maximizeButton.Location = new System.Drawing.Point(1148, 0);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(32, 32);
            this.maximizeButton.TabIndex = 3;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = global::PBL3.Properties.Resources.x;
            this.exitButton.Location = new System.Drawing.Point(1175, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(32, 32);
            this.exitButton.TabIndex = 2;
            this.exitButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(45, 40);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(44, 16);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumOrchid;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumOrchid;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(7, 40);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1207, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1207, 758);
            this.panelDesktop.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1427, 842);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.menuPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private FontAwesome.Sharp.IconButton orderServiceButton;
        private FontAwesome.Sharp.IconButton serviceButton;
        private FontAwesome.Sharp.IconButton employeeButton;
        private FontAwesome.Sharp.IconButton roomButton;
        private FontAwesome.Sharp.IconButton reservationButton;
        private FontAwesome.Sharp.IconButton dashboardButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private Guna.UI2.WinForms.Guna2Panel panelDesktop;
        private Guna.UI2.WinForms.Guna2Button exitButton;
        private Guna.UI2.WinForms.Guna2Button maximizeButton;
        private Guna.UI2.WinForms.Guna2Button minimizeButton;
        private FontAwesome.Sharp.IconButton logOutButton;
        private FontAwesome.Sharp.IconButton billButton;
    }
}
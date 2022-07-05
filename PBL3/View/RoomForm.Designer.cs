namespace PBL3.Forms
{
    partial class RoomForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roomDTG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.searchButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.showButton = new FontAwesome.Sharp.IconButton();
            this.addButton = new FontAwesome.Sharp.IconButton();
            this.updateButton = new FontAwesome.Sharp.IconButton();
            this.deleteButton = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.roomTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.pricecomboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.typeRoomCBB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.statusCBB = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomDTG)).BeginInit();
            this.SuspendLayout();
            // 
            // roomDTG
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.roomDTG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.roomDTG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomDTG.BackgroundColor = System.Drawing.Color.White;
            this.roomDTG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomDTG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.roomDTG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomDTG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.roomDTG.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomDTG.DefaultCellStyle = dataGridViewCellStyle9;
            this.roomDTG.EnableHeadersVisualStyles = false;
            this.roomDTG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomDTG.Location = new System.Drawing.Point(64, 217);
            this.roomDTG.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.roomDTG.Name = "roomDTG";
            this.roomDTG.RowHeadersVisible = false;
            this.roomDTG.RowHeadersWidth = 51;
            this.roomDTG.RowTemplate.Height = 24;
            this.roomDTG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomDTG.Size = new System.Drawing.Size(811, 259);
            this.roomDTG.TabIndex = 0;
            this.roomDTG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.roomDTG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.roomDTG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.roomDTG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.roomDTG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.roomDTG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.roomDTG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomDTG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.roomDTG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.roomDTG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.roomDTG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.roomDTG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.roomDTG.ThemeStyle.HeaderStyle.Height = 4;
            this.roomDTG.ThemeStyle.ReadOnly = false;
            this.roomDTG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.roomDTG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.roomDTG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.roomDTG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.roomDTG.ThemeStyle.RowsStyle.Height = 24;
            this.roomDTG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomDTG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.LightSalmon;
            this.searchButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchButton.IconColor = System.Drawing.Color.LightSalmon;
            this.searchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchButton.IconSize = 35;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.Location = new System.Drawing.Point(748, 93);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.searchButton.Size = new System.Drawing.Size(145, 50);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSalmon;
            this.label1.Location = new System.Drawing.Point(60, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Room";
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.ForeColor = System.Drawing.Color.LightSalmon;
            this.showButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.showButton.IconColor = System.Drawing.Color.LightSalmon;
            this.showButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.showButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showButton.Location = new System.Drawing.Point(64, 546);
            this.showButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.showButton.Name = "showButton";
            this.showButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.showButton.Size = new System.Drawing.Size(124, 47);
            this.showButton.TabIndex = 5;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.LightSalmon;
            this.addButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addButton.IconColor = System.Drawing.Color.LightSalmon;
            this.addButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addButton.IconSize = 35;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(236, 546);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.addButton.Size = new System.Drawing.Size(159, 47);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.LightSalmon;
            this.updateButton.IconChar = FontAwesome.Sharp.IconChar.PencilRuler;
            this.updateButton.IconColor = System.Drawing.Color.LightSalmon;
            this.updateButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updateButton.IconSize = 35;
            this.updateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateButton.Location = new System.Drawing.Point(449, 546);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.updateButton.Name = "updateButton";
            this.updateButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.updateButton.Size = new System.Drawing.Size(159, 47);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.LightSalmon;
            this.deleteButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.deleteButton.IconColor = System.Drawing.Color.LightSalmon;
            this.deleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteButton.IconSize = 35;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Location = new System.Drawing.Point(661, 546);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.deleteButton.Size = new System.Drawing.Size(159, 47);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSalmon;
            this.label2.Location = new System.Drawing.Point(404, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = "Type Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSalmon;
            this.label3.Location = new System.Drawing.Point(404, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status Room";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.LightSalmon;
            this.Price.Location = new System.Drawing.Point(60, 135);
            this.Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(48, 20);
            this.Price.TabIndex = 12;
            this.Price.Text = "Price";
            // 
            // roomTxt
            // 
            this.roomTxt.AutoRoundedCorners = true;
            this.roomTxt.BorderRadius = 15;
            this.roomTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomTxt.DefaultText = "";
            this.roomTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.roomTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.roomTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.roomTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomTxt.Location = new System.Drawing.Point(147, 61);
            this.roomTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roomTxt.Name = "roomTxt";
            this.roomTxt.PasswordChar = '\0';
            this.roomTxt.PlaceholderText = "";
            this.roomTxt.SelectedText = "";
            this.roomTxt.Size = new System.Drawing.Size(200, 32);
            this.roomTxt.TabIndex = 14;
            // 
            // pricecomboBox
            // 
            this.pricecomboBox.AutoRoundedCorners = true;
            this.pricecomboBox.BackColor = System.Drawing.Color.Transparent;
            this.pricecomboBox.BorderRadius = 17;
            this.pricecomboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.pricecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pricecomboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pricecomboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pricecomboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pricecomboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.pricecomboBox.ItemHeight = 30;
            this.pricecomboBox.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.pricecomboBox.Location = new System.Drawing.Point(147, 135);
            this.pricecomboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pricecomboBox.Name = "pricecomboBox";
            this.pricecomboBox.Size = new System.Drawing.Size(200, 36);
            this.pricecomboBox.TabIndex = 15;
            // 
            // typeRoomCBB
            // 
            this.typeRoomCBB.AutoRoundedCorners = true;
            this.typeRoomCBB.BackColor = System.Drawing.Color.Transparent;
            this.typeRoomCBB.BorderRadius = 17;
            this.typeRoomCBB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.typeRoomCBB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeRoomCBB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.typeRoomCBB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.typeRoomCBB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.typeRoomCBB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.typeRoomCBB.ItemHeight = 30;
            this.typeRoomCBB.Location = new System.Drawing.Point(517, 59);
            this.typeRoomCBB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.typeRoomCBB.Name = "typeRoomCBB";
            this.typeRoomCBB.Size = new System.Drawing.Size(200, 36);
            this.typeRoomCBB.TabIndex = 16;
            // 
            // statusCBB
            // 
            this.statusCBB.AutoRoundedCorners = true;
            this.statusCBB.BackColor = System.Drawing.Color.Transparent;
            this.statusCBB.BorderRadius = 17;
            this.statusCBB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusCBB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCBB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusCBB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusCBB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusCBB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.statusCBB.ItemHeight = 30;
            this.statusCBB.Location = new System.Drawing.Point(517, 135);
            this.statusCBB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusCBB.Name = "statusCBB";
            this.statusCBB.Size = new System.Drawing.Size(200, 36);
            this.statusCBB.TabIndex = 17;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1189, 711);
            this.Controls.Add(this.statusCBB);
            this.Controls.Add(this.typeRoomCBB);
            this.Controls.Add(this.pricecomboBox);
            this.Controls.Add(this.roomTxt);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.roomDTG);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSalmon;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "RoomForm";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Text = "Room";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomDTG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView roomDTG;
        private FontAwesome.Sharp.IconButton searchButton;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton showButton;
        private FontAwesome.Sharp.IconButton addButton;
        private FontAwesome.Sharp.IconButton updateButton;
        private FontAwesome.Sharp.IconButton deleteButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Price;
        private Guna.UI2.WinForms.Guna2TextBox roomTxt;
        private Guna.UI2.WinForms.Guna2ComboBox pricecomboBox;
        private Guna.UI2.WinForms.Guna2ComboBox typeRoomCBB;
        private Guna.UI2.WinForms.Guna2ComboBox statusCBB;
    }
}
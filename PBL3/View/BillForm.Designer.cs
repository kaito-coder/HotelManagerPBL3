namespace PBL3.View
{
    partial class BillForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.billDTG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID_Reservation = new System.Windows.Forms.Label();
            this.idReservationTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.isPaidCheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.unPaidCheckbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.exportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.billDTG)).BeginInit();
            this.SuspendLayout();
            // 
            // billDTG
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.billDTG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.billDTG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billDTG.BackgroundColor = System.Drawing.Color.White;
            this.billDTG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.billDTG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.billDTG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billDTG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.billDTG.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(214)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.billDTG.DefaultCellStyle = dataGridViewCellStyle3;
            this.billDTG.EnableHeadersVisualStyles = false;
            this.billDTG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.billDTG.Location = new System.Drawing.Point(28, 131);
            this.billDTG.Name = "billDTG";
            this.billDTG.RowHeadersVisible = false;
            this.billDTG.RowHeadersWidth = 51;
            this.billDTG.RowTemplate.Height = 24;
            this.billDTG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billDTG.Size = new System.Drawing.Size(1128, 229);
            this.billDTG.TabIndex = 0;
            this.billDTG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.billDTG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.billDTG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.billDTG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.billDTG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.billDTG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.billDTG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.billDTG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.billDTG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.billDTG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.billDTG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.billDTG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.billDTG.ThemeStyle.HeaderStyle.Height = 4;
            this.billDTG.ThemeStyle.ReadOnly = false;
            this.billDTG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.billDTG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.billDTG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.billDTG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.billDTG.ThemeStyle.RowsStyle.Height = 24;
            this.billDTG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.billDTG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ID_Reservation
            // 
            this.ID_Reservation.AutoSize = true;
            this.ID_Reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Reservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(214)))), ((int)(((byte)(188)))));
            this.ID_Reservation.Location = new System.Drawing.Point(66, 38);
            this.ID_Reservation.Name = "ID_Reservation";
            this.ID_Reservation.Size = new System.Drawing.Size(124, 20);
            this.ID_Reservation.TabIndex = 1;
            this.ID_Reservation.Text = "ID_Reservation";
            // 
            // idReservationTxt
            // 
            this.idReservationTxt.AutoRoundedCorners = true;
            this.idReservationTxt.BorderRadius = 17;
            this.idReservationTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idReservationTxt.DefaultText = "";
            this.idReservationTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idReservationTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idReservationTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idReservationTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idReservationTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idReservationTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idReservationTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idReservationTxt.Location = new System.Drawing.Point(261, 27);
            this.idReservationTxt.Name = "idReservationTxt";
            this.idReservationTxt.PasswordChar = '\0';
            this.idReservationTxt.PlaceholderText = "";
            this.idReservationTxt.SelectedText = "";
            this.idReservationTxt.Size = new System.Drawing.Size(200, 36);
            this.idReservationTxt.TabIndex = 2;
            // 
            // showButton
            // 
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(214)))), ((int)(((byte)(188)))));
            this.showButton.Location = new System.Drawing.Point(300, 440);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(90, 46);
            this.showButton.TabIndex = 5;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(214)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(648, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Paid";
            // 
            // isPaidCheckBox1
            // 
            this.isPaidCheckBox1.AutoSize = true;
            this.isPaidCheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.isPaidCheckBox1.CheckedState.BorderRadius = 0;
            this.isPaidCheckBox1.CheckedState.BorderThickness = 0;
            this.isPaidCheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.isPaidCheckBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isPaidCheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(214)))), ((int)(((byte)(188)))));
            this.isPaidCheckBox1.Location = new System.Drawing.Point(743, 36);
            this.isPaidCheckBox1.Name = "isPaidCheckBox1";
            this.isPaidCheckBox1.Size = new System.Drawing.Size(82, 27);
            this.isPaidCheckBox1.TabIndex = 9;
            this.isPaidCheckBox1.Text = "Is paid";
            this.isPaidCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.isPaidCheckBox1.UncheckedState.BorderRadius = 0;
            this.isPaidCheckBox1.UncheckedState.BorderThickness = 0;
            this.isPaidCheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // unPaidCheckbox
            // 
            this.unPaidCheckbox.AutoSize = true;
            this.unPaidCheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unPaidCheckbox.CheckedState.BorderRadius = 0;
            this.unPaidCheckbox.CheckedState.BorderThickness = 0;
            this.unPaidCheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unPaidCheckbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unPaidCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(214)))), ((int)(((byte)(188)))));
            this.unPaidCheckbox.Location = new System.Drawing.Point(859, 36);
            this.unPaidCheckbox.Name = "unPaidCheckbox";
            this.unPaidCheckbox.Size = new System.Drawing.Size(92, 27);
            this.unPaidCheckbox.TabIndex = 10;
            this.unPaidCheckbox.Text = "Un paid";
            this.unPaidCheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.unPaidCheckbox.UncheckedState.BorderRadius = 0;
            this.unPaidCheckbox.UncheckedState.BorderThickness = 0;
            this.unPaidCheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // exportButton
            // 
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(214)))), ((int)(((byte)(188)))));
            this.exportButton.Location = new System.Drawing.Point(632, 440);
            this.exportButton.Name = "exportButton";
            this.exportButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.exportButton.Size = new System.Drawing.Size(109, 46);
            this.exportButton.TabIndex = 11;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1189, 711);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.unPaidCheckbox);
            this.Controls.Add(this.isPaidCheckBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.idReservationTxt);
            this.Controls.Add(this.ID_Reservation);
            this.Controls.Add(this.billDTG);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(214)))), ((int)(((byte)(188)))));
            this.Name = "BillForm";
            this.Text = "BillForm";
            this.Load += new System.EventHandler(this.BillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billDTG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView billDTG;
        private System.Windows.Forms.Label ID_Reservation;
        private Guna.UI2.WinForms.Guna2TextBox idReservationTxt;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox isPaidCheckBox1;
        private Guna.UI2.WinForms.Guna2CheckBox unPaidCheckbox;
        private System.Windows.Forms.Button exportButton;
    }
}
namespace PBL3.View
{
    partial class DashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.startDateDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.endDateDTP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.thisMonthButton = new FontAwesome.Sharp.IconButton();
            this.todayButton = new FontAwesome.Sharp.IconButton();
            this.last7DaysButton = new FontAwesome.Sharp.IconButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.numberOfReservationlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.totalRevenuelabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.totalProfitlable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grossRevenuechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.numberOfRoomLable = new System.Windows.Forms.Label();
            this.numberOfemployeeLable = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numberOfServiceLable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chartTopProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.okButton = new FontAwesome.Sharp.IconButton();
            this.customButton = new FontAwesome.Sharp.IconButton();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grossRevenuechart)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.Checked = true;
            this.startDateDateTimePicker.CustomFormat = "MMM dd, yyyy";
            this.startDateDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateDateTimePicker.Location = new System.Drawing.Point(33, 13);
            this.startDateDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.startDateDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(200, 30);
            this.startDateDateTimePicker.TabIndex = 0;
            this.startDateDateTimePicker.Value = new System.DateTime(2022, 6, 11, 15, 16, 7, 954);
            // 
            // endDateDTP
            // 
            this.endDateDTP.Checked = true;
            this.endDateDTP.CustomFormat = "MMM dd, yyyy";
            this.endDateDTP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.endDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateDTP.Location = new System.Drawing.Point(321, 13);
            this.endDateDTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.endDateDTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.endDateDTP.Name = "endDateDTP";
            this.endDateDTP.Size = new System.Drawing.Size(200, 30);
            this.endDateDTP.TabIndex = 1;
            this.endDateDTP.Value = new System.DateTime(2022, 6, 11, 15, 16, 7, 954);
            // 
            // thisMonthButton
            // 
            this.thisMonthButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.thisMonthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thisMonthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thisMonthButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.thisMonthButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.thisMonthButton.IconColor = System.Drawing.Color.Black;
            this.thisMonthButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.thisMonthButton.Location = new System.Drawing.Point(1042, 2);
            this.thisMonthButton.Name = "thisMonthButton";
            this.thisMonthButton.Size = new System.Drawing.Size(135, 53);
            this.thisMonthButton.TabIndex = 2;
            this.thisMonthButton.Text = "This month";
            this.thisMonthButton.UseVisualStyleBackColor = true;
            this.thisMonthButton.Click += new System.EventHandler(this.thisMonthButton_Click);
            // 
            // todayButton
            // 
            this.todayButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.todayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.todayButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.todayButton.IconColor = System.Drawing.Color.Black;
            this.todayButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.todayButton.Location = new System.Drawing.Point(760, 2);
            this.todayButton.Name = "todayButton";
            this.todayButton.Size = new System.Drawing.Size(135, 53);
            this.todayButton.TabIndex = 4;
            this.todayButton.Text = "Today";
            this.todayButton.UseVisualStyleBackColor = true;
            this.todayButton.Click += new System.EventHandler(this.todayButton_Click);
            // 
            // last7DaysButton
            // 
            this.last7DaysButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.last7DaysButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.last7DaysButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last7DaysButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.last7DaysButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.last7DaysButton.IconColor = System.Drawing.Color.Black;
            this.last7DaysButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.last7DaysButton.Location = new System.Drawing.Point(901, 2);
            this.last7DaysButton.Name = "last7DaysButton";
            this.last7DaysButton.Size = new System.Drawing.Size(135, 53);
            this.last7DaysButton.TabIndex = 5;
            this.last7DaysButton.Text = "Last 7 days";
            this.last7DaysButton.UseVisualStyleBackColor = true;
            this.last7DaysButton.Click += new System.EventHandler(this.last7DaysButton_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.guna2Panel1.Controls.Add(this.numberOfReservationlabel);
            this.guna2Panel1.Location = new System.Drawing.Point(33, 82);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(200, 57);
            this.guna2Panel1.TabIndex = 7;
            // 
            // numberOfReservationlabel
            // 
            this.numberOfReservationlabel.AutoEllipsis = true;
            this.numberOfReservationlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.numberOfReservationlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfReservationlabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.numberOfReservationlabel.Location = new System.Drawing.Point(58, 24);
            this.numberOfReservationlabel.Name = "numberOfReservationlabel";
            this.numberOfReservationlabel.Size = new System.Drawing.Size(128, 33);
            this.numberOfReservationlabel.TabIndex = 1;
            this.numberOfReservationlabel.Text = "1000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(32, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Reservations";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.guna2Panel2.Controls.Add(this.totalRevenuelabel);
            this.guna2Panel2.Location = new System.Drawing.Point(252, 82);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(203, 57);
            this.guna2Panel2.TabIndex = 8;
            // 
            // totalRevenuelabel
            // 
            this.totalRevenuelabel.AutoEllipsis = true;
            this.totalRevenuelabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRevenuelabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.totalRevenuelabel.Location = new System.Drawing.Point(58, 24);
            this.totalRevenuelabel.Name = "totalRevenuelabel";
            this.totalRevenuelabel.Size = new System.Drawing.Size(130, 33);
            this.totalRevenuelabel.TabIndex = 1;
            this.totalRevenuelabel.Text = "1000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(274, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Revenue";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(463, 95);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel1.TabIndex = 9;
            this.guna2HtmlLabel1.Text = null;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.guna2Panel3.Controls.Add(this.totalProfitlable);
            this.guna2Panel3.Location = new System.Drawing.Point(472, 82);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(705, 57);
            this.guna2Panel3.TabIndex = 10;
            // 
            // totalProfitlable
            // 
            this.totalProfitlable.AutoEllipsis = true;
            this.totalProfitlable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.totalProfitlable.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProfitlable.ForeColor = System.Drawing.Color.Gainsboro;
            this.totalProfitlable.Location = new System.Drawing.Point(38, 24);
            this.totalProfitlable.Name = "totalProfitlable";
            this.totalProfitlable.Size = new System.Drawing.Size(137, 33);
            this.totalProfitlable.TabIndex = 1;
            this.totalProfitlable.Text = "1000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(490, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Profit";
            // 
            // grossRevenuechart
            // 
            this.grossRevenuechart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineWidth = 0;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorGrid.LineWidth = 0;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea3.AxisX.MajorTickMark.Size = 3F;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.LabelStyle.Format = "${0:0,}K";
            chartArea3.AxisY.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.AxisY.LineWidth = 0;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea3.Name = "ChartArea1";
            this.grossRevenuechart.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            legend3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.grossRevenuechart.Legends.Add(legend3);
            this.grossRevenuechart.Location = new System.Drawing.Point(33, 158);
            this.grossRevenuechart.Name = "grossRevenuechart";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            series3.Legend = "Legend1";
            series3.MarkerSize = 10;
            series3.Name = "Series1";
            this.grossRevenuechart.Series.Add(series3);
            this.grossRevenuechart.Size = new System.Drawing.Size(820, 300);
            this.grossRevenuechart.TabIndex = 11;
            this.grossRevenuechart.Text = "chart1";
            title3.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title3.Name = "Title1";
            title3.Text = "Gross Revenue";
            this.grossRevenuechart.Titles.Add(title3);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.guna2Panel4.Controls.Add(this.numberOfRoomLable);
            this.guna2Panel4.Controls.Add(this.numberOfemployeeLable);
            this.guna2Panel4.Controls.Add(this.label11);
            this.guna2Panel4.Controls.Add(this.label10);
            this.guna2Panel4.Controls.Add(this.numberOfServiceLable);
            this.guna2Panel4.Controls.Add(this.label8);
            this.guna2Panel4.Controls.Add(this.label7);
            this.guna2Panel4.Location = new System.Drawing.Point(278, 471);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(285, 228);
            this.guna2Panel4.TabIndex = 13;
            // 
            // numberOfRoomLable
            // 
            this.numberOfRoomLable.AutoEllipsis = true;
            this.numberOfRoomLable.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfRoomLable.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.numberOfRoomLable.Location = new System.Drawing.Point(43, 182);
            this.numberOfRoomLable.Name = "numberOfRoomLable";
            this.numberOfRoomLable.Size = new System.Drawing.Size(223, 36);
            this.numberOfRoomLable.TabIndex = 17;
            this.numberOfRoomLable.Text = "1000000";
            // 
            // numberOfemployeeLable
            // 
            this.numberOfemployeeLable.AutoEllipsis = true;
            this.numberOfemployeeLable.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfemployeeLable.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.numberOfemployeeLable.Location = new System.Drawing.Point(43, 121);
            this.numberOfemployeeLable.Name = "numberOfemployeeLable";
            this.numberOfemployeeLable.Size = new System.Drawing.Size(198, 39);
            this.numberOfemployeeLable.TabIndex = 16;
            this.numberOfemployeeLable.Text = "1000000";
            // 
            // label11
            // 
            this.label11.AutoEllipsis = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(16, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 22);
            this.label11.TabIndex = 14;
            this.label11.Text = "Number of Room";
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(19, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(263, 22);
            this.label10.TabIndex = 14;
            this.label10.Text = "Number of Employees";
            // 
            // numberOfServiceLable
            // 
            this.numberOfServiceLable.AutoEllipsis = true;
            this.numberOfServiceLable.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfServiceLable.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.numberOfServiceLable.Location = new System.Drawing.Point(43, 61);
            this.numberOfServiceLable.Name = "numberOfServiceLable";
            this.numberOfServiceLable.Size = new System.Drawing.Size(223, 38);
            this.numberOfServiceLable.TabIndex = 15;
            this.numberOfServiceLable.Text = "1000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(15, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total counter";
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(16, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Number of Services";
            // 
            // chartTopProducts
            // 
            this.chartTopProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea4.Name = "ChartArea1";
            this.chartTopProducts.ChartAreas.Add(chartArea4);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Name = "Legend1";
            this.chartTopProducts.Legends.Add(legend4);
            this.chartTopProducts.Location = new System.Drawing.Point(859, 158);
            this.chartTopProducts.Name = "chartTopProducts";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series4.IsValueShownAsLabel = true;
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartTopProducts.Series.Add(series4);
            this.chartTopProducts.Size = new System.Drawing.Size(301, 541);
            this.chartTopProducts.TabIndex = 14;
            this.chartTopProducts.Text = "chart2";
            title4.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title4.Name = "Title1";
            title4.Text = "Top Type Room";
            this.chartTopProducts.Titles.Add(title4);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            this.okButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.okButton.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.okButton.IconColor = System.Drawing.Color.Black;
            this.okButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.okButton.Location = new System.Drawing.Point(544, 8);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(60, 40);
            this.okButton.TabIndex = 15;
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // customButton
            // 
            this.customButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.customButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.customButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.customButton.IconColor = System.Drawing.Color.Black;
            this.customButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.customButton.Location = new System.Drawing.Point(619, 2);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(135, 53);
            this.customButton.TabIndex = 16;
            this.customButton.Text = "Custom";
            this.customButton.UseVisualStyleBackColor = true;
            this.customButton.Click += new System.EventHandler(this.customButton_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1189, 711);
            this.Controls.Add(this.customButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.chartTopProducts);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.grossRevenuechart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.last7DaysButton);
            this.Controls.Add(this.todayButton);
            this.Controls.Add(this.thisMonthButton);
            this.Controls.Add(this.endDateDTP);
            this.Controls.Add(this.startDateDateTimePicker);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DashboardForm";
            this.ShowIcon = false;
            this.Text = "8";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grossRevenuechart)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker startDateDateTimePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker endDateDTP;
        private FontAwesome.Sharp.IconButton thisMonthButton;
        private FontAwesome.Sharp.IconButton todayButton;
        private FontAwesome.Sharp.IconButton last7DaysButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label numberOfReservationlabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label totalRevenuelabel;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label totalProfitlable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart grossRevenuechart;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label numberOfRoomLable;
        private System.Windows.Forms.Label numberOfemployeeLable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label numberOfServiceLable;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProducts;
        private FontAwesome.Sharp.IconButton okButton;
        private FontAwesome.Sharp.IconButton customButton;
    }
}
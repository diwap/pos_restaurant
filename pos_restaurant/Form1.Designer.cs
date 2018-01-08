namespace pos_restaurant
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ActivePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.csv_path = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.add_menu = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.discard = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.category = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.name = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.p_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.payment = new System.Windows.Forms.Button();
            this.sort_price = new System.Windows.Forms.Button();
            this.sort_name = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.report_grid_view = new System.Windows.Forms.DataGridView();
            this.total_sales = new System.Windows.Forms.Label();
            this.total_cash = new System.Windows.Forms.Label();
            this.report_total_sales = new System.Windows.Forms.TextBox();
            this.report_cash_received = new System.Windows.Forms.TextBox();
            this.report_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.add_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report_grid_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.ActivePanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 671);
            this.panel1.TabIndex = 0;
            // 
            // ActivePanel
            // 
            this.ActivePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ActivePanel.Location = new System.Drawing.Point(0, 171);
            this.ActivePanel.Name = "ActivePanel";
            this.ActivePanel.Size = new System.Drawing.Size(12, 70);
            this.ActivePanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cafeteria";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(12, 245);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(208, 70);
            this.button5.TabIndex = 3;
            this.button5.Text = "      SELL REPORT";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 70);
            this.button1.TabIndex = 3;
            this.button1.Text = "      DASHBOARD";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(220, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 20);
            this.panel2.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(1187, 25);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 37);
            this.button6.TabIndex = 3;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.csv_path);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(220, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1043, 45);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(275, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(768, 553);
            this.panel4.TabIndex = 10;
            // 
            // csv_path
            // 
            this.csv_path.BackColor = System.Drawing.Color.White;
            this.csv_path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.csv_path.Location = new System.Drawing.Point(175, 13);
            this.csv_path.Name = "csv_path";
            this.csv_path.ReadOnly = true;
            this.csv_path.Size = new System.Drawing.Size(452, 13);
            this.csv_path.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 38);
            this.button2.TabIndex = 0;
            this.button2.Text = "IMPORT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // add_menu
            // 
            this.add_menu.Controls.Add(this.save);
            this.add_menu.Controls.Add(this.discard);
            this.add_menu.Controls.Add(this.price);
            this.add_menu.Controls.Add(this.flowLayoutPanel3);
            this.add_menu.Controls.Add(this.category);
            this.add_menu.Controls.Add(this.flowLayoutPanel2);
            this.add_menu.Controls.Add(this.name);
            this.add_menu.Controls.Add(this.flowLayoutPanel1);
            this.add_menu.Location = new System.Drawing.Point(220, 65);
            this.add_menu.Name = "add_menu";
            this.add_menu.Size = new System.Drawing.Size(273, 606);
            this.add_menu.TabIndex = 7;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(24, 328);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(101, 38);
            this.save.TabIndex = 7;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // discard
            // 
            this.discard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.discard.FlatAppearance.BorderSize = 0;
            this.discard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discard.ForeColor = System.Drawing.Color.White;
            this.discard.Location = new System.Drawing.Point(131, 328);
            this.discard.Name = "discard";
            this.discard.Size = new System.Drawing.Size(111, 38);
            this.discard.TabIndex = 8;
            this.discard.Text = "CLEAR";
            this.discard.UseVisualStyleBackColor = false;
            this.discard.Click += new System.EventHandler(this.discard_Click);
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(24, 234);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(205, 22);
            this.price.TabIndex = 6;
            this.price.Text = "Price";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flowLayoutPanel3.Location = new System.Drawing.Point(20, 221);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(222, 49);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(24, 133);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(205, 22);
            this.category.TabIndex = 5;
            this.category.Text = "Category";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(20, 120);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(222, 49);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(24, 34);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(205, 22);
            this.name.TabIndex = 4;
            this.name.Text = "Name";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(222, 49);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_name,
            this.p_category,
            this.p_price,
            this.p_select});
            this.dataGridView1.Location = new System.Drawing.Point(499, 71);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(761, 547);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // p_name
            // 
            this.p_name.HeaderText = "Name";
            this.p_name.Name = "p_name";
            // 
            // p_category
            // 
            this.p_category.HeaderText = "Category";
            this.p_category.Name = "p_category";
            // 
            // p_price
            // 
            this.p_price.HeaderText = "Price";
            this.p_price.Name = "p_price";
            // 
            // p_select
            // 
            this.p_select.HeaderText = "Select";
            this.p_select.Name = "p_select";
            // 
            // payment
            // 
            this.payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.payment.FlatAppearance.BorderSize = 0;
            this.payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payment.ForeColor = System.Drawing.Color.White;
            this.payment.Location = new System.Drawing.Point(603, 3);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(165, 38);
            this.payment.TabIndex = 2;
            this.payment.Text = "PAYMENT";
            this.payment.UseVisualStyleBackColor = false;
            this.payment.Visible = false;
            this.payment.Click += new System.EventHandler(this.payment_Click);
            // 
            // sort_price
            // 
            this.sort_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.sort_price.FlatAppearance.BorderSize = 0;
            this.sort_price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sort_price.ForeColor = System.Drawing.Color.White;
            this.sort_price.Location = new System.Drawing.Point(3, 3);
            this.sort_price.Name = "sort_price";
            this.sort_price.Size = new System.Drawing.Size(80, 38);
            this.sort_price.TabIndex = 2;
            this.sort_price.Text = "Sort by price";
            this.sort_price.UseVisualStyleBackColor = false;
            this.sort_price.Click += new System.EventHandler(this.sort_price_Click);
            // 
            // sort_name
            // 
            this.sort_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.sort_name.FlatAppearance.BorderSize = 0;
            this.sort_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sort_name.ForeColor = System.Drawing.Color.White;
            this.sort_name.Location = new System.Drawing.Point(89, 3);
            this.sort_name.Name = "sort_name";
            this.sort_name.Size = new System.Drawing.Size(80, 38);
            this.sort_name.TabIndex = 2;
            this.sort_name.Text = "Sort by name";
            this.sort_name.UseVisualStyleBackColor = false;
            this.sort_name.Click += new System.EventHandler(this.sort_name_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.payment);
            this.panel5.Controls.Add(this.sort_name);
            this.panel5.Controls.Add(this.sort_price);
            this.panel5.Location = new System.Drawing.Point(492, 621);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(771, 50);
            this.panel5.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.report_chart);
            this.panel6.Controls.Add(this.total_sales);
            this.panel6.Controls.Add(this.total_cash);
            this.panel6.Controls.Add(this.report_total_sales);
            this.panel6.Controls.Add(this.report_cash_received);
            this.panel6.Controls.Add(this.report_grid_view);
            this.panel6.Location = new System.Drawing.Point(228, 71);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1032, 600);
            this.panel6.TabIndex = 5;
            // 
            // report_grid_view
            // 
            this.report_grid_view.AllowUserToAddRows = false;
            this.report_grid_view.AllowUserToDeleteRows = false;
            this.report_grid_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.report_grid_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.report_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.report_grid_view.Location = new System.Drawing.Point(0, 0);
            this.report_grid_view.Name = "report_grid_view";
            this.report_grid_view.ReadOnly = true;
            this.report_grid_view.Size = new System.Drawing.Size(614, 529);
            this.report_grid_view.TabIndex = 1;
            // 
            // total_sales
            // 
            this.total_sales.AutoSize = true;
            this.total_sales.Location = new System.Drawing.Point(229, 553);
            this.total_sales.Name = "total_sales";
            this.total_sales.Size = new System.Drawing.Size(60, 13);
            this.total_sales.TabIndex = 18;
            this.total_sales.Text = "Total Sales";
            // 
            // total_cash
            // 
            this.total_cash.AutoSize = true;
            this.total_cash.Location = new System.Drawing.Point(8, 553);
            this.total_cash.Name = "total_cash";
            this.total_cash.Size = new System.Drawing.Size(107, 13);
            this.total_cash.TabIndex = 19;
            this.total_cash.Text = "Total Cash Received";
            // 
            // report_total_sales
            // 
            this.report_total_sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.report_total_sales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.report_total_sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_total_sales.Location = new System.Drawing.Point(228, 566);
            this.report_total_sales.Name = "report_total_sales";
            this.report_total_sales.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.report_total_sales.Size = new System.Drawing.Size(205, 22);
            this.report_total_sales.TabIndex = 16;
            this.report_total_sales.Text = "0";
            // 
            // report_cash_received
            // 
            this.report_cash_received.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.report_cash_received.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.report_cash_received.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_cash_received.Location = new System.Drawing.Point(7, 566);
            this.report_cash_received.Name = "report_cash_received";
            this.report_cash_received.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.report_cash_received.Size = new System.Drawing.Size(205, 22);
            this.report_cash_received.TabIndex = 17;
            this.report_cash_received.Text = "0";
            // 
            // report_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.report_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.report_chart.Legends.Add(legend2);
            this.report_chart.Location = new System.Drawing.Point(615, 3);
            this.report_chart.Name = "report_chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.report_chart.Series.Add(series2);
            this.report_chart.Size = new System.Drawing.Size(417, 529);
            this.report_chart.TabIndex = 20;
            this.report_chart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 671);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add_menu);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.add_menu.ResumeLayout(false);
            this.add_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report_grid_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel ActivePanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox csv_path;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel add_menu;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button discard;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_price;
        private System.Windows.Forms.DataGridViewCheckBoxColumn p_select;
        private System.Windows.Forms.Button payment;
        private System.Windows.Forms.Button sort_price;
        private System.Windows.Forms.Button sort_name;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView report_grid_view;
        private System.Windows.Forms.Label total_sales;
        private System.Windows.Forms.Label total_cash;
        private System.Windows.Forms.TextBox report_total_sales;
        private System.Windows.Forms.TextBox report_cash_received;
        private System.Windows.Forms.DataVisualization.Charting.Chart report_chart;
    }
}


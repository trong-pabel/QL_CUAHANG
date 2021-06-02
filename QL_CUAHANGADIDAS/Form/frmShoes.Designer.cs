namespace QL_CUAHANGADIDAS
{
    partial class frmShoes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShoes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.txbtop = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvShoes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbinfo = new System.Windows.Forms.GroupBox();
            this.txbSL = new System.Windows.Forms.TextBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdateShoes = new System.Windows.Forms.Button();
            this.btnDelShoes = new System.Windows.Forms.Button();
            this.btnAddShoes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShoes)).BeginInit();
            this.panel3.SuspendLayout();
            this.gbinfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txbSearch);
            this.panel1.Controls.Add(this.txbtop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 69);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(743, -2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 31);
            this.button1.TabIndex = 19;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.BackColor = System.Drawing.Color.White;
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.ForeColor = System.Drawing.Color.Black;
            this.txbSearch.Location = new System.Drawing.Point(306, 34);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txbSearch.Multiline = true;
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(202, 26);
            this.txbSearch.TabIndex = 17;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // txbtop
            // 
            this.txbtop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txbtop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbtop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtop.ForeColor = System.Drawing.Color.White;
            this.txbtop.Location = new System.Drawing.Point(290, 4);
            this.txbtop.Margin = new System.Windows.Forms.Padding(2);
            this.txbtop.Multiline = true;
            this.txbtop.Name = "txbtop";
            this.txbtop.Size = new System.Drawing.Size(240, 25);
            this.txbtop.TabIndex = 14;
            this.txbtop.Text = "Danh sách sản phẩm";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.dtgvShoes);
            this.panel4.Location = new System.Drawing.Point(0, 64);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(790, 305);
            this.panel4.TabIndex = 5;
            // 
            // dtgvShoes
            // 
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvShoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            this.dtgvShoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvShoes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvShoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvShoes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvShoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvShoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dtgvShoes.ColumnHeadersHeight = 35;
            this.dtgvShoes.DoubleBuffered = true;
            this.dtgvShoes.EnableHeadersVisualStyles = false;
            this.dtgvShoes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.dtgvShoes.HeaderForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvShoes.Location = new System.Drawing.Point(6, 0);
            this.dtgvShoes.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvShoes.Name = "dtgvShoes";
            this.dtgvShoes.ReadOnly = true;
            this.dtgvShoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvShoes.RowHeadersVisible = false;
            this.dtgvShoes.RowHeadersWidth = 51;
            this.dtgvShoes.RowTemplate.Height = 24;
            this.dtgvShoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvShoes.Size = new System.Drawing.Size(768, 268);
            this.dtgvShoes.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbinfo);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 374);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(796, 117);
            this.panel3.TabIndex = 6;
            // 
            // gbinfo
            // 
            this.gbinfo.Controls.Add(this.txbSL);
            this.gbinfo.Controls.Add(this.cbSize);
            this.gbinfo.Controls.Add(this.label1);
            this.gbinfo.Controls.Add(this.label5);
            this.gbinfo.Controls.Add(this.label2);
            this.gbinfo.Controls.Add(this.txbID);
            this.gbinfo.Controls.Add(this.label3);
            this.gbinfo.Controls.Add(this.txbName);
            this.gbinfo.Controls.Add(this.txbPrice);
            this.gbinfo.Controls.Add(this.label4);
            this.gbinfo.Enabled = false;
            this.gbinfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbinfo.Location = new System.Drawing.Point(6, -3);
            this.gbinfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbinfo.Name = "gbinfo";
            this.gbinfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbinfo.Size = new System.Drawing.Size(475, 117);
            this.gbinfo.TabIndex = 20;
            this.gbinfo.TabStop = false;
            this.gbinfo.Text = "Thông tin sản phẩm";
            // 
            // txbSL
            // 
            this.txbSL.Location = new System.Drawing.Point(136, 80);
            this.txbSL.Margin = new System.Windows.Forms.Padding(2);
            this.txbSL.MaxLength = 10;
            this.txbSL.Multiline = true;
            this.txbSL.Name = "txbSL";
            this.txbSL.Size = new System.Drawing.Size(57, 24);
            this.txbSL.TabIndex = 1;
            this.txbSL.TextChanged += new System.EventHandler(this.txbSL_TextChanged);
            this.txbSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSL_KeyPress);
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44"});
            this.cbSize.Location = new System.Drawing.Point(292, 80);
            this.cbSize.Margin = new System.Windows.Forms.Padding(2);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(55, 25);
            this.cbSize.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên mặt hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(370, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID:";
            this.label5.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng:";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(412, 80);
            this.txbID.Margin = new System.Windows.Forms.Padding(2);
            this.txbID.Multiline = true;
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(50, 24);
            this.txbID.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(236, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Size:";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(136, 28);
            this.txbName.Margin = new System.Windows.Forms.Padding(2);
            this.txbName.Multiline = true;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(139, 24);
            this.txbName.TabIndex = 12;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(364, 28);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txbPrice.Multiline = true;
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(98, 24);
            this.txbPrice.TabIndex = 6;
            this.txbPrice.TextChanged += new System.EventHandler(this.txbAddress_TextChanged);
            this.txbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrice_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(297, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đơn giá:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(6, 72);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(98, 35);
            this.btnExcel.TabIndex = 17;
            this.btnExcel.Text = " Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(202, 68);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 41);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "     Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(109, 68);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 41);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = " Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdateShoes
            // 
            this.btnUpdateShoes.FlatAppearance.BorderSize = 0;
            this.btnUpdateShoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateShoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateShoes.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateShoes.Image")));
            this.btnUpdateShoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateShoes.Location = new System.Drawing.Point(109, 23);
            this.btnUpdateShoes.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateShoes.Name = "btnUpdateShoes";
            this.btnUpdateShoes.Size = new System.Drawing.Size(90, 41);
            this.btnUpdateShoes.TabIndex = 11;
            this.btnUpdateShoes.Text = " Sửa";
            this.btnUpdateShoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateShoes.UseVisualStyleBackColor = true;
            this.btnUpdateShoes.Click += new System.EventHandler(this.btnUpdateShoes_Click);
            // 
            // btnDelShoes
            // 
            this.btnDelShoes.FlatAppearance.BorderSize = 0;
            this.btnDelShoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelShoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelShoes.Image = ((System.Drawing.Image)(resources.GetObject("btnDelShoes.Image")));
            this.btnDelShoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelShoes.Location = new System.Drawing.Point(203, 23);
            this.btnDelShoes.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelShoes.Name = "btnDelShoes";
            this.btnDelShoes.Size = new System.Drawing.Size(85, 41);
            this.btnDelShoes.TabIndex = 10;
            this.btnDelShoes.Text = " Xóa";
            this.btnDelShoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelShoes.UseVisualStyleBackColor = true;
            this.btnDelShoes.Click += new System.EventHandler(this.btnDelShoes_Click);
            // 
            // btnAddShoes
            // 
            this.btnAddShoes.FlatAppearance.BorderSize = 0;
            this.btnAddShoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddShoes.Image = ((System.Drawing.Image)(resources.GetObject("btnAddShoes.Image")));
            this.btnAddShoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddShoes.Location = new System.Drawing.Point(6, 23);
            this.btnAddShoes.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddShoes.Name = "btnAddShoes";
            this.btnAddShoes.Size = new System.Drawing.Size(98, 41);
            this.btnAddShoes.TabIndex = 9;
            this.btnAddShoes.Text = " Thêm";
            this.btnAddShoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddShoes.UseVisualStyleBackColor = true;
            this.btnAddShoes.Click += new System.EventHandler(this.btnAddShoes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddShoes);
            this.groupBox2.Controls.Add(this.btnExcel);
            this.groupBox2.Controls.Add(this.btnDelShoes);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnUpdateShoes);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(486, 370);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(292, 117);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Công cụ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(191, 280);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(674, 277);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(45, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(725, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(602, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Trang :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Số dòng trên trang :";
            // 
            // frmShoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(788, 494);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmShoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShoes";
            this.Load += new System.EventHandler(this.frmShoes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShoes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.gbinfo.ResumeLayout(false);
            this.gbinfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbtop;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvShoes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnUpdateShoes;
        private System.Windows.Forms.Button btnDelShoes;
        private System.Windows.Forms.Button btnAddShoes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.TextBox txbSL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbinfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
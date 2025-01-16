namespace AdminLogin
{
    partial class Home
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_excel = new System.Windows.Forms.Button();
            this.button_PDF = new System.Windows.Forms.Button();
            this.comboBox_luachon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Sapxep = new System.Windows.Forms.Button();
            this.label_Total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLanDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sifu = new AdminLogin.Sifu();
            this.managerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.managerTableAdapter1 = new AdminLogin.SifuTableAdapters.ManagerTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTaiKhoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLanDangNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpositonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ypositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zpositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yrotationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentHealthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxHealthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentStaminaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxStaminaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staminaLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentAttackDamgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currrentSoulsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthSliderValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staminaSliderValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_Exit);
            this.groupBox1.Controls.Add(this.button_excel);
            this.groupBox1.Controls.Add(this.button_PDF);
            this.groupBox1.Controls.Add(this.comboBox_luachon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_Sapxep);
            this.groupBox1.Controls.Add(this.label_Total);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1121, 767);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người chơi";
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(729, 719);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(192, 99);
            this.button_Exit.TabIndex = 8;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_excel
            // 
            this.button_excel.Location = new System.Drawing.Point(822, 600);
            this.button_excel.Margin = new System.Windows.Forms.Padding(2);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(192, 99);
            this.button_excel.TabIndex = 7;
            this.button_excel.Text = "PDF";
            this.button_excel.UseVisualStyleBackColor = true;
            this.button_excel.Click += new System.EventHandler(this.button_excel_Click);
            // 
            // button_PDF
            // 
            this.button_PDF.Location = new System.Drawing.Point(588, 600);
            this.button_PDF.Margin = new System.Windows.Forms.Padding(2);
            this.button_PDF.Name = "button_PDF";
            this.button_PDF.Size = new System.Drawing.Size(192, 99);
            this.button_PDF.TabIndex = 6;
            this.button_PDF.Text = "Excel";
            this.button_PDF.UseVisualStyleBackColor = true;
            this.button_PDF.Click += new System.EventHandler(this.button_PDF_Click);
            // 
            // comboBox_luachon
            // 
            this.comboBox_luachon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_luachon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_luachon.FormattingEnabled = true;
            this.comboBox_luachon.Items.AddRange(new object[] {
            "Thời Gian Chơi",
            "Số Lần Đăng Nhập",
            "Lượng Boss Tiêu Diệt",
            "Level",
            "Điểm Cao Nhất"});
            this.comboBox_luachon.Location = new System.Drawing.Point(279, 618);
            this.comboBox_luachon.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_luachon.Name = "comboBox_luachon";
            this.comboBox_luachon.Size = new System.Drawing.Size(227, 33);
            this.comboBox_luachon.TabIndex = 5;
            this.comboBox_luachon.SelectedIndexChanged += new System.EventHandler(this.comboBox_luachon_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 614);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiêu chí sắp xếp";
            // 
            // button_Sapxep
            // 
            this.button_Sapxep.AutoSize = true;
            this.button_Sapxep.BackColor = System.Drawing.Color.Blue;
            this.button_Sapxep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Sapxep.Location = new System.Drawing.Point(161, 675);
            this.button_Sapxep.Margin = new System.Windows.Forms.Padding(2);
            this.button_Sapxep.Name = "button_Sapxep";
            this.button_Sapxep.Size = new System.Drawing.Size(187, 91);
            this.button_Sapxep.TabIndex = 3;
            this.button_Sapxep.Text = "Sắp xếp";
            this.button_Sapxep.UseVisualStyleBackColor = false;
            this.button_Sapxep.Click += new System.EventHandler(this.button_Sapxep_Click);
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(296, 566);
            this.label_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(203, 25);
            this.label_Total.TabIndex = 2;
            this.label_Total.Text = "Tổng số người chơi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 558);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng số người chơi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TenTaiKhoan,
            this.soLanDangNhap,
            this.level,
            this.idDataGridViewTextBoxColumn,
            this.tenTaiKhoanDataGridViewTextBoxColumn,
            this.soLanDangNhapDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn,
            this.xpositonDataGridViewTextBoxColumn,
            this.ypositionDataGridViewTextBoxColumn,
            this.zpositionDataGridViewTextBoxColumn,
            this.yrotationDataGridViewTextBoxColumn,
            this.scenceDataGridViewTextBoxColumn,
            this.currentHealthDataGridViewTextBoxColumn,
            this.maxHealthDataGridViewTextBoxColumn,
            this.healthLevelDataGridViewTextBoxColumn,
            this.currentStaminaDataGridViewTextBoxColumn,
            this.maxStaminaDataGridViewTextBoxColumn,
            this.staminaLevelDataGridViewTextBoxColumn,
            this.currentAttackDamgeDataGridViewTextBoxColumn,
            this.currrentSoulsDataGridViewTextBoxColumn,
            this.healthSliderValueDataGridViewTextBoxColumn,
            this.staminaSliderValueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.managerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(8, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1105, 500);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 10;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 200;
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            this.TenTaiKhoan.HeaderText = "Username";
            this.TenTaiKhoan.MinimumWidth = 10;
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            this.TenTaiKhoan.Width = 200;
            // 
            // soLanDangNhap
            // 
            this.soLanDangNhap.DataPropertyName = "soLanDangNhap";
            this.soLanDangNhap.HeaderText = "Number of Login";
            this.soLanDangNhap.MinimumWidth = 10;
            this.soLanDangNhap.Name = "soLanDangNhap";
            this.soLanDangNhap.Width = 200;
            // 
            // level
            // 
            this.level.DataPropertyName = "level";
            this.level.HeaderText = "Level";
            this.level.MinimumWidth = 10;
            this.level.Name = "level";
            this.level.Width = 200;
            // 
            // sifu
            // 
            this.sifu.DataSetName = "Sifu";
            this.sifu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerBindingSource1
            // 
            this.managerBindingSource1.DataMember = "Manager";
            this.managerBindingSource1.DataSource = this.sifu;
            // 
            // managerTableAdapter1
            // 
            this.managerTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenTaiKhoanDataGridViewTextBoxColumn
            // 
            this.tenTaiKhoanDataGridViewTextBoxColumn.DataPropertyName = "TenTaiKhoan";
            this.tenTaiKhoanDataGridViewTextBoxColumn.HeaderText = "TenTaiKhoan";
            this.tenTaiKhoanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenTaiKhoanDataGridViewTextBoxColumn.Name = "tenTaiKhoanDataGridViewTextBoxColumn";
            this.tenTaiKhoanDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLanDangNhapDataGridViewTextBoxColumn
            // 
            this.soLanDangNhapDataGridViewTextBoxColumn.DataPropertyName = "soLanDangNhap";
            this.soLanDangNhapDataGridViewTextBoxColumn.HeaderText = "soLanDangNhap";
            this.soLanDangNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLanDangNhapDataGridViewTextBoxColumn.Name = "soLanDangNhapDataGridViewTextBoxColumn";
            this.soLanDangNhapDataGridViewTextBoxColumn.Width = 125;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "level";
            this.levelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.Width = 125;
            // 
            // xpositonDataGridViewTextBoxColumn
            // 
            this.xpositonDataGridViewTextBoxColumn.DataPropertyName = "x-positon";
            this.xpositonDataGridViewTextBoxColumn.HeaderText = "x-positon";
            this.xpositonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xpositonDataGridViewTextBoxColumn.Name = "xpositonDataGridViewTextBoxColumn";
            this.xpositonDataGridViewTextBoxColumn.Width = 125;
            // 
            // ypositionDataGridViewTextBoxColumn
            // 
            this.ypositionDataGridViewTextBoxColumn.DataPropertyName = "y-position";
            this.ypositionDataGridViewTextBoxColumn.HeaderText = "y-position";
            this.ypositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ypositionDataGridViewTextBoxColumn.Name = "ypositionDataGridViewTextBoxColumn";
            this.ypositionDataGridViewTextBoxColumn.Width = 125;
            // 
            // zpositionDataGridViewTextBoxColumn
            // 
            this.zpositionDataGridViewTextBoxColumn.DataPropertyName = "z-position";
            this.zpositionDataGridViewTextBoxColumn.HeaderText = "z-position";
            this.zpositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zpositionDataGridViewTextBoxColumn.Name = "zpositionDataGridViewTextBoxColumn";
            this.zpositionDataGridViewTextBoxColumn.Width = 125;
            // 
            // yrotationDataGridViewTextBoxColumn
            // 
            this.yrotationDataGridViewTextBoxColumn.DataPropertyName = "y-rotation";
            this.yrotationDataGridViewTextBoxColumn.HeaderText = "y-rotation";
            this.yrotationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yrotationDataGridViewTextBoxColumn.Name = "yrotationDataGridViewTextBoxColumn";
            this.yrotationDataGridViewTextBoxColumn.Width = 125;
            // 
            // scenceDataGridViewTextBoxColumn
            // 
            this.scenceDataGridViewTextBoxColumn.DataPropertyName = "scence";
            this.scenceDataGridViewTextBoxColumn.HeaderText = "scence";
            this.scenceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scenceDataGridViewTextBoxColumn.Name = "scenceDataGridViewTextBoxColumn";
            this.scenceDataGridViewTextBoxColumn.Width = 125;
            // 
            // currentHealthDataGridViewTextBoxColumn
            // 
            this.currentHealthDataGridViewTextBoxColumn.DataPropertyName = "currentHealth";
            this.currentHealthDataGridViewTextBoxColumn.HeaderText = "currentHealth";
            this.currentHealthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentHealthDataGridViewTextBoxColumn.Name = "currentHealthDataGridViewTextBoxColumn";
            this.currentHealthDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxHealthDataGridViewTextBoxColumn
            // 
            this.maxHealthDataGridViewTextBoxColumn.DataPropertyName = "maxHealth";
            this.maxHealthDataGridViewTextBoxColumn.HeaderText = "maxHealth";
            this.maxHealthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxHealthDataGridViewTextBoxColumn.Name = "maxHealthDataGridViewTextBoxColumn";
            this.maxHealthDataGridViewTextBoxColumn.Width = 125;
            // 
            // healthLevelDataGridViewTextBoxColumn
            // 
            this.healthLevelDataGridViewTextBoxColumn.DataPropertyName = "healthLevel";
            this.healthLevelDataGridViewTextBoxColumn.HeaderText = "healthLevel";
            this.healthLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.healthLevelDataGridViewTextBoxColumn.Name = "healthLevelDataGridViewTextBoxColumn";
            this.healthLevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // currentStaminaDataGridViewTextBoxColumn
            // 
            this.currentStaminaDataGridViewTextBoxColumn.DataPropertyName = "currentStamina";
            this.currentStaminaDataGridViewTextBoxColumn.HeaderText = "currentStamina";
            this.currentStaminaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentStaminaDataGridViewTextBoxColumn.Name = "currentStaminaDataGridViewTextBoxColumn";
            this.currentStaminaDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxStaminaDataGridViewTextBoxColumn
            // 
            this.maxStaminaDataGridViewTextBoxColumn.DataPropertyName = "maxStamina";
            this.maxStaminaDataGridViewTextBoxColumn.HeaderText = "maxStamina";
            this.maxStaminaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxStaminaDataGridViewTextBoxColumn.Name = "maxStaminaDataGridViewTextBoxColumn";
            this.maxStaminaDataGridViewTextBoxColumn.Width = 125;
            // 
            // staminaLevelDataGridViewTextBoxColumn
            // 
            this.staminaLevelDataGridViewTextBoxColumn.DataPropertyName = "staminaLevel";
            this.staminaLevelDataGridViewTextBoxColumn.HeaderText = "staminaLevel";
            this.staminaLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staminaLevelDataGridViewTextBoxColumn.Name = "staminaLevelDataGridViewTextBoxColumn";
            this.staminaLevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // currentAttackDamgeDataGridViewTextBoxColumn
            // 
            this.currentAttackDamgeDataGridViewTextBoxColumn.DataPropertyName = "currentAttackDamge";
            this.currentAttackDamgeDataGridViewTextBoxColumn.HeaderText = "currentAttackDamge";
            this.currentAttackDamgeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentAttackDamgeDataGridViewTextBoxColumn.Name = "currentAttackDamgeDataGridViewTextBoxColumn";
            this.currentAttackDamgeDataGridViewTextBoxColumn.Width = 125;
            // 
            // currrentSoulsDataGridViewTextBoxColumn
            // 
            this.currrentSoulsDataGridViewTextBoxColumn.DataPropertyName = "currrentSouls";
            this.currrentSoulsDataGridViewTextBoxColumn.HeaderText = "currrentSouls";
            this.currrentSoulsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currrentSoulsDataGridViewTextBoxColumn.Name = "currrentSoulsDataGridViewTextBoxColumn";
            this.currrentSoulsDataGridViewTextBoxColumn.Width = 125;
            // 
            // healthSliderValueDataGridViewTextBoxColumn
            // 
            this.healthSliderValueDataGridViewTextBoxColumn.DataPropertyName = "healthSliderValue";
            this.healthSliderValueDataGridViewTextBoxColumn.HeaderText = "healthSliderValue";
            this.healthSliderValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.healthSliderValueDataGridViewTextBoxColumn.Name = "healthSliderValueDataGridViewTextBoxColumn";
            this.healthSliderValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // staminaSliderValueDataGridViewTextBoxColumn
            // 
            this.staminaSliderValueDataGridViewTextBoxColumn.DataPropertyName = "staminaSliderValue";
            this.staminaSliderValueDataGridViewTextBoxColumn.HeaderText = "staminaSliderValue";
            this.staminaSliderValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staminaSliderValueDataGridViewTextBoxColumn.Name = "staminaSliderValueDataGridViewTextBoxColumn";
            this.staminaSliderValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1121, 675);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Button button_Sapxep;
        private System.Windows.Forms.ComboBox comboBox_luachon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_PDF;
        private System.Windows.Forms.Button button_excel;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLanDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.BindingSource managerBindingSource;
        private Sifu sifu;
        private System.Windows.Forms.BindingSource managerBindingSource1;
        private SifuTableAdapters.ManagerTableAdapter managerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTaiKhoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLanDangNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpositonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ypositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zpositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yrotationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentHealthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxHealthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentStaminaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxStaminaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staminaLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentAttackDamgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currrentSoulsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthSliderValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staminaSliderValueDataGridViewTextBoxColumn;
    }
}
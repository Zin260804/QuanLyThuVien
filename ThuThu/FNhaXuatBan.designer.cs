namespace QuanLyThuVien.ThuThu
{
    partial class FNhaXuatBan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTimKiem = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtDiaChi = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtSdt = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtTenNXB = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.txtMaNXB = new Guna.UI.WinForms.GunaTextBox();
            this.dtNhaXuatBan = new Guna.UI.WinForms.GunaDataGridView();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLamMoi = new Guna.UI.WinForms.GunaButton();
            this.btnThem = new Guna.UI.WinForms.GunaButton();
            this.btnXoa = new Guna.UI.WinForms.GunaButton();
            this.btnSua = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNhaXuatBan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.gunaLabel5);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.gunaLabel6);
            this.panel1.Controls.Add(this.txtSdt);
            this.panel1.Controls.Add(this.gunaLabel7);
            this.panel1.Controls.Add(this.txtTenNXB);
            this.panel1.Controls.Add(this.gunaLabel8);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.gunaLabel9);
            this.panel1.Controls.Add(this.txtMaNXB);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.panel1.Location = new System.Drawing.Point(31, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 184);
            this.panel1.TabIndex = 21;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderRadius = 10;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(303, 146);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(285, 32);
            this.txtTimKiem.TabIndex = 36;
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AnimationHoverSpeed = 0.07F;
            this.btnTimKiem.AnimationSpeed = 0.03F;
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.btnTimKiem.BorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTimKiem.FocusedColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = global::QuanLyThuVien.Properties.Resources.find;
            this.btnTimKiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTimKiem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTimKiem.Location = new System.Drawing.Point(594, 147);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OnHoverBaseColor = System.Drawing.Color.Goldenrod;
            this.btnTimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTimKiem.OnHoverImage = null;
            this.btnTimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiem.Radius = 10;
            this.btnTimKiem.Size = new System.Drawing.Size(48, 32);
            this.btnTimKiem.TabIndex = 35;
            this.btnTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(231, 65);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(58, 19);
            this.gunaLabel5.TabIndex = 29;
            this.gunaLabel5.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BaseColor = System.Drawing.Color.White;
            this.txtDiaChi.BorderColor = System.Drawing.Color.Silver;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDiaChi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.txtDiaChi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(235, 86);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(304, 32);
            this.txtDiaChi.TabIndex = 28;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(595, 65);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(99, 19);
            this.gunaLabel6.TabIndex = 27;
            this.gunaLabel6.Text = "Số điện thoại";
            // 
            // txtSdt
            // 
            this.txtSdt.BaseColor = System.Drawing.Color.White;
            this.txtSdt.BorderColor = System.Drawing.Color.Silver;
            this.txtSdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSdt.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSdt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.txtSdt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSdt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(599, 86);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.PasswordChar = '\0';
            this.txtSdt.SelectedText = "";
            this.txtSdt.Size = new System.Drawing.Size(304, 32);
            this.txtSdt.TabIndex = 26;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(231, 9);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(73, 19);
            this.gunaLabel7.TabIndex = 25;
            this.gunaLabel7.Text = "Tên NXB";
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.BaseColor = System.Drawing.Color.White;
            this.txtTenNXB.BorderColor = System.Drawing.Color.Silver;
            this.txtTenNXB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNXB.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTenNXB.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.txtTenNXB.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenNXB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNXB.Location = new System.Drawing.Point(235, 30);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.PasswordChar = '\0';
            this.txtTenNXB.SelectedText = "";
            this.txtTenNXB.Size = new System.Drawing.Size(304, 32);
            this.txtTenNXB.TabIndex = 24;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(595, 9);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(49, 19);
            this.gunaLabel8.TabIndex = 23;
            this.gunaLabel8.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BaseColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(599, 30);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(304, 32);
            this.txtEmail.TabIndex = 22;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(15, 9);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(70, 19);
            this.gunaLabel9.TabIndex = 21;
            this.gunaLabel9.Text = "Mã NXB";
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaNXB.BorderColor = System.Drawing.Color.Silver;
            this.txtMaNXB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNXB.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaNXB.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.txtMaNXB.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaNXB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNXB.ForeColor = System.Drawing.Color.Black;
            this.txtMaNXB.Location = new System.Drawing.Point(19, 30);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.PasswordChar = '\0';
            this.txtMaNXB.ReadOnly = true;
            this.txtMaNXB.SelectedText = "";
            this.txtMaNXB.Size = new System.Drawing.Size(156, 32);
            this.txtMaNXB.TabIndex = 20;
            // 
            // dtNhaXuatBan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtNhaXuatBan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtNhaXuatBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtNhaXuatBan.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtNhaXuatBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtNhaXuatBan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtNhaXuatBan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtNhaXuatBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtNhaXuatBan.ColumnHeadersHeight = 20;
            this.dtNhaXuatBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNXB,
            this.Ten,
            this.DiaChi,
            this.Email,
            this.Sdt});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtNhaXuatBan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtNhaXuatBan.EnableHeadersVisualStyles = false;
            this.dtNhaXuatBan.GridColor = System.Drawing.Color.White;
            this.dtNhaXuatBan.Location = new System.Drawing.Point(31, 205);
            this.dtNhaXuatBan.Name = "dtNhaXuatBan";
            this.dtNhaXuatBan.RowHeadersVisible = false;
            this.dtNhaXuatBan.RowHeadersWidth = 51;
            this.dtNhaXuatBan.RowTemplate.Height = 24;
            this.dtNhaXuatBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtNhaXuatBan.Size = new System.Drawing.Size(944, 390);
            this.dtNhaXuatBan.TabIndex = 20;
            this.dtNhaXuatBan.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtNhaXuatBan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtNhaXuatBan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtNhaXuatBan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtNhaXuatBan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtNhaXuatBan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtNhaXuatBan.ThemeStyle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dtNhaXuatBan.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dtNhaXuatBan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.dtNhaXuatBan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtNhaXuatBan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNhaXuatBan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dtNhaXuatBan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtNhaXuatBan.ThemeStyle.HeaderStyle.Height = 20;
            this.dtNhaXuatBan.ThemeStyle.ReadOnly = false;
            this.dtNhaXuatBan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtNhaXuatBan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtNhaXuatBan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNhaXuatBan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtNhaXuatBan.ThemeStyle.RowsStyle.Height = 24;
            this.dtNhaXuatBan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.Control;
            this.dtNhaXuatBan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtNhaXuatBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtNhaXuatBan_CellClick);
            // 
            // MaNXB
            // 
            this.MaNXB.DataPropertyName = "MaNXB";
            this.MaNXB.HeaderText = "Mã NXB";
            this.MaNXB.MinimumWidth = 6;
            this.MaNXB.Name = "MaNXB";
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên NXB";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "Số điện thoại";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.AnimationHoverSpeed = 0.07F;
            this.btnLamMoi.AnimationSpeed = 0.03F;
            this.btnLamMoi.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.btnLamMoi.BorderColor = System.Drawing.Color.Black;
            this.btnLamMoi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLamMoi.FocusedColor = System.Drawing.Color.Empty;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Image = global::QuanLyThuVien.Properties.Resources.refresh;
            this.btnLamMoi.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLamMoi.Location = new System.Drawing.Point(284, 601);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.OnHoverBaseColor = System.Drawing.Color.Goldenrod;
            this.btnLamMoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLamMoi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLamMoi.OnHoverImage = null;
            this.btnLamMoi.OnPressedColor = System.Drawing.Color.Black;
            this.btnLamMoi.Size = new System.Drawing.Size(160, 42);
            this.btnLamMoi.TabIndex = 22;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.AnimationHoverSpeed = 0.07F;
            this.btnThem.AnimationSpeed = 0.03F;
            this.btnThem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.btnThem.BorderColor = System.Drawing.Color.Black;
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.FocusedColor = System.Drawing.Color.Empty;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::QuanLyThuVien.Properties.Resources.plus;
            this.btnThem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThem.Location = new System.Drawing.Point(815, 601);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBaseColor = System.Drawing.Color.Goldenrod;
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThem.OnHoverImage = null;
            this.btnThem.OnPressedColor = System.Drawing.Color.Black;
            this.btnThem.Size = new System.Drawing.Size(160, 42);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm ";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AnimationHoverSpeed = 0.07F;
            this.btnXoa.AnimationSpeed = 0.03F;
            this.btnXoa.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::QuanLyThuVien.Properties.Resources.bin;
            this.btnXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoa.Location = new System.Drawing.Point(638, 601);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.Goldenrod;
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Size = new System.Drawing.Size(160, 42);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AnimationHoverSpeed = 0.07F;
            this.btnSua.AnimationSpeed = 0.03F;
            this.btnSua.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.btnSua.BorderColor = System.Drawing.Color.Black;
            this.btnSua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSua.FocusedColor = System.Drawing.Color.Empty;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = global::QuanLyThuVien.Properties.Resources.edit;
            this.btnSua.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSua.Location = new System.Drawing.Point(461, 601);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnHoverBaseColor = System.Drawing.Color.Goldenrod;
            this.btnSua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSua.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSua.OnHoverImage = null;
            this.btnSua.OnPressedColor = System.Drawing.Color.Black;
            this.btnSua.Size = new System.Drawing.Size(160, 42);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 831);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dtNhaXuatBan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FNhaXuatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FNhaXuatBan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNhaXuatBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnThem;
        private Guna.UI.WinForms.GunaButton btnXoa;
        private Guna.UI.WinForms.GunaButton btnSua;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtDiaChi;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox txtSdt;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox txtTenNXB;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaTextBox txtMaNXB;
        private Guna.UI.WinForms.GunaDataGridView dtNhaXuatBan;
        private Guna.UI.WinForms.GunaButton btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI.WinForms.GunaButton btnLamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
    }
}
namespace QuanLyThuVien.ThuThu
{
    partial class FDauSach
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
            this.dtDauSach = new Guna.UI.WinForms.GunaDataGridView();
            this.MaDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaDS = new Guna.UI.WinForms.GunaTextBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.btnTimKiem = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtMaNhaXuatBan = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtTheLoai = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtMaTacGia = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtTen = new Guna.UI.WinForms.GunaTextBox();
            this.lblMaDauSach = new Guna.UI.WinForms.GunaLabel();
            this.btnLamMoi = new Guna.UI.WinForms.GunaButton();
            this.btnThem = new Guna.UI.WinForms.GunaButton();
            this.btnXoa = new Guna.UI.WinForms.GunaButton();
            this.btnSua = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtDauSach)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtDauSach
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtDauSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtDauSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtDauSach.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtDauSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtDauSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtDauSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtDauSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtDauSach.ColumnHeadersHeight = 20;
            this.dtDauSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDS,
            this.MaTG,
            this.MaNXB,
            this.Ten,
            this.TheLoai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtDauSach.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtDauSach.EnableHeadersVisualStyles = false;
            this.dtDauSach.GridColor = System.Drawing.Color.White;
            this.dtDauSach.Location = new System.Drawing.Point(31, 205);
            this.dtDauSach.Name = "dtDauSach";
            this.dtDauSach.RowHeadersVisible = false;
            this.dtDauSach.RowHeadersWidth = 51;
            this.dtDauSach.RowTemplate.Height = 24;
            this.dtDauSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtDauSach.Size = new System.Drawing.Size(944, 390);
            this.dtDauSach.TabIndex = 10;
            this.dtDauSach.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtDauSach.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtDauSach.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtDauSach.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtDauSach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtDauSach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtDauSach.ThemeStyle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dtDauSach.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dtDauSach.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.dtDauSach.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtDauSach.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDauSach.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dtDauSach.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtDauSach.ThemeStyle.HeaderStyle.Height = 20;
            this.dtDauSach.ThemeStyle.ReadOnly = false;
            this.dtDauSach.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtDauSach.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtDauSach.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDauSach.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtDauSach.ThemeStyle.RowsStyle.Height = 24;
            this.dtDauSach.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.Control;
            this.dtDauSach.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtDauSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDauSach_CellClick);
            // 
            // MaDS
            // 
            this.MaDS.DataPropertyName = "MaDS";
            this.MaDS.HeaderText = "Mã đầu sách";
            this.MaDS.MinimumWidth = 6;
            this.MaDS.Name = "MaDS";
            // 
            // MaTG
            // 
            this.MaTG.DataPropertyName = "MaTG";
            this.MaTG.HeaderText = "Mã tác giả";
            this.MaTG.MinimumWidth = 6;
            this.MaTG.Name = "MaTG";
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
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            // 
            // TheLoai
            // 
            this.TheLoai.DataPropertyName = "TheLoai";
            this.TheLoai.HeaderText = "Thể Loại";
            this.TheLoai.MinimumWidth = 6;
            this.TheLoai.Name = "TheLoai";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaDS);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.gunaLabel5);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.txtMaNhaXuatBan);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.txtTheLoai);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.txtMaTacGia);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.lblMaDauSach);
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 172);
            this.panel1.TabIndex = 11;
            // 
            // txtMaDS
            // 
            this.txtMaDS.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaDS.BorderColor = System.Drawing.Color.Silver;
            this.txtMaDS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDS.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaDS.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.txtMaDS.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaDS.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDS.ForeColor = System.Drawing.Color.Black;
            this.txtMaDS.Location = new System.Drawing.Point(23, 68);
            this.txtMaDS.Name = "txtMaDS";
            this.txtMaDS.PasswordChar = '\0';
            this.txtMaDS.ReadOnly = true;
            this.txtMaDS.SelectedText = "";
            this.txtMaDS.Size = new System.Drawing.Size(136, 32);
            this.txtMaDS.TabIndex = 44;
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
            this.txtTimKiem.Location = new System.Drawing.Point(293, 132);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(285, 32);
            this.txtTimKiem.TabIndex = 37;
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyUp);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.gunaLabel5.Location = new System.Drawing.Point(17, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(201, 31);
            this.gunaLabel5.TabIndex = 23;
            this.gunaLabel5.Text = "Quản lý đầu sách";
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
            this.btnTimKiem.Location = new System.Drawing.Point(584, 132);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OnHoverBaseColor = System.Drawing.Color.Goldenrod;
            this.btnTimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTimKiem.OnHoverImage = null;
            this.btnTimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiem.Radius = 10;
            this.btnTimKiem.Size = new System.Drawing.Size(48, 32);
            this.btnTimKiem.TabIndex = 21;
            this.btnTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(341, 46);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(70, 19);
            this.gunaLabel4.TabIndex = 19;
            this.gunaLabel4.Text = "Mã NXB";
            // 
            // txtMaNhaXuatBan
            // 
            this.txtMaNhaXuatBan.BaseColor = System.Drawing.Color.White;
            this.txtMaNhaXuatBan.BorderColor = System.Drawing.Color.Silver;
            this.txtMaNhaXuatBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNhaXuatBan.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaNhaXuatBan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.txtMaNhaXuatBan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaNhaXuatBan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhaXuatBan.Location = new System.Drawing.Point(345, 68);
            this.txtMaNhaXuatBan.Name = "txtMaNhaXuatBan";
            this.txtMaNhaXuatBan.PasswordChar = '\0';
            this.txtMaNhaXuatBan.SelectedText = "";
            this.txtMaNhaXuatBan.Size = new System.Drawing.Size(136, 32);
            this.txtMaNhaXuatBan.TabIndex = 18;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(722, 46);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(64, 19);
            this.gunaLabel3.TabIndex = 17;
            this.gunaLabel3.Text = "Thể loại";
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.BaseColor = System.Drawing.Color.White;
            this.txtTheLoai.BorderColor = System.Drawing.Color.Silver;
            this.txtTheLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTheLoai.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTheLoai.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.txtTheLoai.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTheLoai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheLoai.Location = new System.Drawing.Point(726, 68);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.PasswordChar = '\0';
            this.txtTheLoai.SelectedText = "";
            this.txtTheLoai.Size = new System.Drawing.Size(195, 32);
            this.txtTheLoai.TabIndex = 16;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(180, 46);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(79, 19);
            this.gunaLabel2.TabIndex = 15;
            this.gunaLabel2.Text = "Mã tác giả";
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.BaseColor = System.Drawing.Color.White;
            this.txtMaTacGia.BorderColor = System.Drawing.Color.Silver;
            this.txtMaTacGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaTacGia.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaTacGia.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.txtMaTacGia.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaTacGia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTacGia.Location = new System.Drawing.Point(184, 68);
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.PasswordChar = '\0';
            this.txtMaTacGia.SelectedText = "";
            this.txtMaTacGia.Size = new System.Drawing.Size(136, 32);
            this.txtMaTacGia.TabIndex = 14;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(502, 46);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(34, 19);
            this.gunaLabel1.TabIndex = 13;
            this.gunaLabel1.Text = "Tên";
            // 
            // txtTen
            // 
            this.txtTen.BaseColor = System.Drawing.Color.White;
            this.txtTen.BorderColor = System.Drawing.Color.Silver;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTen.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.txtTen.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(506, 68);
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.SelectedText = "";
            this.txtTen.Size = new System.Drawing.Size(195, 32);
            this.txtTen.TabIndex = 12;
            // 
            // lblMaDauSach
            // 
            this.lblMaDauSach.AutoSize = true;
            this.lblMaDauSach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDauSach.Location = new System.Drawing.Point(23, 46);
            this.lblMaDauSach.Name = "lblMaDauSach";
            this.lblMaDauSach.Size = new System.Drawing.Size(93, 19);
            this.lblMaDauSach.TabIndex = 11;
            this.lblMaDauSach.Text = "Mã đầu sách";
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
            this.btnLamMoi.TabIndex = 28;
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
            this.btnThem.TabIndex = 14;
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
            this.btnXoa.TabIndex = 13;
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
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 831);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtDauSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDauSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDauSach";
            this.Load += new System.EventHandler(this.FDauSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDauSach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dtDauSach;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtMaNhaXuatBan;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtTheLoai;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtMaTacGia;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lblMaDauSach;
        private Guna.UI.WinForms.GunaButton btnSua;
        private Guna.UI.WinForms.GunaButton btnXoa;
        private Guna.UI.WinForms.GunaButton btnThem;
        private Guna.UI.WinForms.GunaTextBox txtTen;
        private Guna.UI.WinForms.GunaButton btnTimKiem;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaButton btnLamMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private Guna.UI.WinForms.GunaTextBox txtMaDS;
    }
}
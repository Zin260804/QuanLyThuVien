namespace QuanLyThuVien.ThuThu
{
    partial class FViTri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtKe = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtNgan = new Guna.UI.WinForms.GunaTextBox();
            this.lblMaDauSach = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaVT = new Guna.UI.WinForms.GunaTextBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.btnTimKiem = new Guna.UI.WinForms.GunaButton();
            this.txtKhuVuc = new Guna.UI.WinForms.GunaTextBox();
            this.dtViTri = new Guna.UI.WinForms.GunaDataGridView();
            this.MaVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new Guna.UI.WinForms.GunaButton();
            this.btnSua = new Guna.UI.WinForms.GunaButton();
            this.btnXoa = new Guna.UI.WinForms.GunaButton();
            this.btnLamMoi = new Guna.UI.WinForms.GunaButton();
            this.rdbDacosach = new System.Windows.Forms.RadioButton();
            this.rdbChuacosach = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtViTri)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(471, 43);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(29, 19);
            this.gunaLabel4.TabIndex = 19;
            this.gunaLabel4.Text = "Kệ";
            // 
            // txtKe
            // 
            this.txtKe.BaseColor = System.Drawing.Color.White;
            this.txtKe.BorderColor = System.Drawing.Color.Silver;
            this.txtKe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKe.FocusedBaseColor = System.Drawing.Color.White;
            this.txtKe.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.txtKe.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKe.Location = new System.Drawing.Point(475, 63);
            this.txtKe.Name = "txtKe";
            this.txtKe.PasswordChar = '\0';
            this.txtKe.SelectedText = "";
            this.txtKe.Size = new System.Drawing.Size(195, 32);
            this.txtKe.TabIndex = 18;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(245, 43);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(65, 19);
            this.gunaLabel2.TabIndex = 15;
            this.gunaLabel2.Text = "Khu vực";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(697, 43);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(44, 19);
            this.gunaLabel1.TabIndex = 13;
            this.gunaLabel1.Text = "Ngăn";
            // 
            // txtNgan
            // 
            this.txtNgan.BaseColor = System.Drawing.Color.White;
            this.txtNgan.BorderColor = System.Drawing.Color.Silver;
            this.txtNgan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgan.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNgan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.txtNgan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNgan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgan.Location = new System.Drawing.Point(701, 63);
            this.txtNgan.Name = "txtNgan";
            this.txtNgan.PasswordChar = '\0';
            this.txtNgan.SelectedText = "";
            this.txtNgan.Size = new System.Drawing.Size(195, 32);
            this.txtNgan.TabIndex = 12;
            // 
            // lblMaDauSach
            // 
            this.lblMaDauSach.AutoSize = true;
            this.lblMaDauSach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDauSach.Location = new System.Drawing.Point(23, 43);
            this.lblMaDauSach.Name = "lblMaDauSach";
            this.lblMaDauSach.Size = new System.Drawing.Size(67, 19);
            this.lblMaDauSach.TabIndex = 11;
            this.lblMaDauSach.Text = "Mã vị trí";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rdbChuacosach);
            this.panel1.Controls.Add(this.rdbDacosach);
            this.panel1.Controls.Add(this.txtMaVT);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.gunaLabel5);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.txtKe);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.txtKhuVuc);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.txtNgan);
            this.panel1.Controls.Add(this.lblMaDauSach);
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 172);
            this.panel1.TabIndex = 16;
            // 
            // txtMaVT
            // 
            this.txtMaVT.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaVT.BorderColor = System.Drawing.Color.Silver;
            this.txtMaVT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaVT.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaVT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.txtMaVT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaVT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVT.ForeColor = System.Drawing.Color.Black;
            this.txtMaVT.Location = new System.Drawing.Point(27, 63);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.PasswordChar = '\0';
            this.txtMaVT.ReadOnly = true;
            this.txtMaVT.SelectedText = "";
            this.txtMaVT.Size = new System.Drawing.Size(144, 32);
            this.txtMaVT.TabIndex = 44;
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
            this.txtTimKiem.Location = new System.Drawing.Point(25, 125);
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
            this.gunaLabel5.Location = new System.Drawing.Point(17, -3);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(154, 31);
            this.gunaLabel5.TabIndex = 24;
            this.gunaLabel5.Text = "Quản lý vị trí";
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
            this.btnTimKiem.Location = new System.Drawing.Point(316, 125);
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
            // txtKhuVuc
            // 
            this.txtKhuVuc.BaseColor = System.Drawing.Color.White;
            this.txtKhuVuc.BorderColor = System.Drawing.Color.Silver;
            this.txtKhuVuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKhuVuc.FocusedBaseColor = System.Drawing.Color.White;
            this.txtKhuVuc.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.txtKhuVuc.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKhuVuc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhuVuc.Location = new System.Drawing.Point(249, 63);
            this.txtKhuVuc.Name = "txtKhuVuc";
            this.txtKhuVuc.PasswordChar = '\0';
            this.txtKhuVuc.SelectedText = "";
            this.txtKhuVuc.Size = new System.Drawing.Size(195, 32);
            this.txtKhuVuc.TabIndex = 14;
            // 
            // dtViTri
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dtViTri.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtViTri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtViTri.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtViTri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtViTri.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtViTri.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtViTri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtViTri.ColumnHeadersHeight = 20;
            this.dtViTri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVT,
            this.KhuVuc,
            this.Ke,
            this.Ngan});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtViTri.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtViTri.EnableHeadersVisualStyles = false;
            this.dtViTri.GridColor = System.Drawing.Color.White;
            this.dtViTri.Location = new System.Drawing.Point(31, 190);
            this.dtViTri.Name = "dtViTri";
            this.dtViTri.RowHeadersVisible = false;
            this.dtViTri.RowHeadersWidth = 51;
            this.dtViTri.RowTemplate.Height = 24;
            this.dtViTri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtViTri.Size = new System.Drawing.Size(944, 390);
            this.dtViTri.TabIndex = 15;
            this.dtViTri.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtViTri.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtViTri.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtViTri.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtViTri.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtViTri.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtViTri.ThemeStyle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dtViTri.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dtViTri.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.dtViTri.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtViTri.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtViTri.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dtViTri.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtViTri.ThemeStyle.HeaderStyle.Height = 20;
            this.dtViTri.ThemeStyle.ReadOnly = false;
            this.dtViTri.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtViTri.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtViTri.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtViTri.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtViTri.ThemeStyle.RowsStyle.Height = 24;
            this.dtViTri.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.Control;
            this.dtViTri.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtViTri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtViTri_CellClick);
            // 
            // MaVT
            // 
            this.MaVT.DataPropertyName = "MaVT";
            this.MaVT.HeaderText = "Mã vị trí";
            this.MaVT.MinimumWidth = 6;
            this.MaVT.Name = "MaVT";
            // 
            // KhuVuc
            // 
            this.KhuVuc.DataPropertyName = "KhuVuc";
            this.KhuVuc.HeaderText = "Khu Vực";
            this.KhuVuc.MinimumWidth = 6;
            this.KhuVuc.Name = "KhuVuc";
            // 
            // Ke
            // 
            this.Ke.DataPropertyName = "Ke";
            this.Ke.HeaderText = "Kệ";
            this.Ke.MinimumWidth = 6;
            this.Ke.Name = "Ke";
            // 
            // Ngan
            // 
            this.Ngan.DataPropertyName = "Ngan";
            this.Ngan.HeaderText = "Ngăn";
            this.Ngan.MinimumWidth = 6;
            this.Ngan.Name = "Ngan";
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
            this.btnThem.Location = new System.Drawing.Point(815, 586);
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
            this.btnSua.Location = new System.Drawing.Point(461, 586);
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
            this.btnXoa.Location = new System.Drawing.Point(638, 586);
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
            this.btnLamMoi.Location = new System.Drawing.Point(284, 586);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.OnHoverBaseColor = System.Drawing.Color.Goldenrod;
            this.btnLamMoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLamMoi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLamMoi.OnHoverImage = null;
            this.btnLamMoi.OnPressedColor = System.Drawing.Color.Black;
            this.btnLamMoi.Size = new System.Drawing.Size(160, 42);
            this.btnLamMoi.TabIndex = 29;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // rdbDacosach
            // 
            this.rdbDacosach.AutoSize = true;
            this.rdbDacosach.Location = new System.Drawing.Point(555, 137);
            this.rdbDacosach.Name = "rdbDacosach";
            this.rdbDacosach.Size = new System.Drawing.Size(95, 20);
            this.rdbDacosach.TabIndex = 45;
            this.rdbDacosach.TabStop = true;
            this.rdbDacosach.Text = "Đã có sách";
            this.rdbDacosach.UseVisualStyleBackColor = true;
            this.rdbDacosach.CheckedChanged += new System.EventHandler(this.rdbDacosach_CheckedChanged);
            // 
            // rdbChuacosach
            // 
            this.rdbChuacosach.AutoSize = true;
            this.rdbChuacosach.Location = new System.Drawing.Point(694, 137);
            this.rdbChuacosach.Name = "rdbChuacosach";
            this.rdbChuacosach.Size = new System.Drawing.Size(109, 20);
            this.rdbChuacosach.TabIndex = 46;
            this.rdbChuacosach.TabStop = true;
            this.rdbChuacosach.Text = "Chưa có sách";
            this.rdbChuacosach.UseVisualStyleBackColor = true;
            this.rdbChuacosach.CheckedChanged += new System.EventHandler(this.rdbChuacosach_CheckedChanged);
            // 
            // FViTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 831);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtViTri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FViTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FViTri";
            this.Load += new System.EventHandler(this.FViTri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtViTri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnThem;
        private Guna.UI.WinForms.GunaButton btnSua;
        private Guna.UI.WinForms.GunaButton btnTimKiem;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtKe;
        private Guna.UI.WinForms.GunaButton btnXoa;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtKhuVuc;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtNgan;
        private Guna.UI.WinForms.GunaLabel lblMaDauSach;
        private Guna.UI.WinForms.GunaDataGridView dtViTri;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngan;
        private Guna.UI.WinForms.GunaButton btnLamMoi;
        private Guna.UI.WinForms.GunaTextBox txtMaVT;
        private System.Windows.Forms.RadioButton rdbChuacosach;
        private System.Windows.Forms.RadioButton rdbDacosach;
    }
}
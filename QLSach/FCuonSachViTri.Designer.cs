namespace QuanLyThuVien.ThuThu
{
    partial class FCuonSachViTri
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
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.btnTimKiem = new Guna.UI.WinForms.GunaButton();
            this.txtTimkiemvt = new Guna.UI.WinForms.GunaTextBox();
            this.dtCuonSachViTri = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCuonSachViTri)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaLabel5);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimkiemvt);
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 101);
            this.panel1.TabIndex = 21;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.gunaLabel5.Location = new System.Drawing.Point(17, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(288, 31);
            this.gunaLabel5.TabIndex = 23;
            this.gunaLabel5.Text = "Thông tin vị trí cuốn sách";
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
            this.btnTimKiem.Location = new System.Drawing.Point(429, 54);
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
            // txtTimkiemvt
            // 
            this.txtTimkiemvt.BackColor = System.Drawing.Color.Transparent;
            this.txtTimkiemvt.BaseColor = System.Drawing.Color.White;
            this.txtTimkiemvt.BorderColor = System.Drawing.Color.Silver;
            this.txtTimkiemvt.BorderSize = 1;
            this.txtTimkiemvt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiemvt.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTimkiemvt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.txtTimkiemvt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTimkiemvt.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtTimkiemvt.Location = new System.Drawing.Point(23, 54);
            this.txtTimkiemvt.Name = "txtTimkiemvt";
            this.txtTimkiemvt.PasswordChar = '\0';
            this.txtTimkiemvt.Radius = 10;
            this.txtTimkiemvt.SelectedText = "";
            this.txtTimkiemvt.Size = new System.Drawing.Size(400, 32);
            this.txtTimkiemvt.TabIndex = 20;
            this.txtTimkiemvt.Text = "Tìm kiếm ...";
            // 
            // dtCuonSachViTri
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtCuonSachViTri.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtCuonSachViTri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCuonSachViTri.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtCuonSachViTri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtCuonSachViTri.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtCuonSachViTri.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtCuonSachViTri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtCuonSachViTri.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtCuonSachViTri.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtCuonSachViTri.EnableHeadersVisualStyles = false;
            this.dtCuonSachViTri.GridColor = System.Drawing.Color.White;
            this.dtCuonSachViTri.Location = new System.Drawing.Point(31, 128);
            this.dtCuonSachViTri.Name = "dtCuonSachViTri";
            this.dtCuonSachViTri.RowHeadersVisible = false;
            this.dtCuonSachViTri.RowHeadersWidth = 51;
            this.dtCuonSachViTri.RowTemplate.Height = 24;
            this.dtCuonSachViTri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtCuonSachViTri.Size = new System.Drawing.Size(944, 628);
            this.dtCuonSachViTri.TabIndex = 20;
            this.dtCuonSachViTri.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtCuonSachViTri.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtCuonSachViTri.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtCuonSachViTri.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtCuonSachViTri.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtCuonSachViTri.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtCuonSachViTri.ThemeStyle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dtCuonSachViTri.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dtCuonSachViTri.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(188)))), ((int)(((byte)(167)))));
            this.dtCuonSachViTri.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtCuonSachViTri.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCuonSachViTri.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dtCuonSachViTri.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtCuonSachViTri.ThemeStyle.HeaderStyle.Height = 20;
            this.dtCuonSachViTri.ThemeStyle.ReadOnly = false;
            this.dtCuonSachViTri.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtCuonSachViTri.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtCuonSachViTri.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCuonSachViTri.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtCuonSachViTri.ThemeStyle.RowsStyle.Height = 24;
            this.dtCuonSachViTri.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.Control;
            this.dtCuonSachViTri.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // FCuonSachViTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 784);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtCuonSachViTri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCuonSachViTri";
            this.Text = "FCuonSachViTri";
            this.Load += new System.EventHandler(this.FCuonSachViTri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCuonSachViTri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaButton btnTimKiem;
        private Guna.UI.WinForms.GunaTextBox txtTimkiemvt;
        private Guna.UI.WinForms.GunaDataGridView dtCuonSachViTri;
    }
}
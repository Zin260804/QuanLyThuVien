
using QuanLyThuVien.DAL;
using QuanLyThuVien.TrangChu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.ThuThu
{
    public partial class FManHinhChinh : Form
    {
        FDauSach fdausach = new FDauSach();
        FCuonSach fcuonsach = new FCuonSach();
        FDocGia fdocgia = new FDocGia();
        FNhaXuatBan fnhaxuatban = new FNhaXuatBan();
        FViTri fvitri = new FViTri();
        UCMenu ucmenu = new UCMenu();
        FTacGIa ftacgia = new FTacGIa();
        FCuonSachViTri fcuonsachvitri = new FCuonSachViTri();
        FTaoPhieuMuon ftaophieumuon = new FTaoPhieuMuon();
        UCMenuMuonTra ucmenumuontra = new UCMenuMuonTra();
        FTraSach ftrasach = new FTraSach();
        FViPham fvipham = new FViPham();
        FTrangChu ftrangchu = new FTrangChu();
        ThuThuDao thuthudao = new ThuThuDao();  
        public FManHinhChinh()
        {
            InitializeComponent();
            AddFormToPanel(ftrangchu);
            lblTenThuThu.Text = thuthudao.LayTenThuThu(FDangNhap.mtt);
            ucmenu.btnDauSach.Click += btnQuanLySach_Click;
            ucmenu.btnCuonSach.Click += btnQLCuonSach_Click;
            ucmenu.btnViTri.Click += btnQLViTri_Click;
            ucmenu.btnCuonSachViTri.Click += btnCuonSachViTri_Click;
            ucmenumuontra.btnMuonSach.Click += btnMuonTra_Click;
            ucmenumuontra.btnTraSach.Click += btnTraSach_Click;
            ftaophieumuon.Load += btnMuonTra_Click;
            ucmenumuontra.btnViPham.Click += btnViPham_Click;
        }
   
        private void AddFormToPanel(Form form)
        {
            pnlHienThi.Controls.Clear();
            form.TopLevel = false;
            form.Visible = true;
            pnlHienThi.Controls.Add(form);
            form.Size = pnlHienThi.Size;
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            AddFormToPanel(fdausach);
            pnlMenu.Controls.Add(ucmenu);
            ucmenu.Dock = DockStyle.Fill;
            hienThiTieuDe();
            ucmenu.Visible = true;
        }
        private void btnCuonSachViTri_Click(object sender, EventArgs e)
        {
            AddFormToPanel(fcuonsachvitri);

        }
        private void btnQLCuonSach_Click(object sender, EventArgs e)
        {
            AddFormToPanel(fcuonsach);
           
        }
        private void btnQLViTri_Click(object sender, EventArgs e)
        {
            AddFormToPanel(fvitri);         
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            AddFormToPanel(fdocgia);
            hienThiTieuDe();
            lblDocGia.Visible = true;
        }

        private void btnNhaXuatBan_Click(object sender, EventArgs e)
        {
            AddFormToPanel(fnhaxuatban);
            hienThiTieuDe();
            lblNXB.Visible = true;
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            AddFormToPanel(ftacgia);          
            hienThiTieuDe();
            lblTacGia.Visible = true;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {       
            hienThiTieuDe();
            AddFormToPanel(ftrangchu);
            lblTieuDe.Visible=true;          
        }
        void hienThiTieuDe()
        {
            ucmenumuontra.Visible = false;
            ucmenu.Visible = false;
            lblTieuDe.Visible = false;
            lblNXB.Visible = false;
            lblDocGia.Visible = false;
            lblTacGia.Visible = false;
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            AddFormToPanel(ftaophieumuon);
            pnlMenu.Controls.Add(ucmenumuontra);
            ucmenumuontra.Dock = DockStyle.Fill;
            hienThiTieuDe();
            ucmenumuontra.Visible = true;
            
        }
        private void btnTraSach_Click(object sender, EventArgs e)
        {
            AddFormToPanel(ftrasach);           
        }
        private void FManHinhChinh_Load(object sender, EventArgs e)
        {
            btnTrangChu_Click(sender, e);
        }
        private void btnViPham_Click(object sender, EventArgs e)
        {
            AddFormToPanel(fvipham);
        }
    }
}

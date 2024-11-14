using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    class PhieuMuon
    {
        private string mapm;
        private string madg;
        private string matt;
        private DateTime ngaymuon;
        private DateTime ngaytra;

        public PhieuMuon(string mapm, string madg, string matt, DateTime ngaymuon, DateTime ngaytra)
        {
            this.Mapm = mapm;
            this.Madg = madg;
            this.Matt = matt;
            this.Ngaymuon = ngaymuon;
            this.Ngaytra = ngaytra;
        }

        public string Mapm { get => mapm; set => mapm = value; }
        public string Madg { get => madg; set => madg = value; }
        public string Matt { get => matt; set => matt = value; }
        public DateTime Ngaymuon { get => ngaymuon; set => ngaymuon = value; }
        public DateTime Ngaytra { get => ngaytra; set => ngaytra = value; }
        public int KiemTra()
        {
            if (string.IsNullOrEmpty(Mapm) || string.IsNullOrEmpty(Madg) || string.IsNullOrEmpty(Matt))
            {
                return 0; 
            }
            return 1; 
        }
    }
}

using QuanLyThuVien.DTO;
using QuanLyThuVien.ThuThu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace QuanLyThuVien.DAL
{
    class PhieuMuonDao
    {
        public DataTable LoadPhieuMuon()
        {
            string query = "select * from View_PhieuMuonDangMuon";
            return DbConnection.Instance.Load(query);
        }
        public void TaoPhieuMuon(PhieuMuon pm)
        {
            try
            {
                DbConnection.Instance.OpenConnection();
                using (SqlCommand command = new SqlCommand("Proc_ThemPhieuMuon", DbConnection.conn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaDG", pm.Madg);
                    command.Parameters.AddWithValue("@MaTT", pm.Matt);
                    command.Parameters.AddWithValue("@NgayTra", pm.Ngaytra);
                    command.Parameters.AddWithValue("@NgayMuon", pm.Ngaymuon);
                   

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm phiếu mượn thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm phiếu mượn thất bại.");
                    }
                }           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                DbConnection.conn.Close();
            }
        }
        public void ThemSachVaoPhieuMuon(PhieuMuon pm,string macs)
        {
            try
            {
                DbConnection.Instance.OpenConnection();
                using (SqlCommand command = new SqlCommand("Proc_ThemChiTietPhieuMuon", DbConnection.conn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaCS", macs);
                    command.Parameters.AddWithValue("@MaPM", pm.Mapm);                
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm sách vào phiếu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm sách vào phiếu thất bại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                DbConnection.conn.Close();
            }
        }
        public void TraSachTheoPhieuMuon(string mapm)
        {
            DateTime ngayhientai = DateTime.Now;
            try
            {
                DbConnection.Instance.OpenConnection();
                using (SqlCommand command = new SqlCommand("Proc_TraSachTheoPhieuMuon", DbConnection.conn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NgayTra", ngayhientai);
                    command.Parameters.AddWithValue("@MaPM", mapm);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm sách vào phiếu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm sách vào phiếu thất bại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                DbConnection.conn.Close();
            }
        }
        public void HienThiChiTietPhieuMuon(string mapm,DataGridView dvg)
        {
            try
            {
                DbConnection.Instance.OpenConnection();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Func_ThongTinChiTietPhieuMuon(@MaPM)", DbConnection.conn))
                {
                    command.Parameters.AddWithValue("@MaPM", mapm);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dvg.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                DbConnection.conn.Close();
            }
        }
        public DataTable LayThongKeChiTietPhieuMuonViPham()
        {
            DataTable dataTable = new DataTable();

            try
            {
                DbConnection.Instance.OpenConnection();

                using (SqlCommand command = new SqlCommand("Proc_ThongKeChiTietPhieuMuonViPham", DbConnection.conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                DbConnection.conn.Close();
            }

            return dataTable;
        }
    }
}

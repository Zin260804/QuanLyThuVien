using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.DAL
{
    class CuonSachDao
    {
        public DataTable LoadCuonSach()
        {
            string query = "select * from View_ThongTinCuonSach";
            return DbConnection.Instance.Load(query);
        }     
        public void ThemCuonSach(CuonSach cuonsach)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Proc_ThemCuonSach", DbConnection.conn);
                cmd.CommandType = CommandType.StoredProcedure;              
                cmd.Parameters.Add("@MaDS", SqlDbType.NVarChar, 100).Value = cuonsach.Mads;
                cmd.Parameters.Add("@MaVT", SqlDbType.NVarChar, 50).Value = cuonsach.Mavt;       
                if (DbConnection.conn.State == ConnectionState.Closed)
                {
                    DbConnection.Instance.OpenConnection();
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm cuốn sách thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {

                if (DbConnection.conn.State == ConnectionState.Open)
                {
                    DbConnection.Instance.CloseConnection();
                }
            }
        }
        public void XoaCuonSach(CuonSach cuonsach)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Proc_XoaCuonSach", DbConnection.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaCS", SqlDbType.NVarChar, 10).Value = cuonsach.Macs;
                if (DbConnection.conn.State == ConnectionState.Closed)
                {
                    DbConnection.Instance.OpenConnection();
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm cuốn sách thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {

                if (DbConnection.conn.State == ConnectionState.Open)
                {
                    DbConnection.Instance.CloseConnection();
                }
            }
        }
        public void SuaCuonSach(CuonSach cuonsach)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Proc_SuaCuonSach", DbConnection.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaDS", SqlDbType.NVarChar, 10).Value = cuonsach.Macs;
                cmd.Parameters.Add("@MaDS", SqlDbType.NVarChar, 100).Value = cuonsach.Mads;
                cmd.Parameters.Add("@MaVT", SqlDbType.NVarChar, 50).Value = cuonsach.Mavt;
                if (DbConnection.conn.State == ConnectionState.Closed)
                {
                    DbConnection.Instance.OpenConnection();
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thông tin cuốn sách thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {

                if (DbConnection.conn.State == ConnectionState.Open)
                {
                    DbConnection.Instance.CloseConnection();
                }
            }
        }
        public void TimKiemCuonSach(string tukhoa, DataGridView dvg)
        {
            try
            {
                DbConnection.Instance.OpenConnection();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Func_TimKiemCuonSach(@TuKhoa)", DbConnection.conn))
                {
                    command.Parameters.AddWithValue("@TuKhoa", tukhoa);
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
    }
}

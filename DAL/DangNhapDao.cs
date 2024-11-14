using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyThuVien.DAL
{
    class DangNhapDao
    {
        public string XacThucTaiKhoan(string tenDangNhap, string matKhau)
        {
            string maTT = null;

            try
            {
                DbConnection.Instance.OpenConnection();

                using (SqlCommand command = new SqlCommand("SELECT dbo.Func_XacThucTaiKhoan(@TenDangNhap, @MatKhau)", DbConnection.conn))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);

                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        maTT = result.ToString();
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

            return maTT;
        }
        public bool XacThucDocGia(string maDG)
        {
            bool isValid = false;

            try
            {
                DbConnection.Instance.OpenConnection();

                using (SqlCommand command = new SqlCommand("SELECT dbo.Func_XacThucDocGia(@MaDG)", DbConnection.conn))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@MaDG", maDG);

                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        isValid = Convert.ToBoolean(result);
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

            return isValid;
        }
    }
}

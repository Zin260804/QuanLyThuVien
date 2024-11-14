using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
/*using ClosedXML.Excel;
using OfficeOpenXml;
*/

namespace QuanLyThuVien.DAL
{
    public class ThongTinSachDao
    {
        public DataTable LoadThongtinsach()
        {
            return DbConnection.Instance.Load("Select * from View_ThongTinSach");
        }

        public DataTable TimKiemSach(string maSach = null, string tenSach = null, string tenNXB = null, string tenTG = null)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Func_TimKiemSach(@MaSach, @TenSach, @TenNXB, @TenTG)", DbConnection.conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@MaSach", SqlDbType.NVarChar, 50).Value = (object)maSach ?? DBNull.Value;
                    cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar, 255).Value = (object)tenSach ?? DBNull.Value;
                    cmd.Parameters.Add("@TenNXB", SqlDbType.NVarChar, 255).Value = (object)tenNXB ?? DBNull.Value;
                    cmd.Parameters.Add("@TenTG", SqlDbType.NVarChar, 255).Value = (object)tenTG ?? DBNull.Value;

                    if (DbConnection.conn.State == ConnectionState.Closed)
                    {
                        DbConnection.Instance.OpenConnection();
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
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
                if (DbConnection.conn.State == ConnectionState.Open)
                {
                    DbConnection.Instance.CloseConnection();
                }
            }
            return dataTable;
        }

        // Phương thức Export dữ liệu ra Excel
        /*public bool XuatDuLieuSachExcel(string filePath)
        {
            try
            {
                // Đặt LicenseContext cho EPPlus
                ExcelPackage.LicenseContext = LicenseContext.Commercial; // Hoặc LicenseContext.NonCommercial nếu sử dụng phi thương mại

                // Kết nối đến SQL Server thông qua DbConnection
                DbConnection.Instance.OpenConnection();
                SqlConnection connection = DbConnection.conn; // Dùng kết nối hiện tại từ DbConnection

                // Truy vấn dữ liệu từ View_ThongTinSach
                string query = "SELECT MaSach, TenSach, TheLoai, TenTG, TenNXB, KhuVuc, Ke, Ngan FROM View_ThongTinSach";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Sử dụng EPPlus để tạo file Excel
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = package.Workbook.Worksheets.Add("ThongTinSach");

                    // Thêm tiêu đề cột
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = dataTable.Columns[i].ColumnName;
                    }

                    // Thêm dữ liệu vào sheet
                    for (int row = 0; row < dataTable.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataTable.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dataTable.Rows[row][col];
                        }
                    }

                    // Lưu file
                    package.Save();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                // Đảm bảo đóng kết nối sau khi thực hiện
                DbConnection.Instance.CloseConnection();
            }
        }*/
    }
}


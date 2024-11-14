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
    class ThuThuDao
    {
        public string LayTenThuThu(string matt)
        {
            string tenThuThu = string.Empty; // Mặc định là chuỗi rỗng

            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                DbConnection.Instance.OpenConnection();

                // Tạo SqlCommand để gọi hàm Func_LayTenThuThu
                using (SqlCommand command = new SqlCommand("SELECT dbo.Func_LayTenThuThu(@MaTT)", DbConnection.conn))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@MaTT", matt);

                    // Thực thi câu lệnh và lấy kết quả trả về
                    object result = command.ExecuteScalar();

                    // Nếu kết quả không phải DBNull, chuyển đổi nó thành chuỗi
                    if (result != DBNull.Value)
                    {
                        tenThuThu = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                // Đảm bảo kết nối được đóng
                DbConnection.conn.Close();
            }

            return tenThuThu;
        }

    }
}

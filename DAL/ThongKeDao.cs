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
    class ThongKeDao
    {     
        public DataTable ThongKeKhoSach()
        {
            DataTable dataTable = new DataTable();

            try
            {
                DbConnection.Instance.OpenConnection();

                using (SqlCommand command = new SqlCommand("Proc_ThongKeKhoSach", DbConnection.conn))
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
        public DataTable DuDoanBoSungSach(int thoiGianTinhThang = 1, int tanSuatMuonCao = 1)
        {
            DataTable resultTable = new DataTable();

            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                DbConnection.Instance.OpenConnection();

                // Tạo SqlCommand để gọi stored procedure
                using (SqlCommand command = new SqlCommand("Proc_DuDoanBoSungSach", DbConnection.conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số vào stored procedure
                    command.Parameters.AddWithValue("@ThoiGianTinhThang", thoiGianTinhThang);
                    command.Parameters.AddWithValue("@TanSuatMuonCao", tanSuatMuonCao);

                    // Tạo SqlDataAdapter để nhận dữ liệu trả về
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    // Điền dữ liệu vào DataTable
                    dataAdapter.Fill(resultTable);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                // Đảm bảo kết nối được đóng sau khi hoàn thành
                DbConnection.conn.Close();
            }

            return resultTable;
        }
        public DataTable ThongKeDocGiaTheoHoatDong(DateTime tuNgay, DateTime denNgay)
        {
            DataTable resultTable = new DataTable();

            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                DbConnection.Instance.OpenConnection();

                // Tạo SqlCommand để gọi stored procedure
                using (SqlCommand command = new SqlCommand("Proc_ThongKeDocGiaTheoHoatDong", DbConnection.conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số vào stored procedure
                    command.Parameters.AddWithValue("@TuNgay", tuNgay);
                    command.Parameters.AddWithValue("@DenNgay", denNgay);

                    // Tạo SqlDataAdapter để nhận dữ liệu trả về
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    // Điền dữ liệu vào DataTable
                    dataAdapter.Fill(resultTable);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                // Đảm bảo kết nối được đóng sau khi hoàn thành
                DbConnection.conn.Close();
            }

            return resultTable;
        }

        // Phương thức này sẽ được gọi từ giao diện người dùng (Form)
        public DataTable ThongKeTrongKhoangThoiGianMacDinh()
        {
            // Lấy ngày hiện tại và tính toán khoảng thời gian mặc định (30 ngày trước và hôm nay)
            DateTime denNgay = DateTime.Now;
            DateTime tuNgay = denNgay.AddDays(-30);

            // Gọi phương thức ThongKeDocGiaTheoHoatDong với tham số mặc định
            return ThongKeDocGiaTheoHoatDong(tuNgay, denNgay);
        }
        public string ThongKe(string truyVan)
        {
            string tongDauSach = "0"; // Mặc định là 0

            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                DbConnection.Instance.OpenConnection();

                // Tạo SqlCommand để thực thi câu lệnh SQL động
                using (SqlCommand command = new SqlCommand(truyVan, DbConnection.conn))
                {
                    command.CommandType = CommandType.Text;

                    // Thực thi câu lệnh và lấy kết quả trả về
                    object result = command.ExecuteScalar();

                    // Nếu kết quả không phải DBNull, chuyển đổi nó thành chuỗi
                    if (result != DBNull.Value)
                    {
                        tongDauSach = result.ToString();
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

            return tongDauSach;
        }

    }
}

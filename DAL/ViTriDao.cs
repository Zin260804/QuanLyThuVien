﻿using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.ThuThu;

namespace QuanLyThuVien.DAL
{
    class ViTriDao
    {
        public DataTable LoadViTri()
        {
            string query = "select * from View_ViTri";
            return DbConnection.Instance.Load(query);
        }
        public void ThemViTri(ViTri vitri)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Proc_ThemViTri", DbConnection.conn);
                cmd.CommandType = CommandType.StoredProcedure;            
                cmd.Parameters.Add("@KhuVuc", SqlDbType.NVarChar, 100).Value = vitri.Khuvuc;
                cmd.Parameters.Add("@Ke", SqlDbType.NVarChar, 50).Value = vitri.Ke;
                cmd.Parameters.Add("@Ngan", SqlDbType.NVarChar, 10).Value = vitri.Ngan;          
                if (DbConnection.conn.State == ConnectionState.Closed)
                {
                    DbConnection.Instance.OpenConnection();
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm vị trí thành công!");
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
        public void XoaViTri(ViTri vitri)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Proc_XoaViTri", DbConnection.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaVT", SqlDbType.NVarChar, 100).Value = vitri.Mavt;
                if (DbConnection.conn.State == ConnectionState.Closed)
                {
                    DbConnection.Instance.OpenConnection();
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa vị trí thành công!");
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
        public void SuaViTri(ViTri vitri)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Proc_SuaViTri", DbConnection.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaVT", SqlDbType.NVarChar, 10).Value = vitri.Mavt;
                cmd.Parameters.Add("@KhuVuc", SqlDbType.NVarChar, 100).Value = vitri.Khuvuc;
                cmd.Parameters.Add("@Ke", SqlDbType.NVarChar, 50).Value = vitri.Ke;
                cmd.Parameters.Add("@Ngan", SqlDbType.NVarChar, 10).Value = vitri.Ngan;
                {
                    DbConnection.Instance.OpenConnection();
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thông tin vị trí thành công!");
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
        public void TimKiemViTri(string mavt,DataGridView dvg )
        {
            try
            {
                DbConnection.Instance.OpenConnection();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Func_TimKiemViTri(@MaVT)", DbConnection.conn))
                {
                    command.Parameters.AddWithValue("@MaVT", mavt);
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
        public DataTable LocViTri(string trangThai)
        {
            try
            {
                DbConnection.Instance.OpenConnection();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Func_LocViTri(@TrangThai)", DbConnection.conn))
                {
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return null;
            }
            finally
            {
                DbConnection.Instance.CloseConnection();
            }
        }

    }
}

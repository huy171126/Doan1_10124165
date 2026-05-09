using CNPM_SPA.DAL;
using System;
using System.Data;
using System.Data.SqlClient;

public class GiaoDichDAL
{
    public DataTable GetAll()
    {
        DataTable dt = new DataTable();

        using (SqlConnection conn = new SqlConnection(DBConnect.connStr))
        using (SqlCommand cmd = new SqlCommand("sp_GiaoDich_GetAll", conn))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
        }

        return dt;
    }

    public DataTable GetByType(string loai)
    {
        DataTable dt = new DataTable();

        using (SqlConnection conn = new SqlConnection(DBConnect.connStr))
        using (SqlCommand cmd = new SqlCommand("sp_GiaoDich_ByType", conn))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Loai", loai);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
        }

        return dt;
    }

    public DataTable GetByDate(DateTime from, DateTime to)
    {
        DataTable dt = new DataTable();

        using (SqlConnection conn = new SqlConnection(DBConnect.connStr))
        using (SqlCommand cmd = new SqlCommand("sp_GiaoDich_ByDate", conn))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FromDate", from);
            cmd.Parameters.AddWithValue("@ToDate", to);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
        }

        return dt;
    }
}
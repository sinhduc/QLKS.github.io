using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace quanlykhachsan
{
    internal class Function
    {
        public DataSet getData(String query)//dataset dung de tra ve nhieu bang . datatable dung de tra ve mot ban
        { 
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            SqlCommand command = new SqlCommand();//Đối tượng SqlCommand được sử dụng để thực hiện các câu lệnh SQL và tương tác với cơ sở dữ liệu.
            command.Connection = sqlConnection;//Dòng này thiết lập kết nối cho đối tượng SqlCommand. Biến sqlConnection chứa đối tượng kết nối đến cơ sở dữ liệu, được truyền vào từ phương thức Connection.GetSqlConnection().
            command.CommandText = query;//Dòng này thiết lập nội dung của câu lệnh SQL mà SqlCommand sẽ thực thi. Biến query chứa câu lệnh SQL được truyền vào từ tham số của phương thức.
            SqlDataAdapter ad = new SqlDataAdapter(command);//Đối tượng SqlDataAdapter được sử dụng để thực hiện truy vấn và lấy dữ liệu từ cơ sở dữ liệu.
            DataSet ds = new DataSet();//Đối tượng DataSet là một cấu trúc dữ liệu trong .NET Framework được sử dụng để lưu trữ và làm việc với dữ liệu từ nhiều nguồn khác nhau
            ad.Fill(ds);//Dòng này sử dụng đối tượng SqlDataAdapter để lấy dữ liệu từ cơ sở dữ liệu và lưu trữ vào DataSet. Phương thức Fill của SqlDataAdapter được sử dụng để điền dữ liệu vào DataSet từ kết quả truy vấn. Sau khi phương thức này được gọi, dataSet sẽ chứa dữ liệu từ cơ sở dữ liệu.
            return ds;
        }
        public void Setdata(String query,String mesenger)
        {
            SqlConnection sqlconnection= Connection.GetSqlConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlconnection;
            command.CommandText = query;// trong đoạn mã trên được sử dụng để thiết lập nội dung của câu lệnh SQL mà đối tượng SqlCommand sẽ thực thi.
            sqlconnection.Open();
            command.ExecuteNonQuery();//trong đoạn mã trên được sử dụng để thực thi câu lệnh SQL mà đối tượng SqlCommand đang giữ.
            sqlconnection.Close();
            MessageBox.Show(mesenger,"Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public SqlDataReader GetDataCombor(String query)
            /*ý nghĩa của đoạn code trên là: Kết nối với cơ sở dữ liệu SQL Server và thực thi một 
             * câu lệnh SQL, sau đó trả về kết quả dưới dạng SqlDataReader.*/
        {
            SqlConnection sqlConnection= Connection.GetSqlConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            sqlConnection.Open();
            command = new SqlCommand(query,sqlConnection);
            SqlDataReader reader = command.ExecuteReader();//ExecuteReader() là một phương thức của đối tượng SqlCommand và được sử dụng để thực thi câu lệnh SQL và trả về một SqlDataReader để truy cập dữ liệu từ kết quả truy vấn.
            return reader;
        }
    }
}

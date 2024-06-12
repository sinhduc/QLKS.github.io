using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlykhachsan.All_User_Control
{
    public partial class US_CheckOut : UserControl
    {
        Function fn=new Function();
        string query;
        public US_CheckOut()
        {
            InitializeComponent();
        }

        private void US_CheckOut_Load(object sender, EventArgs e)
        {
            query = "select Khach_Hang.ClientId,Khach_Hang.name_kh,Khach_Hang.CCCD,Khach_Hang.Nationality,Khach_Hang.Sex_kh,Khach_Hang.PhoneNumber,Khach_Hang.RoomId,Khach_Hang.address,Khach_Hang.checkin,Khach_Hang.Age,Phong.RoomNumber,Phong.Roomtype,Phong.BegNumber,Phong.Price from Khach_Hang inner join Phong on Khach_Hang.RoomId=Phong.RoomId where chekout='No'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select Khach_Hang.ClientId,Khach_Hang.name_kh,Khach_Hang.CCCD,Khach_Hang.Nationality,Khach_Hang.Sex_kh,Khach_Hang.PhoneNumber,Khach_Hang.RoomId,Khach_Hang.address,Khach_Hang.checkin,Khach_Hang.Age,Phong.RoomNumber,Phong.Roomtype,Phong.BegNumber,Phong.Price from Khach_Hang inner join Phong on Khach_Hang.RoomId=Phong.RoomId where name_kh like '"+txtName.Text+"%' and chekout= 'No'";
            DataSet dataSet = fn.getData(query);
            guna2DataGridView1.DataSource = dataSet.Tables[0];

        }
        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
               id= int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                /*thuộc tính Cells của một đối tượng DataGridViewRow, biểu diễn một tập hợp các ô
                 * trong một hàng. Thuộc tính này cũng có thể được truy cập bằng chỉ số để lấy một
                 * ô cụ thể. Trong trường hợp này, chỉ số được sử dụng là 0 , tức là ô thứ hai trong hàng*/
                txtCName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                /*thuộc tính Rows của đối tượng guna2DataGridView1, 
                 * biểu diễn một tập hợp các hàng trong bảng dữ liệu. 
                 * Thuộc tính này có thể được truy cập bằng chỉ số để 
                 * lấy một hàng cụ thể. Trong trường hợp này, chỉ số được sử dụng là e.RowIndex,
                 * là một biến chứa chỉ số của hàng hiện tại*/
                txtRoom.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            } 
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "")
            {
                if(MessageBox.Show("Bạn có chắc chắn không","Xác Nhận ", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    string cdate = txtCheckOutDate.Text;
                    query = "update Khach_Hang set chekout='Yes',checkout='"+cdate+"'where ClientId="+id+"update Phong set Booked='NO' where RoomNumber='"+txtRoom.Text+"'";
                    fn.Setdata(query, "Thanh Toán Thành Công ");
                    US_CheckOut_Load(this, null);
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Khong co Khach Hang De Lua chon", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }
        public void ClearAll()
        {
            txtName.Clear();
            txtCName.Clear();
            txtRoom.Clear();
            txtCheckOutDate.Refresh();
        }
        private void txtCName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtRoom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

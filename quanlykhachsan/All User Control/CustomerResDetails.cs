using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlykhachsan.All_User_Control
{
    public partial class CustomerResDetails : UserControl
    {
        Function fn=new Function();
        String query;
        public CustomerResDetails()
        {
            InitializeComponent();
        }

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtSearchBy.SelectedIndex==0)
            {
                query = "select Khach_Hang.ClientId,Khach_Hang.name_kh,Khach_Hang.CCCD,Khach_Hang.Nationality,Khach_Hang.Sex_kh,Khach_Hang.PhoneNumber,Khach_Hang.RoomId,Khach_Hang.address,Khach_Hang.checkin,Khach_Hang.Age,Phong.RoomNumber,Phong.Roomtype,Phong.BegNumber,Phong.Price from Khach_Hang inner join Phong on Khach_Hang.RoomId=Phong.RoomId ";
                getRecord(query);
            }
            else if(txtSearchBy.SelectedIndex==1)
            {
                query = "select Khach_Hang.ClientId,Khach_Hang.name_kh,Khach_Hang.CCCD,Khach_Hang.Nationality,Khach_Hang.Sex_kh,Khach_Hang.PhoneNumber,Khach_Hang.RoomId,Khach_Hang.address,Khach_Hang.checkin,Khach_Hang.Age,Phong.RoomNumber,Phong.Roomtype,Phong.BegNumber,Phong.Price from Khach_Hang inner join Phong on Khach_Hang.RoomId=Phong.RoomId where checkout is null";
                getRecord(query);
            }
            else if(txtSearchBy.SelectedIndex == 2)
            {
                query = "select Khach_Hang.ClientId,Khach_Hang.name_kh,Khach_Hang.CCCD,Khach_Hang.Nationality,Khach_Hang.Sex_kh,Khach_Hang.PhoneNumber,Khach_Hang.RoomId,Khach_Hang.address,Khach_Hang.checkin,Khach_Hang.Age,Phong.RoomNumber,Phong.Roomtype,Phong.BegNumber,Phong.Price from Khach_Hang inner join Phong on Khach_Hang.RoomId=Phong.RoomId where checkout is not null";
                getRecord(query);
            }
        }
        private void getRecord(string query)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}

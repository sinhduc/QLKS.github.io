using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlykhachsan.All_User_Control
{
    public partial class US_CustomerRes : UserControl
    {
        Function fn =new Function();
        string query;
        int rid;
        
        public US_CustomerRes()
        {
            InitializeComponent();
        }
        public void SetComboBox(string query, ComboBox combo)/*Đọc dữ liệu từ cơ sở dữ liệu SQL Server theo câu lệnh SQL hoặc stored 
                                                              * procedure được truyền vào và thêm vào danh sách các tùy chọn của ComboBox combo.*/
        {
            SqlDataReader sdr = fn.GetDataCombor(query);//lenh SqlDatareader dung de doc co so du lieu tu sql server hie
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }
        private void US_CustomerRes_Load(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear();
            query = "select RoomNumber from Phong where BegNumber='" + txtBeg.Text + "'and Booked ='No'";
            SetComboBox(query, txtRoomNo);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoom.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select Price,RoomId from Phong where RoomNumber='" + txtRoomNo.Text + "'";
            DataSet ds=fn.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAllotCustomerRes_Click(object sender, EventArgs e)
        {
            if (txtName.Text!="" && txtContact.Text!="" && txtNationality.Text!="" && txtGender.Text!="" && txtBight.Text!="" && txtID.Text!="" && txtAddress.Text!="" && txtDK.Text!="")
            {
                string name = txtName.Text;
                Int64 sdt = Int64.Parse(txtContact.Text);
                string quoc_gia = txtNationality.Text;
                string gioi_tinh = txtGender.Text;
                string bight=txtBight.Text;
                string ma_id=txtID.Text;
                string address=txtAddress.Text;
                string ngay_dk=txtDK.Text;

                query = "insert into Khach_Hang (name_kh,PhoneNumber,Nationality,Sex_kh,Age,CCCD,address,checkin,RoomId) values ('"+name+"',"+sdt+",'"+quoc_gia+"','"+gioi_tinh+"','"+bight+"','"+ma_id+"','"+address+"','"+ngay_dk+"',"+rid+") update Phong set Booked ='Yes' where RoomNumber ='"+txtRoomNo.Text+"'";
                fn.Setdata(query, "Số Phòng "+ txtRoomNo.Text+ " ĐÃ Đang Ký ");
                ClearAll();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin ", "THÔNG BÁO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ClearAll()
        {
            txtName.Clear();
            txtContact.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex=-1;
            txtBight.ResetText();
            txtID.Clear();
            txtAddress.Clear();
            txtDK.ResetText();
            txtBeg.SelectedIndex=-1;
            txtRoom.SelectedIndex=-1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
        }
    }
}

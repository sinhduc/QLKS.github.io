using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace quanlykhachsan.All_User_Control
{
    public partial class US_AddRoom : UserControl
    {
        Function fc=new Function();
        string query;
        public US_AddRoom()
        {
            InitializeComponent();
        }

        private void US_AddRoom_Load(object sender, EventArgs e)
        {
            query= "select * from phong";
            DataSet ds=fc.getData(query);
            DataGridView1.DataSource = ds.Tables[0];//DataSource chỉ định nguồn dữ liệu hiện thị ở đây là được gán là ds 
        }

        private void btnArrRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNumber.Text != "" && txtRoomType.Text != "" && txtBeg.Text != "" && txtPrice.Text != "")
            {
                string number= txtRoomNumber.Text;
                string type=txtRoomType.Text;
                string beg=txtBeg.Text;
                Int64 price=Int64.Parse(txtPrice.Text);


                query = "insert into Phong (RoomNumber,Roomtype,BegNumber,Price) values ('"+number +"','"+type+"','"+beg+"','"+price+"')";
                fc.Setdata(query, "da them phong");

                US_AddRoom_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("vui lòng điền đầy đủ thông tin","warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void clearAll()
        {
            txtRoomNumber.Clear();
            txtRoomType.SelectedIndex = -1;
            txtBeg.SelectedIndex = -1;
            txtPrice.Clear();

        }

        private void DataGridView1_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void DataGridView1_Enter(object sender, EventArgs e)
        {
            US_AddRoom_Load(this,null);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
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
    public partial class US_Employee : UserControl
    {
        Function fn =new Function();
        string query;
        public US_Employee()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void US_Employee_Load(object sender, EventArgs e)
        {
           getMaxID();
        }
        public void getMaxID()
        {
            query = "select max(Staffid) from Nhan_vien";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSet.Text = (num + 1).ToString();
            }
        }

        private void btnRegistaion_Click(object sender, EventArgs e)
        {
            if(txtName.Text!="" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtUserName.Text != "" && txtPassword.Text != "")
            {
                string name = txtName.Text;
                Int64 mobile=Int64.Parse(txtMobile.Text);
                string gender=txtGender.Text;
                string email=txtEmail.Text;
                string userName=txtUserName.Text;
                string password=txtPassword.Text;
                query = "insert into Nhan_Vien(Name_nv,Sex_nv,mobile,emailid,userName,pass) values ('"+name+"','"+ gender + "','"+ mobile + "','"+email+"','"+userName+"','"+password+"')";
                fn.Setdata(query, "Bạn đã đăng ký thành công ");

                clearAll();
                getMaxID();
            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1 )
            {
                setControl1(guna2DataGridView1);
            }
            else if(tabControl1.SelectedIndex == 2 )
            {
                setControl1(guna2DataGridView2);
            }
        }
        public void setControl1(DataGridView dgv)
        {
            query = "select * from Nhan_Vien";
            DataSet ds=fn.getData(query);
            dgv.DataSource= ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("bạn có chắc chắn chưa", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from Nhan_Vien where StaffId=" + txtID.Text + "";
                    fn.Setdata(query, "bạn đã xóa thành công ");
                    tabControl1_SelectedIndexChanged(this, null);
                }
            }
        }

        private void US_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}

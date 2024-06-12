using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlykhachsan
{
    public partial class Form1 : Form
    {
        Function fn =new Function();
        string query;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = "select userName,pass from Nhan_Vien where userName ='" + txtUser.Text + "'and pass='" + txtPass.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                labelError.Visible = false;//visible nếu sai thì khong hien dung moi hien
                Dashboard dk=new Dashboard();
                this.Hide();//lệng này dùng để tamj ẩn 
                dk.Show();
            }
            else
            {
                labelError.Visible = true;//khong hien thi
                txtPass.Clear();
                txtUser.Clear();
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

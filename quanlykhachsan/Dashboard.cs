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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panelMoving.Left = btnCustomerRts.Left + 60;
            uS_CustomerRes1.Visible= true;
            uS_CustomerRes1.BringToFront();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            panelMoving.Left = btnAddRoom.Left + 50; // Di chuyển panelMoving sang phải 50 điểm ảnh so với vị trí ngang ban đầu của btnAddRoom
            uS_AddRoom1.Visible = true;
            uS_AddRoom1.BringToFront();
        }

        private void btnChekcOut_Click(object sender, EventArgs e)
        {
            panelMoving.Left=btnChekcOut.Left + 60;
            uS_CheckOut1.Visible = true;
            uS_CheckOut1.BringToFront() ;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uS_AddRoom1.Visible=false;
            uS_CustomerRes1.Visible = false;
            btnAddRoom.PerformClick();
        }

        private void uS_AddRoom1_Load(object sender, EventArgs e)
        {

        }

        private void uS_CheckOut1_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomerDetail_Click(object sender, EventArgs e)
        {
           panelMoving.Left=btnCustomerDetail.Left +60;
           customerResDetails1.Visible = true;
            customerResDetails1.BringToFront();
           
            
        }

        private void btnEployee_Click(object sender, EventArgs e)
        {
            panelMoving.Left=btnEployee.Left + 60;
            uS_Employee1.Visible = true;
            uS_Employee1.BringToFront();
        }

        private void uS_Employee1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

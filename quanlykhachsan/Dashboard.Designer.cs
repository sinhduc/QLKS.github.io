namespace quanlykhachsan
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMinisize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnEployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnChekcOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerRts = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uS_Employee1 = new quanlykhachsan.All_User_Control.US_Employee();
            this.customerResDetails1 = new quanlykhachsan.All_User_Control.CustomerResDetails();
            this.uS_CheckOut1 = new quanlykhachsan.All_User_Control.US_CheckOut();
            this.uS_CustomerRes1 = new quanlykhachsan.All_User_Control.US_CustomerRes();
            this.uS_AddRoom1 = new quanlykhachsan.All_User_Control.US_AddRoom();
            this.panelMoving = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Teal;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.Size = new System.Drawing.Size(47, 44);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // btnMinisize
            // 
            this.btnMinisize.BackColor = System.Drawing.Color.Teal;
            this.btnMinisize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinisize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinisize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinisize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinisize.FillColor = System.Drawing.Color.Teal;
            this.btnMinisize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinisize.ForeColor = System.Drawing.Color.White;
            this.btnMinisize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinisize.Image")));
            this.btnMinisize.Location = new System.Drawing.Point(0, 50);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinisize.Size = new System.Drawing.Size(47, 44);
            this.btnMinisize.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.btnEployee);
            this.guna2Panel1.Controls.Add(this.btnCustomerDetail);
            this.guna2Panel1.Controls.Add(this.btnChekcOut);
            this.guna2Panel1.Controls.Add(this.btnCustomerRts);
            this.guna2Panel1.Controls.Add(this.btnAddRoom);
            this.guna2Panel1.Location = new System.Drawing.Point(89, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1765, 135);
            this.guna2Panel1.TabIndex = 1;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnEployee
            // 
            this.btnEployee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEployee.BorderRadius = 18;
            this.btnEployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEployee.FillColor = System.Drawing.Color.Aquamarine;
            this.btnEployee.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnEployee.ForeColor = System.Drawing.Color.White;
            this.btnEployee.Location = new System.Drawing.Point(1459, 0);
            this.btnEployee.Name = "btnEployee";
            this.btnEployee.Size = new System.Drawing.Size(284, 116);
            this.btnEployee.TabIndex = 0;
            this.btnEployee.Text = "Nhân Viên";
            this.btnEployee.Click += new System.EventHandler(this.btnEployee_Click);
            // 
            // btnCustomerDetail
            // 
            this.btnCustomerDetail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCustomerDetail.BorderRadius = 18;
            this.btnCustomerDetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerDetail.FillColor = System.Drawing.Color.Aquamarine;
            this.btnCustomerDetail.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnCustomerDetail.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDetail.Location = new System.Drawing.Point(1116, 0);
            this.btnCustomerDetail.Name = "btnCustomerDetail";
            this.btnCustomerDetail.Size = new System.Drawing.Size(284, 116);
            this.btnCustomerDetail.TabIndex = 0;
            this.btnCustomerDetail.Text = "Chi Tiết Khách Hàng";
            this.btnCustomerDetail.Click += new System.EventHandler(this.btnCustomerDetail_Click);
            // 
            // btnChekcOut
            // 
            this.btnChekcOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChekcOut.BorderRadius = 18;
            this.btnChekcOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnChekcOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChekcOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChekcOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChekcOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChekcOut.FillColor = System.Drawing.Color.Aquamarine;
            this.btnChekcOut.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnChekcOut.ForeColor = System.Drawing.Color.White;
            this.btnChekcOut.Location = new System.Drawing.Point(731, 3);
            this.btnChekcOut.Name = "btnChekcOut";
            this.btnChekcOut.Size = new System.Drawing.Size(284, 116);
            this.btnChekcOut.TabIndex = 0;
            this.btnChekcOut.Text = "Thanh Toán";
            this.btnChekcOut.Click += new System.EventHandler(this.btnChekcOut_Click);
            // 
            // btnCustomerRts
            // 
            this.btnCustomerRts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCustomerRts.BorderRadius = 18;
            this.btnCustomerRts.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerRts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerRts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerRts.FillColor = System.Drawing.Color.Aquamarine;
            this.btnCustomerRts.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnCustomerRts.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRts.Location = new System.Drawing.Point(380, 3);
            this.btnCustomerRts.Name = "btnCustomerRts";
            this.btnCustomerRts.Size = new System.Drawing.Size(284, 116);
            this.btnCustomerRts.TabIndex = 0;
            this.btnCustomerRts.Text = "Đăng Ký Khách Hang";
            this.btnCustomerRts.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddRoom.BorderRadius = 18;
            this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom.FillColor = System.Drawing.Color.Aquamarine;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(50, 0);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(284, 116);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Thêm Phòng";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.uS_Employee1);
            this.panel1.Controls.Add(this.customerResDetails1);
            this.panel1.Controls.Add(this.uS_CheckOut1);
            this.panel1.Controls.Add(this.uS_CustomerRes1);
            this.panel1.Controls.Add(this.uS_AddRoom1);
            this.panel1.Location = new System.Drawing.Point(58, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1881, 874);
            this.panel1.TabIndex = 2;
            // 
            // uS_Employee1
            // 
            this.uS_Employee1.BackColor = System.Drawing.Color.White;
            this.uS_Employee1.Location = new System.Drawing.Point(3, 5);
            this.uS_Employee1.Name = "uS_Employee1";
            this.uS_Employee1.Size = new System.Drawing.Size(1882, 852);
            this.uS_Employee1.TabIndex = 4;
            this.uS_Employee1.Load += new System.EventHandler(this.uS_Employee1_Load);
            // 
            // customerResDetails1
            // 
            this.customerResDetails1.BackColor = System.Drawing.Color.White;
            this.customerResDetails1.Location = new System.Drawing.Point(3, 5);
            this.customerResDetails1.Name = "customerResDetails1";
            this.customerResDetails1.Size = new System.Drawing.Size(1882, 852);
            this.customerResDetails1.TabIndex = 3;
            // 
            // uS_CheckOut1
            // 
            this.uS_CheckOut1.BackColor = System.Drawing.Color.White;
            this.uS_CheckOut1.Location = new System.Drawing.Point(19, 15);
            this.uS_CheckOut1.Name = "uS_CheckOut1";
            this.uS_CheckOut1.Size = new System.Drawing.Size(1882, 852);
            this.uS_CheckOut1.TabIndex = 2;
            this.uS_CheckOut1.Load += new System.EventHandler(this.uS_CheckOut1_Load);
            // 
            // uS_CustomerRes1
            // 
            this.uS_CustomerRes1.BackColor = System.Drawing.Color.White;
            this.uS_CustomerRes1.ForeColor = System.Drawing.Color.Black;
            this.uS_CustomerRes1.Location = new System.Drawing.Point(3, 5);
            this.uS_CustomerRes1.Name = "uS_CustomerRes1";
            this.uS_CustomerRes1.Size = new System.Drawing.Size(1882, 852);
            this.uS_CustomerRes1.TabIndex = 1;
            // 
            // uS_AddRoom1
            // 
            this.uS_AddRoom1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uS_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uS_AddRoom1.ForeColor = System.Drawing.Color.Black;
            this.uS_AddRoom1.Location = new System.Drawing.Point(3, 3);
            this.uS_AddRoom1.Name = "uS_AddRoom1";
            this.uS_AddRoom1.Size = new System.Drawing.Size(1882, 852);
            this.uS_AddRoom1.TabIndex = 0;
            this.uS_AddRoom1.Load += new System.EventHandler(this.uS_AddRoom1_Load);
            // 
            // panelMoving
            // 
            this.panelMoving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelMoving.Location = new System.Drawing.Point(139, 156);
            this.panelMoving.Name = "panelMoving";
            this.panelMoving.Size = new System.Drawing.Size(300, 7);
            this.panelMoving.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.panelMoving);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnMinisize);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinisize;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnEployee;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDetail;
        private Guna.UI2.WinForms.Guna2Button btnChekcOut;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRts;
        private Guna.UI2.WinForms.Guna2Panel panelMoving;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Control.US_AddRoom uS_AddRoom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_User_Control.US_CustomerRes uS_CustomerRes1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Control.US_CheckOut uS_CheckOut1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_User_Control.CustomerResDetails customerResDetails1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private All_User_Control.US_Employee uS_Employee1;
    }
}
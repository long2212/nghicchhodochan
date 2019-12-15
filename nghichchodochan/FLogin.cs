using nghichchodochan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nghichchodochan
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void btnDangki_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("con Giang ngáo lắm");
            
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            //StringConn.serve = txbServer.Text;

            string userName = txtuserName.Text;
            string passWord = txtPassWord.Text;

            if (userName == "") MessageBox.Show("Bạn chưa điền Tên đăng nhập!!!");
            else if (passWord == "") MessageBox.Show("Bạn chưa điền Mật khẩu!!!");
            else if (Login(userName, passWord))
            {
                FAdmin thisinh = new FAdmin();
                this.Hide();
                thisinh.ShowDialog();
                //this.Show();
            }
            else MessageBox.Show("Bạn điền sai Tên đăng nhập hoặc Mật khẩu!!!");
        }

        bool Login (string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}

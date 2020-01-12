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
    public partial class FFinish : Form
    {
        public FFinish()
        {
            InitializeComponent();
            dgwListAns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwListAns.DataSource = Method.ViewFinish();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        int flagFinish = 0;
        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (flagFinish == 0)
            {
                String query = "exec PlusChooseUser";
                DataProvider.Instance.ExecuteNonQuery(query);

                String query2 = "exec resetisans";
                DataProvider.Instance.ExecuteNonQuery(query2);
                //MessageBox.Show("Kết quả đã được lưu lại");
                btnPre.Enabled = false;
                for (int i = 1; i <= 20; i++)
                {
                    Count.lastpoint += Count.point[i];
                }
                string a = "";
                a += "Trầm cảm: ";
                if (Count.lastpoint < 41)
                {
                    a += "Nhẹ";
                }
                else if (Count.lastpoint < 51)
                {
                    a += "Vừa";
                }
                else
                {
                    a += "Nặng";
                }

                
                MessageBox.Show(a);
                btnFinish.Text = "Kết thúc";
                flagFinish = 1;
            } else if(flagFinish==1)
            {
                Application.Exit();
            }
        }

        private void FFinish_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void FFinish_Load(object sender, EventArgs e)
        {

        }
    }
}

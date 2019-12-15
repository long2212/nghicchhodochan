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
                if (Count.lastpoint < 10)
                {
                    a += "Bình thương";
                }
                else if (Count.lastpoint < 14)
                {
                    a += "Nhẹ";
                }
                else if (Count.lastpoint < 21)
                {
                    a += "Vừa";
                }
                else if (Count.lastpoint < 28)
                {
                    a += "Nặng";
                }
                else
                {
                    a += "Rất nặng";
                }

                a += "\nLo âu: ";
                if (Count.lastpoint < 8)
                {
                    a += "Bình thương";
                }
                else if (Count.lastpoint < 10)
                {
                    a += "Nhẹ";
                }
                else if (Count.lastpoint < 15)
                {
                    a += "Vừa";
                }
                else if (Count.lastpoint < 20)
                {
                    a += "Nặng";
                }
                else
                {
                    a += "Rất nặng";
                }

                a += "\nStress: ";
                if (Count.lastpoint < 15)
                {
                    a += "Bình thương";
                }
                else if (Count.lastpoint < 19)
                {
                    a += "Nhẹ";
                }
                else if (Count.lastpoint < 26)
                {
                    a += "Vừa";
                }
                else if (Count.lastpoint < 34)
                {
                    a += "Nặng";
                }
                else
                {
                    a += "Rất nặng";
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

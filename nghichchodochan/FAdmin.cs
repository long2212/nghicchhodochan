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
    public partial class FAdmin : Form
    {
        public FAdmin()
        {
            InitializeComponent();
            gbxListQue.Text = "Số câu hỏi đã chọn: 0";
            addBtn();
            dtwListQueOfData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtwListQueOfData.DataSource = Method.ViewListQueOfData();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Count.Sottcauhoi = 1;
            if (Count.Sottdanhsachcauhoi > 1 && Count.Sottdanhsachcauhoi < 21)
            {
                MessageBox.Show("Bạn chưa chọn xong câu hỏi cho thí sinh");
            }
            else if (Count.Sottdanhsachcauhoi == 21 || Count.Sottdanhsachcauhoi == 1)
            {
                if (Count.Sottdanhsachcauhoi == 1)
                {
                    MessageBox.Show("Bạn chưa chọn câu hỏi cho thí sinh nên các câu hỏi sẽ mặc định từ 1 đến 20 trong bộ đề");
                }
                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        void addBtn()
        {
            Button oldbtn = new Button() { Width = 0, Location = new Point(0, 0) };

            int sott = 1;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    Button btn = new Button()
                    {
                        Width = 30,
                        Height = 30,
                        Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y),
                        Text = sott.ToString()
                    };
                    sott++;
                    pnlListQue.Controls.Add(btn);

                    btn.Click += Btn_Click;
                    oldbtn = btn;
                }
                oldbtn.Location = new Point(0, oldbtn.Location.Y + 30);
                oldbtn.Width = 0;
                oldbtn.Height = 0;
                sott--;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (Count.Sottdanhsachcauhoi <= 20) 
            {
                Button btn = sender as Button;
                Count.ListQue[Count.Sottdanhsachcauhoi] = Int32.Parse(btn.Text);
                btn.Enabled = false;
                //MessageBox.Show(Count.ListQue[Count.Sottdanhsachcauhoi].ToString());
                gbxListQue.Text = "Số câu hỏi đã chọn: ";   
                gbxListQue.Text += Count.Sottdanhsachcauhoi.ToString();
                Count.Sottdanhsachcauhoi++;
                if (Count.Sottdanhsachcauhoi >= 21)
                {
                    MessageBox.Show("Bạn đã chọn xong 20 Câu hỏi!!!");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FEditQue f = new FEditQue();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            dtwListQueOfData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtwListQueOfData.DataSource = Method.ViewListQueOfData();
        }
    }
}

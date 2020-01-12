using nghichchodochan.DAO;
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

namespace nghichchodochan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            load();
            addBtn();
            
        }

        void addBtn()
        {
            Button oldbtn = new Button() { Width = 0, Location = new Point(0, 0) };

            int sott = 1;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    Button btn = new Button()
                    {
                        Width = 30,
                        Height = 30,
                        Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y),
                        Text = sott.ToString(),
                        BackColor = Color.Moccasin
                    };
                    sott++;
                    pnlCQues.Controls.Add(btn);

                    btn.Click += btn_Click;
                    oldbtn = btn;
                }
                oldbtn.Location = new Point(0, oldbtn.Location.Y + 30);
                oldbtn.Width = 0;
                oldbtn.Height = 0;
                sott--;
            }
        }
            
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int sottch = Int32.Parse(btn.Text);

            Count.Sottcauhoi = sottch;

            gbCauhoi.Text = "Câu Hỏi ";
            gbCauhoi.Text += sottch.ToString();

            btnTl1.Text = Method.Cautraloi(sottch, 1);
            
            btnTl2.Text = Method.Cautraloi(sottch, 2);

            btnTl3.Text = Method.Cautraloi(sottch, 3);

            btnTl4.Text = Method.Cautraloi(sottch, 0);


            btnCauHoi.Text = Method.Cauhoi(sottch);
            
        }

        void load()
        {
            gbCauhoi.Text = "Câu Hỏi ";
            gbCauhoi.Text += Count.Sottcauhoi.ToString();

            btnTl1.Text = Method.Cautraloi(Count.ListQue[Count.Sottcauhoi], 1);
            btnTl2.Text = Method.Cautraloi(Count.ListQue[Count.Sottcauhoi], 2);
            btnTl3.Text = Method.Cautraloi(Count.ListQue[Count.Sottcauhoi], 3);
            btnTl4.Text = Method.Cautraloi(Count.ListQue[Count.Sottcauhoi], 0);

            btnCauHoi.Text = Method.Cauhoi(Count.ListQue[Count.Sottcauhoi]);
        }

        
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Count.Sottcauhoi < Count.max)
            {
                Count.Sottcauhoi++;
                load();
            }
        }

        private void btnPreviou_Click(object sender, EventArgs e)
        {
            
            if (Count.Sottcauhoi > Count.min)
            {
                Count.Sottcauhoi--;
                load();
            }
        }

        private void btnTl1_Click(object sender, EventArgs e)
        {
            Method.btnDapan(btnTl1.Text, btnTl2.Text, btnTl3.Text, btnTl4.Text);
        }

        private void btnTl2_Click(object sender, EventArgs e)
        {
            Method.btnDapan(btnTl2.Text, btnTl1.Text, btnTl3.Text, btnTl4.Text);
        }

        private void btnTl3_Click(object sender, EventArgs e)
        {
            Method.btnDapan(btnTl3.Text, btnTl2.Text, btnTl1.Text, btnTl4.Text);
        }

        private void btnTl4_Click(object sender, EventArgs e)
        {
            Method.btnDapan(btnTl4.Text, btnTl2.Text, btnTl3.Text, btnTl1.Text);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            FFinish nopbai = new FFinish();
            this.Hide();
            nopbai.ShowDialog();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
        
}

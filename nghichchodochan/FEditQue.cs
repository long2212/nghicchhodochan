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
    public partial class FEditQue : Form
    {
        public FEditQue()
        {
            InitializeComponent();
            addBtn();
        }


        void addBtn()
        {
            int size = 40;
            Button oldbtn = new Button() { Width = 0, Location = new Point(0, 0) };

            int sott = 1;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    Button btn = new Button()
                    {
                        Width = size,
                        Height = size,
                        Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y),
                        Text = sott.ToString(),
                        TabIndex = 13,
                        BackColor = Color.Moccasin
                    };
                    sott++;
                    pnlListQue.Controls.Add(btn);

                    btn.Click += Btn_Click;
                    oldbtn = btn;
                }
                oldbtn.Location = new Point(0, oldbtn.Location.Y + size);
                oldbtn.Width = 0;
                oldbtn.Height = 0;
                sott--;
            }
        }

        

        private int stt;
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int sottch = Int32.Parse(btn.Text);
            stt = sottch;
            Count.Sottcauhoi = sottch;
            //MessageBox.Show(sottch.ToString());

            Load(sottch);
        }
        new void Load(int sottch)
        {
            btnAns1.Text = Method.Cautraloi(sottch, 1);
            btnAns2.Text = Method.Cautraloi(sottch, 2);
            btnAns3.Text = Method.Cautraloi(sottch, 3);
            btnAns4.Text = Method.Cautraloi(sottch, 0);

            btnPoint1.Text = Method.PointAns(sottch, 1);
            btnPoint2.Text = Method.PointAns(sottch, 2);
            btnPoint3.Text = Method.PointAns(sottch, 3);
            btnPoint4.Text = Method.PointAns(sottch, 0);


            btnQueEdit.Text = Method.Cauhoi(sottch);
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txbQue.Text != "")
            {
                Method.UpdateQue(txbQue.Text, Count.Sottcauhoi.ToString());
            }

            if (txbAns1.Text != "")
            {
                Method.UpdateAns(txbAns1.Text, Count.Sottcauhoi.ToString(), "1");
            }
            if (txbAns2.Text != "")
            {
                Method.UpdateAns(txbAns2.Text, Count.Sottcauhoi.ToString(), "2");
            }
            if (txbAns3.Text != "")
            {
                Method.UpdateAns(txbAns3.Text, Count.Sottcauhoi.ToString(), "3");
            }
            if (txbAns4.Text != "")
            {
                Method.UpdateAns(txbAns4.Text, Count.Sottcauhoi.ToString(), "4");
            }

            if (txbPoin1.Text != "")
            {
                Method.UpdatePointAns(txbPoin1.Text, Count.Sottcauhoi.ToString(), "1");
            }
            if (txbPoin2.Text != "")
            {
                Method.UpdatePointAns(txbPoin2.Text, Count.Sottcauhoi.ToString(), "2");
            }
            if (txbPoin3.Text != "")
            {
                Method.UpdatePointAns(txbPoin3.Text, Count.Sottcauhoi.ToString(), "3");
            }
            if (txbPoin4.Text != "")
            {
                Method.UpdatePointAns(txbPoin4.Text, Count.Sottcauhoi.ToString(), "4");
            }
            LoadEdit(Count.Sottcauhoi);
        }

        void LoadEdit (int Sottcauhoi)
        {
            txbQue.Text = "";
            txbAns1.Text = "";
            txbAns2.Text = "";
            txbAns3.Text = "";
            txbAns4.Text = "";

            txbPoin4.Text = "";
            txbPoin3.Text = "";
            txbPoin2.Text = "";
            txbPoin1.Text = "";

            Load(stt);
        }

        FAdmin Fadmin = new FAdmin();
        private void btnBack_Click(object sender, EventArgs e)
        {            
            this.Hide();
            Fadmin.ShowDialog();
            this.Show();
        }
    }
}

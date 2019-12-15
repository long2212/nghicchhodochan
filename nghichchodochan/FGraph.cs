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
    public partial class FGraph : Form
    {
        public FGraph()
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
                        TabIndex = 13
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

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int sottch = Int32.Parse(btn.Text);
            Count.Sottcauhoi = sottch;

            LoadGraph(sottch);
        }
        void LoadGraph(int sottch)
        {
            pnlGraph.Controls.Clear();
            int size = 35;
            Button oldbtn = new Button() { Width = 0, Location = new Point(0, 0) };
            int dem = 1;
            for (int j = 0; j < 4; j++)
            {
                Button btn = new Button()
                {
                    Width = size,
                    Height = Int32.Parse(Method.Userchoose(sottch, dem)) * 20,
                    Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y),
                    Text = Method.Userchoose(sottch, dem),
                    TabIndex = 13
                };
                pnlGraph.Controls.Add(btn);
                dem++;

                oldbtn = btn;
                
            }

        }
    }
}

using nghichchodochan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nghichchodochan
{
    class Method
    {
        // bỏ chọn đáp án
        public static void UpdateIsNotAns(string Ques)
        {
            String query = "exec IsNot_Ans N'" + Ques + "', " + Count.Sottcauhoi.ToString() + "";

            DataProvider.Instance.ExecuteNonQuery(query);
        }

        //chọn đap án
        public static void UpdateIsAns(string Ans)
        {
            String query = "exec Is_Ans N'" + Ans + "', " + Count.Sottcauhoi.ToString();

            DataProvider.Instance.ExecuteNonQuery(query);       
        }

        public static float PointAns(string Ans)
        {
            float b = 0;
            String query = "exec PointAns N'" + Ans + "', " + Count.Sottcauhoi.ToString();

            b = DataProvider.Instance.ExecuteNonQuery(query);
            MessageBox.Show(b.ToString());
            return b;
        }
        // chọn đáp án, vị trí a là đáp án được chọn, còn lại là không chọn
        public static void btnDapan(string a, string b, string c, string d)
        {
            UpdateIsAns(a);
            UpdateIsNotAns(b);
            UpdateIsNotAns(c);
            UpdateIsNotAns(d);
            //Count.point[0] = 0;
            int diem = PointAnsint(a);
            Count.point[Count.Sottcauhoi] = diem;
            
        }

        // a = 1; a = "1"

        // chọn câu trả lời ra btn
        public static String Cautraloi(int Cauhoi, int Cautl)
        {
            String cautl = "";
            String query = "exec Choose_Ans " + Cauhoi.ToString() + ", " + Cautl.ToString() + "";

            return cautl = DataProvider.Instance.ExecuteScalar(query).ToString();
        }

        // hiện điểm của câu trả lời ra btn hiện chuỗi
        public static String PointAns(int Cauhoi, int Cautl)
        {
            String cautl = "";
            String query = "exec Choose_PointAns " + Cauhoi.ToString() + ", " + Cautl.ToString() + "";

            return cautl = DataProvider.Instance.ExecuteScalar(query).ToString();
        }

        // hiện điểm của câu trả lời ra btn hiện số: int
        public static int PointAnsint(string Cautl)
        {
            String query = "exec PointAns N'"+ Cautl + "'," + Count.Sottcauhoi.ToString();

            return Int32.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());
        }

        // chọn câu hỏi ra btn
        public static String Cauhoi(int Cauhoi)
        {
            String cauhoi = "";
            String query = "exec Choose_Que " + Cauhoi.ToString() + "";

            return cauhoi = DataProvider.Instance.ExecuteScalar(query).ToString();
        }

        // Lấy dữ liệu của câu hỏi đổ về dgw
        public static DataTable ViewFinish()
        {
            //DataSet data = new DataSet();

            String query = "exec ViewFinish";

            DataTable tableFinish = DataProvider.Instance.ExecuteQuery(query);



            return tableFinish;
        }

        public static DataTable ViewListQueOfData()
        {
            //DataSet data = new DataSet();

            String query = "select * from Questions";

            DataTable tableFinish = DataProvider.Instance.ExecuteQuery(query);



            return tableFinish;
        }

        public static void UpdateAns(string Ans, string NoQue, string AnsQ)
        {
            String query = "exec update_Ans N'" + Ans + "', " + NoQue + ", " + AnsQ;

            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static String Userchoose(int Cauhoi, int Cautl)
        {
            String cautl = "";
            String query = "exec Choosesize " + Cauhoi.ToString() + ", " + Cautl.ToString() + "";

            return cautl = DataProvider.Instance.ExecuteScalar(query).ToString();
        }

        public static void UpdatePointAns(string Point, string NoQue, string AnsQ)
        {
            String query = "exec update_PointAns N'" + Point + "', " + NoQue + ", " + AnsQ;

            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static void UpdateQue(string Que_id, string NoQue)
        {
            String query = "exec update_Que N'" + Que_id + "'," + NoQue + "";

            DataProvider.Instance.ExecuteNonQuery(query);
        }



    }
}

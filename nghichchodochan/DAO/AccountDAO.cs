using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nghichchodochan.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            //int i = 1;
            string query2 = "select * from accounts where UserName = '" + username + "' and PassWord = '" + password + "'";

            DataTable result2 = DataProvider.Instance.ExecuteQuery(query2);
            return result2.Rows.Count > 0;

        }
    }
}

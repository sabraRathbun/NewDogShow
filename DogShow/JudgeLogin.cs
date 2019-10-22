using PetaPoco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogShow
{
    public partial class JudgeLogin : Form
    {
        public JudgeLogin()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            bool log;
            JudgementPage judge = new JudgementPage();
           

            log = LoginAuthenticate(username, password);
            if(log == true)
            {
                judge.Show();
            }
            else
            {
                errorLbl.Visible = true;
            }
        }

        public bool LoginAuthenticate(string user, string pass)
        {
            string result;
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "select `username` from `judgeLogin` where `username` = @0 AND `userPassword` = @1; ";
                var results = db.Fetch<string>(sql, user, pass);
                result = results.FirstOrDefault();
                if(result == null)
                {
                    return false;
                }
                else if (result.Equals(user))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}

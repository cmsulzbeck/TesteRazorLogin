using Login_MVC_.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login_MVC_.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        void ConnectionString()
        {
            con.ConnectionString = @"data source = (LocalDb)\LocalDBDemo; database=CustomerContact; integrated security = SSPI";
        }

        [HttpPost]
        public ActionResult Verify(Account account)
        {
            ConnectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Usuario where usr_email='" + account.Name + "' and usr_pw='" + account.Password + "'";

            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();

                if (account.Name.Contains("admin"))
                {
                    return View("CustomerListAdmin");
                }
                else
                {
                    return View("CustomerList");
                }
            }
            else
            {
                con.Close();

                return View("Error");
            }
        }

        [HttpGet]
        public ActionResult PopulateTable()
        {
            ConnectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Client";

            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();

                return View();
            }
            else
            {
                con.Close();

                return View("Error");
            }
        }
    }
}
using Enchanter_Fashion.DBConnection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Enchanter_Fashion.Signup_and_Registration
{
    public class databasecrudoperations
    {
        public string errormaages;
        public string username;

        public bool checklogin(string username, string password)
        {
            try
            {
                int withuser__count=0, Withemial_count=0;
                MySqlConnection con = DBConection.getconnection();
                string query = "SELECT COUNT(username) AS count FROM registration WHERE username = '" + username + "' AND password ='" + password + "';";
                Console.WriteLine(query);
                MySqlCommand mycmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader dr = mycmd.ExecuteReader();
                while (dr.Read())
                {
                    withuser__count = dr.GetInt32("count");
                }
                con.Close();

                query = "SELECT COUNT(email) AS count FROM registration WHERE email = '" + username + "' AND password ='" + password + "';";
                mycmd = new MySqlCommand(query, con);
                con.Open();
                dr = mycmd.ExecuteReader();
                while (dr.Read())
                {
                    Withemial_count = dr.GetInt32("count");
                }
                con.Close();

                if(withuser__count == 1 || Withemial_count == 1)
                {
                    if(withuser__count == 1)
                    {
                        query = "SELECT name FROM registration WHERE username = '" + username + "';";
                    }
                    else
                    {
                        query = "SELECT name FROM registration WHERE email = '" + username + "';";
                    }
                    mycmd = new MySqlCommand(query, con);
                    con.Open();
                    dr = mycmd.ExecuteReader();
                    while (dr.Read())
                    {
                        this.username = dr.GetString("name").ToString();
                    }
                    con.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException exp)
            {

            }
            return false;
        }

        public bool checkusername(string name)
        {
            try
            {
                int count = 0;
                MySqlConnection con = DBConection.getconnection();
                string query = "SELECT COUNT(username) AS count FROM registration WHERE username = '" + name + "';";
                Console.WriteLine(query);
                MySqlCommand mycmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader dr = mycmd.ExecuteReader();
                while (dr.Read())
                {
                    count = dr.GetInt32("count");
                }
                con.Close();
                if(count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exp)
            {

            }
            return false;
        }

        public bool checkemail(string email)
        {
            try
            {
                int count = 0;
                MySqlConnection con = DBConection.getconnection();
                string query = "SELECT COUNT(email) AS count FROM registration WHERE email = '" + email + "';";
                Console.WriteLine(query);
                MySqlCommand mycmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader dr = mycmd.ExecuteReader();
                while (dr.Read())
                {
                    count = dr.GetInt32("count");
                }
                con.Close();
                if (count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exp)
            {

            }
            return false;
        }

        public void registeringcompleting(string username, string email, string name, int phonenumber, string password, string gender, string bookname, string school) 
        {
            try
            {
                int empnum = 0;
                MySqlConnection con = DBConection.getconnection();
                string query = "SELECT MAX(emp_no) AS max FROM registration ;";
                Console.WriteLine(query);
                MySqlCommand mycmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader dr = mycmd.ExecuteReader();
                while (dr.Read())
                {
                    empnum = dr.GetInt32("max");
                }
                con.Close();
                int new_empnum = empnum + 1;
                query = "insert into registration(username, password, email, gender, phone_no, name, emp_no, question_1, question_2) values('" + username + "','" + password + "','" + email + "','" + gender + "','" + phonenumber + "','" + name + "','" + new_empnum + "','" + bookname + "','" + school + "')";
                Console.WriteLine(query);
                mycmd = new MySqlCommand(query, con);
                con.Open();
                dr = mycmd.ExecuteReader();
                while (dr.Read())
                {
                }
                con.Close();
            }
            catch (MySqlException exp)
            {

            }
        }

        public bool check_answers(string schoolname, string bookname, string text)
        {
            string username = "", email = "";
            try
            {
                MySqlConnection con = DBConection.getconnection();
                string query = "SELECT username, email FROM registration WHERE question_1 = '" + schoolname + "' AND question_2 = '" + bookname + "'; ";
                Console.WriteLine(query);
                MySqlCommand mycmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader dr = mycmd.ExecuteReader();
                while (dr.Read())
                {
                    username = dr.GetString("username").ToString();
                    email = dr.GetString("email").ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {

            }

            if(username == text || email == text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidatePassword(string password)
        {
            var input = password;
            errormaages = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                errormaages = "Password should contain At least one lower case letter";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                errormaages = "Password should contain At least one upper case letter";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                errormaages = "Password should not be less than or greater than 12 characters";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                errormaages = "Password should contain At least one numeric value";
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                errormaages = "Password should contain At least one special case characters";
                return false;
            }
            else
            {
                return true;
            }
        }

        public void updatepassword(string password)
        {
            try
            {
                MySqlConnection con = DBConection.getconnection();
                string query = "update password FROM registration set password='" + password + "'; ";
                Console.WriteLine(query);
                MySqlCommand mycmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader dr = mycmd.ExecuteReader();
                while (dr.Read())
                {
                }
                con.Close();
            }
            catch(Exception ex)
            {

            }
        }
    }
}

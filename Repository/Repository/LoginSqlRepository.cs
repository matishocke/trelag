using Abstraction.IRepository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{

    public class LoginSqlRepository : ILoginRepository
    {
        string path = string.Empty;
        public LoginSqlRepository()
        {
            path = ConfigurationManager.ConnectionStrings["DbClean"].ToString(); ///////////
        }

        public async Task<bool> Login(string username, string password, string userType)
        {
            SqlConnection connection = new SqlConnection(path);

            if (userType == "admin")
            {
                SqlCommand cmd = new SqlCommand  //Find the usertype with username and password and usertype
                    ("SELECT userType FROM Admin WHERE userName = @username AND password = @password AND userType = @usertype", connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@usertype", userType);

                try
                {
                    connection.Open();
                    object obj = cmd.ExecuteScalar();   //Try to run that query
                    connection.Close();
                    if (obj != null)  //if you could run it so it is true
                    {
                        return await Task.FromResult(true);
                    }
                    else              //if not so false
                    {
                        return await Task.FromResult(false);
                    }
                }
                catch (Exception)
                {
                    connection.Close();
                    return await Task.FromResult(false);
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand  //Find the usertype with username and password and usertype
                    ("SELECT userType FROM Customer WHERE userName = @username AND password = @password AND userType = @usertype", connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@usertype", userType);

                try
                {
                    connection.Open();
                    object obj = cmd.ExecuteScalar();   //Try to run that query
                    connection.Close();
                    if (obj != null)  //if you could run it so it is true
                    {
                        return await Task.FromResult(true);
                    }
                    else              //if not so false
                    {
                        return await Task.FromResult(false);
                    }
                }
                catch (Exception)
                {
                    connection.Close();
                    return await Task.FromResult(false);
                }
            }
        }
    }
}

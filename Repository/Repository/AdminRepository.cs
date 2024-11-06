using Abstraction.IModels;
using Abstraction.IRepository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class AdminRepository : IAdminRepository
    {
        string path = string.Empty;
        public AdminRepository()
        {
            path = ConfigurationManager.ConnectionStrings["DbClean"].ToString();
        }





        //Read All 
        public async Task<List<IAdmin>> GetAllAdmins()
        {
            List<IAdmin> adminList = new List<IAdmin>();

            SqlConnection connection = new SqlConnection(path);
            try
            {
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand("SELECT * FROM Admin", connection);

                SqlDataReader reader = await command.ExecuteReaderAsync();
                while (reader.Read())
                {
                    IAdmin admin = new Admin();
                    admin.UserName = (string)reader["userName"];
                    admin.Password = (string)reader["password"];
                    admin.UserType = (string)reader["userType"];
                    admin.AdminID = (int)reader["adminID"];
                    admin.FirstName = (string)reader["firstName"];
                    admin.LastName = (string)reader["lastName"];
                    admin.PhoneNumber = (string)reader["phoneNumber"];
                    admin.Email = (string)reader["email"];
                    admin.Address = (string)reader["address"];
                    admin.Salary = (string)reader["salary"];

                    adminList.Add(admin);
                }

                await connection.CloseAsync();

                return adminList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                throw new Exception("Failed to retrieve admin from the database", ex);
            }
        }


        //Read By ID
        public IAdmin GetAdminByID(int adminID)
        {
            SqlConnection connection = new SqlConnection(path);
            try
            {
                connection.Open();

                SqlCommand command =
                    new SqlCommand("SELECT * FROM Admin WHERE adminID = @adminid", connection);
                command.Parameters.AddWithValue("@adminid", adminID);

                SqlDataReader reader = command.ExecuteReader();

                IAdmin admin = null;
                while (reader.Read())
                {
                    admin = new Admin();
                    admin.UserName = (string)reader["userName"];
                    admin.Password = (string)reader["password"];
                    admin.UserType = (string)reader["userType"];
                    admin.AdminID = (int)reader["adminID"];
                    admin.FirstName = (string)reader["firstName"];
                    admin.LastName = (string)reader["lastName"];
                    admin.PhoneNumber = (string)reader["phoneNumber"];
                    admin.Email = (string)reader["email"];
                    admin.Address = (string)reader["address"];
                    admin.Salary = (string)reader["salary"];
                }


                connection.Close();

                return admin;
            }

            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);

                throw new Exception("Failed to retrieve the admin", ex);
            }
        }





        //Read By UserName
        public IAdmin GetAdminByUserName(string username)
        {
            SqlConnection connection = new SqlConnection(path);
            try
            {
                connection.Open();

                SqlCommand command =
                    new SqlCommand("SELECT * FROM Admin WHERE userName = @username", connection);
                command.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = command.ExecuteReader();

                IAdmin admin = null;
                while (reader.Read())
                {
                    admin = new Admin();
                    admin.UserName = (string)reader["userName"];
                    admin.Password = (string)reader["password"];
                    admin.UserType = (string)reader["userType"];
                    admin.AdminID = (int)reader["adminID"];
                    admin.FirstName = (string)reader["firstName"];
                    admin.LastName = (string)reader["lastName"];
                    admin.PhoneNumber = (string)reader["phoneNumber"];
                    admin.Email = (string)reader["email"];
                    admin.Address = (string)reader["address"];
                    admin.Salary = (string)reader["salary"];
                }


                connection.Close();

                return admin;
            }

            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);

                throw new Exception("Failed to retrieve the admin", ex);
            }

        }






        //Create
        public async Task<bool> CreateAdmin(string username, string password, string usertype, string firstname,
            string lastname, string phonenumber, string email, string address, string salary)
        {
            SqlConnection connection = new SqlConnection(path);
            try
            {
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand("INSERT INTO Admin (userName, password, userType, firstName, lastName, phoneNumber, email, address, salary) VALUES (@username, @password, @usertype, @firstname, @lastname, @phonenumber, @email, @address, @salary)", connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@usertype", usertype);
                command.Parameters.AddWithValue("@firstname", firstname);
                command.Parameters.AddWithValue("@lastname", lastname);
                command.Parameters.AddWithValue("@phonenumber", phonenumber);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@salary", salary);

                await command.ExecuteNonQueryAsync();
                await connection.CloseAsync();
                return await Task.FromResult(true);
            }
            catch (Exception)
            {
                return await Task.FromResult(false);
            }
        }





        //Delete
        public async Task<bool> DeleteAdmin(int adminid)
        {
            SqlConnection connection = new SqlConnection(path);
            try
            {
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand
                    ("DELETE FROM Admin WHERE adminID = @adminid", connection);
                command.Parameters.AddWithValue("@adminid", adminid);

                int result = await command.ExecuteNonQueryAsync();

                if (result == 0)  //if tried was NOT successfull 
                {
                    return await Task.FromResult(false);
                }
                else //result != 0
                {
                    return await Task.FromResult(true);
                }
            }
            catch (Exception)
            {
                return await Task.FromResult(false);
            }
        }


        //Update
        public async Task<bool> UpdateAdmin(int adminID, string username, string password, string firstname,
            string lastname, string phonenumber, string email, string address, string salary)
        {
            SqlConnection connection = new SqlConnection(path);

            try
            {
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand
                ("UPDATE Admin SET password = @password ,firstName = @firstname, lastName = @lastname, phoneNumber = @phonenumber, email = @email, address = @address, userName = @username, salary = @salary WHERE adminID = @adminid", connection);
                command.Parameters.AddWithValue("@adminid", adminID);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@firstname", firstname);
                command.Parameters.AddWithValue("@lastname", lastname);
                command.Parameters.AddWithValue("@phonenumber", phonenumber);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@salary", salary);

                int result = await command.ExecuteNonQueryAsync();
                await connection.CloseAsync();
                if (result != 1) 
                {
                    return false; 
                }
                return true;

            }
            catch (Exception)
            {
                return await Task.FromResult(false);
            }
        }
    }
}

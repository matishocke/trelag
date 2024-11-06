using Abstraction.IModels;
using Abstraction.IRepository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        string path = string.Empty;
        public CustomerRepository()
        {
            path = ConfigurationManager.ConnectionStrings["DbClean"].ToString(); 
        }





        //READ ALL
        public async Task<List<ICustomer>> GetAllCustomers()
        {
            List<ICustomer> customerList = new List<ICustomer>();

            SqlConnection connection = new SqlConnection(path);
            try
            {
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand("SELECT * FROM Customer", connection);

                SqlDataReader reader = await command.ExecuteReaderAsync();
                while (reader.Read())
                {
                    ICustomer customer = new Customer();
                    customer.Username = (string)reader["userName"];
                    customer.Password = (string)reader["password"];
                    customer.UserType = (string)reader["userType"];
                    customer.CustomerId = (int)reader["customerID"];
                    customer.Firstname = (string)reader["firstName"];
                    customer.Lastname = (string)reader["lastName"];
                    customer.PhoneNumber = (string)reader["phoneNumber"];
                    customer.Email = (string)reader["email"];
                    customer.Address = (string)reader["address"];
                    customerList.Add(customer);
                }

                await connection.CloseAsync();

                return customerList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                throw new Exception("Failed to retrieve customers from the database", ex);
            }
            
        }



        




        //READ One
        public ICustomer GetCustomer(string username)
        {
            SqlConnection connection = new SqlConnection(path);
            try
            {
                connection.Open();

                SqlCommand command =
                    new SqlCommand("SELECT * FROM Customer WHERE userName = @username", connection);
                command.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = command.ExecuteReader();

                Customer customer = new Customer();
                while (reader.Read())
                {
                    customer.Username = (string)reader["username"];
                    customer.Password = (string)reader["password"];
                    customer.UserType = (string)reader["usertype"];
                    customer.Firstname = (string)reader["firstname"];
                    customer.Lastname = (string)reader["lastname"];
                    customer.PhoneNumber = (string)reader["phonenumber"];
                    customer.Email = (string)reader["email"];
                    customer.Address = (string)reader["address"];
                    customer.CustomerId = (int)reader["customerID"];
                }
                connection.Close();

                return customer;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                
                throw new Exception("Failed to retrieve the customer", ex);
            }
            
        }


        public ICustomer GetCustomerByID(int customerID)
        {
            SqlConnection connection = new SqlConnection(path);
            try
            {
                connection.Open();

                SqlCommand command =
                    new SqlCommand("SELECT * FROM Customer WHERE customerID = @customerid", connection);
                command.Parameters.AddWithValue("@customerid", customerID);

                SqlDataReader reader = command.ExecuteReader();

                Customer customer = new Customer();
                while (reader.Read())
                {
                    customer.Username = (string)reader["username"];
                    customer.Password = (string)reader["password"];
                    customer.UserType = (string)reader["usertype"];
                    customer.Firstname = (string)reader["firstname"];
                    customer.Lastname = (string)reader["lastname"];
                    customer.PhoneNumber = (string)reader["phonenumber"];
                    customer.Email = (string)reader["email"];
                    customer.Address = (string)reader["address"];
                    customer.CustomerId = (int)reader["customerID"];
                }
                connection.Close();

                return customer;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);

                throw new Exception("Failed to retrieve the customer", ex);
            }

        }





        //CREATE
        public async Task<bool> CreateCustomer(string username, string password, string usertype,
            string firstname, string lastname, string phonenumber, string email, string address)
        {
            SqlConnection connection = new SqlConnection(path);
            try
            {
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand("INSERT INTO Customer (userName, password, userType, firstName, lastName, phoneNumber, email, address) VALUES (@username, @password, @usertype, @firstname, @lastname, @phonenumber, @email, @address)", connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@usertype", usertype);
                command.Parameters.AddWithValue("@firstname", firstname);
                command.Parameters.AddWithValue("@lastname", lastname);
                command.Parameters.AddWithValue("@phonenumber", phonenumber);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@address", address);

                await command.ExecuteNonQueryAsync();
                await connection.CloseAsync();
                return await Task.FromResult(true);
            }
            catch (Exception)
            {
                return await Task.FromResult(false);
            }
            
        }








        //UPDATE
        public async Task<bool> UpdateCustomer(int customerID, string username, string password, string firstname, string lastname,
            string phonenumber, string email, string address)
        {
            SqlConnection connection = new SqlConnection(path);

            try
            {
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand
                ("UPDATE Customer SET password = @password ,firstName = @firstname, lastName = @lastname, phoneNumber = @phonenumber, email = @email, address = @address, userName = @username WHERE customerID = @customerid", connection);
                command.Parameters.AddWithValue("@customerid", customerID);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@firstname", firstname);
                command.Parameters.AddWithValue("@lastname", lastname);
                command.Parameters.AddWithValue("@phonenumber", phonenumber);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@address", address);

                int result = await command.ExecuteNonQueryAsync();
                await connection.CloseAsync();
                if (result != 1) { return false; }
                return true;

            }
            catch (Exception) 
            {
                return await Task.FromResult(false);
            }
        }







        //DELETE
        public async Task<bool> DeleteCustomer(int customerid)
        {
            SqlConnection connection = new SqlConnection(path);
            try
            {
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand
                    ("DELETE FROM Customer WHERE customerID = @customerid", connection);
                command.Parameters.AddWithValue("@customerid", customerid);

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


    }
}

using Abstraction.IModels;
using Abstraction.IRepository;
using Abstraction.IService;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class RequestRepository : IRequestRepository
    {
        string path = string.Empty;
        public RequestRepository()
        {
            path = ConfigurationManager.ConnectionStrings["DbClean"].ToString();
        }





        //READ ALL
        public async Task<List<IRequest>> GetAllRequests()
        {
            List<IRequest> requestList = new List<IRequest>();

            SqlConnection connection = new SqlConnection(path);
            await connection.OpenAsync();

            SqlCommand command = new SqlCommand("SELECT * FROM Request", connection);
            SqlDataReader reader = await command.ExecuteReaderAsync();

            while (reader.Read())
            {
                IRequest request = new Request();
                request.RequestID = (int)reader["requestID"];


                // Fetch the customer details from the reader
                ICustomer customer = new Customer
                {
                    CustomerId = (int)reader["customerID"],
                    // Set other customer properties accordingly...
                };

                // Assign the concrete customer instance to the request
                (request as Request).Customer = customer;




                request.DateCreated = (DateTime)reader["dateCreated"];
                request.HasAlarm = (bool)reader["hasAlarm"];
                request.HasCleaningSupplies = (bool)reader["hasCleaningSupply"];
                request.HasPets = (bool)reader["hasPets"];
                request.Discount = (double)reader["discount"];
                requestList.Add(request);
            }

            await connection.CloseAsync();

            return requestList;
        }








        //READ ONE
        public async Task<IRequest> GetRequest(int requestID)
        {
            SqlConnection connection = new SqlConnection(path);
            await connection.OpenAsync();


            SqlCommand command = new SqlCommand("SELECT * FROM Request WHERE requestID = @requestid", connection);
            command.Parameters.AddWithValue("@requestid", requestID);

            SqlDataReader reader = await command.ExecuteReaderAsync();

            IRequest request = null;
            if (reader.HasRows)
            {
                request = new Request();
                while (reader.Read())
                {
                    request.RequestID = (int)reader["requestID"];


                    // Fetch the customer details from the reader
                    ICustomer customer = new Customer
                    {
                        CustomerId = (int)reader["customerID"],
                        // Set other customer properties accordingly...
                    };

                    // Assign the concrete customer instance to the request
                    (request as Request).Customer = customer;



                    request.DateCreated = (DateTime)reader["dateCreated"];
                    request.HasAlarm = (bool)reader["hasAlarm"];
                    request.HasCleaningSupplies = (bool)reader["hasCleaningSupply"];
                    request.HasPets = (bool)reader["hasPets"];
                    request.Discount = (double)reader["discount"];
                }
            }


            await connection.CloseAsync();
            return request;
        }





        //READ ONE
        public async Task<List<IRequest>> GetRequestByCustomerID(int customerID)
        {
            List<IRequest> requestListBySameCustomerID = new List<IRequest>();

            SqlConnection connection = new SqlConnection(path);
            await connection.OpenAsync();


            SqlCommand command = new SqlCommand("SELECT * FROM Request WHERE customerID = @customerid", connection);
            command.Parameters.AddWithValue("@customerid", customerID);

            SqlDataReader reader = await command.ExecuteReaderAsync();


            while (reader.Read())
            {
                IRequest request = new Request();
                request.RequestID = (int)reader["requestID"];
                request.DateCreated = (DateTime)reader["dateCreated"];
                request.HasAlarm = (bool)reader["hasAlarm"];
                request.HasCleaningSupplies = (bool)reader["hasCleaningSupply"];
                request.HasPets = (bool)reader["hasPets"];
                request.Discount = (double)reader["discount"];




                //request.Customer.CustomerId = (int)reader["customerID"];
                // Fetch the customer details from the reader
                ICustomer customer = new Customer
                {
                    CustomerId = (int)reader["customerID"],
                    // Set other customer properties accordingly...
                };

                // Assign the concrete customer instance to the request
                (request as Request).Customer = customer;

                requestListBySameCustomerID.Add(request);
            }


            await connection.CloseAsync();
            return requestListBySameCustomerID;
        }








        //CREATE
        public async Task<int> CreateRequest(ICustomer customer, DateTime dateCreated,
            bool hasAlarm, bool hasClearingSupply, bool hasPets, double discount)  //RETURNS requestID
        {
            SqlConnection connection = new SqlConnection(path);
            await connection.OpenAsync();

            SqlCommand command = new SqlCommand
            ("INSERT INTO Request (customerID, dateCreated, hasAlarm, hasCleaningSupply, hasPets, discount) " +
            "VALUES (@customerid, @datecreated, @hasalarm, @hascleaningsupply, @haspets, @discount); SELECT SCOPE_IDENTITY();", connection);  //SELECT SCOPE_IDENTITY() function will return the requestID of the newly inserted row in the Request table.
            command.Parameters.AddWithValue("@customerid", customer.CustomerId);
            command.Parameters.AddWithValue("@datecreated", dateCreated);
            command.Parameters.AddWithValue("@hasalarm", hasAlarm);
            command.Parameters.AddWithValue("@hascleaningsupply", hasClearingSupply);
            command.Parameters.AddWithValue("@haspets", hasPets);
            command.Parameters.AddWithValue("@discount", discount);

            int requestIDofNewINSERTBeenCreated = Convert.ToInt32(await command.ExecuteScalarAsync());
            await connection.CloseAsync();
            return requestIDofNewINSERTBeenCreated;
        }







        //DELETE
        public async Task<bool> DeleteRequest(int requestID)
        {
            SqlConnection connection = new SqlConnection(path);
            await connection.OpenAsync();

            SqlCommand deleteFavorLinesCommand = new SqlCommand
                ("DELETE FROM FavorLine WHERE requestID = @requestid", connection);
            deleteFavorLinesCommand.Parameters.AddWithValue("@requestid", requestID);
            await deleteFavorLinesCommand.ExecuteNonQueryAsync();

            SqlCommand command = new SqlCommand
                ("DELETE FROM Request WHERE requestID = @requestid", connection);
            command.Parameters.AddWithValue("@requestid", requestID);
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






        //UPDATE
        public async Task<bool> UpdateRequest(int requestID, ICustomer customerID,
            DateTime dateCreated, bool hasAlarm, bool hasCleaningSupply, bool hasPets, double discount)
        {
            SqlConnection connection = new SqlConnection(path);
            await connection.OpenAsync();

            SqlCommand command = new SqlCommand
            ("UPDATE Request SET customerID = @customerid, dateCreated = @datecreated, hasAlarm = @hasalarm, hasCleaningSupply = @hascleaningsupply, hasPets = @haspets, discount = @discount WHERE requestID = @requestid", connection);
            command.Parameters.AddWithValue("@requestid", requestID);
            command.Parameters.AddWithValue("@customerid", customerID.CustomerId);
            command.Parameters.AddWithValue("@datecreated", dateCreated);
            command.Parameters.AddWithValue("@hasalarm", hasAlarm);
            command.Parameters.AddWithValue("@hascleaningsupply", hasCleaningSupply);
            command.Parameters.AddWithValue("@haspets", hasPets);
            command.Parameters.AddWithValue("@discount", discount);

            await command.ExecuteNonQueryAsync();

            await connection.CloseAsync();

            return await Task.FromResult(true);
        }









        //public async Task<IRequest> GetRequest(int requestID)
        //{
        //    SqlConnection connection = new SqlConnection(path);
        //    await connection.OpenAsync();


        //    SqlCommand command = new SqlCommand("SELECT * FROM Request WHERE requestID = @requestid", connection);
        //    command.Parameters.AddWithValue("@requestid", requestID);

        //    SqlDataReader reader = await command.ExecuteReaderAsync();

        //    IRequest request = new Request();
        //    while (reader.Read())
        //    {
        //        request.RequestID = (int)reader["requestID"];




        //        // Fetch the customer details from the reader
        //        ICustomer customer = new Customer
        //        {
        //            CustomerId = (int)reader["customerID"],
        //            // Set other customer properties accordingly...
        //        };

        //        // Assign the concrete customer instance to the request
        //        (request as Request).Customer = customer;



        //        request.DateCreated = (DateTime)reader["dateCreated"];
        //        request.HasAlarm = (bool)reader["hasAlarm"];
        //        request.HasCleaningSupplies = (bool)reader["hasCleaningSupply"];
        //        request.HasPets = (bool)reader["hasPets"];
        //        request.Discount = (double)reader["discount"];
        //    }

        //    await connection.CloseAsync();
        //    return request;
        //}



    }
}

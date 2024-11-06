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
using System.Windows.Input;

namespace Repository.Repository
{
    public class FavorLineRepositoy : IFavorLineRepository
    {

        string path = string.Empty;
        public FavorLineRepositoy()
        {
            path = ConfigurationManager.ConnectionStrings["DbClean"].ToString();
        }




        public async Task<List<IFavorLine>> GetAllFavorLinesByFavorID(IRequest request, List<IFavorLine> listOfAllFavorLines)
        {

            List<IFavorLine> favorLinesBelongsTo = listOfAllFavorLines.Where(x => x.Request.RequestID == request.RequestID).ToList();

            return await Task.FromResult(favorLinesBelongsTo);
        }


        //READ all
        public async Task<List<IFavorLine>> GetAllFavorLines()
        {
            List<IFavorLine> favorLinesList = new List<IFavorLine>();

            SqlConnection connection = new SqlConnection(path);
            await connection.OpenAsync();

            SqlCommand command = new SqlCommand("SELECT * FROM FavorLine", connection);

            SqlDataReader reader = command.ExecuteReader();

            while (await reader.ReadAsync())
            {
                IFavorLine favorLine = new FavorLine();
                favorLine.FavorLineID = (int)reader["favorLineID"];


                IFavor favor = new Favor { FavorID = (int)reader["favorID"], FavorName = (string)reader["favorName"], };
                (favorLine as FavorLine).Favor = favor;


                IRequest request = new Request { RequestID = (int)reader["requestID"], };
                (favorLine as FavorLine).Request = request;


                favorLine.FavorQuantity = (int)reader["favorQuantity"];


                
                if (reader["favorStatus"] != DBNull.Value)
                {
                    favorLine.FavorStatus = (string)reader["favorStatus"];
                }
                else
                {
                    favorLine.FavorStatus = string.Empty;
                }


                if (reader["favorComment"] != DBNull.Value)
                {
                    favorLine.FavorComment = (string)reader["favorComment"];
                }
                else
                {
                    favorLine.FavorComment = string.Empty;
                }




                favorLinesList.Add(favorLine);
            }

            await connection.CloseAsync();
            return favorLinesList;
        }





        //READ one
        public async Task<IFavorLine> GetFavorLine(int favorLineID)
        {
            SqlConnection connection = new SqlConnection(path);
            await connection.OpenAsync();

            SqlCommand command = new SqlCommand
            ("SELECT * FROM FavorLine WHERE favorLineID = @favorlineid", connection);
            command.Parameters.AddWithValue("@favorlineid", favorLineID);

            SqlDataReader reader = command.ExecuteReader();

            IFavorLine favorLine = new FavorLine();
            while (await reader.ReadAsync())
            {
                favorLine.FavorLineID = (int)reader["favorLineID"];

                IFavor favor = new Favor { FavorID = (int)reader["favorID"], };
                (favorLine as FavorLine).Favor = favor;


                IRequest request = new Request { RequestID = (int)reader["requestID"], };
                (favorLine as FavorLine).Request = request;


                favorLine.FavorQuantity = (int)reader["favorQuantity"];



                if (reader["favorStatus"] != DBNull.Value)
                {
                    favorLine.FavorStatus = (string)reader["favorStatus"];
                }
                else
                {
                    favorLine.FavorStatus = string.Empty;
                }


                if (reader["favorComment"] != DBNull.Value)
                {
                    favorLine.FavorComment = (string)reader["favorComment"];
                }
                else
                {
                    favorLine.FavorComment = string.Empty;
                }


            }

            await connection.CloseAsync();
            return favorLine;
        }





        //CREATE
        public async Task<bool> CreateFavorLine(IFavor favorId, int requestID, int favorQuantity, IFavor favorName)
        {
            SqlConnection connection = new SqlConnection(path);
            await connection.OpenAsync();

            SqlCommand command = new SqlCommand
            ("INSERT INTO FavorLine (favorID, requestID, favorQuantity, favorName) VALUES (@favorid, @requestid, @favorquantity, @favorname)", connection);
            command.Parameters.AddWithValue("@favorid", favorId.FavorID);
            command.Parameters.AddWithValue("@requestid", requestID);
            command.Parameters.AddWithValue("@favorquantity", favorQuantity);
            command.Parameters.AddWithValue("@favorname", favorName.FavorName);

            await command.ExecuteNonQueryAsync();
            await connection.CloseAsync();

            return await Task.FromResult(true);
        }





        //DELETE
        public async Task<bool> DeleteFavorLine(int favorLineID)
        {
            SqlConnection connection = new SqlConnection(path);
            await connection.OpenAsync();


            SqlCommand command = new SqlCommand
                ("DELETE FROM FavorLine WHERE favorLineID = @favorlineid", connection);
            command.Parameters.AddWithValue("@favorlineid", favorLineID);


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
        public async Task<bool> UpdateFavorLine(int favorLineID, int favorQuantity)
        {
            SqlConnection connection = new SqlConnection(path);
            await connection.OpenAsync();


            SqlCommand command = new SqlCommand
            ("UPDATE FavorLine SET favorQuantity = @favorquantity WHERE favorLineID = @favorlineid", connection);
            command.Parameters.AddWithValue("@favorlineid", favorLineID);
            command.Parameters.AddWithValue("@favorquantity", favorQuantity);
            await command.ExecuteNonQueryAsync();


            await connection.CloseAsync();


            return await Task.FromResult(true);
        }

        public async Task<bool> InsertInspectorComments(int favorLineID, string favorStatus, string favorComment)
        {
            SqlConnection connection = new SqlConnection(path);
            await connection.OpenAsync();

            SqlCommand command = new SqlCommand(
                "UPDATE FavorLine SET favorStatus = @favorStatus, favorComment = @favorComment WHERE favorLineID = @favorLineID",
                connection);

            command.Parameters.AddWithValue("@favorStatus", favorStatus);
            command.Parameters.AddWithValue("@favorComment", favorComment);
            command.Parameters.AddWithValue("@favorLineID", favorLineID);

            await command.ExecuteNonQueryAsync();
            await connection.CloseAsync();

            return await Task.FromResult(true);
        }
    }
}

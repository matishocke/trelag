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
    public class FavorRepository : IFavorRepository
    {
        string path = string.Empty;
        public FavorRepository()
        {
            path = ConfigurationManager.ConnectionStrings["DbClean"].ToString();
        }






        //READ all
        public async Task<List<IFavor>> GetAllFavors()
        {
            List<IFavor> favorList = new List<IFavor>();

            SqlConnection connection = new SqlConnection(path);
            await connection.OpenAsync();

            SqlCommand command = new SqlCommand("SELECT * FROM Favor", connection);

            SqlDataReader reader = await command.ExecuteReaderAsync();
            while (reader.Read())
            {
                IFavor favor = new Favor();
                favor.FavorID = (int)reader["favorID"];
                favor.FavorName = (string)reader["favorName"];
                favor.UnitPrice = (double)reader["unitPrice"];

                favorList.Add(favor);
            }

            await connection.CloseAsync();

            return favorList;
        }









        //READ one
        public async Task<IFavor> GetFavor(int favorID)
        {
            SqlConnection connection = new SqlConnection(path);
            await connection.OpenAsync();

            SqlCommand command = new SqlCommand("SELECT * FROM Favor WHERE favorID = @favorid", connection);
            command.Parameters.AddWithValue("@favorid", favorID);

            SqlDataReader reader = command.ExecuteReader();

            IFavor favor = null;
            if (reader.HasRows)
            {
                favor = new Favor();
                while (await reader.ReadAsync())
                {
                    favor.FavorID = (int)reader["favorID"];
                    favor.FavorName = (string)reader["favorName"];
                    favor.UnitPrice = (double)reader["unitPrice"];
                }
            }
            
            await connection.CloseAsync();

            return favor;
        }








        //CREATE
        public async Task<bool> CreateFavor(string favorName, double unitPrice)
        {
            SqlConnection connection = new SqlConnection(path);
            await connection.OpenAsync();

            SqlCommand command = new SqlCommand
            ("INSERT INTO Favor (favorName, unitPrice) VALUES (@favorname, @unitprice)", connection);
            command.Parameters.AddWithValue("@favorname", favorName);
            command.Parameters.AddWithValue("@unitprice", unitPrice);

            await command.ExecuteNonQueryAsync();
            await connection.CloseAsync();

            return await Task.FromResult(true);
        }








        //DELETE
        public async Task<bool> DeleteFavor(int favorID)
        {
            SqlConnection connection = new SqlConnection(path);
            await connection.OpenAsync();

            SqlCommand command = new SqlCommand
                ("DELETE FROM Favor WHERE favorID = @favorid", connection);
            command.Parameters.AddWithValue("@favorid", favorID);

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
        public async Task<bool> UpdateFavor(int favorID, string favorName, double unitPrice)
        {
            SqlConnection connection = new SqlConnection(path);
            await connection.OpenAsync();

            SqlCommand command = new SqlCommand
            ("UPDATE Favor SET favorName = @favorname, unitPrice = @unitprice WHERE favorID = @favorid", connection);
            command.Parameters.AddWithValue("@favorid", favorID);
            command.Parameters.AddWithValue("@favorname", favorName);
            command.Parameters.AddWithValue("@unitprice", unitPrice);
            await command.ExecuteNonQueryAsync();

            await connection.CloseAsync();

            return await Task.FromResult(true);
        }




        //public async Task<List<IFavorLine>> GetAllfavorLinesWhichHaveSameID(IFavor favor)
        //{
        //    List<IFavorLine> listOfAllFavorLines = await _favorLineRepository.GetAllFavorLines();



        //    listOfAllFavorLines.Where(x => x.FavorID == favor.FavorID);

        //    return listOfAllFavorLines;
        //}
    }
}

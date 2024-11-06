using Abstraction.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.IRepository
{
    public interface IFavorLineRepository
    {
        Task<List<IFavorLine>> GetAllFavorLines();
        Task<IFavorLine> GetFavorLine(int favorLineID);


        Task<List<IFavorLine>> GetAllFavorLinesByFavorID(IRequest request, List<IFavorLine> listOfAllFavorLines);


        Task<bool> CreateFavorLine(IFavor favor, int requestID, int favorQuantity, IFavor favorName);
        Task<bool> UpdateFavorLine(int favorLineID, int favorQuantity);
        Task<bool> DeleteFavorLine(int favorLineID);

        Task<bool> InsertInspectorComments(int favorLineID, string favorStatus, string favorComment);
    }
}

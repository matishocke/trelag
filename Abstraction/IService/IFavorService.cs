using Abstraction.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.IService
{
    public interface IFavorService
    {
        Task<List<IFavor>> GetAllFavors();
        Task<IFavor> GetFavor(int favorID);
        Task<bool> CreateFavor(string favorName, double unitPrice);
        Task<bool> UpdateFavor(int favorID, string favorName, double unitPrice);
        Task<bool> DeleteFavor(int favorID);
    }
}

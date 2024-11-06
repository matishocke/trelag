using Abstraction.IModels;
using Abstraction.IRepository;
using Abstraction.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class FavorService : IFavorService
    {
        private readonly IFavorRepository _favorRepository;
        public FavorService(IFavorRepository favorRepository)
        {
            _favorRepository = favorRepository;
        }



        public async Task<List<IFavor>> GetAllFavors()
        {
            return await _favorRepository.GetAllFavors();
        }

        public async Task<IFavor> GetFavor(int favorID)
        {
            return await _favorRepository.GetFavor(favorID);
        }

        public async Task<bool> CreateFavor(string favorName, double unitPrice)
        {
            return await _favorRepository.CreateFavor(favorName, unitPrice);
        }

        public async Task<bool> DeleteFavor(int favorID)
        {
            return await _favorRepository.DeleteFavor(favorID);
        }

        public async Task<bool> UpdateFavor(int favorID, string favorName, double unitPrice)
        {
            return await _favorRepository.UpdateFavor(favorID, favorName, unitPrice);
        }
    }
}

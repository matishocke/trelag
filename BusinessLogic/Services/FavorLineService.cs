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
    public class FavorLineService : IFavorLineService
    {
        private readonly IFavorLineRepository _favorLineRepository;
        public FavorLineService(IFavorLineRepository favorLineRepository)
        {
            _favorLineRepository = favorLineRepository;
        }




        public async Task<List<IFavorLine>> GetAllFavorLinesByFavorID( IRequest request, List<IFavorLine> listOfAllFavorLines)
        {
            return await _favorLineRepository.GetAllFavorLinesByFavorID(request, listOfAllFavorLines);
        }



        public async Task<bool> CreateFavorLine(IFavor favor, int requestID, int favorQuantity, IFavor favorName)
        {
            return await _favorLineRepository.CreateFavorLine(favor, requestID, favorQuantity, favorName);
        }

        public async Task<bool> DeleteFavorLine(int favorLineID)
        {
            return await _favorLineRepository.DeleteFavorLine(favorLineID);
        }

        public async Task<List<IFavorLine>> GetAllFavorLines()
        {
            return await _favorLineRepository.GetAllFavorLines();
        }

        public async Task<IFavorLine> GetFavorLine(int favorLineID)
        {
            return await _favorLineRepository.GetFavorLine(favorLineID);
        }

        public async Task<bool> UpdateFavorLine(int favorLineID, int favorQuantity)
        {
            return await _favorLineRepository.UpdateFavorLine(favorLineID, favorQuantity);
        }

        public async Task<bool> InsertInspectorComments(int favorLineID, string favorStatus, string favorComment)
        {
            return await _favorLineRepository.InsertInspectorComments(favorLineID, favorStatus, favorComment);
        }
    }
}

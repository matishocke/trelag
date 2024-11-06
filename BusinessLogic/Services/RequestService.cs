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
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository _requestRepository;
        public RequestService(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }




        public async Task<int> CreateRequest(ICustomer customer, DateTime dateCreated,
            bool hasAlarm, bool hasClearingSupply, bool hasPets, double discount)
        {
            return await _requestRepository.CreateRequest(customer, dateCreated, 
                hasAlarm, hasClearingSupply, hasPets, discount);
        }



        public async Task<bool> DeleteRequest(int requestID)
        {
            return await _requestRepository.DeleteRequest(requestID);
        }

        public async Task<List<IRequest>> GetAllRequests()
        {
            return await _requestRepository.GetAllRequests();
        }


        public async Task<IRequest> GetRequest(int reqestID)
        {
            return await _requestRepository.GetRequest(reqestID);
        }

        public async Task<List<IRequest>> GetRequestByCustomerID(int customerID)
        {
            return await _requestRepository.GetRequestByCustomerID(customerID);
        }



        public async Task<bool> UpdateRequest(int requestID, ICustomer customerID,
            DateTime dateCreated, bool hasAlarm, bool hasCleaningSupply, bool hasPets, double discount)
        {
            return await _requestRepository.UpdateRequest(requestID, customerID, 
                dateCreated, hasAlarm, hasCleaningSupply, hasPets, discount);
        }
        
    }
}

using Abstraction.IModels;
using Abstraction.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.IRepository
{
    public interface IRequestRepository
    {
        Task<List<IRequest>> GetAllRequests();


        Task<IRequest> GetRequest(int requestID);
        Task<List<IRequest>> GetRequestByCustomerID(int customerID);



        Task<int> CreateRequest(ICustomer customer, DateTime dateCreated,
            bool hasAlarm, bool hasClearingSupply, bool hasPets, double discount);

        Task<bool> UpdateRequest(int requestID, ICustomer customerID,
            DateTime dateCreated, bool hasAlarm, bool hasCleaningSupply, bool hasPets, double discount);
        Task<bool> DeleteRequest(int requestID);
        
    }
}

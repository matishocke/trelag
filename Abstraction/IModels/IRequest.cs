using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.IModels
{
    public interface IRequest
    {
        int RequestID { get; set; }
        double TotalPrice { get; set; }
        ICustomer Customer { get; set; }   // Customer PK => Foreign Key Here
        DateTime DateCreated { get; set; }
        bool HasAlarm { get; set; }
        bool HasCleaningSupplies { get; set; }
        bool HasPets { get; set; }
        double Discount { get; set; }
    }
}

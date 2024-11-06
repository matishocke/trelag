using Abstraction.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Request : IRequest
    {
        public int RequestID { get; set; }
        public double TotalPrice { get; set; }
        public ICustomer Customer { get; set; }   // Customer PK => Foreign Key Here
        public DateTime DateCreated { get; set; }
        public bool HasAlarm { get; set; }
        public bool HasCleaningSupplies { get; set; }
        public bool HasPets { get; set; }
        public double Discount { get; set; }
    }
}

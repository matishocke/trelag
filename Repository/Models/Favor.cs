using Abstraction.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Favor : IFavor
    {
        public int FavorID { get; set; }
        public string FavorName { get; set; }
        public double UnitPrice { get; set; }
    }
}

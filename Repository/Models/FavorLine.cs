using Abstraction.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class FavorLine : IFavorLine
    {
        public int FavorLineID { get; set; }
        public IRequest Request { get; set; }
        public IFavor Favor { get; set; }
        public int FavorQuantity { get; set; }
        public IFavor FavorName { get; set; }
        public string FavorStatus { get; set; }
        public string FavorComment { get; set; }
    }
}

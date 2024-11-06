using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.IModels
{
    public interface IFavorLine
    {
        int FavorLineID { get; set; }
        IRequest Request { get; set; }  //FK // RequestID PK => Foreign Key Here
        IFavor Favor { get; set; }  //FK     // FavorID PK => Foreign Key Here
        int FavorQuantity { get; set; }
        IFavor FavorName { get; set; }
        string FavorStatus { get; set; }
        string FavorComment { get; set; }
    }
}

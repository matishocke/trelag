using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.IModels
{
    public interface IFavor
    {
        int FavorID { get; set; }
        string FavorName { get; set; }
        double UnitPrice { get; set; }

    }
}

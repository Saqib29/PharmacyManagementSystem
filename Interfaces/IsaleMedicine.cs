using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Interfaces
{
    public interface IsaleMedicine
    {
        bool addtoChart_Method(Medicine m, string quantity);
        bool deletefromChart(SaleMedicine m);
        bool confirmMethod();
        void cencelmethod();
        List<SaleMedicine> viewSoldMedicine();
        List<SaleMedicine> getSoldMedicine();
    }
}

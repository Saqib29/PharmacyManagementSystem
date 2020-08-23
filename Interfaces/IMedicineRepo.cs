using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Interfaces
{
    public interface IMedicineRepo
    {
        bool InsertMedicine(Medicine md);
        bool UpdateMedicine(Medicine md);
        bool DeleteMedicine(Medicine md);
        Medicine GetMedicine(string m);
        List<Medicine> GetAllMedicine();
    }
}

using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsDepartememts
    {
        public static DataTable GetAllDepartementsName()
        {
            return clsDepartmentsData.GetAllDepartementsName();
        }
    }
}

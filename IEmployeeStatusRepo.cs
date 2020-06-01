using SPTDataLayer.Database;
using SPTEntities.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTDataLayer.Repositories.Interfaces
{
    public interface IEmployeeStatusRepo : IGenericRepo<EmployeeStatus, EMPL_STATUS>
    {
        EmployeeStatus GetEmployeeStatusById(int id);
    }
}

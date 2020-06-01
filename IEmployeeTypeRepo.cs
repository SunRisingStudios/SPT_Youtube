using SPTDataLayer.Database;
using SPTEntities.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTDataLayer.Repositories.Interfaces
{
    public interface IEmployeeTypeRepo : IGenericRepo<EmployeeType, EMPL_TYPE>
    {
        EmployeeType GetEmployeeTypeById(int id);
        List<EmployeeType> GetEmployeeTypes();
    }
}

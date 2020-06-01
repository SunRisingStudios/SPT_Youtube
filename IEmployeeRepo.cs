using SPTDataLayer.Database;
using SPTEntities.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTDataLayer.Repositories
{
    public interface IEmployeeRepo : IGenericRepo<Employee, EMPL>
    {
        List<Employee> GetEmployeesByReportsToId(int reportsToId);
    }
}

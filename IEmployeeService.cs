using SPTDataLayer;
using SPTEntities.DatabaseEntities;
using SPTEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTBusinessLayer.Interfaces
{
    public interface IEmployeeService
    {
        ManagerViewModel GetEmployeesByReportsToId(int reportsToId, out List<EmployeeType> employeeTypeList);
    }
}

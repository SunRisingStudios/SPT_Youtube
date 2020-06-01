using SPTDataLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTDataLayer.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepo Employee { get; }

        ICompanyRepo Company { get; }

        IEmployeeStatusRepo EmployeeStatus { get; }

        IEmployeeTypeRepo EmployeeType { get; }

        IDistGuideRepo DistGuide { get; }

        IPctIncreaseRepo PctIncrease { get; }

        IQuintileRepo Quintile { get; }

        int Complete();
    }
}

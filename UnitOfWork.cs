using SPTDataLayer.Database;
using SPTDataLayer.Repositories.Interfaces;
using SPTEntities.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTDataLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataModel _db;

        public UnitOfWork(DataModel db)
        {
            _db = db;
            Employee = new EmployeeRepo(_db);
            Company = new CompanyRepo(_db);
            EmployeeStatus = new EmployeeStatusRepo(_db);
            EmployeeType = new EmployeeTypeRepo(_db);
            DistGuide = new DistGuideRepo(_db);
            PctIncrease = new PctIncreaseRepo(_db);
            Quintile = new QuintileRepo(_db);
        }
        public IEmployeeRepo Employee { get;  }

        public ICompanyRepo Company { get; }

        public IEmployeeStatusRepo EmployeeStatus { get; }

        public IEmployeeTypeRepo EmployeeType { get; }

        public IDistGuideRepo DistGuide { get; }

        public IPctIncreaseRepo PctIncrease { get; }

        public IQuintileRepo Quintile { get; }

        public int Complete()
        {
            return _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}

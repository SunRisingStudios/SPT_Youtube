using SPTDataLayer.Database;
using SPTDataLayer.Repositories.Interfaces;
using SPTEntities.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SPTDataLayer.Repositories
{
    public class EmployeeStatusRepo : GenericRepo<EmployeeStatus, EMPL_STATUS>, IEmployeeStatusRepo
    {
        private readonly DataModel db;

        public EmployeeStatusRepo(DataModel context) : base(context)
        {
            db = context;
        }

        public EmployeeStatus GetEmployeeStatusById(int id)
        {
            return ConvertToModel(db.EMPL_STATUS.Where(x => x.EMPL_STATUS_ID == id && x.DELETE_DT == null).FirstOrDefault());
        }

        private EmployeeStatus ConvertToModel(EMPL_STATUS entity)
        {
            EmployeeStatus e = new EmployeeStatus()
            {
                EmployeeStatusId = entity.EMPL_STATUS_ID,
                EmployeeStatusName = entity.EMPL_STATUS_NM,
                DeleteDate = entity.DELETE_DT
            };

            return e;
        }

        private EMPL_STATUS ConvertToDbOject(EmployeeStatus entity)
        {
            EMPL_STATUS e = new EMPL_STATUS()
            {
                EMPL_STATUS_ID = entity.EmployeeStatusId,
                EMPL_STATUS_NM = entity.EmployeeStatusName,
                DELETE_DT = entity.DeleteDate
            };

            return e;
        }
    }
}

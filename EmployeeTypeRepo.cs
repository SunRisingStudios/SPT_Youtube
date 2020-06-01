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
    public class EmployeeTypeRepo : GenericRepo<EmployeeType, EMPL_TYPE>, IEmployeeTypeRepo
    {
        private readonly DataModel db;

        public EmployeeTypeRepo(DataModel context) : base(context)
        {
            db = context;
        }

        public EmployeeType GetEmployeeTypeById(int id)
        {
            return ConvertToModel(db.EMPL_TYPE.Where(x => x.EMPL_TYPE_ID == id && x.DELETE_DT == null).FirstOrDefault());
        }

        public List<EmployeeType> GetEmployeeTypes()
        {
            var query = db.EMPL_TYPE.Where(x => x.DELETE_DT == null);
            return ConvertToModelList(query.AsEnumerable()).ToList();
        }

        private IEnumerable<EmployeeType> ConvertToModelList(IEnumerable<EMPL_TYPE> list)
        {
            return list.Select(ConvertToModel).ToList();
        }

        private EmployeeType ConvertToModel(EMPL_TYPE entity)
        {
            EmployeeType e = new EmployeeType()
            {
                EmployeeTypeId = entity.EMPL_TYPE_ID,
                EmployeeTypeCode = entity.EMPL_TYPE_CD,
                EmployeeTypeText = entity.EMPL_TYPE_NM,
                DeleteDate = entity.DELETE_DT
            };

            return e;
        }

        private EMPL_TYPE ConvertToDbObject(EmployeeType entity)
        {
            EMPL_TYPE e = new EMPL_TYPE()
            {
                EMPL_TYPE_ID = entity.EmployeeTypeId,
                EMPL_TYPE_CD = entity.EmployeeTypeCode,
                EMPL_TYPE_NM = entity.EmployeeTypeText,
                DELETE_DT = entity.DeleteDate
            };

            return e;
        }        
    }
}

using SPTDataLayer.Database;
using SPTDataLayer.Repositories.Interfaces;
using SPTEntities.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTDataLayer.Repositories
{
    public class CompanyRepo : GenericRepo<Company, COMPANY>, ICompanyRepo
    {
        private readonly DataModel db;

        public CompanyRepo(DataModel context) : base(context)
        {
            db = context;
        }

        public Company GetcompanyById(int companyId)
        {
            return ConvertToModel(db.COMPANY.Where(x => x.COMPANY_ID == companyId && x.DELETE_DT == null).FirstOrDefault());
        }

        private Company ConvertToModel(COMPANY entity)
        {
            Company c = new Company()
            {
                CompanyId = entity.COMPANY_ID,
                CompanyName = entity.COMPANY_NM,
                EffectiveDate = entity.EFFECTIVE_DT,
                DeleteDate = entity.DELETE_DT
            };

            return c;
        }
    }
}

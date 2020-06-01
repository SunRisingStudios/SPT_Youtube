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
    public class DistGuideRepo : GenericRepo<DistributionGuideline, DIST_GUIDELINES>, IDistGuideRepo
    {
        private readonly DataModel db;

        public DistGuideRepo(DataModel context) : base(context)
        {
            db = context;
        }

        public List<DistributionGuideline> GetDistributionGuidelines()
        {
            var query = db.DIST_GUIDELINES.Where(x => x.DELETE_DT == null);
            return ConvertToModelList(query.AsEnumerable<DIST_GUIDELINES>()).ToList();
        }

        private IEnumerable<DistributionGuideline> ConvertToModelList(IEnumerable<DIST_GUIDELINES> list)
        {
            return list.Select(ConvertToModel).ToList();
        }

        public int GetDistKeyIdByEmpl(int company, int operation, int fullPartTime)
        {
            return db.DIST_GUIDELINES.Where(x => x.DELETE_DT == null && x.COMPANY_CO == company && x.OPERATION == operation && x.EMP_TYPE == fullPartTime).FirstOrDefault().DIST_GUIDE_ID;
        }

        public DistributionGuideline ConvertToModel(DIST_GUIDELINES entity)
        {
            DistributionGuideline d = new DistributionGuideline()
            {
                DistributionGuideLineId = entity.DIST_GUIDE_ID,
                CompmanyCode = entity.COMPANY_CO,
                OperationId = entity.OPERATION,
                EmployeeType = entity.EMP_TYPE,
                DistGuideAmt = entity.AMOUNT,
                DeleteDate = entity.DELETE_DT
            };

            return d;
        }

        public DIST_GUIDELINES ConvertToDbObject(DistributionGuideline entity)
        {
            DIST_GUIDELINES d = new DIST_GUIDELINES()
            {
                DIST_GUIDE_ID = entity.DistributionGuideLineId,
                COMPANY_CO = entity.CompmanyCode,
                OPERATION = entity.OperationId,
                EMP_TYPE = entity.EmployeeType,
                AMOUNT = entity.DistGuideAmt,
                DELETE_DT = entity.DeleteDate
            };

            return d;
        }

        
    }
}

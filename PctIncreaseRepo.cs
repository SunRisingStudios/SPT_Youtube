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
    public class PctIncreaseRepo : GenericRepo<PctIncrease, PCT_INCREASE>, IPctIncreaseRepo
    {
        private readonly DataModel db;

        public PctIncreaseRepo(DataModel context) : base(context)
        {
            db = context;
        }

        public List<PctIncrease> GetPctIncreaseGuidelines()
        {
            var query = db.PCT_INCREASE.Where(x => x.DELETE_DT == null);
            return ConvertToModelList(query.AsEnumerable<PCT_INCREASE>()).ToList();
        }

        private IEnumerable<PctIncrease> ConvertToModelList(IEnumerable<PCT_INCREASE> list)
        {
            return list.Select(ConvertToModel).ToList();
        }

        public PctIncrease ConvertToModel(PCT_INCREASE entity)
        {
            PctIncrease p = new PctIncrease()
            {
                PctIncreaseId = entity.PCT_INCREASE_ID,
                Rating = entity.RATING,
                EmployeeStatus = entity.STATUS,
                DistKey = entity.DIST_KEY,
                Quintile = entity.QUINTILE,
                Minval = entity.MIN_VAL,
                MaxVal = entity.MAX_VAL,
                DeleteDate = entity.DELETE_DT
            };

            return p;
        }
    }
}

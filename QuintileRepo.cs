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
    public class QuintileRepo : GenericRepo<Quintile, QUINTILE>, IQuintileRepo
    {
        private readonly DataModel db;

        public QuintileRepo(DataModel context) : base(context)
        {
            db = context;
        }

        public int CalculateEmplQuintile(int Grade, int FullPartTime, int DistKeyId, decimal AnnualRate, decimal HourlyRate)
        {
            var record = ConvertToModel(db.QUINTILE.Where(x => x.DELETE_DT == null && x.GRADE == Grade && x.EMPL_STATUS == FullPartTime && x.DIST_KEY == DistKeyId).FirstOrDefault());
            if (FullPartTime == 1)
            {
                if (record.Q1Val > AnnualRate)
                    return 1;
                else if (record.Q2Val > AnnualRate)
                    return 2;
                else if (record.Q3Val > AnnualRate)
                    return 3;
                else if (record.Q4Val > AnnualRate)
                    return 4;
                else
                    return 5;
            } else
            {
                if (record.Q1Val > HourlyRate)
                    return 1;
                else if (record.Q2Val > HourlyRate)
                    return 2;
                else if (record.Q3Val > HourlyRate)
                    return 3;
                else if (record.Q4Val > HourlyRate)
                    return 4;
                else
                    return 5;
            }
        }

        private Quintile ConvertToModel(QUINTILE entity)
        {
            Quintile q = new Quintile()
            {
                QuintileId = entity.QUINTILE_ID,
                Grade = entity.GRADE,
                EmplStatus = entity.EMPL_STATUS,
                DistKey = entity.DIST_KEY,
                Q1Val = entity.Q1_VAL,
                Q2Val = entity.Q2_VAL,
                Q3Val = entity.Q3_VAL,
                Q4Val = entity.Q4_VAL,
                Q5Val = entity.Q5_VAL,
                DeleteDate = entity.DELETE_DT
            };

            return q;
        }
    }
}

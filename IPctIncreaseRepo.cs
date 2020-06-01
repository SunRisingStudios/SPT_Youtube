using SPTDataLayer.Database;
using SPTEntities.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTDataLayer.Repositories.Interfaces
{
    public interface IPctIncreaseRepo : IGenericRepo<PctIncrease, PCT_INCREASE>
    {
        List<PctIncrease> GetPctIncreaseGuidelines();
    }
}

using SPTEntities.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTDataLayer.Repositories.Interfaces
{
    public interface IDistGuideRepo
    {
        List<DistributionGuideline> GetDistributionGuidelines();
        int GetDistKeyIdByEmpl(int company, int operation, int fullPartTime);
    }
}

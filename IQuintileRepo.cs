using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTDataLayer.Repositories.Interfaces
{
    public interface IQuintileRepo
    {
        int CalculateEmplQuintile(int Grade, int FullPartTime, int DistKeyId, decimal AnnualRate, decimal HourlyRate);
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPTDataLayer.Database;
using SPTEntities.DatabaseEntities;

namespace SPTDataLayer.Repositories
{
    public class EmployeeRepo : GenericRepo<Employee, EMPL>, IEmployeeRepo
    {
        private readonly DataModel db;

        public EmployeeRepo(DataModel context) : base(context)
        {
            db = context;
        }

        public List<Employee> GetEmployeesByReportsToId(int reportsToId)
        {
            var query = db.EMPL.Where(x => x.REPORTS_TO_ID == reportsToId.ToString() && x.DELETE_DT == null);
            return ConvertToModelList(query.AsEnumerable<EMPL>()).ToList();
        }

        private IEnumerable<Employee> ConvertToModelList(IEnumerable<EMPL> list)
        {
            return list.Select(ConvertToModel).ToList();
        }

        public EMPL ConvertToDbObject(Employee entity)
        {
            EMPL empl = new EMPL()
            {
                EMPL_ID = entity.EmployeeId,
                EMPL_NO = entity.EmployeeNumber,
                NAME = entity.EmployeeName,
                BIRTHDATE = entity.BirthDate,
                HIRE_DT = entity.HireDate,
                REHIRE_DT = entity.RehireDate,
                OPERATION = entity.Operation,
                JOB_TITLE = entity.JobTitle,
                FULL_PART_TIME = entity.FullPartTime,
                COMPANY_CO = entity.Company,
                LOCATION = entity.Location,
                STD_HOURS = entity.StdHours,
                GRADE = entity.Grade,
                ANNUAL_RT = entity.AnnualRate,
                HOURLY_RT = entity.HourlyRate,
                REPORTS_TO_ID = entity.ReportsToId,
                LAST_RATING = entity.LastRating,
                LAST_REVIEW_DT = entity.LastReviewDate,
                NEXT_REVIEW_DT = entity.NextReviewDate,
                NEW_RATING = entity.NewRating,
                INCREASE_AMT = entity.IncreaseAmount,
                LAST_UPDATED_DT = entity.LastUpdatedDate,
                EMPL_STANDING = entity.EmployeeStanding,
                DELETE_DT = entity.DeleteDate,
                EMPL_TYPE = entity.EmployeeType
            };

            return empl;
        }

        public Employee ConvertToModel(EMPL entity)
        {
            Employee e = new Employee()
            {
                EmployeeId = entity.EMPL_ID,
                EmployeeNumber = entity.EMPL_NO,
                EmployeeName = entity.NAME,
                BirthDate = entity.BIRTHDATE,
                HireDate = entity.HIRE_DT,
                RehireDate = entity.REHIRE_DT,
                Operation = entity.OPERATION,
                JobTitle = entity.JOB_TITLE,
                FullPartTime = entity.FULL_PART_TIME,
                Company = entity.COMPANY_CO,
                Location = entity.LOCATION,
                StdHours = entity.STD_HOURS,
                Grade = entity.GRADE,
                AnnualRate = entity.ANNUAL_RT,
                HourlyRate = entity.HOURLY_RT,
                ReportsToId = entity.REPORTS_TO_ID,
                LastRating = entity.LAST_RATING,
                LastReviewDate = entity.LAST_REVIEW_DT,
                NextReviewDate = entity.NEXT_REVIEW_DT,
                NewRating = entity.NEW_RATING,
                IncreaseAmount = entity.INCREASE_AMT,
                LastUpdatedDate = entity.LAST_UPDATED_DT,
                EmployeeStanding = entity.EMPL_STANDING,
                DeleteDate = entity.DELETE_DT,
                EmployeeType = entity.EMPL_TYPE
            };

            return e;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTEntities.DatabaseEntities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public DateTime BirthDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime HireDate { get; set; }
        public DateTime? RehireDate { get; set; }
        public int Operation { get; set; }
        public string JobTitle { get; set; }
        public int FullPartTime { get; set; }
        public string FullPartTimeText { get; set; }
        public int Company { get; set; }
        public string CompanyText { get; set; }
        public int Location { get; set; }
        public int StdHours { get; set; }
        public int Grade { get; set; }
        public decimal AnnualRate { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal MinPctIncrease { get; set; }
        public decimal MaxPctIncrease { get; set; }
        public string ReportsToId { get; set; }
        public int? LastRating { get; set; }
        public DateTime? LastReviewDate { get; set; }
        public DateTime NextReviewDate { get; set; }
        public int? NewRating { get; set; }
        public decimal? IncreaseAmount { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? LastUpdatedDate { get; set; }
        public int EmployeeStanding { get; set; }
        public bool CanEarnIncrease { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int EmployeeType { get; set; }
        public string EmployeeTypeText { get; set; }
        public int DistKeyId { get; set; }
        public int Quintile { get; set; }
    }
}

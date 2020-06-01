using SPTBusinessLayer.Interfaces;
using SPTDataLayer;
using SPTDataLayer.Repositories;
using SPTEntities.DatabaseEntities;
using SPTEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTBusinessLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IUnitOfWork _unitOfWork;
        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        
        public ManagerViewModel GetEmployeesByReportsToId(int reportsToId, out List<EmployeeType> employeeTypes)
        {
            ManagerViewModel model = new ManagerViewModel();
            model.ManagersEmployees = new List<Employee>();
            model.ManagersEmployees = _unitOfWork.Employee.GetEmployeesByReportsToId(reportsToId);
            foreach (var item in model.ManagersEmployees)
            {
                item.CompanyText = _unitOfWork.Company.GetcompanyById(item.Company).CompanyName;
                item.FullPartTimeText = _unitOfWork.EmployeeStatus.GetEmployeeStatusById(item.FullPartTime).EmployeeStatusName;
                item.EmployeeTypeText = _unitOfWork.EmployeeType.GetEmployeeTypeById(item.EmployeeType).EmployeeTypeCode;
                item.CanEarnIncrease = CanEarnIncrease(item);
                item.DistKeyId = _unitOfWork.DistGuide.GetDistKeyIdByEmpl(item.Company, item.Operation, item.FullPartTime);
                item.Quintile = _unitOfWork.Quintile.CalculateEmplQuintile(item.Grade, item.FullPartTime, item.DistKeyId, item.AnnualRate, item.HourlyRate);
            }

            model = CalculateDistributionAmounts(model, out List<EmployeeType> employeeTypeList);
            model = GetPctIncreaseGuidelines(model);
            employeeTypes = employeeTypeList;

            return model;
        }

        private int CalculateEmplQuintile(int grade, int fullPartTime, int distKeyId, decimal annualRate, decimal hourlyRate)
        {
            throw new NotImplementedException();
        }

        private ManagerViewModel GetPctIncreaseGuidelines(ManagerViewModel model)
        {
            model.PctIncreaseGuidelines = _unitOfWork.PctIncrease.GetPctIncreaseGuidelines();
            return model;
        }

        private bool CanEarnIncrease(Employee item)
        {
            return item.EmployeeStanding == 1;
        }

        private ManagerViewModel CalculateDistributionAmounts(ManagerViewModel model, out List<EmployeeType> employeeTypeList)
        {
            employeeTypeList = _unitOfWork.EmployeeType.GetEmployeeTypes();
            model.DistributionGuidelines = _unitOfWork.DistGuide.GetDistributionGuidelines();

            foreach (var item in model.DistributionGuidelines)
            {
                item.DistGuideTotal = CalculateDistributionAmounts(model.ManagersEmployees.Where(x => item.EmployeeType == x.EmployeeType
                    && item.OperationId == x.Operation && item.CompmanyCode == x.Company && x.DeleteDate == null).ToList(), item);
                var salaryTotal = model.ManagersEmployees.Where(x => item.EmployeeType == x.EmployeeType && item.OperationId == x.Operation && item.CompmanyCode == x.Company && x.DeleteDate == null && x.FullPartTime ==1).Sum(x => x.IncreaseAmount);
                var hourlyTotal = model.ManagersEmployees.Where(x => item.EmployeeType == x.EmployeeType && item.OperationId == x.Operation && item.CompmanyCode == x.Company && x.DeleteDate == null && x.FullPartTime ==2).Sum(x => x.IncreaseAmount);
                item.AmtRemaning = item.DistGuideTotal - (salaryTotal + hourlyTotal);
                item.EmployeeTypeText = employeeTypeList.Where(x => item.EmployeeType == x.EmployeeTypeId).FirstOrDefault().EmployeeTypeText;
            }
            return model;
        }

        private decimal CalculateDistributionAmounts(List<Employee> list, DistributionGuideline item)
        {
            decimal total;


            var salaryTotal = list.Where(x => x.FullPartTime == 1).Sum(x => x.AnnualRate) * item.DistGuideAmt;
            var hourlyTotal = list.Where(x => x.FullPartTime == 2).Sum(x => x.HourlyRate) * item.DistGuideAmt;
            total = salaryTotal.Value + hourlyTotal.Value;

            return total;
        }
    }
}

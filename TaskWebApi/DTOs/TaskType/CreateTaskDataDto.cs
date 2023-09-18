using System;
using TaskWebApi.DTOs.Common;
using TaskWebApi.DTOs.TaskType;
using TaskWebApi.Models;

namespace TaskWebApi.DTOs.SalaryType
{
    public class CreateTaskDataDto : ITaskDataDto
    {

        private decimal basicSalary;

        public decimal GetBasicSalary()
        {
            return basicSalary;
        }

        public void SetBasicSalary(decimal value)
        {
            basicSalary = value;
        }

        private decimal allowance;

        public decimal GetAllowance()
        {
            return allowance;
        }

        public void SetAllowance(decimal value)
        {
            allowance = value;
        }

        private decimal transportation;

        public decimal GetTransportation()
        {
            return transportation;
        }

        public void SetTransportation(decimal value)
        {
            transportation = value;
        }

        private decimal tax;

        public decimal GetTax()
        {
            return tax;
        }

        public void SetTax(decimal value)
        {
            tax = value;
        }

        private string firstName;

        public string GetFirstName()
        {
            return firstName;
        }


        public void SetFirstName(string value)
        {
            firstName = value;
        }

        private string lastName;


        public string GetLastName()
        {
            return lastName;
        }


        public void SetLastName(string value)
        {
            lastName = value;
        }

        private DateTime date;

        public DateTime GetDate()
        {
            return date;
        }

        public void SetDate(DateTime value)
        {
            date = value;
        }
    }
}

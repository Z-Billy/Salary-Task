using TaskWebApi.DTOs.TaskType;
using TaskWebApi.DTOs.Common;
using System;

namespace TaskWebApi.DTOs.TaskType
{
    public class TaskDataDto : BaseDto, ITaskDataDto
    {
        /// <summary>
        /// حقوق پایه
        /// </summary>
        private decimal basicSalary;   
        public decimal GetBasicSalary()
        {
            return basicSalary;
        }
        public void SetBasicSalary(decimal value)
        {
            basicSalary = value;
        }

        /// <summary>
        /// حق جذب
        /// </summary>
        private decimal allowance;
        public decimal GetAllowance()
        {
            return allowance;
        }
        public void SetAllowance(decimal value)
        {
            allowance = value;
        }

        /// <summary>
        /// ایاب و ذهاب
        /// </summary>
        private decimal transportation;
        public decimal GetTransportation()
        {
            return transportation;
        }
        public void SetTransportation(decimal value)
        {
            transportation = value;
        }

        /// <summary>
        /// مالیات
        /// </summary>
        private decimal tax;
        public decimal GetTax()
        {
            return tax;
        }
        public void SetTax(decimal value)
        {
            tax = value;
        }

        /// <summary>
        /// نام
        /// </summary>
        private string firstName;
        public string GetFirstName()
        {
            return firstName;
        }
        public void SetFirstName(string value)
        {
            firstName = value;
        }

        /// <summary>
        /// نام خانوادگی
        /// </summary>
        private string lastName;
        public string GetLastName()
        {
            return lastName;
        }
        public void SetLastName(string value)
        {
            lastName = value;
        }

        /// <summary>
        /// تاریخ
        /// </summary>
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

using  TaskWebApi.DTOs.SalaryType;
using TaskWebApi.DTOs.Common;

namespace TaskWebApi.DTOs.SalaryType
{
    public class SalaryDataDto : BaseDto , ISalaryDataDto
    {
        private decimal basicSalary;

        /// <summary>
        /// حقوق پایه
        /// </summary>
        public decimal GetBasicSalary()
        {
            return basicSalary;
        }

        /// <summary>
        /// حقوق پایه
        /// </summary>
        public void SetBasicSalary(decimal value)
        {
            basicSalary = value;
        }

        private decimal allowance;

        /// <summary>
        /// حق جذب
        /// </summary>
        public decimal GetAllowance()
        {
            return allowance;
        }

        /// <summary>
        /// حق جذب
        /// </summary>
        public void SetAllowance(decimal value)
        {
            allowance = value;
        }

        private decimal transportation;

        /// <summary>
        /// ایاب و ذهاب
        /// </summary>
        public decimal GetTransportation()
        {
            return transportation;
        }

        /// <summary>
        /// ایاب و ذهاب
        /// </summary>
        public void SetTransportation(decimal value)
        {
            transportation = value;
        }

        private decimal tax;

        /// <summary>
        /// مالیات
        /// </summary>
        public decimal GetTax()
        {
            return tax;
        }

        /// <summary>
        /// مالیات
        /// </summary>
        public void SetTax(decimal value)
        {
            tax = value;
        }

        private decimal recieveSalary;

        /// <summary>
        /// حقوق دریافتی
        /// </summary>
        public decimal GetRecieveSalary()
        {
            return recieveSalary;
        }

        /// <summary>
        /// حقوق دریافتی
        /// </summary>
        public void SetRecieveSalary(decimal value)
        {
            recieveSalary = value;
        }
    }
}

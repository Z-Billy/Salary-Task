using TaskWebApi.DTOs.TaskType;

namespace TaskWebApi.DTOs.SalaryType
{
    public class CreateTaskDataDto : ISalaryDataDto
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

        private decimal recieveSalary;

        public decimal GetRecieveSalary()
        {
            return recieveSalary;
        }

        public void SetRecieveSalary(decimal value)
        {
            recieveSalary = value;
        }

        public decimal GetAllowance()
        {
            throw new System.NotImplementedException();
        }

        public decimal GetBasicSalary()
        {
            throw new System.NotImplementedException();
        }

        public decimal GetRecieveSalary()
        {
            throw new System.NotImplementedException();
        }

        public decimal GetTax()
        {
            throw new System.NotImplementedException();
        }

        public decimal GetTransportation()
        {
            throw new System.NotImplementedException();
        }

        public void SetAllowance(decimal value)
        {
            throw new System.NotImplementedException();
        }

        public void SetBasicSalary(decimal value)
        {
            throw new System.NotImplementedException();
        }

        public void SetRecieveSalary(decimal value)
        {
            throw new System.NotImplementedException();
        }

        public void SetTax(decimal value)
        {
            throw new System.NotImplementedException();
        }

        public void SetTransportation(decimal value)
        {
            throw new System.NotImplementedException();
        }
    }
}

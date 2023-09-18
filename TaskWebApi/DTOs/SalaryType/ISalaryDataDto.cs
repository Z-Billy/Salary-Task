namespace TaskWebApi.DTOs.SalaryType
{
    public interface ISalaryDataDto
    {
        decimal GetBasicSalary();
        void SetBasicSalary(decimal value);

        decimal GetAllowance();
        void SetAllowance(decimal value);

        decimal GetTransportation();
        void SetTransportation(decimal value);

        decimal GetTax();
        void SetTax(decimal value);

        decimal GetRecieveSalary();
        void SetRecieveSalary(decimal value);
    }
}

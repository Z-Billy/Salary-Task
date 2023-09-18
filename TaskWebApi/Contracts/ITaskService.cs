using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskWebApi.Models;
using TaskWebApi.Services.Base;

namespace TaskWebApi.Contracts
{
    public interface ITaskService
    {
        Task<Response<int>> Add(decimal BasicSalary, decimal Allowance, decimal Transportation, decimal Tax, UserDs user);
        Task<Response<int>> Update(int nationalCode, int month, SalaryDs salary);
        Task<Response<int>> Delete(int nationalCode, int month);
        Task<DateDs> Get (int nationalCode, int month);
        Task<List<DateDs>> GetRange(int nationalCode, DateTime starDate, DateTime endDate);
    }
}

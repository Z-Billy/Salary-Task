using OvetimePolicies;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskWebApi.Contracts;
using TaskWebApi.Models;
using TaskWebApi.Services.Base;
using System.Net.Http;

namespace TaskWebApi.Services
{
    public class TaskService : BaseHttpService, ITaskService
    {


        private readonly HttpClient _httpClient;

        public TaskService(HttpClient httpClient)
            : base(httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Response<int>> Add(decimal BasicSalary, decimal Allowance, decimal Transportation, decimal Tax, UserDs user)
        {
            try
            {
                var response = new Response<int>();
                OvetimePoliciesClass ovetimePoliciesClass = new OvetimePoliciesClass();
                decimal OverTimeCalc = ovetimePoliciesClass.OverTimeCalculator(BasicSalary + Allowance);
                decimal recieveSalary = BasicSalary + Allowance + Transportation - OverTimeCalc + Tax;
                DataDs dataDs = new DataDs()
                {
                    SalaryDs = new SalaryDs()
                    {
                        Allowance = Allowance,
                        BasicSalary = BasicSalary,
                        Transportation = Transportation,
                        Tax = Tax,
                        RecieveSalary = recieveSalary
                    },
                    UserDs = user,
                    DateDs = new DateDs()
                    {
                        Date = DateTime.Now,
                        Month = DateTime.Now.Month,
                    },
                };

                //var apiResponse = await _httpClient.LeaveTypesPOSTAsync(dataDs);

                //if (apiResponse.Success)
                //{
                //    response.Data = apiResponse.Id;
                //    response.Success = true;
                //}
                //else
                //{
                //    foreach (var err in apiResponse.Errors)
                //    {
                //        response.ValidationErrors += err + Environment.NewLine;
                //    }
                //}
                //return response;

                return new Response<int>();
            }
            catch (ApiException exp)
            {

                return ConvertApiExceptions<int>(exp);
            }
        }

        public async Task<Response<int>> Update(int nationalCode, int month, SalaryDs salary)
        {
            try
            {

               // await _httpClient.LeaveTypesPUTAsync(nationalCode,  month,  salary);
                return new Response<int> { Success = true };

            }
            catch (ApiException exp)
            {

                return ConvertApiExceptions<int>(exp);
            }
        }

        public async Task<Response<int>> Delete(int nationalCode, int month)
        {
            try
            {
                //await _httpClient.LeaveTypesDELETEAsync(nationalCode,  month);
                return new Response<int> { Success = true };
            }
            catch (ApiException exp)
            {

                return ConvertApiExceptions<int>(exp);
            }
        }

        public async Task<DateDs> Get(int nationalCode, int month)
        {
            //var dataDs = await _httpClient.LeaveTypesGETAsync(nationalCode, month);
            return new DateDs();
        }
        
        public async Task<List<DateDs>> GetRange(int nationalCode, DateTime starDate, DateTime endDate)
        {
            //var listDataDs = await _httpClient.LeaveTypesAllAsync(nationalCode, starDate,  endDate);
            return new List<DateDs>();
        }


    }
}

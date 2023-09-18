using MediatR;
using TaskWebApi.DTOs.TaskType;
using TaskWebApi.Features.TaskTypes.Requests.Commands;
using TaskWebApi.Features.TaskTypes.Requests.Queries;
using TaskWebApi.Responses;
using Microsoft.AspNetCore.Mvc;
using TaskWebApi.Models;
using TaskWebApi.Contracts;
using TaskWebApi.Services.Base;
using Microsoft.AspNetCore.Http;
using OvetimePolicies;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using TaskWebApi.DTOs.SalaryType;

namespace TaskWebApi.Controllers
{
    public class Task2Controller : Controller
    {
        private readonly IMediator _mediator;

        public Task2Controller (IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<ActionResult> Add([FromBody]decimal BasicSalary, decimal Allowance, decimal Transportation, decimal Tax, string name, string lastName )
        {
            OvetimePoliciesClass ovetimePoliciesClass = new OvetimePoliciesClass();
            decimal OverTimeCalc = ovetimePoliciesClass.OverTimeCalculator(BasicSalary + Allowance);
            decimal recieveSalary = BasicSalary + Allowance + Transportation - OverTimeCalc + Tax;
            TaskDataDto taskDataDto = new TaskDataDto();
            taskDataDto.SetBasicSalary(BasicSalary);
            taskDataDto.SetTax(Tax);
            taskDataDto.SetAllowance(Allowance);
            taskDataDto.SetFirstName(name); 
            taskDataDto.SetLastName(lastName);
            taskDataDto.SetTransportation(Transportation);
            var command = new CreateTaskDataCommand { TaskDataDto = taskDataDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut("{nationalCode},{month}")]
        public async Task<ActionResult> Update(int nationalCode, int month, TaskDataDto salary)
        {
            var command = new UpdateTaskDataCommand { TaskDataDto = salary };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{nationalCode},{month}")]
        public async Task<ActionResult> Delete(int nationalCode, int montht)
        {
            var command = new DeleteTaskDataCommand { NationalCode =nationalCode, Month= montht };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpGet("{nationalCode}")]
        public async Task<ActionResult<List<DataDs>>> GetRange(int nationalCode, DateTime StarDate, DateTime EndDate)
        {
            var TaskDatas = await _mediator.Send(new GetTaskDataListRequest { NationalCode = nationalCode, StarDate =StarDate, EndDate= EndDate });
            return Ok(TaskDatas);
        }

        // GET api/<TaskDatasController>/5
        [HttpGet("{nationalCode},{month}")]
        public async Task<ActionResult<DataDs>> Get(int nationalCode, int month)
        {
            var TaskData = await _mediator.Send(new GetTaskDataDetailRequest { NationalCode = nationalCode, Month = month });
            return Ok(TaskData);
        }
    }
}

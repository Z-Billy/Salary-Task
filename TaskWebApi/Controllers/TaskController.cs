using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using TaskWebApi.Contracts;
using TaskWebApi.Models;

namespace TaskWebApi.Controllers
{

    public class TaskController : Controller
    {
        private readonly ITaskService _TaskService;

        public TaskController (ITaskService TaskService)
        {
            _TaskService = TaskService;
        }

        public  ActionResult Index()
        {
            return View();
        }


        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Add(decimal BasicSalary, decimal Allowance, decimal Transportation, decimal Tax, UserDs user)
        {
            
            try
            {
                var response = await _TaskService.Add( BasicSalary,  Allowance,  Transportation,  Tax,  user);
                if (response.Success)
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", response.ValidationErrors);

            }
            catch (Exception exp)
            {
                ModelState.AddModelError("", exp.Message);
            }

            return View();
        }

        public async Task<ActionResult> Update(int nationalCode, int month)
        {
            var response = await _TaskService.Get(nationalCode, month);
            return View(response);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Update(int nationalCode, int month, SalaryDs salary)
        {
            try
            {
                var response = await _TaskService.Update(nationalCode, month, salary);
                if (response.Success)
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", response.ValidationErrors);

            }
            catch (Exception exp)
            {
                ModelState.AddModelError("", exp.Message);
            }

            return View(salary);
        }

        public async Task<ActionResult> Delete(int nationalCode, int month)
        {
            var leaveType = await _TaskService.Get(nationalCode, month);
            return View(leaveType);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteRecord (int nationalCode, int month)
        {
            try
            {
                var response = await _TaskService.Delete(nationalCode, month);
                if (response.Success)
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", response.ValidationErrors);

            }
            catch (Exception exp)
            {
                ModelState.AddModelError("", exp.Message);
            }

            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Get(int nationalCode, int month)
        {
            var response = await _TaskService.Get( nationalCode,  month);
            return View(response);
        }

        public async Task<ActionResult> GetRange(int nationalCode, DateTime starDate, DateTime endDate)
        {
            var response = await _TaskService.GetRange( nationalCode, starDate, endDate);
            return View(response);
        }

    }
}

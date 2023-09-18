using System;
using TaskWebApi.DTOs.Common;
using TaskWebApi.DTOs.TaskType;

namespace TaskWebApi.DTOs.TaskType
{
    public interface ITaskDataDto
    {


        /// <summary>
        /// حقوق پایه
        /// </summary>
        decimal GetBasicSalary();
        void SetBasicSalary(decimal value);

        /// <summary>
        /// حق جذب
        /// </summary>
        decimal GetAllowance();
        void SetAllowance(decimal value);

        /// <summary>
        /// ایاب و ذهاب
        /// </summary>
        decimal GetTransportation();
        void SetTransportation(decimal value);

        /// <summary>
        /// مالیات
        /// </summary>
        decimal GetTax();
        void SetTax(decimal value);

        /// <summary>
        /// نام
        /// </summary>
        string GetFirstName();
        void SetFirstName(string value);

        /// <summary>
        /// نام خانوادگی
        /// </summary>
        string GetLastName();
        void SetLastName(string value);

        /// <summary>
        /// تاریخ
        /// </summary>
        DateTime GetDate();
        void SetDate(DateTime value);
    }
}

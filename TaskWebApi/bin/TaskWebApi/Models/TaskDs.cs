using System;

namespace TaskWebApi.Models
{
    public class DataDs
    {
        /// <summary>
        /// اطلاعات فرد
        /// </summary>
        public UserDs UserDs { get; set; }

        /// <summary>
        /// اطلاعات حقوقی 
        /// </summary>
        public SalaryDs SalaryDs { get; set; }

        /// <summary>
        /// اطلاعات تاریخ
        /// </summary>
        public DateDs DateDs { get; set; }

    }

    public class SalaryDs
    {
        /// <summary>
        /// حقوق پایه
        /// </summary>
        public decimal BasicSalary { get; set; }

        /// <summary>
        /// حق جذب
        /// </summary>
        public decimal Allowance { get; set; }

        /// <summary>
        /// ایاب و ذهاب
        /// </summary>
        public decimal Transportation { get; set; }

        /// <summary>
        /// مالیات
        /// </summary>
        public decimal Tax { get; set; }

        /// <summary>
        /// حقوق دریافتی
        /// </summary>
        public decimal RecieveSalary { get; set; }

    }

    public class UserDs
    {
        /// <summary>
        /// نام
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// نام خانوادگی
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// کد ملی
        /// </summary>
        public int NationalCode { get; set; }

    }

    public class DateDs
    {
        /// <summary>
        /// ماه
        /// </summary>
        public int Month { get; set; }

        /// <summary>
        /// تاریخ
        /// </summary>
        public DateTime Date { get; set; }
    }

    public class Data
    {
        /// <summary>
        /// نام
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// نام خانوادگی
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// حقوق پایه
        /// </summary>
        public decimal BasicSalary { get; set; }
        /// <summary>
        /// حق جذب
        /// </summary>
        public decimal Allowance { get; set; }
        /// <summary>
        /// ایاب و ذهاب
        /// </summary>
        public decimal Transportation { get; set; }
        /// <summary>
        /// تاریخ 
        /// </summary>
        public DateTime Date { get; set; }
    }

    public partial class ApiException : System.Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public ApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException)
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + ((response == null) ? "(null)" : response.Substring(0, response.Length >= 512 ? 512 : response.Length)), innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

}
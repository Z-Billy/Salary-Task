using TaskWebApi.Models;
using System.Net.Http;

namespace TaskWebApi.Services.Base
{
    public class BaseHttpService
    {
        protected readonly HttpClient _httpClient;

        public BaseHttpService( HttpClient HttpClient)
        {
            _httpClient = HttpClient;
        }

        protected Response<Guid> ConvertApiExceptions<Guid>(ApiException exception)
        {
            if (exception.StatusCode == 400)
            {
                return new Response<Guid>()
                {
                    Message = "400 error",
                    ValidationErrors = exception.Response,
                    Success = false
                };
            }
            else if(exception.StatusCode == 404)
            {
                return new Response<Guid>()
                {
                    Message = "error 404 : NOtFound",
                    ValidationErrors = exception.Response,
                    Success = false
                };
            }
            else
            {
                return new Response<Guid>()
                {
                    Message = "error 404 : NOtFound",
                    Success = false
                };
            }
        }

    }
}

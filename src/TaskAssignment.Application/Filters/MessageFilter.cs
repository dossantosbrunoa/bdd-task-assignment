using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TaskAssignment.Common.ErrorMessages.Interface;

namespace TaskAssignment.Application.Filters
{
    public class MessageFilter : IActionFilter
    {
        private readonly IErrorMessageService _errorMessageService;

        public MessageFilter(IErrorMessageService errorMessageService)
        {
            _errorMessageService = errorMessageService;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if(_errorMessageService.HasErrorMessages())
            {
                context.Result = new ObjectResult(_errorMessageService.GetAll())
                {
                    StatusCode = context.HttpContext.Response.StatusCode,
                };
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //Not implemented
        }
    }
}

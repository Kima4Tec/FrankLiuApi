using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FrankLiuApi1.Filters
{
    public class Shirt_ValidateShirtIdFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ActionArguments.ContainsKey("id") && context.ActionArguments["id"] is int id)
            {
                if (id < 1)
                {
                    context.Result = new BadRequestObjectResult($"The shirt with id {id} is not valid.");
                }
                if (id > 4)
                {
                    context.Result = new NotFoundObjectResult($"We do not have a shirt with id: {id}");
                }
            }
            base.OnActionExecuting(context);
        }
    }
    
}

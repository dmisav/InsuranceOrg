using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace InsuranceOrgWebAPI.Application.CustomActionFilters;

public class ControllerValidateModelAttribute: ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        if (context.ModelState.IsValid == false)
        {
            context.Result = new BadRequestResult();
        }
    }
}
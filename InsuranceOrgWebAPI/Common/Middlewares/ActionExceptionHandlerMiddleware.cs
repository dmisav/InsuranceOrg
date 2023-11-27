using System.Net;

namespace InsuranceOrgWebAPI.Common.Middlewares;

public class ActionExceptionHandlerMiddleware
{
    private readonly ILogger<ActionExceptionHandlerMiddleware> _logger;
    private readonly RequestDelegate _requestDelegate;

    public ActionExceptionHandlerMiddleware(
        ILogger<ActionExceptionHandlerMiddleware> logger,
        RequestDelegate requestDelegate)
    {
        _logger = logger;
        _requestDelegate = requestDelegate;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _requestDelegate(context);
        }
        catch (Exception e)
        {
            var eid = Guid.NewGuid();
            _logger.LogError(e, $"{eid} : e.Message");
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/json";

            var error = new
            {
                Id = eid,
                ErrorMessage = "Error occured"
            };

            await context.Response.WriteAsJsonAsync(error);
        }
    }
}
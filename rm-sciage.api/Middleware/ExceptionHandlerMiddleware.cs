using System.Net;
using Ardalis.GuardClauses;
using FluentValidation;
using Newtonsoft.Json;

namespace rm_sciage.api.Middleware;

public class ExceptionHandlerMiddleware(RequestDelegate next)
{
    public async Task Invoke(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            await ConvertException(context, ex);
        }
    }

    private static Task ConvertException(HttpContext context, Exception exception)
    {
        var result = string.Empty;
        HttpStatusCode httpStatusCode;

        context.Response.ContentType = "application/json";

        switch (exception)
        {
            case ValidationException validationException:
                httpStatusCode = HttpStatusCode.BadRequest;
                result = JsonConvert.SerializeObject(validationException.Errors.Select(x => x.ErrorMessage));
                break;
            case NotFoundException:
                httpStatusCode = HttpStatusCode.NotFound;
                break;
            default:
                httpStatusCode = HttpStatusCode.InternalServerError;
                break;
        }

        context.Response.StatusCode = (int)httpStatusCode;

        if (result == string.Empty) result = JsonConvert.SerializeObject(new { error = exception.Message });

        return context.Response.WriteAsync(result);
    }
}
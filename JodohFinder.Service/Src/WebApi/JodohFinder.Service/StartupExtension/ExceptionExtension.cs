using JodohFinder.Guard;
using Microsoft.AspNetCore.Diagnostics;

namespace JodohFinder.Service
{
    public class ExceptionExtension : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            if (exception is GuardParentException guardException)
            {
                httpContext.Response.StatusCode = guardException.StatusCode;
                httpContext.Response.ContentType = "application/json";

                await httpContext.Response.WriteAsJsonAsync(new
                {
                    message = guardException.CustomMessage
                }, cancellationToken);

                return true;
            }

            return false;
        }
    }
}

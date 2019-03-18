using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace WalkthroughFifteen.Extensions
{
    public static class HttpContextItemsMiddlewareExtensions
    {
        public static IApplicationBuilder UseHttpContextItemsMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HttpContextItemsMiddleware>();
        }
    }
}

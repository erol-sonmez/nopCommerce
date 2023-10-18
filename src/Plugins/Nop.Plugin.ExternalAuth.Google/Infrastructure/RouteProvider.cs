using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework.Mvc.Routing;

namespace Nop.Plugin.ExternalAuth.Google.Infrastructure
{
    public class RouteProvider : IRouteProvider
    {
        public int Priority => 0;

        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
            endpointRouteBuilder.MapControllerRoute(GoogleAuthenticationDefaults.DataDeletionCallbackRoute, $"google/data-deletion-callback/",
             new { controller = "GoogleDataDeletion", action = "DataDeletionCallback" });

            endpointRouteBuilder.MapControllerRoute(GoogleAuthenticationDefaults.DataDeletionStatusCheckRoute, $"google/data-deletion-status-check/{{earId:min(0)}}",
                new { controller = "GoogleAuthentication", action = "DataDeletionStatusCheck" });
        }
    }
}

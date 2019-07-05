using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace WebApp1
{
    public class CustomAuthorizationHandler : AuthorizationHandler<CustomRequirement>
    {
        private readonly ILogger<CustomAuthorizationHandler> _logger;

        public CustomAuthorizationHandler(ILogger<CustomAuthorizationHandler> logger)
        {
            _logger = logger;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, CustomRequirement requirement)
        {
            _logger.LogDebug($"Principal's Identity is WindowsIdentity {context.User.Identity.Name}");
            context.Succeed(requirement);
            return Task.FromResult(0);
        }
    }
}

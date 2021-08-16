using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterHomework.Filters
{
    public class AutorizationFilterA : Attribute, IAuthorizationFilter
    {
        private readonly ILogger<AutorizationFilterA> logger;

        public AutorizationFilterA(ILogger<AutorizationFilterA> logger)
        {
            this.logger = logger;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            logger.LogInformation("AutorizationFilterA");
        }
    }
}

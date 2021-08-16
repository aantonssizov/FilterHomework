using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterHomework.Filters
{
    public class AutorizationFilterB : Attribute, IAuthorizationFilter
    {
        private readonly ILogger<AutorizationFilterB> logger;

        public AutorizationFilterB(ILogger<AutorizationFilterB> logger)
        {
            this.logger = logger;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            logger.LogInformation("AutorizationFilterB");
        }
    }
}

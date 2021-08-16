using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterHomework.Filters
{
    public class CheckResourseFilter : Attribute, IResourceFilter
    {
        private readonly IConfiguration configuration;

        public CheckResourseFilter(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            if (int.TryParse(context.HttpContext.Request.Cookies[configuration["CookieKeys:FirstNumber"]], out int num1) &&
                int.TryParse(context.HttpContext.Request.Cookies[configuration["CookieKeys:SecondNumber"]], out int num2) &&
                int.TryParse(context.HttpContext.Request.Headers[configuration["CheckNumHeader"]], out int NumToCheck))
            {
                var resultNum = num1 + num2;
                if (resultNum != NumToCheck)
                {
                    context.Result = new ContentResult { Content = $"Sum of two cookie numbers is not equal {configuration["CheckNumHeader"]} header number" };
                }
            } 
            else
            {
                context.Result = new ContentResult { Content = "Failed to convert numbers" };
            }
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            //throw new NotImplementedException();
        }
    }
}

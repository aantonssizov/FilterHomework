using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterHomework.Filters
{
    public class FormatExceptionFilter : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception != null && context.Exception.GetType() == typeof(FormatException))
            {
                context.Result = new ContentResult { Content = "Can't add invalid number" };
                context.ExceptionHandled = true;
            }
        }
    }
}

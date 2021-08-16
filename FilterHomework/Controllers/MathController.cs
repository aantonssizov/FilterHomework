using FilterHomework.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterHomework.Controllers
{
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        [HttpGet]
        [Route("{num}")]
        [FormatExceptionFilter]
        public int GetNum(string num)
        {
            var result = 20;
            int value = int.Parse(num);

            return result + value;
        }

        [HttpGet]
        [ServiceFilter(typeof(AutorizationFilterB), Order = 2)]
        [ServiceFilter(typeof(AutorizationFilterA), Order = 1)]
        [TypeFilter(typeof(CheckResourseFilter))]
        public string Get()
        {
            return "Success";
        }
    }
}

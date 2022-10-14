using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Project;

namespace WebAPI_Project.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
       public double division (double left , double right)
        {
            double result = 0;
            try
            {
                result = WebAPI_LibraryProject.Calculator_Logic.division(left, right);
            }catch(DivideByZeroException)
            {
                Response.StatusCode = 400;
            }
            return result;
        }
    }
}

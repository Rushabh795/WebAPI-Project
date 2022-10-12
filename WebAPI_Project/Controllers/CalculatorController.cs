using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        double result = 0;

        try
            {
                result= WebAPI_Library.Calculator_Logic.division(left, right);
            }catch(DivideByZeroException)
            {
                Response.StatusCode = 400;
            }
return result;
}

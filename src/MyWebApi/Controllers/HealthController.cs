using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class HealthController : ControllerBase
  {
    // GET api/Health
    [HttpGet]
    public ActionResult<string> Get()
    {
      return $"Hello World from container: {Environment.MachineName}\n";
    }

    [HttpGet("{number}")]
    public ActionResult<string> Get(int number)
    {
       long nthPrime = FindPrimeNumber(number); //set higher value for more time

      return $"Hello World from container: {Environment.MachineName}. Nth prime number: {nthPrime}\n";
    }

    public long FindPrimeNumber(int n)
    {
      int count = 0;
      long a = 2;
      while (count < n)
      {
        long b = 2;
        int prime = 1;// to check if found a prime
        while (b * b <= a)
        {
          if (a % b == 0)
          {
            prime = 0;
            break;
          }
          b++;
        }
        if (prime > 0)
        {
          count++;
        }
        a++;
      }
      return (--a);
    }
  }
}
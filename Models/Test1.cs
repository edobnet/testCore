using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Models
{

    public class Test1:Itest 
    {

      public string Do()
      {
          return "test1";
      }
         
    }
}

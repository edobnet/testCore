using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebApplication.Models.EF
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public abstract class EntryBase
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public Int64 id {get;set;}
       
        [MaxLength(64)]
        public string Name {get;set;}
       public DateTime CreateTime {get;set;}

       public DateTime UpdateTime {get;set;}

       public EntryBase SetDefault()
       {
           CreateTime = UpdateTime = DateTime.Now;
           return this;
       }

    }
}

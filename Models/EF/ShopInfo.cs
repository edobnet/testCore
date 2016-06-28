using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebApplication.Models.EF
{
    [Table("ShopInfo")]
    public class ShopInfo:EntryBase
    {
        [MaxLength(255)]
        public string desc {get;set;}

    }
}

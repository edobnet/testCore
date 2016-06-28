using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models.EF;

namespace WebApplication.Models.Util
{
    public static class EFUtil
    {
        public static EntryBase SetInitDefault(this EntryBase entry)
        {
            entry.CreateTime = DateTime.Now;
            entry.UpdateTime = DateTime.Now;
            return entry;
        }
    }
}

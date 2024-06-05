using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tdtlession06CF.Models
{
    public class TdtBookStore:DbContext
    {
        public TdtBookStore():base() { }
        
        public DbSet<TdtCategory> TdtCategories { get; set; }
        public DbSet<TdtBook> Books { get; set; }
    }
}
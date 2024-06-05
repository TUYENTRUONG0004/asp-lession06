using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tdtlession06CF.Models
{
    public class TdtCategory
    {
        [Key]
        public int TdtId { get; set; }
        public string TdtCategoryName { get; set; }
  
        public virtual ICollection<TdtBook> TdtBook { get; set; }
    }
}
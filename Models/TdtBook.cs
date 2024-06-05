using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tdtlession06CF.Models
{
    public class TdtBook
    {
        [Key]
        public int TdtId { get; set; }
        public string TdtBookId { get; set; }
        public string TtdTitle { get; set; }
        public string TdtAuthor { get; set; }
        public int TdtYear { get; set; }
        public string TdtPublisher { get; set; }
        public string TdtPicture { get; set; }
        public int TdtCategoryId { get; set; }

        // Thuộc tính quan hệ
        public virtual TdtCategory TdtCategory { get; set; }
    }
}
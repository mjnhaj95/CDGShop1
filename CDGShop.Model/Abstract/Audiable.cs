using System;
using System.ComponentModel.DataAnnotations;

namespace CDGShop.Model.Abstract
{
    public abstract class Audiable : IAudiable
    {
        public DateTime? CreateDate { set; get; }

        [MaxLength(256)]
        public string CreateBy { set; get; }

        public DateTime? UpdateDate { set; get; }

        [MaxLength(256)]
        public string UpdateBy { set; get; }
    }
}
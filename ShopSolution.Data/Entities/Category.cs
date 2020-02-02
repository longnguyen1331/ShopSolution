using ShopSolution.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Entities
{
    public class Category : BaseEntity
    {
        public int SortOrder { set; get; }
        public bool IsShowHome { set; get; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }
    }
}

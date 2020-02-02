using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Entities
{
    public class BaseEntity
    {
        public int Id { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public DateTime DateCreated { set; get; }
    }
}

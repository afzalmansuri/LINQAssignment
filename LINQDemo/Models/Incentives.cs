using System;
using System.Collections.Generic;

namespace LINQDemo.Models
{
    public partial class Incentives
    {
        public int EmpRefId { get; set; }
        public DateTime IncentiveDate { get; set; }
        public int IncentiveAmount { get; set; }

        public virtual Employee EmpRef { get; set; }
    }
}

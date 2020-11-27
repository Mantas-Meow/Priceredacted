using System;
using System.Collections.Generic;
using System.Text;

namespace Priceredacted.Models
{
    class Receipt
    {
        public Guid UserId { get; set; }
        public DateTime Date { get; set; } 
        public int ProductId { get; set; }
        public Double Sum { get; set; }

    }
}

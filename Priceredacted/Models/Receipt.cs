using System;
using System.Collections.Generic;
using System.Text;

namespace Priceredacted.Models
{
    class Receipt
    {
        public Guid UserId { get; set; }
        public Guid ReceiptId { get; set; }        
        public string Date { get; set; } 
        public Double Sum { get; set; }

    }
}

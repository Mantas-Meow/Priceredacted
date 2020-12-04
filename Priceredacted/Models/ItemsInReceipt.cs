using System;
using System.Collections.Generic;
using System.Text;

namespace Priceredacted.Models
{
    class ItemsInReceipt
    {
        public Guid ReceiptId { get; set; }
        public int ProductId { get; set; }
    }
}

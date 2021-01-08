using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceredactedWeb.DTOs
{
    public class UpdatePasswordDTO
    {
        public string CurrentEmail { get; set; }
        public string NewPassword { get; set; }
    }
}

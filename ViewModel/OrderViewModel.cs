using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectPayII.ViewModel
{
    public class OrderViewModel
    {
        public string service { get; set; }
        public int value { get; set; }

        public string endDate { get; set; }

        public int subscriptionId { get; set; }
    }
}
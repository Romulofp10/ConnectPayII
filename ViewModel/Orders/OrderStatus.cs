using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectPayII.ViewModel
{
    public class OrderStatus
    {
        public const string pending = "pending";
        public const string completed = "completed";
        public const string failed = "failed";
        public const string canceled = "canceled";
    }
}
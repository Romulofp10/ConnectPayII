using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectPayII.ViewModel
{
    public class OrderViewModel
    {
      public required string service { get;   set; }
	  public required int value { get;   set; }
	  public required string endDate { get; set; }

	  public required string expirationDate  { get;  set;}
	  public required int subscriptionId { get;  set; }

	  public required OrderStatus status { get;  set; }
    }
}
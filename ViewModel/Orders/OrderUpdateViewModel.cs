using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectPayII.ViewModel.Orders
{
    public class OrderUpdateViewModel
    {
      public required int id {get; set;}
      public  string? service { get;   set; }
	  public  int? value { get;   set; }
	  public  string? endDate { get; set; }
	  public  string? expirationDate  { get;  set;}

	  public required OrderStatus status { get;  set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectPayII.Models
{
	[Table("Order")]

public class Order

{
		[Key]
	public int id { get;  private set; }
	public string service { get;  private set; }
	public int value { get;  private set; }
	public string endDate { get; private set; }

	public string expirationDate  { get; private set;}
	public int subscriptionId { get; private set; }

	public string status { get; private set; }

    public DateTime createdAt { get; set; }
		 
    public DateTime updatedAt { get; set; }
	
		public Order(string service, int value, string endDate, int subscriptionId, string expirationDate	)
		{
			this.service = service;
			this.expirationDate = expirationDate;
			this.value = value;
			this.subscriptionId = subscriptionId;
			this.status = "pending";
			this.endDate = endDate;
			this.createdAt = DateTime.Now;
			this.updatedAt = DateTime.Now;
		}

}
}

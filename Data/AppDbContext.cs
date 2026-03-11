using System;
using Microsoft.EntityFrameworkCore;
using ConnectPayII.Models;

namespace ConnectPayII.Data
{

public class AppDbContext: DbContext
{
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
			try
			{
				var connectionString = "server=localhost;port=3306;database=connectpay;user=root;password=12345678";
				optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
				
			}catch(Exception ex)
			{
				Console.WriteLine("Error configuring the database: " + ex.Message);
			}
	}

	public DbSet<Order> Orders {get;set;}
	
}
}
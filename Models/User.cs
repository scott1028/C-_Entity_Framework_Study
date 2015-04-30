using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace myTestMVC
{
	public partial class DaoContext : DbContext
	{
		public DaoContext():base("name=SYS_DB")
		{
		}

		public virtual DbSet<User> Users { get; set; }
	}

	[Table("user")]
	public class User
	{
		public int id { get; set;}
		public string user_id { get; set; }
		public string password { get; set; }
	}
}


using Castle.ActiveRecord;
using System;

namespace testwB
{
	// For ActiveRecord Start
	[ActiveRecord("user")]
	public class User1:ActiveRecordBase
	{
		private int id;
		private String user_id;

		[PrimaryKey(PrimaryKeyType.Native, "id")]
		private int Id
		{
			get { return id; }
			set { id = value; }
		}

		[Property("user_id")]
		public String User_id
		{
			get { return user_id; }
			set { user_id = value; }
		}

		public static User1 Find(int id)
		{
			return (User1) FindByPrimaryKey(typeof(User1), id);
		}
	}
	// For ActiveRecord End
}

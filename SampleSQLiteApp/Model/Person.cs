using System;
using SQLite.Net.Attributes;

namespace SampleSQLiteApp
{
	[Table("HellowWorld")]
	public class Person
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		[MaxLength(250), Unique]
		public string Name { get; set; }
	}
}

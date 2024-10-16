namespace ASP.NET_lesson_1_project.Models
{
	public class MyProfile
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public int Age { get; set; }
		public string[] Frontend { get; set; }
		public string[] Backend { get; set; }
		public string[] Frameworks { get; set; }
	}
}

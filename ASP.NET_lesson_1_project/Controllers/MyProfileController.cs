using ASP.NET_lesson_1_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_lesson_1_project.Controllers
{
	public class MyProfileController : Controller
	{
		public MyProfile profile = new MyProfile
		{
			FirstName = "Nikita",
			LastName = "Belokrinitskiy",
			DateOfBirth = new DateTime(1998, 3, 10),
			Age = 26,
			Frontend = ["HTML", "CSS", "JavaScript"],
			Backend = ["C++", "C#", "PHP"],
			Frameworks = [".NET", "Entity Framework Core", "Laravel", "Unity"]
		};
		public IActionResult GetMyProfileView()
		{
			return View(profile);
		}
	}
}

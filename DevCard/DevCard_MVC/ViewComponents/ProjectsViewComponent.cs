using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
	public class ProjectsViewComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var project = new List<Project>()
			{
				new Project(1,"Project Heading","Project intro lorem ipsum dolor sit amet, consectetuer adipiscing elit. Cum sociis natoque penatibus et magnis dis parturient montes.","project-1.jpg","Google"),
				new Project(2,"Project Heading","Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus","project-2.jpg","Dropbox"),
				new Project(3,"Project Heading","Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.","project-3.jpg","Google"),
				new Project(4,"Project Heading","Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.","project-4.jpg","Uber"),

			};

			return View("_Projects", project);
		}
	}
}

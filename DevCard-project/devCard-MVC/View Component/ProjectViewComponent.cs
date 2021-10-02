using devCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devCard_MVC.View_Component
{
    public class ProjectViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Project> projects = new List<Project> {
            new Project(1,"taxi","take a free taxi","people","project-1.jpg"),
            new Project(2,"foody","take a free lounch","employee","project-2.jpg"),
            new Project(3,"gifty","take a free gifty","younge people","project-3.jpg"),
            new Project(4,"shoping","take a free taxi to shopping mall","elderly","project-4.jpg") };
            return View("_Project",projects);

        }
    }
}

using System;
using System.Linq;
using System.Threading.Tasks;

namespace devCard_MVC.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
    }
}

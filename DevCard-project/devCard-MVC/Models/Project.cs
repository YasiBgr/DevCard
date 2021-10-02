using System;
using System.Linq;
using System.Threading.Tasks;

namespace devCard_MVC.Models
{
    public class Project
    {
        public Project(int iD, string name, string description, string client, string image)
        {
            ID = iD;
            Name = name;
            Description = description;
            Client = client;
            Image = image;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
        public string Image { get; set; }
    }
  
}

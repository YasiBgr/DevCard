namespace devCard_MVC.Models
{
    public class Article
    {
        public Article(int iD, string title, string description, string image)
        {
            ID = iD;
            Title = title;
            Description = description;
            Image = image;
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

    }
}

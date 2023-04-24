namespace NewsPortal.Areas.Admin.Models
{
    public class Category
    {
        public int Id { get; set; } 
        public string Name { get; set; }   
        
       public List<New>News { get; set; }
    }
}

using NewsPortal.Areas.Admin.Models;

namespace NewsPortal.ViewModel
{
    public class IndexViewModel
    {
        public List<Category> Categories { get; set; }
        public List<New> News { get; set; }
    }
}

﻿namespace NewsPortal.Areas.Admin.Models
{
    public class New
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CategoryId {get; set; }
        public Category Category { get; set; }

        public int UserId {get; set; }
        public User User { get; set; }

       

    }
}

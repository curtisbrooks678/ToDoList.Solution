using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Item
    {
        public Item()
        {
            this.JoinEntities = new HashSet<CategoryItem>();
            Completed = false;
        }

        public int ItemId { get; set; }
        public string Description { get; set; }
        
        public bool Completed { get; set; }

        public DateTime DueDate { get; set; }

        public virtual ICollection<CategoryItem> JoinEntities { get;}
    }
}
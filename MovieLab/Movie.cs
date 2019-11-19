using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLab
{
     class Movie
    {
        private string category;
        private string title;

        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }
                    
        public string Title
        {
            get { return title; }
            set { title = value; }
                
        }
        public string Category
        {
            get { return category; }
            set { category = value; }

        }
        public virtual string Definition()
        {
            return $"{title}";
        }
        public virtual string SortByCat()
        {
            return $"{category}";
            
            
        }
       
       
    }
}

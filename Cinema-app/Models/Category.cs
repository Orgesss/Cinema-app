﻿namespace Cinema_app.model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Movie> Movies { get; set; } = new List<Movie>();
    }
}
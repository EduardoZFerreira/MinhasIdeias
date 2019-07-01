using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinhasIdeias.Entities
{
    public class Idea
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
    }
}

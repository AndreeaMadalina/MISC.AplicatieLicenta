using System;
using System.Collections.Generic;

namespace DB_Licenta.Models
{
    public partial class News
    {
        public int NewsID { get; set; }
        public System.DateTime Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

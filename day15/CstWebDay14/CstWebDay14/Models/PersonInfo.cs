using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CstWebDay14.Models
{
    public class PersonInfo
    {
        public int id { get; set; }
        public string username { get; set; }

        public string password { get; set; }

        public int isDeleted { get; set; }

        public DateTime createDatetime { get; set; }

        public DateTime updateDatetime { get; set; }

    }
}
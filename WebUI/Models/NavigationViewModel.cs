using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class NavigationViewModel
    {
        public IEnumerable<string> Genres { get; set; }
        public IEnumerable<DateTime?> Years { get; set; }
        public IEnumerable<int?> Rates { get; set; }
    }
}
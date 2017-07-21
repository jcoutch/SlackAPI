using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackAPI.Utilities
{
    public class SlackAction
    {
        public string name { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public string value { get; set; }
        public IEnumerable<MenuOption> options { get; set; }
    }

    public class MenuOption
    {
        public string text { get; set; }
        public string value { get; set; }
    }
}

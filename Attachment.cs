using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlackAPI.Utilities;

namespace SlackAPI
{
    public class Attachment
    {
        public string Pretext;
        public string text;
        public string title;
        public string title_link;
        public string fallback;
        public string color;
        public string callback_id;
        public string attachment_type;
        public IEnumerable<Field> fields;
        public IEnumerable<SlackAction> actions;
    }

    public class Field{
        public string title;
        public string value;
        public bool @short;
    }
}

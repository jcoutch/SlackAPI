using System;
using System.Collections.Generic;

namespace SlackAPI.WebSocketMessages
{
    [SlackSocketRouting("message")]
    [SlackSocketRouting("message", "bot_message")]
    public class NewMessage : SlackSocketMessage
    {
        public string user;
        public string bot_id;
        public string channel;
        public string text;
        public string team;
        public DateTime ts;

        public List<Attachment> attachments;

        public NewMessage()
        {
            type = "message";
        }
    }
}

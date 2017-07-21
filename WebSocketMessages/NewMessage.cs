using System;
using System.Collections.Generic;
using SlackAPI.Utilities;

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
        public string ts;
        public string thread_ts;

        public List<Attachment> attachments;

        public string ThreadParent => ts != thread_ts ? thread_ts : null;

        public NewMessage()
        {
            type = "message";
        }
    }
}

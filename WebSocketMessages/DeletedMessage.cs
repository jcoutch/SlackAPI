using System;

namespace SlackAPI.WebSocketMessages
{
    [SlackSocketRouting("message", "message_deleted")]
    public class DeletedMessage : SlackSocketMessage
    {
        public string channel;
        public string ts;
        public string deleted_ts;
        public bool hidden;
    }
}

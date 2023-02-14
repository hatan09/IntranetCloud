﻿using System;

namespace Intranet.Entities.Entities
{
    public class UserConversation : BaseEntity<int>
    {
        public int ConversationId { get; set; }
        public virtual Conversation Conversation { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public bool IsMute { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        //conversation.ChatMessages.First();
    }
}

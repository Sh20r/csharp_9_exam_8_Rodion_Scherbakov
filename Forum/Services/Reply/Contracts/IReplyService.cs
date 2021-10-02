using Forum.Models.Reply;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Services.Reply.Contracts
{
    public interface IReplyService
    {
        void CreateReply(ReplyCreateModel model, int currentUserId);
    }
}

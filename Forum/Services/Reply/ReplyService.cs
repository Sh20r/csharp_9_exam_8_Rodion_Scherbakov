using AutoMapper;
using Forum.DAL.Entities;
using Forum.DAL.Repositories.Contracts;
using Forum.Models.Reply;
using Forum.Services.Reply.Contracts;

namespace Forum.Services
{
    public class ReplyService : IReplyService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public ReplyService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public void CreateReply(ReplyCreateModel model, int currentUserId)
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var reply = Mapper.Map<Forum.DAL.Entities.Reply>(model);

                reply.BlogTheme = model.Title;

                unitOfWork.Replies.Create(reply);

            }
        }
    }
}

using Forum.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.DAL.Repositories
{
    public class UnitOfWork : IDisposable
    {
        private readonly ApplicationDbContext _context;
        private bool _disposed;

        public IBlogRepository Blogs { get; set; }
        public IReplyRepository Replies { get; set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Blogs = new BlogRepository(context);
            Replies = new ReplyRepository(context);

        }

        #region Disposable
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
                _context.Dispose();

            _disposed = true;
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
        #endregion
    }
}

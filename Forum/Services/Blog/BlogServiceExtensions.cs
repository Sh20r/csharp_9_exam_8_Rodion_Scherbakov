using Forum.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Services
{
    public static class BlogServiceExtensions
    {
        public static IEnumerable<Blog> BySearchKey(this IEnumerable<Blog> records, string searchKey)
        {
            if (!string.IsNullOrWhiteSpace(searchKey))
                records = records.Where(r => r.BlogTheme.Contains(searchKey) || r.Content.Contains(searchKey));

            return records;
        }

        public static IEnumerable<Blog> ByAuthorName(this IEnumerable<Blog> records, string authorName)
        {
            if (!string.IsNullOrWhiteSpace(authorName))
                records = records.Where(r => r.Author.UserName.Contains(authorName));

            return records;
        }

        public static IEnumerable<Blog> ByDateFrom(this IEnumerable<Blog> records, DateTime? dateFrom)
        {
            if (dateFrom.HasValue)
                records = records.Where(r => r.DatePublished >= dateFrom.Value);

            return records;
        }

        public static IEnumerable<Blog> ByDateTo(this IEnumerable<Blog> records, DateTime? dateTo)
        {
            if (dateTo.HasValue)
                records = records.Where(r => r.DatePublished <= dateTo.Value);

            return records;
        }
    }
}

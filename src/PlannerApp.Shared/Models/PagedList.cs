using System.Collections.Generic;

namespace PlannerApp.Shared.Models
{
    public class PagedList<T>
    {
        public int TotalPages { get; set; }
        public int ItemsCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public IEnumerable<T> Records { get; set; }
    }

    public class PlanSummary
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverUrl { get; set; }
    }
}

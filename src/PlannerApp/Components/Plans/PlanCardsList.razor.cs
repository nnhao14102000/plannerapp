using Microsoft.AspNetCore.Components;
using PlannerApp.Shared.Models;
using System;
using System.Threading.Tasks;

namespace PlannerApp.Components
{
    public partial class PlanCardsList
    {
        private bool _isBusy { get; set; }

        private int _pageNumber = 1;

        private int _pageSize = 10;

        private string _query = string.Empty;

        [Parameter]
        public Func<string, int, int, Task<PagedList<PlanSummary>>> FetchPlans { get; set; }

        private PagedList<PlanSummary> _result = new();

        protected override async Task OnInitializedAsync()
        {
            _isBusy = true;
            _result = await FetchPlans?.Invoke(_query, _pageNumber, _pageSize);
            _isBusy = false;
        }
    }
}
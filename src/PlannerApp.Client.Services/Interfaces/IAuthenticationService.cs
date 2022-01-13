using PlannerApp.Shared.Models;
using PlannerApp.Shared.Responses;
using System.Threading.Tasks;

namespace PlannerApp.Client.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<ApiResponse> RegisterUserAsync(RegisterRequest model);

        // TODO: Migrate Login to IAuthenticationService
    }
}

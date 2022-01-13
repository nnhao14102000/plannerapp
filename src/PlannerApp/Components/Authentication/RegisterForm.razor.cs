using Microsoft.AspNetCore.Components;
using PlannerApp.Client.Services.Exceptions;
using PlannerApp.Client.Services.Interfaces;
using PlannerApp.Shared.Models;
using System;
using System.Threading.Tasks;

namespace PlannerApp.Components.Authentication
{
    public partial class RegisterForm
    {
        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        private RegisterRequest _model = new();
        private bool _isBusy = false;
        private string _errorMessage = string.Empty;

        private async Task RegisterUserAsync()
        {
            _isBusy = true;
            _errorMessage = string.Empty;

            try
            {
                await AuthenticationService.RegisterUserAsync(_model);
                Navigation.NavigateTo("authentication/login");
            }
            catch(ApiException ax)
            {
                _errorMessage = ax.ApiErrorResponse.Message;
            }
            catch(Exception ex)
            {
                _errorMessage = ex.Message;
            }

            _isBusy = false;
        }

        private void RedirectToLogin()
        {
            Navigation.NavigateTo("authentication/login");

        }
    }
}

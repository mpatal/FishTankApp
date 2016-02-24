using FishTankApp.ViewModels;

namespace FishTankApp.Services
{
    public interface IViewModelService
    {
        DashboardViewModel GetDashboardViewModel();
    }
}
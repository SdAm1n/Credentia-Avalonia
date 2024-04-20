using CommunityToolkit.Mvvm.ComponentModel;

namespace Credentia.ViewModels;

public partial class HomePageViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _title;

    public HomePageViewModel()
    {
        Title = "Sample Page 1";
    }
}



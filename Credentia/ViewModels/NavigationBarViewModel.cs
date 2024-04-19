using Credentia.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Avalonia.Controls;

namespace Credentia.ViewModels;

public partial class NavigationBarViewModel : ViewModelBase
{
    [ObservableProperty]
    private UserControl _selectedView;

    [RelayCommand]
    public void Navigate(string pageKey)
    {
        switch (pageKey)
        {
            case "SamplePage1":
                SelectedView = new HomePageView();
                break;

        }
    }
}


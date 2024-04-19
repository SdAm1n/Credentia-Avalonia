using CommunityToolkit.Mvvm.ComponentModel;
using Avalonia.Controls;

namespace Credentia.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private UserControl _currentView;

    public MainWindowViewModel()
    {
        // Initialize with the NavigationBarView as the default view
        CurrentView = new Views.NavigationBarView();
    }

}




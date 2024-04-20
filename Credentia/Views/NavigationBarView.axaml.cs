using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Credentia.ViewModels;

namespace Credentia.Views;

public partial class NavigationBarView : UserControl
{
    public NavigationBarView()
    {
        InitializeComponent();
        DataContext = new NavigationBarViewModel();
    }
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
}


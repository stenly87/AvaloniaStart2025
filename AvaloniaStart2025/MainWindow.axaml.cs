using Avalonia.Controls;
using Avalonia.Interactivity;
using Tmds.DBus.Protocol;

namespace AvaloniaStart2025;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Title = "Вжух и всё";
    }

    private void SecondButtonClick(object? sender, RoutedEventArgs e)
    {
        Title = "Вжух и понос";
        e.Handled = true;
    }
}
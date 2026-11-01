using Avalonia;
using Avalonia.Markup.Xaml;

namespace MVPGraph;

public class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        var window = new MainWindow();
        window.Show();
        base.OnFrameworkInitializationCompleted();
    }
}

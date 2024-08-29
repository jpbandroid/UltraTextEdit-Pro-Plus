namespace UltraTextEdit_Pro_Plus.Views;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
        appTitleBar.Window = App.CurrentWindow;
    }
}


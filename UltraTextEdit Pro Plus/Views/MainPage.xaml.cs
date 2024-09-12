namespace UltraTextEdit_Pro_Plus.Views;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
        EditRibbon.Visibility = Visibility.Visible;
        InsertRibbon.Visibility = Visibility.Collapsed;
        //ViewCmdBar.Visibility = Visibility.Collapsed;
        EditButton.IsChecked = true;
        InsertButton.IsChecked = false;
        //TextBoxViewButton.IsChecked = false;
        appTitleBar.Window = App.CurrentWindow;
    }

    private void Button_PointerEntered(object sender, Microsoft.UI.Xaml.Input.PointerRoutedEventArgs e)
    {

    }

    private void NewFile_Click(object sender, RoutedEventArgs e)
    {

    }

    private void OpenFile_Click(object sender, RoutedEventArgs e)
    {

    }

    private void OpenMultipleFiles_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Save_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Delete_Click(object sender, RoutedEventArgs e)
    {

    }

    private void HomeItem_Click(object sender, RoutedEventArgs e)
    {

    }

    private void EditTab_Click(object sender, RoutedEventArgs e)
    {
        EditRibbon.Visibility = Visibility.Visible;
        InsertRibbon.Visibility = Visibility.Collapsed;
        //ViewCmdBar.Visibility = Visibility.Collapsed;
        EditButton.IsChecked = true;
        InsertButton.IsChecked = false;
        //TextBoxViewButton.IsChecked = false;
    }

    private void InsertTab_Click(object sender, RoutedEventArgs e)
    {
        EditRibbon.Visibility = Visibility.Collapsed;
        InsertRibbon.Visibility = Visibility.Visible;
        //ViewCmdBar.Visibility = Visibility.Collapsed;
        EditButton.IsChecked = false;
        InsertButton.IsChecked = true;
        //TextBoxViewButton.IsChecked = false;
    }

    private void ViewTab_Click(object sender, RoutedEventArgs e)
    {

    }

    private void SettingsButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void AboutItem_Click(object sender, RoutedEventArgs e)
    {

    }

    private void RTFPaste(object sender, RoutedEventArgs e)
    {

    }

    private void SimplePaste(object sender, RoutedEventArgs e)
    {

    }

    private void Paste_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Cut_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Copy_Click(object sender, RoutedEventArgs e)
    {

    }

    private void FontBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private void FontSize_ValueChanged(NumberBox sender, NumberBoxValueChangedEventArgs args)
    {

    }

    private void FontSize_GotFocus(object sender, RoutedEventArgs e)
    {

    }

    private void FontSize_LostFocus(object sender, RoutedEventArgs e)
    {

    }

    private void FontSizeBox_GotFocus(object sender, RoutedEventArgs e)
    {

    }

    private void FontSizeBox_LostFocus(object sender, RoutedEventArgs e)
    {

    }

    private void ForegroundButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void NullForegroundButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Advanced_Color_Click(object sender, RoutedEventArgs e)
    {

    }

    private void HighlightButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void NullHighlightButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Advanced_Highlight_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Lowercase_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Uppercase_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Sentencecase_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Titlecase_Click(object sender, RoutedEventArgs e)
    {

    }

    private void EraseFormat_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Template1_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Template2_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Template3_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Template4_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Template5_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Template6_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Template7_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Template8_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Template9_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Template10_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Template11_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Template12_Click(object sender, RoutedEventArgs e)
    {

    }

    private void BoldButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void ItalicButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void UnderlineFlyoutItem_Click(object sender, RoutedEventArgs e)
    {

    }

    private void StrikethroughButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void SubscriptButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void SuperscriptButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void MenuFlyoutFontSize_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Image_Insert_Click(object sender, RoutedEventArgs e)
    {

    }

    private void LinkInsert_Click(object sender, RoutedEventArgs e)
    {

    }

    private void InsertLink(object sender, RoutedEventArgs e)
    {

    }

    private void DeleteLink(object sender, RoutedEventArgs e)
    {

    }

    private void CancelLink(object sender, RoutedEventArgs e)
    {

    }

    private void DefaultTimeFormat(object sender, RoutedEventArgs e)
    {

    }

    private void MMDDTimeFormat(object sender, RoutedEventArgs e)
    {

    }

    private void DDMMTimeFormat(object sender, RoutedEventArgs e)
    {

    }

    private void MMDDnoYYTimeFormat(object sender, RoutedEventArgs e)
    {

    }

    private void DDMMnoYYTimeFormat(object sender, RoutedEventArgs e)
    {

    }
}

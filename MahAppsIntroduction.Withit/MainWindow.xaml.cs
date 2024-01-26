using System.Windows;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace MahAppsIntroduction.Withit;

public partial class MainWindow : MetroWindow
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public async Task OpenDialogAndDisplayText(string? inputtext = "Hello Mrs. Ungerer-Lagger :)")
    {
        if (!string.IsNullOrEmpty(inputtext))
        {
            await this.ShowMessageAsync("Attention!", inputtext);
        }
    }

    private async void btn_clickme_tab1(object sender, RoutedEventArgs e)
    {
        await OpenDialogAndDisplayText();
    }

    private async void btn_orclickme_tab1(object sender, RoutedEventArgs e)
    {
        await OpenDialogAndDisplayText(txtbox.Text);
    }

    private async void btn_clickme_tab2(object sender, RoutedEventArgs e)
    { 
        await OpenDialogAndDisplayText();
    }

    private async void btn_orclickme_tab2(object sender, RoutedEventArgs e)
    {
        await OpenDialogAndDisplayText(txtbox.Text);
    }
    private async void btn_clickme_tab3(object sender, RoutedEventArgs e)
    {
        await OpenDialogAndDisplayText();
    }

    private async void btn_orclickme_tab3(object sender, RoutedEventArgs e)
    {
        await OpenDialogAndDisplayText(txtbox.Text);
    }
}

using System.Windows;

namespace MahAppsIntroduction.Withit;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void OpenDialogAndDisplayText(string? inputtext = "Hello Mrs. Ungerer :)")
    {
        if (!string.IsNullOrEmpty(inputtext))
        {
            MessageBox.Show(inputtext, "Attentione!");
        }
    }

    private void btn_clickme_tab1(object sender, RoutedEventArgs e)
    {
        OpenDialogAndDisplayText();
    }

    private void btn_orclickme_tab1(object sender, RoutedEventArgs e)
    {
        OpenDialogAndDisplayText(txtbox.Text);
    }

    private void btn_clickme_tab2(object sender, RoutedEventArgs e)
    {
        OpenDialogAndDisplayText();
    }

    private void btn_orclickme_tab2(object sender, RoutedEventArgs e)
    {
        OpenDialogAndDisplayText(txtbox.Text);
    }
    private void btn_clickme_tab3(object sender, RoutedEventArgs e)
    {
        OpenDialogAndDisplayText();
    }

    private void btn_orclickme_tab3(object sender, RoutedEventArgs e)
    {
        OpenDialogAndDisplayText(txtbox.Text);
    }
}

using System.Windows;

namespace MahAppsIntroduction.Without;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void OpenDialogAndDisplayText(string? inputtext = "")
    {

    }

    private void btn_clickme_tab1(object sender, RoutedEventArgs e)
    {
        OpenDialogAndDisplayText();
    } 
    
    private void btn_orclickme_tab1(object sender, RoutedEventArgs e)
    {
        OpenDialogAndDisplayText();
    }   
    
    private void btn_clickme_tab2(object sender, RoutedEventArgs e)
    {
        OpenDialogAndDisplayText();
    } 
    
    private void btn_orclickme_tab2(object sender, RoutedEventArgs e)
    {
        OpenDialogAndDisplayText();
    }
    private void btn_clickme_tab3(object sender, RoutedEventArgs e)
    {
        OpenDialogAndDisplayText();
    } 
    
    private void btn_orclickme_tab3(object sender, RoutedEventArgs e)
    {
        OpenDialogAndDisplayText();
    }


}
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfPackaged;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        // Configure open file dialog box
        Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

        // Set initial directory to a location the app has permission to access
        // This could be the app's local folder, or a user library the app has permission for
        string initialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        dlg.InitialDirectory = initialDirectory;

        dlg.DefaultExt = ".jpg"; // Default file extension
        dlg.Filter = "Images (.jpg)|*.jpg"; // Filter files by extension
        dlg.CheckFileExists = true;
        dlg.Multiselect = false;
        
        // Show open file dialog box
        Nullable<bool> result = dlg.ShowDialog();

        // Process open file dialog box results
        if (result == true)
        {
            // Open document
            FileNameBlock.Text  = dlg.FileName;

            //using var ms = dlg.OpenFile();
        }

    }
}
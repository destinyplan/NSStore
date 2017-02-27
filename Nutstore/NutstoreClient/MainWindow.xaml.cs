using NutstoreClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NutstoreClient
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        NavigationWindow window = null;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            window = new NavigationWindow();
            window.Width = 800;
            window.Height = 500;
            window.WindowStyle = WindowStyle.ToolWindow;
            window.Title = "欢迎使用坚果云";
            //window.Icon = new BitmapImage(new Uri("../Assets/Icon/icon_welcomewizard_pre.png", UriKind.Relative));
            window.MouseDown += MouseDownDo;
            window.ShowsNavigationUI = false;
            window.Source = new Uri("/Views/WelcomeWizard.xaml", UriKind.Relative);
            window.Show();
        }

        private void MouseDownDo(object sender, MouseButtonEventArgs e)
        {
            window?.DragMove();
        }
    }
}

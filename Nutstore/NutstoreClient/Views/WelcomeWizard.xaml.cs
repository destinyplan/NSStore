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

namespace NutstoreClient.Views
{
    /// <summary>
    /// WelcomeWizard.xaml 的交互逻辑
    /// </summary>
    public partial class WelcomeWizard : Page
    {
        public WelcomeWizard()
        {
            InitializeComponent();
            Dispatcher.BeginInvoke(new Action(() =>
            {
                var navwindow = Window.GetWindow(this) as NavigationWindow;
                if (navwindow != null) navwindow.ShowsNavigationUI = false;
            }));
        }

    }
}

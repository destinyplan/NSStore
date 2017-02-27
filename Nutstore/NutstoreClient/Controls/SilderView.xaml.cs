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

namespace NutstoreClient.Controls
{
    /// <summary>
    /// SilderView.xaml 的交互逻辑
    /// </summary>
    public partial class SilderView : UserControl
    {
        private int current_index = 0;
        //路径=@"../Assets/Pic/Pic_WelcomeWizard_2_1.png";
        private List<string> list_pic_tips_path;
        private int select_pic_index = 0;
        private int select_tips_index = 3;

        public SilderView()
        {
            InitializeComponent();
            btn_tips_pre.Opacity = 0;
            btn_tips_next.Opacity = 1;
            tips_mark_1.Fill = new SolidColorBrush(Colors.Black);
            tips_mark_2.Fill = new SolidColorBrush(Colors.Wheat);
            tips_mark_3.Fill = new SolidColorBrush(Colors.Wheat);
            tips_mark_4.Fill = new SolidColorBrush(Colors.Wheat);

            current_index = 0;

            list_pic_tips_path = new List<string>();
            list_pic_tips_path.Add(@"/Assets/Pic/Pic_WelcomeWizard_1_1.png");
            list_pic_tips_path.Add(@"/Assets/Pic/Pic_WelcomeWizard_2_1.png");
            list_pic_tips_path.Add(@"/Assets/Pic/Pic_WelcomeWizard_3_1.png");
            list_pic_tips_path.Add(@"/Assets/Pic/Pic_WelcomeWizard_4_1.png");
            list_pic_tips_path.Add(@"/Assets/Pic/Pic_WelcomeWizard_1_2.png");
            list_pic_tips_path.Add(@"/Assets/Pic/Pic_WelcomeWizard_2_2.png");
            list_pic_tips_path.Add(@"/Assets/Pic/Pic_WelcomeWizard_3_2.png");
            list_pic_tips_path.Add(@"/Assets/Pic/Pic_WelcomeWizard_4_2.png");
        }

        private void Button_Click_next(object sender, RoutedEventArgs e)
        {
            if (current_index >= 3)
            {
                return;
            }
            current_index++;
            Switch_Tips_Image(current_index);
        }

        private void Button_Click_pre(object sender, RoutedEventArgs e)
        {
            if (current_index == 0)
            {
                return;
            }
            current_index--;
            Switch_Tips_Image(current_index);
        }

        private void Switch_Tips_Image(int index)
        {
            select_pic_index = 0;
            select_tips_index = 4;
            switch (index)
            {
                case 0:
                    select_pic_index = 0;
                    select_tips_index = 4;
                    btn_tips_pre.Opacity = 0;
                    tips_mark_1.Fill = new SolidColorBrush(Colors.Black);
                    tips_mark_2.Fill = new SolidColorBrush(Colors.Wheat);
                    tips_mark_4.Fill = new SolidColorBrush(Colors.Wheat);
                    break;
                case 1:
                    select_pic_index = 1;
                    select_tips_index = 5;
                    btn_tips_pre.Opacity = 1;
                    btn_tips_next.Opacity = 1;
                    tips_mark_1.Fill = new SolidColorBrush(Colors.Wheat);
                    tips_mark_2.Fill = new SolidColorBrush(Colors.Black);
                    tips_mark_3.Fill = new SolidColorBrush(Colors.Wheat);
                    break;
                case 2:
                    select_pic_index = 2;
                    select_tips_index = 6;
                    btn_tips_pre.Opacity = 1;
                    btn_tips_next.Opacity = 1;
                    tips_mark_2.Fill = new SolidColorBrush(Colors.Wheat);
                    tips_mark_3.Fill = new SolidColorBrush(Colors.Black);
                    tips_mark_4.Fill = new SolidColorBrush(Colors.Wheat);
                    break;
                case 3:
                    select_pic_index = 3;
                    select_tips_index = 7;
                    btn_tips_next.Opacity = 0;
                    tips_mark_1.Fill = new SolidColorBrush(Colors.Wheat);
                    tips_mark_3.Fill = new SolidColorBrush(Colors.Wheat);
                    tips_mark_4.Fill = new SolidColorBrush(Colors.Black);
                    break;
                default:break;
            }
            Image_Tips_1.Source = new BitmapImage(new Uri(list_pic_tips_path.ElementAt(select_pic_index), UriKind.Relative));
            Image_Tips_2.Source = new BitmapImage(new Uri(list_pic_tips_path.ElementAt(select_tips_index), UriKind.Relative));
        }

    }
}

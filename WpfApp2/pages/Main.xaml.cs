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

namespace WpfApp2.pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();

            for (int j = 0; j < 4; j++)
            {
                list.RowDefinitions.Add(new RowDefinition());
            }
            for (int j = 0; j < 3; j++)
            {
                list.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Button btn = GetButton();
                    btn.Style = (Style)Resources["ButtonStyle1"];
                    list.Children.Add(btn);
                    Grid.SetColumn(btn, i);
                    Grid.SetRow(btn, j);
                };
            }


        }
        static Button GetButton()
        {
            Button button = new Button();
            StackPanel panel = new StackPanel();
            Image image = new Image();
            image.Source = new BitmapImage(new Uri(@"..\images\icon.png", UriKind.Relative));
            image.Height = 50;
            image.SnapsToDevicePixels = true;
            Label label = new Label();
            label.Content = "Service name";
            var bc = new BrushConverter();
            label.Foreground = (Brush)bc.ConvertFrom("#04A0FF");
            label.FontSize = 20;
            label.Padding = new Thickness(0, 50, 0, 0);
            panel.Children.Add(image);
            panel.Children.Add(label);
            button.Content = panel;
            return button;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.Frame.Navigate(new User());
        }
    }
}

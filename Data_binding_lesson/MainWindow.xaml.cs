using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace Data_binding_lesson
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly DispatcherTimer timer; 

        public MainWindow()
        {

            InitializeComponent();
            timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(500)};


            timer.Tick += Tick;
        }

        private void Tick(object sender, EventArgs e)
        {

            ++((DataSource)DataContext).Value;

        }

        private void Bind_Click(object sender, RoutedEventArgs e)
        {
            if (!timer.IsEnabled)
            {
                timer.Start();
            }
        }

        private void Window_Updating(object sender, RoutedEventArgs e)
        {

            Time_textblock.Text = ((DataSource)DataContext).Value.ToString();

        }
    }
}

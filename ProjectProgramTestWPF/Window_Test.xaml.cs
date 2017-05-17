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
using System.Windows.Shapes;

namespace ProjectProgramTestWPF
{
    /// <summary>
    /// Логика взаимодействия для Window_Test.xaml
    /// </summary>
    public partial class Window_Test : Window
    {
        private int u;

        public Window_Test()
        {
            u = 0;
           
            InitializeComponent();
            DataContext = App.obj;
            Page_Test page = new Page_Test(u);
            Frame.NavigationService.Navigate(page);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
          

                u = u + 1;

            Console.WriteLine(u);
                Page_Test page = new Page_Test(u);
                Frame.NavigationService.Navigate(page);
            if (u == App.obj.Questions.Count-1)
            {

                button_Continue.IsEnabled = false;
                button_Exit.IsEnabled = true;

            }
        
            
        }


    }
}

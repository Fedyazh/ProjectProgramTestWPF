using Newtonsoft.Json;
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
        private int u = 0;

        public Window_Test()
        {
            
            this.DataContext = App.obj.Questions[u].Answers;
            InitializeComponent();
            label.Content = App.obj.Questions[u].QTopic;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
           
            u = u + 1;
            
            if (u == App.obj.Questions.Count - 1)
            {
                button_Continue.IsEnabled = false;
                button_Exit.IsEnabled = true;
                label.Content = App.obj.Questions[u].QTopic;
                this.DataContext = App.obj.Questions[u].Answers;//
            }
            else
            {
                label.Content = App.obj.Questions[u].QTopic;
                this.DataContext = App.obj.Questions[u].Answers;
            }
                                 
        }

        private void button_Exit_Click(object sender, RoutedEventArgs e)
        {
            string output = JsonConvert.SerializeObject(App.obj, Formatting.Indented);
            ParseFile bb = JsonConvert.DeserializeObject<ParseFile>(output);
            this.Close();
        }
        
    }
}

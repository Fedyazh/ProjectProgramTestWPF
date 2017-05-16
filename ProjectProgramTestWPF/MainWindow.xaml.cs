using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using Newtonsoft.Json;

namespace ProjectProgramTestWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_DonwloadTest_Click(object sender, RoutedEventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            /*Возвращает или задает текущую строку фильтра имен файлов, которая определяет варианты, 
            которые появляются в окне "сохранить как тип файла" или "файлы типа" в диалоговом окне. 
            */
            openFileDialog1.FilterIndex = 2; //Возвращает или задает индекс фильтра, выбранного в настоящий момент в диалоговом окне файла.
            openFileDialog1.RestoreDirectory = true;



            if (openFileDialog1.ShowDialog() == true)//Comment
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (StreamReader sr = new StreamReader(myStream))
                        {

                            string L = await sr.ReadToEndAsync();
                            ParseFile obj = JsonConvert.DeserializeObject<ParseFile>(L);

                            Console.WriteLine(obj.Questions[0].Answers[0].QAValue);
                            TextBox_Name.Text = obj.Questions[0].Answers[0].QAValue;

                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

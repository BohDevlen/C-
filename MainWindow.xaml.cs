using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
namespace Cосун
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> FileList { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string filePath = @"C:\Users\polka\OneDrive\Документы\.net\.net_sourse_learn\Cосун\All_ml.txt";
                string fileContent = File.ReadAllText(filePath);

                labelContent.Content = fileContent;

                listBoxI.Items.Add(labelContent.Content.ToString());
            }
            catch (IOException ex)
            {
                MessageBox.Show("Помилка читання файлу: " + ex.Message, "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                string filePath = @"C:\Users\polka\OneDrive\Документы\.net\.net_sourse_learn\Cосун\All_Biger.txt";
                string fileContent = File.ReadAllText(filePath);

                labelContent.Content = fileContent;

                Листок.Items.Add(labelContent.Content.ToString());
            }
            catch (IOException ex)
            {
                MessageBox.Show("Помилка читання файлу: " + ex.Message, "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                string filePath = @"C:\Users\polka\OneDrive\Документы\.net\.net_sourse_learn\Cосун\Навіжений бобр.txt";
                string fileContent = File.ReadAllText(filePath);

                labelContent.Content = fileContent;

                Shit.Items.Add(labelContent.Content.ToString());
            }
            catch (IOException ex)
            {
                MessageBox.Show("Помилка читання файлу: " + ex.Message, "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                string filePath = @"C:\Users\polka\OneDrive\Документы\.net\.net_sourse_learn\Cосун\Дк 80 ilvl.txt";
                string fileContent = File.ReadAllText(filePath);

                labelContent.Content = fileContent;
                xamlo.Items.Add(labelContent.Content.ToString());
            }
            catch (IOException ex)
            {
                MessageBox.Show("Помилка читання файлу: " + ex.Message, "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
         
            if (listBoxI.Items.Count > 0 || Листок.Items.Count > 0 || Shit.Items.Count > 0 || xamlo.Items.Count > 0)
            {

                List<int> numbers = new List<int>();

                string filePath = @"C:\Users\polka\OneDrive\Документы\.net\.net_sourse_learn\Cосун\Дк 80 ilvl.txt";
                string filePathh = @"C:\Users\polka\OneDrive\Документы\.net\.net_sourse_learn\Cосун\Навіжений бобр.txt";
                string filePathhh = @"C:\Users\polka\OneDrive\Документы\.net\.net_sourse_learn\Cосун\All_Biger.txt";
                string filePathhhh = @"C:\Users\polka\OneDrive\Документы\.net\.net_sourse_learn\Cосун\All_ml.txt";
                string fileContent = File.ReadAllText(filePath);
                string fileContentt = File.ReadAllText(filePathh);
                string fileContenttt = File.ReadAllText(filePathhh);
                string fileContentttt = File.ReadAllText(filePathhhh);
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    int sum= 0;

                    // Читаем строки из файла до его окончания
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Преобразуем строку в число с помощью int.Parse() или int.TryParse()
                        if (int.TryParse(line, out int number))
                        {
                            // Добавляем число в список
                            numbers.Add(number);
                        }
                    }

                    foreach (var item in numbers)
                    {

                        sum += item;
                    }
                    
                    labelContent.Content = sum.ToString();

                }
                using (StreamReader reader = new StreamReader(filePathh))
                {
                    string line;
                    int sum = 0;

                    // Читаем строки из файла до его окончания
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Преобразуем строку в число с помощью int.Parse() или int.TryParse()
                        if (int.TryParse(line, out int number))
                        {
                            // Добавляем число в список
                            numbers.Add(number);
                        }
                    }

                    foreach (var item in numbers)
                    {

                        sum += item;
                    }

                    labelContent.Content = sum.ToString();

                }
                using (StreamReader reader = new StreamReader(filePathhh))
                {
                    string line;
                    int sum = 0;

                    // Читаем строки из файла до его окончания
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Преобразуем строку в число с помощью int.Parse() или int.TryParse()
                        if (int.TryParse(line, out int number))
                        {
                            // Добавляем число в список
                            numbers.Add(number);
                        }
                    }

                    foreach (var item in numbers)
                    {

                        sum += item;
                    }

                    labelContent.Content = sum.ToString();

                }
                using (StreamReader reader = new StreamReader(filePathhhh))
                {
                    string line;
                    int sum = 0;

                    // Читаем строки из файла до его окончания
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Преобразуем строку в число с помощью int.Parse() или int.TryParse()
                        if (int.TryParse(line, out int number))
                        {
                            // Добавляем число в список
                            numbers.Add(number);
                        }
                    }

                    foreach (var item in numbers)
                    {

                        sum += item;
                    }

                    labelContent.Content = sum.ToString();

                }
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\Users\polka\OneDrive\Документы\.net\.net_sourse_learn\Cосун\Навіжений бобр.txt";
            try
            {
                File.WriteAllText(filePath,string.Empty);
                MessageBox.Show("Все");

            }
            catch 
            {
                MessageBox.Show("Ярік всьо бачок потік ");            
            }
            Shit.Items.Clear();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\Users\polka\OneDrive\Документы\.net\.net_sourse_learn\Cосун\All_ml.txt";
            try
            {
                File.WriteAllText(filePath, string.Empty);
                MessageBox.Show("Все");

            }
            catch
            {
                MessageBox.Show("Ярік всьо бачок потік ");
            }
            listBoxI.Items.Clear();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\Users\polka\OneDrive\Документы\.net\.net_sourse_learn\Cосун\All_Biger.txt";
            try
            {
                File.WriteAllText(filePath, string.Empty);
                MessageBox.Show("Все");

            }
            catch
            {
                MessageBox.Show("Ярік всьо бачок потік ");
            }
            Листок.Items.Clear();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\Users\polka\OneDrive\Документы\.net\.net_sourse_learn\Cосун\Дк 80 ilvl.txt";
            try
            {
                File.WriteAllText(filePath, string.Empty);
                MessageBox.Show("Все");

            }
            catch
            {
                MessageBox.Show("Ярік всьо бачок потік ");
            }
            xamlo.Items.Clear();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\Users\polka\OneDrive\Документы\.net\.net_sourse_learn\Cосун\Навіжений бобр.txt";
            if (trololololo.Text.Length > 0)
            {


                try
                {
                    string text = trololololo.Text;
                    File.WriteAllText(filePath, text);
                    MessageBox.Show("Все");

                }
                catch
                {
                    MessageBox.Show("Ярік всьо бачок потік ");
                }
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\Users\polka\OneDrive\Документы\.net\.net_sourse_learn\Cосун\All_ml.txt";
            if (Чай.Text.Length > 0)
            {
                try
                {
                    string text = trololololo.Text;
                    File.WriteAllText(filePath, text);
                    MessageBox.Show("Все");

                }
                catch
                {
                    MessageBox.Show("Ярік всьо бачок потік ");
                }
            }
            else
            {
                MessageBox.Show("Строка ПУСТА ЯК твоя бошка ");
            }

           
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\Users\polka\OneDrive\Документы\.net\.net_sourse_learn\Cосун\All_Biger.txt";
            if (Карпатський_чай.Text.Length > 0)
            {
                try
                {
                    string text = trololololo.Text;
                    File.WriteAllText(filePath, text);
                    MessageBox.Show("Все");

                }
                catch
                {
                    MessageBox.Show("Ярік всьо бачок потік ");
                }

            }
        }
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\Users\polka\OneDrive\Документы\.net\.net_sourse_learn\Cосун\Дк 80 ilvl.txt";
            if (Індійський_чай.Text.Length > 0)
            {
                try
                {
                  string text = trololololo.Text;
                  File.WriteAllText(filePath, text);
                  MessageBox.Show("Все");

                }
                catch
                {
                 MessageBox.Show("Ярік всьо бачок потік ");
                }
       
            }
        }
    }
}
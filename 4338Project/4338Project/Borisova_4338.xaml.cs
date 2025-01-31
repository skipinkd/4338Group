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

namespace _4338Project
{
    /// <summary>
    /// Логика взаимодействия для Borisova_4338.xaml
    /// </summary>
    public partial class Borisova_4338 : Window
    {
        public Borisova_4338()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Хеллоу, меня зовут Ксю, мне 18, всем пока!");
        }
    }
}

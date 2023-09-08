using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace NameGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            VatersMethode();
        }
        //Приём комманды о начале работы
        private void btGenerat_Click(object sender, RoutedEventArgs e)
        {
            VatersMethode();
            //NameResult();
        }
        //Метод генерации
        public void NameResult()
        {

            //tbResult.Text = "Timur";

        }
        public void VatersMethode()
        {
            //Генерация последовательности построения

            Random random = new Random();

            int core = random.Next(0, 10);
            int suffix = random.Next(0, 4);
            int preffix = random.Next(0,4);
            int endffix = random.Next(0,4);

            string VatersResult = 
                core.ToString() +
                suffix.ToString() +
                preffix.ToString() +
                endffix.ToString();

            //Приём сгененерированных результатов

            tbResult.Text = VatersResult;

        }
    }
}

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

namespace practos3_2
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        private ChurchEntities basadan = new ChurchEntities();
        public Page3()
        {
            InitializeComponent();
            ThirdGrid.ItemsSource = basadan.ChurchService.ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}

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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        private ChurchEntities basadan = new ChurchEntities();
        public Page2()
        {
            InitializeComponent();
            SecondGrid.ItemsSource = basadan.ChurchService.ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}

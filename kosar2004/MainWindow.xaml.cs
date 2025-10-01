using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kosar2004
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Feladatok f;
        List<Merkozes> lista;
        public MainWindow()
        {
            InitializeComponent();
            f = new Feladatok();
            lista = f.Lista;
        }

        private void btn_beolvasas_Click(object sender, RoutedEventArgs e)
        {
            lb_adatok.ItemsSource = lista;
        }
    }
}
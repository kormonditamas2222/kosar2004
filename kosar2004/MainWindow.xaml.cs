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
            lbl_3.Content = f.Harom1;
            lbl_4.Content = f.Negy1;
            lbl_5.Content = f.Ot1;
            foreach (var item in f.Hat1)
            {
                lbl_6.Content += item + "\n";
            }
        }

        private void btn_beolvasas_Click(object sender, RoutedEventArgs e)
        {
            lb_adatok.ItemsSource = lista;
        }
    }
}
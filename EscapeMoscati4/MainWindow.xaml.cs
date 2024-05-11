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

namespace EscapeMoscati4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

    
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login();
        }
        private void Login()
        {
            if (Nome.Text != "Mario") { MessageBox.Show("Nome utente sbagliato");return; };
            if (Password.Password != "Rossi") { MessageBox.Show("Password sbagliata");return; };
            Window bo = new RispostaAperta();
            bo.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nome: Mario, Password:Rossi");
        }
    }
}
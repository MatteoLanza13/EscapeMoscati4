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

namespace EscapeMoscati4
{
    /// <summary>
    /// Interaction logic for RispostaAperta.xaml
    /// </summary>
    public partial class RispostaAperta : Window
    {
        public RispostaAperta()
        {
            InitializeComponent();
            Load();
        }

        private void Risposta_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DPrec_Click(object sender, RoutedEventArgs e)
        {
            Previous();

        }

        private void DSucc_Click(object sender, RoutedEventArgs e)
        {
            Next();
        }

        private void SuggerimentoBtn_Click(object sender, RoutedEventArgs e)
        {

        }


        public int ndomanda = 0;


        (string dom, string ris)[] domanda = {

                    ("Ho un orologio che batte le ore, non ha le lancette e quadrante non ha. Ma se si ferma, morire mi fa","cuore"),
                    ("scrivi i numeri primi in ordine crescente (la separazione va fatta con uno spazio)","2 3 5 7 11"),
                    ("Decifra il seguente codice (a numero uguale corrisponde lettera uguale - La prima lettera e le iniziali di nomi propri vanno scritte maiuscole) ti dò una mano al numero 11 corrisponde la lettera d\n 1 2 3 4 5 4 6 7 7 1 8 3 7 1 1 4 9 10 4 11 7 4 11 12 7 13 7 9 3 7 14 4 11 4 7 12 2 6 4 11 7","Scrivi le espressioni dei due teoremi di Euclide"),
                    ("Vedi Figura 1 pt.1","AB^2=AH*AC"),
                    ("Vedi Figura 1 pt.2","BH^2=AH*HC"),
                    ("Primo indizio:\r\nPer saper cosa cercare, nel prossimo quesito ti\r\ndovrai cimentare\r\nHa città ma è senza case. Ci son foreste e tanti fiumi, ma alberi e pesci non ha","mappa"),
                    ("Completa la seguente successione: 8, 13, 18, 23, 28, .....","33"),
                    ("Vedi figura 2","10"),
                    ("Vedi figura 3","B"),
                    ("Secondo indizio:\r\nTroverai il tuo indizio in quel luogo dove il giovedì\r\nviene prima di mercoledì","dizionario"),
                    ("Complimenti, hai finito!","n"),

                };
        public void Load()
        {

            Update(domanda[ndomanda]);
            Immagini Imagginine = new Immagini();
            Imagginine.Show();
        }


        public void Next()
        {
            if (ndomanda < domanda.Length - 1)
            {
                ndomanda++;
                Update(domanda[ndomanda]);
            }
        }

        public void Previous()
        {
            if (ndomanda > 0)
            {
                ndomanda--;
                Update(domanda[ndomanda]);
            }
        }
        public void Reset()
        {
            ndomanda = 0;
            Update(domanda[ndomanda]);
        }
        public void Update((string dom, string ris) domanda)
        {
            Domanda.Text = domanda.dom;
            

        }

        private void DSuc_Click(object sender, RoutedEventArgs e)
        {
            Check();
        }

        private void Check()
        {
            if(Risposta.Text == domanda[ndomanda].ris)
            {
                Next();
            }
            else { MessageBox.Show("Risposta errata"); }
        }





        private void SuggBott_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Non ci sono suggeriemnti :(");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Suggerimento_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

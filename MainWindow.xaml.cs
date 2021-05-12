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

namespace Schraubenprogramm
{


    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Store store = new Store();
        Store2 store2 = new Store2();
        pricelist pricelists = new pricelist();
        PreisWert preiswert = new PreisWert();

        public MainWindow()
        {
            InitializeComponent();
            

        }
        //TreeViewItems für Hauptauswahl



        #region TreeViewItems

        private void tvi_Impressum_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            gr_Normteile.Visibility = Visibility.Hidden;
            tc_BerechnungenVierkant.Visibility = Visibility.Hidden;
            gr_Überuns.Visibility = Visibility.Hidden;
            tc_Anpassungvierkant.Visibility = Visibility.Hidden;
            im_Begrüßung.Visibility = Visibility.Hidden;
            
            im_Logo.Visibility = Visibility.Visible;
            im_HilfeSupport.Visibility = Visibility.Hidden;
            im_Impressum.Visibility = Visibility.Visible;
            lbl_Infotext.Content = "...Impressum";
            gr_AnAnzahl.Visibility = Visibility.Hidden;




        }

        private void tvi_Normteile_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            gr_Normteile.Visibility = Visibility.Visible;
            tc_BerechnungenVierkant.Visibility = Visibility.Hidden;
            gr_Überuns.Visibility = Visibility.Hidden;
            tc_Anpassungvierkant.Visibility = Visibility.Hidden;
            im_Begrüßung.Visibility = Visibility.Hidden;
            lbl_Infotext.Content = "...Bitte wählen Sie einen Schraubenkopf-Typ";
            im_Logo.Visibility = Visibility.Visible;
            im_HilfeSupport.Visibility = Visibility.Hidden;
            im_Impressum.Visibility = Visibility.Hidden;
            gr_NT_Auswahl.Visibility = Visibility.Visible;
            gr_AnAnzahl.Visibility = Visibility.Hidden;
        }

        private void tvi_AnVierkant_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            gr_AnAnpassung.Visibility = Visibility.Visible;
            tc_Anpassungvierkant.Visibility = Visibility.Visible;
            gr_Normteile.Visibility = Visibility.Hidden;
            tc_BerechnungenVierkant.Visibility = Visibility.Hidden;
            gr_Überuns.Visibility = Visibility.Hidden;
            im_Begrüßung.Visibility = Visibility.Hidden;
            lbl_AnKopfbreite.Content = "Kopfbreite (S)";
            lbl_Infotext.Content = "...Bitte geben Sie alle geforderten Maße an";
            im_Logo.Visibility = Visibility.Visible;
            im_HilfeSupport.Visibility = Visibility.Hidden;
            im_Impressum.Visibility = Visibility.Hidden;
            im_Sechkant_Be_TZ.Visibility = Visibility.Hidden;
            im_Vierkant_Be_TZ.Visibility = Visibility.Visible;
            gr_AnAnzahl.Visibility = Visibility.Hidden;
        }

        private void tvi_AnSechkant_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            tc_BerechnungenVierkant.Visibility = Visibility.Hidden;
            gr_Normteile.Visibility = Visibility.Hidden;
            gr_Überuns.Visibility = Visibility.Hidden;
            lbl_AnKopfbreite.Content = "Schlüsselweite (S)";
            tc_Anpassungvierkant.Visibility = Visibility.Visible;
            im_Begrüßung.Visibility = Visibility.Hidden;
            lbl_Infotext.Content = "...Bitte geben Sie alle geforderten Maße an";
            im_Logo.Visibility = Visibility.Visible;
            im_HilfeSupport.Visibility = Visibility.Hidden;
            im_Impressum.Visibility = Visibility.Hidden;
            im_Sechkant_Be_TZ.Visibility = Visibility.Visible;
            im_Vierkant_Be_TZ.Visibility = Visibility.Hidden;
            gr_AnAnzahl.Visibility = Visibility.Hidden;
        }

        private void tvi_AnInnensechskant_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void tvi_BeVierkant_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            tc_BerechnungenVierkant.Visibility = Visibility.Visible;
            gr_Normteile.Visibility = Visibility.Hidden;
            gr_Überuns.Visibility = Visibility.Hidden;
            lbl_Kopfbreite.Content = "Kopfbreite (S)";
            tc_Anpassungvierkant.Visibility = Visibility.Hidden;
            im_Begrüßung.Visibility = Visibility.Hidden;
            lbl_Infotext.Content = "...Bitte geben Sie alle geforderten Maße an";
            im_Logo.Visibility = Visibility.Visible;
            im_HilfeSupport.Visibility = Visibility.Hidden;
            im_Impressum.Visibility = Visibility.Hidden;
            im_VierkantTZ.Visibility = Visibility.Visible;
            im_SechkantTZ.Visibility = Visibility.Hidden;
            gr_AnAnzahl.Visibility = Visibility.Hidden;
        }

        private void tvi_BeSechkant_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            tc_BerechnungenVierkant.Visibility = Visibility.Visible;
            gr_Normteile.Visibility = Visibility.Hidden;
            gr_Überuns.Visibility = Visibility.Hidden;
            lbl_Kopfbreite.Content = "Schlüsselweite (S)";
            tc_Anpassungvierkant.Visibility = Visibility.Hidden;
            im_Begrüßung.Visibility = Visibility.Hidden;
            lbl_Infotext.Content = "...Bitte geben Sie alle geforderten Maße an";
            im_Logo.Visibility = Visibility.Visible;
            im_HilfeSupport.Visibility = Visibility.Hidden;
            im_Impressum.Visibility = Visibility.Hidden;
            im_SechkantTZ.Visibility = Visibility.Visible;
            im_VierkantTZ.Visibility = Visibility.Hidden;
            gr_AnAnzahl.Visibility = Visibility.Hidden;
        }

        private void tvi_BeInnensechskant_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void tvi_Support_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            gr_Überuns.Visibility = Visibility.Hidden;
            gr_Normteile.Visibility = Visibility.Hidden;
            tc_BerechnungenVierkant.Visibility = Visibility.Hidden;
            im_Begrüßung.Visibility = Visibility.Hidden;
            tc_Anpassungvierkant.Visibility = Visibility.Hidden;

            im_Logo.Visibility = Visibility.Visible;
            im_HilfeSupport.Visibility = Visibility.Visible;
            im_Impressum.Visibility = Visibility.Hidden;
            lbl_Infotext.Content = "...Haben Sie noch Fragen";
            gr_AnAnzahl.Visibility = Visibility.Hidden;
        }

        private void tvi_Überuns_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            gr_Überuns.Visibility = Visibility.Visible;
            gr_Normteile.Visibility = Visibility.Hidden;
            tc_BerechnungenVierkant.Visibility = Visibility.Hidden;
            im_Begrüßung.Visibility = Visibility.Hidden;
            tc_Anpassungvierkant.Visibility = Visibility.Hidden;
            
            lbl_Infotext.Content = "...Wer sind wir eigentlich?";
            im_Logo.Visibility = Visibility.Visible;
            im_HilfeSupport.Visibility = Visibility.Hidden;
            im_Impressum.Visibility = Visibility.Hidden;
            gr_AnAnzahl.Visibility = Visibility.Hidden;
        }

        private void btn_zurück_Click(object sender, RoutedEventArgs e)
        {
            tc_Anpassungvierkant.Visibility = Visibility.Visible;
            gr_Normteile.Visibility = Visibility.Hidden;
            gr_Überuns.Visibility = Visibility.Hidden;
            gr_AnAnpassung.Visibility = Visibility.Visible;
            gr_AnAnzahl.Visibility = Visibility.Hidden;
            lbl_Infotext.Content = "...Bitte geben Sie erneut die Daten ein";


        }

        #endregion

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        //Individuelle Berechnung
        //auf Zahl überprüfen
        #region Berechnung
        private void btn_Berechnen_Click(object sender, RoutedEventArgs e)
        {
            if (tb_Gewindelänge.Background == Brushes.Red || tb_Kopfbreite.Background == Brushes.Red || tb_Kopfhöhe.Background == Brushes.Red || tb_Schaftlänge.Background == Brushes.Red || tb_Gewindedurchmesser.Background == Brushes.Red)
            {
                MessageBox.Show("Bitte Eingaben überprüfen");
            }

            if (tb_Gewindelänge.Text == "" || tb_Kopfbreite.Text == "" || tb_Kopfhöhe.Text == "" || tb_Schaftlänge.Text == "" || tb_Gewindedurchmesser.Text == "")
            {
                MessageBox.Show("Sie müssen erst eine Eingabe tätigen");
            }



            else
            {
                double Kopfhöhe, Kopfbreite, Gewindedurchmesser, Gewindelänge, Schaftlänge, dichte, gesamtvolumen, masse, flächenträgheit, Preis, gesamtpreis, widerstandsmoment;
                Kopfhöhe = Convert.ToDouble(tb_Kopfhöhe.Text);
                Kopfbreite = Convert.ToDouble(tb_Kopfbreite.Text);
                Gewindedurchmesser = Convert.ToDouble(tb_Gewindedurchmesser.Text);
                Gewindelänge = Convert.ToDouble(tb_Gewindelänge.Text);
                Schaftlänge = Convert.ToDouble(tb_Schaftlänge.Text);
                dichte = 0;
                masse = 0;
                Preis = 0;
                gesamtvolumen = 0;

                if (Kopfhöhe < 0 || Gewindedurchmesser < 0 || Gewindelänge < 0 || Kopfbreite < 0 || Schaftlänge < 0)
                {
                    MessageBox.Show("Negative Zahlen sind leider nicht möglich");
                }
                else
                {


                    if (cb_Item_Baustahl.IsSelected)
                    {
                        dichte = 7.85;
                        Preis = 3.63;
                    }
                    else if (cb_Item_Aluminium.IsSelected)
                    {
                        dichte = 2.7;
                        Preis = 9.89;
                    }
                    else if (cb_Item_Messing.IsSelected)
                    {
                        dichte = 8.44;
                        Preis = 7.13;
                    }
                    else if (cb_Item_Vergütungsstahl.IsSelected)
                    {
                        dichte = 8;
                        Preis = 10.28;
                    }


                    if (tvi_BeVierkant.IsSelected)
                    {
                        gesamtvolumen = ((((Gewindedurchmesser / 2) * (Gewindedurchmesser / 2) * Math.PI) * (Gewindelänge + Schaftlänge)) + (Kopfhöhe * Kopfbreite)) / 1000;
                        masse = (((((Gewindedurchmesser / 2) * (Gewindedurchmesser / 2) * Math.PI) * (Gewindelänge)) + (Kopfhöhe * Kopfbreite)) / 1000) * dichte;

                    }
                    if (tvi_BeSechkant.IsSelected)
                    {
                        gesamtvolumen = ((Math.Sqrt(3) * (3 * ((Kopfbreite / Math.Sqrt(3)) * (Kopfbreite / Math.Sqrt(3))) / 2)) * Kopfhöhe) + (((Gewindedurchmesser / 2) * (Gewindedurchmesser / 2)) * Math.PI) * (Gewindelänge + Schaftlänge);
                        masse = gesamtvolumen * dichte;

                    }
                    gesamtpreis = Preis * masse;
                    widerstandsmoment = (Math.PI * (Gewindedurchmesser * Gewindedurchmesser * Gewindedurchmesser)) / 32;
                    flächenträgheit = (Math.PI * (Gewindedurchmesser * Gewindedurchmesser * Gewindedurchmesser * Gewindedurchmesser)) / 64;

                    List<Angaben> technDaten = new List<Angaben>();
                    technDaten.Add(new Angaben("Volumen in mm^3", gesamtvolumen));
                    technDaten.Add(new Angaben("Masse in g", masse));
                    technDaten.Add(new Angaben("Preis in €", gesamtpreis));
                    technDaten.Add(new Angaben("Widerstandsmoment in mm^3", widerstandsmoment));
                    technDaten.Add(new Angaben("Flächenträgheitsmoment in mm^4", flächenträgheit));
  
                    btn_Aktualisieren.IsEnabled = true;
                    dg_TechnischeDaten.ItemsSource = technDaten;

                }
            }

        }
        #endregion


        private void tb_Kopfhöhe_LostFocus_1(object sender, RoutedEventArgs e)
        {

            TextBox textbox = (TextBox)sender;

            Double resultat;
            if (Double.TryParse(textbox.Text, out resultat))
            {
                textbox.Background = Brushes.White;
            }
            else
            {
                textbox.Background = Brushes.Red;

            }


        }  //Eingaben prüfen


        #region Legierungen 


        private void cb_Item_Vergütungsstahl_Selected(object sender, RoutedEventArgs e)
        {
            cb_Legierungen.IsEnabled = false;
            cb_Item_Leer.IsSelected = true;
        }

        private void cb_Item_Messing_Selected(object sender, RoutedEventArgs e)
        {
            cb_Legierungen.IsEnabled = false;
            cb_Item_Leer.IsSelected = true;
        }

        private void cb_Item_Aluminium_Selected(object sender, RoutedEventArgs e)
        {
            cb_Legierungen.IsEnabled = true;
            cb_Item_Leer.IsSelected = true;
        }


        private void cb_Item_Baustahl_Selected(object sender, RoutedEventArgs e)
        {

        }


        #endregion

  



        private void dg_Angaben_Loaded(object sender, RoutedEventArgs e)
        {




        }

        

        private void tc_BerechnungenVierkant_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dg_TechnischeDaten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        
        

        private void btn_Erstellen_Click(object sender, RoutedEventArgs e)      //Anpassung Seite 2
        {


            if (tb_AnGewindelänge.Background == Brushes.Red || tb_AnKopfbreite.Background == Brushes.Red || tb_AnKopfhöhe.Background == Brushes.Red || tb_AnSchaftlänge.Background == Brushes.Red || tb_AnGewindedurchmesser.Background == Brushes.Red)
            {
                MessageBox.Show("Bitte Eingaben überprüfen");
            }
            else if (tb_AnGewindelänge.Text == "" || tb_AnKopfbreite.Text == "" || tb_AnSchaftlänge.Text == "" || tb_AnKopfhöhe.Text == "" || tb_AnGewindedurchmesser.Text == "") 
            {
               
                    MessageBox.Show("Sie müssen erst eine Eingabe tätigen");   
            }
            else
            {
                double Kopfhöhe, Kopfbreite, Gewindedurchmesser, Gewindelänge, Schaftlänge;
                Kopfhöhe = Convert.ToDouble(tb_AnKopfhöhe.Text);
                Kopfbreite = Convert.ToDouble(tb_AnKopfbreite.Text);
                Gewindedurchmesser = Convert.ToDouble(tb_AnGewindedurchmesser.Text);
                Gewindelänge = Convert.ToDouble(tb_AnGewindelänge.Text);
                Schaftlänge = Convert.ToDouble(tb_AnSchaftlänge.Text);


                if (Kopfhöhe < 0 || Gewindedurchmesser < 0 || Gewindelänge < 0 || Kopfbreite < 0 || Schaftlänge < 0)
                {
                    MessageBox.Show("Negative Zahlen sind leider nicht möglich");
                }
                else
                {
                    gr_AnAnpassung.Visibility = Visibility.Hidden;
                    gr_AnAnzahl.Visibility = Visibility.Visible;
                    lbl_Infotext.Content = "Fast fertig... Bitte wählen Sie noch eine Anzahl";
                }
            }


            




        }



        
        
        private void dg_Übersicht_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Aktualisieren2_Click(object sender, RoutedEventArgs e)
        {
            List<übersicht> Übersicht = new List<übersicht>();
            Übersicht.Add(new übersicht("Gewindedurchmesser in mm", Convert.ToDouble(tb_AnGewindedurchmesser.Text)));

            Übersicht.Add(new übersicht("Schaftlänge in mm", Convert.ToDouble(tb_AnSchaftlänge.Text)));

            if (tvi_AnVierkant.IsSelected)
            {
                Übersicht.Add(new übersicht("Kopfbreite in mm", Convert.ToDouble(tb_AnKopfbreite.Text)));
            }
            if (tvi_AnSechkant.IsSelected)
            {
                Übersicht.Add(new übersicht("Schlüsselweite in mm", Convert.ToDouble(tb_AnKopfbreite.Text)));
            }
            Übersicht.Add(new übersicht("Kopfhöhe in mm", Convert.ToDouble(tb_AnKopfhöhe.Text)));


            dg_Übersicht.ItemsSource = Übersicht;
        } //Aktualisieren der Übersicht

        private void btn_AktualisierenNew_Click(object sender, RoutedEventArgs e)
        {
            dg_Warenkorb.ItemsSource = store.Schraubenliste;

            dg_Warenkorb_Preis.ItemsSource = pricelists.Gesamtpreisliste;          

            btn_AktualisierenNew.IsEnabled = false;

            btn_Hinzufügen.IsEnabled = false;







        }

        #region Beenden
        private void btn_Beenden2_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        #endregion

        #region Bilder Normteile
        private void lb_Item_Vierkant_MouseEnter(object sender, MouseEventArgs e)
        {
            im_Vierkant.Visibility = Visibility.Visible;
            tbl_Norm.Text = "Vierkantschraube mit Kernansatz DIN 479";
        }

        private void lb_Item_Sechkant_MouseEnter(object sender, MouseEventArgs e)
        {
            im_Sechkant.Visibility = Visibility.Visible;
            tbl_Norm.Text = "Sechskantschraube DIN EN ISO 4017 (durchgängiges Gewinde) / DIN EN ISO 4014 (mit Schaft)";
        }

        private void lb_Item_Innensechskant_MouseEnter(object sender, MouseEventArgs e)
        {
            im_Innensechkant.Visibility = Visibility.Visible;
            tbl_Norm.Text = "Senkkopfschraube mit Innensechskant DIN EN ISO 10642";
        }

        private void lb_Item_Zylinderkopf_MouseEnter(object sender, MouseEventArgs e)
        {
            im_Zylinderkopf.Visibility = Visibility.Visible;
            tbl_Norm.Text = "Zylinderkopfschraube mit Innensechskant DIN EN ISO 4762";
        }

        private void lb_Item_Schlitzkopf_MouseEnter(object sender, MouseEventArgs e)
        {
            im_Schlitzkopf.Visibility = Visibility.Visible;
            tbl_Norm.Text = "Linsensenkschraube mit Schlitz DIN EN ISO 2010";
        }

        private void lb_Item_Vierkant_MouseLeave(object sender, MouseEventArgs e)
        {
            im_Vierkant.Visibility = Visibility.Hidden;
            tbl_Norm.Text = "";
        }

        private void lb_Item_Sechkant_MouseLeave(object sender, MouseEventArgs e)
        {
            im_Sechkant.Visibility = Visibility.Hidden;
            tbl_Norm.Text = "";
        }

        private void lb_Item_Innensechskant_MouseLeave(object sender, MouseEventArgs e)
        {
            im_Innensechkant.Visibility = Visibility.Hidden;
            tbl_Norm.Text = "";
        }

        private void lb_Item_Zylinderkopf_MouseLeave(object sender, MouseEventArgs e)
        {
            im_Zylinderkopf.Visibility = Visibility.Hidden;
            tbl_Norm.Text = "";
        }

        private void lb_Item_Schlitzkopf_MouseLeave(object sender, MouseEventArgs e)
        {
            im_Schlitzkopf.Visibility = Visibility.Hidden;
            tbl_Norm.Text = "";
        }
        

        private void lb_Item_Vierkant_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
        #endregion

        

        private void btn_NT_Beenden_Click(object sender, RoutedEventArgs e)
        {
            if(tb_NT_Länge.Background == Brushes.Red)
            {
                MessageBox.Show("Bitte Eingaben prüfen");
            }
            else if (tb_NT_Länge.Text == "")
            {
                MessageBox.Show("Sie müssen noch Werte eingeben");
            }

            else
            {
                
                double Länge = Convert.ToDouble(tb_NT_Länge.Text);
                if(Länge < 0)
                {
                    MessageBox.Show("Negative Zahlen sind leider nicht möglich");
                }
                
                else
                {
                    gr_NT_Anzahl.Visibility = Visibility.Visible;
                    gr_NT_Anpassung.Visibility = Visibility.Hidden;
                    lbl_Infotext.Content = "Fast fertig... Bitte wählen Sie noch eine Anzahl.";
                }
            }
        }  //Prüfen auf neg. Zahlen NT

        private void tb_NT_Anzahl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            btn_NT_Hinzufügen.IsEnabled = true;
        }

        private void btn_NT_Hinzufügen_Click(object sender, RoutedEventArgs e)        //Hinzufügen button bei Normteilen
        {

            if (tb_NT_Anzahl.Background == Brushes.White)
            {
                double anzaahl = Convert.ToDouble(tb_NT_Anzahl.Text);

                if (anzaahl == 0)
                {
                    MessageBox.Show("Sie müssen mindestens eine Schraube wählen!");
                }
                else if (anzaahl < 1)
                {
                    MessageBox.Show("Mindestens eine Schraube wählen.");
                }
                else if (anzaahl > 1000)
                {
                    MessageBox.Show("Die maximale Anzahl beträgt 1000.");
                }
                else
                {
                    string name = "";
                    if(lb_Item_Schlitzkopf.IsSelected == true)
                    {
                        name = "Schlitzkopf";
                    }
                    if (lb_Item_Sechkant.IsSelected == true)
                    {
                        name = "Sechskant";
                    }
                    if (lb_Item_Vierkant.IsSelected == true)
                    {
                        name = "Vierkant";
                    }
                    if (lb_Item_Zylinderkopf.IsSelected == true)
                    {
                        name = "Zylinderkopf";
                    }
                    if (lb_Item_Innensechskant.IsSelected == true)
                    {
                        name = "Innensechkant";
                    }

                    int artikelnummer = 27354;
                    int anzahl = Convert.ToInt32(tb_NT_Anzahl.Text);
                    double eigenschaft = Convert.ToDouble(tb_NT_Länge.Text);
                    int Preis = 0;

                    Schrauben newSchraube = new Schrauben(name, eigenschaft, anzahl, artikelnummer, Preis);
                    store.Schraubenliste.Add(newSchraube);



                    //Kommentar 
                    lbl_Infotext.Content = "Bitte checken Sie Ihren Warenkorb";

                    MessageBox.Show("Der Artikel wurde zum Warenkorb hinzugefügt.");
                }
            }
            else if (tb_NT_Anzahl.Background == Brushes.Red)
            {
                MessageBox.Show("Bitte Eingabe überprüfen.");
            }
        }

       

        private void tb_NT_Anzahl_LostFocus_1(object sender, RoutedEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            Int32 resultat;
            if (Int32.TryParse(textbox.Text, out resultat))
            {
                tb_NT_Anzahl.Background = Brushes.White;
            }
            else
            {
                tb_NT_Anzahl.Background = Brushes.Red;
            }
        }            //Eingabe auf int prüfen bei NT

        private void btn_NT_Zurück_Click(object sender, RoutedEventArgs e)  // Zurück Button bei NT
        {
            gr_NT_Haupt.Visibility = Visibility.Hidden;
            gr_NT_Auswahl.Visibility = Visibility.Visible;
            lbl_Infotext.Content = "...Bitte wählen Sie erneut einen Schraubenkopf-Typ aus";
        }

        private void btn_NT_Zurück2_Click(object sender, RoutedEventArgs e)   //Button Zurück NT 2
        {
            gr_NT_Anzahl.Visibility = Visibility.Hidden;
            gr_NT_Anpassung.Visibility = Visibility.Visible;
            lbl_Infotext.Content = "...Bitte wählen Sie erneut einen Schraubenkopf-Typ";

        }

        private void btn_AktualisierenNT_Click(object sender, RoutedEventArgs e)
        {
            List<übersichtNT> Übersicht = new List<übersichtNT>();

            if(lb_Item_Innensechskant.IsSelected == true)
            {
                Übersicht.Add(new übersichtNT("Innensechkant", 1));
            }
            if (lb_Item_Schlitzkopf.IsSelected == true)
            {
                Übersicht.Add(new übersichtNT("Schlitzkopf", 1));
            }
            if (lb_Item_Sechkant.IsSelected == true)
            {
                Übersicht.Add(new übersichtNT("Sechkant", 1));
            }
            if (lb_Item_Vierkant.IsSelected == true)
            {
                Übersicht.Add(new übersichtNT("Vierkant", 1));
            }
            if (lb_Item_Zylinderkopf.IsSelected == true)
            {
                Übersicht.Add(new übersichtNT("Zylinderkopf", 1));
            }
            double x = Convert.ToDouble(cb_NT_Gewindegröße.Text);
            Übersicht.Add(new übersichtNT("Gewindegröße in mm", x));

            

            dg_NT_Übersicht.ItemsSource = Übersicht;

        }

      

        
    }


    #region Klassen

    public class PreisWert
    {
        public double Wert { get; set; }
    }
    public class Gesamtpreis
    {
        public double Preis { get; set; }
        public Gesamtpreis(double gesamtpreis)
        {
            this.Preis = gesamtpreis;
        }
    }
    public class Schrauben
    {

        public string Name { get; set; }
        public int Artikelnummer { get; set; }
        public int Anzahl { get; set; }
        public double Durchmesser { get; set; }
        public double Preis { get; set; }

        public Schrauben(string name, double eigenschaft, int anzahl, int artikelnummer, double preis)
        {
            this.Name = name;
            this.Artikelnummer = artikelnummer;
            this.Anzahl = anzahl;
            this.Durchmesser = eigenschaft;
            this.Preis = preis;

        }
        override public string ToString()
        {
            return (Name + Artikelnummer + Anzahl + Durchmesser + Preis);
        }
        
    }

    public class Normteil
    {
        public string Name { get; set; }
        public int Artikelnummer { get; set; }
        public int Anzahl { get; set; }
        public double Durchmesser { get; set; }

        public Normteil(string name, double eigenschaft, int anzahl, int artikelnummer)
        {
            this.Name = name;
            this.Artikelnummer = artikelnummer;
            this.Anzahl = anzahl;
            this.Durchmesser = eigenschaft;
        }
        
    }
    

    public class Store
    {
        public List<Schrauben> Schraubenliste { get; set; }
        public List<Schrauben> Shoppinglist { get; set; }

        
        public Store()
        {
            Schraubenliste = new List<Schrauben>();
            Shoppinglist = new List<Schrauben>();
        }

    }

    public class pricelist
    {
        public List<Gesamtpreis> Gesamtpreisliste { get; set; }

        public pricelist()
        {
            Gesamtpreisliste = new List<Gesamtpreis>();
        }
            
         

    }

    public class Store2
    {
        public List<Schrauben> Schraubenliste2 { get; set; }
        public List<Schrauben> Shoppinglist2 { get; set; }


        public Store2()
        {
            Schraubenliste2 = new List<Schrauben>();
            Shoppinglist2 = new List<Schrauben>();
        }

    }

    

    public class Angaben2
    {
        public string Eigenschaft { get; set; }
        public string Auswahl { get; set; }
        public Angaben2(string eigenschaft, string wert)
        {
            this.Eigenschaft = eigenschaft;
            this.Auswahl = wert;
        }
    }
    public class Angaben
    {
        public string Eigenschaft { get; set; }
        public double Wert { get; set; }
        public Angaben(string eigenschaft, double wert)
        {
            this.Eigenschaft = eigenschaft;
            this.Wert = wert;
        }
    }

    public class übersicht
    {
        public string Eigenschaft { get; set; }
        public double Wert { get; set; }
        public übersicht(string eigenschaft, double wert)
        {
            this.Eigenschaft = eigenschaft;
            this.Wert = wert;
        }
    }

    public class übersichtNT
    {
        public string Eigenschaft { get; set; }
        public double Wert { get; set; }
        public übersichtNT(string eigenschaft, double wert)
        {
            this.Eigenschaft = eigenschaft;
            this.Wert = wert;
        }
    }

    public class technischesBlatt
    {
        public string Eigenschaft { get; set; }
        public double Wert { get; set; }
        public technischesBlatt(string eigenschaft, double wert)
        {
            this.Eigenschaft = eigenschaft;
            this.Wert = wert;
        }
    }

    public class technischesBlattWeitereAngaben
    {
        public string Eigenschaft { get; set; }
        public double Wert { get; set; }
        public technischesBlattWeitereAngaben(string eigenschaft, double wert)
        {
            this.Eigenschaft = eigenschaft;
            this.Wert = wert;
        }
    }


    class Warenartikel
    {
        public string ware { get; set; }
        public int anzahl { get; set; }
        public int artikelnummer { get; set; }
        public double einzelpreis { get; set; }

        public Warenartikel(string Ware, int Anzahl, int Artikelnummer, double Einzelpreis)
        {
            this.ware = Ware;
            this.anzahl = Anzahl;
            this.artikelnummer = Artikelnummer;
            this.einzelpreis = Einzelpreis;
        }
    }
    #endregion




}






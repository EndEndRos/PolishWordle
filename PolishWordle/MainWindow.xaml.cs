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
using System.Drawing;
using System.IO;

namespace PolishWordle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public int Counter { get; set; }
        public int Counter_strike { get; set; }
        public int PointCase { get;  set; }
        public string chosenWord { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Counter = 0;
            Counter_strike = 0;
            PointCase = 0;
            Word.Focus();
            Word.SelectAll();

            string FilePath = "LastScore.txt";
            if (File.Exists(FilePath))
            {
                var FileContent = File.ReadAllText(FilePath);
                LastScore.Text = FileContent;
            }
        }

        public void Clearing()
        {

            txtAA.Content = null;
            txtAB.Content = null;
            txtAC.Content = null;
            txtAD.Content = null;
            txtAE.Content = null;
            txtAA.Background = Brushes.White;
            txtAB.Background = Brushes.White;
            txtAC.Background = Brushes.White;
            txtAD.Background = Brushes.White;
            txtAE.Background = Brushes.White;

            txtBA.Content = null;
            txtBB.Content = null;
            txtBC.Content = null;
            txtBD.Content = null;
            txtBE.Content = null;
            txtBA.Background = Brushes.White;
            txtBB.Background = Brushes.White;
            txtBC.Background = Brushes.White;
            txtBD.Background = Brushes.White;
            txtBE.Background = Brushes.White;

            txtCA.Content = null;
            txtCB.Content = null;
            txtCC.Content = null;
            txtCD.Content = null;
            txtCE.Content = null;
            txtCA.Background = Brushes.White;
            txtCB.Background = Brushes.White;
            txtCC.Background = Brushes.White;
            txtCD.Background = Brushes.White;
            txtCE.Background = Brushes.White;

            txtDA.Content = null;
            txtDB.Content = null;
            txtDC.Content = null;
            txtDD.Content = null;
            txtDE.Content = null;
            txtDA.Background = Brushes.White;
            txtDB.Background = Brushes.White;
            txtDC.Background = Brushes.White;
            txtDD.Background = Brushes.White;
            txtDE.Background = Brushes.White;

            txtEA.Content = null;
            txtEB.Content = null;
            txtEC.Content = null;
            txtED.Content = null;
            txtEE.Content = null;
            txtEA.Background = Brushes.White;
            txtEB.Background = Brushes.White;
            txtEC.Background = Brushes.White;
            txtED.Background = Brushes.White;
            txtEE.Background = Brushes.White;

            Counter = 0;
            TheWord.Foreground = Brushes.Transparent;
            Strike.Foreground = Brushes.White;
        }

        public void Point(int pointcase)
        {
            
            Strike.Content = "Strike: x" + Counter_strike;
            Strike.Foreground = Brushes.LightGreen;

    }
        public enum ThePointStrike
        {
            StrikeOne = 1,
            StrikeTwo,
            StrikeThree,
            StrikeFour,
            StrikeFive
        }

        public void Working()
        {
           
            

            Score(Counter_strike);
            string theword = Word.Text;
            theword = theword.ToUpper();

            char aa = chosenWord[0];
            char bb = chosenWord[1];
            char cc = chosenWord[2];
            char dd = chosenWord[3];
            char ee = chosenWord[4];

            int i = Counter++;
            if (i <= 6)
            {
                if (theword.Length == 5)
                {
                    if (i == 0 && theword != chosenWord)
                    {


                        string firstword = theword;
                        txtAA.Content = firstword[0];
                        txtAB.Content = firstword[1];
                        txtAC.Content = firstword[2];
                        txtAD.Content = firstword[3];
                        txtAE.Content = firstword[4];

                        char AA = firstword[0];
                        char AB = firstword[1];
                        char AC = firstword[2];
                        char AD = firstword[3];
                        char AE = firstword[4];

                        if (AA == aa)
                        {
                            txtAA.Background = Brushes.Green;
                        }
                        else if (AA == bb || AA == cc || AA == dd || AA == ee)
                        {
                            txtAA.Background = Brushes.Yellow;
                        }

                        if (AB == bb)
                        {
                            txtAB.Background = Brushes.Green;
                        }
                        else if (AB == aa || AB == cc || AB == dd || AB == ee)
                        {
                            txtAB.Background = Brushes.Yellow;
                        }

                        if (AC == cc)
                        {
                            txtAC.Background = Brushes.Green;
                        }
                        else if (AC == bb || AC == aa || AC == dd || AC == ee)
                        {
                            txtAC.Background = Brushes.Yellow;
                        }

                        if (AD == dd)
                        {
                            txtAD.Background = Brushes.Green;
                        }
                        else if (AD == bb || AD == cc || AD == aa || AD == ee)
                        {
                            txtAD.Background = Brushes.Yellow;
                        }

                        if (AE == ee)
                        {
                            txtAE.Background = Brushes.Green;
                        }
                        else if (AE == bb || AE == cc || AE == dd || AE == aa)
                        {
                            txtAE.Background = Brushes.Yellow;
                        }
                        theword = "";
                    }
                    else if (i == 0 && theword == chosenWord)
                    {
                        string firstword = theword;
                        txtAA.Content = firstword[0];
                        txtAB.Content = firstword[1];
                        txtAC.Content = firstword[2];
                        txtAD.Content = firstword[3];
                        txtAE.Content = firstword[4];

                        char AA = firstword[0];
                        char AB = firstword[1];
                        char AC = firstword[2];
                        char AD = firstword[3];
                        char AE = firstword[4];

                        if (AA == aa)
                        {
                            txtAA.Background = Brushes.Green;
                        }

                        if (AB == bb)
                        {
                            txtAB.Background = Brushes.Green;
                        }


                        if (AC == cc)
                        {
                            txtAC.Background = Brushes.Green;
                        }


                        if (AD == dd)
                        {
                            txtAD.Background = Brushes.Green;
                        }


                        if (AE == ee)
                        {
                            txtAE.Background = Brushes.Green;
                        }

                        theword = "";

                        TheWord.Foreground = Brushes.White;
                        Counter_strike++;
                        Point(Counter_strike);
                        Counter = 5;
                    }
                    else if (i == 1 && theword != chosenWord)
                    {
                        string secondword = theword;
                        txtBA.Content = secondword[0];
                        txtBB.Content = secondword[1];
                        txtBC.Content = secondword[2];
                        txtBD.Content = secondword[3];
                        txtBE.Content = secondword[4];

                        char BA = secondword[0];
                        char BB = secondword[1];
                        char BC = secondword[2];
                        char BD = secondword[3];
                        char BE = secondword[4];

                        if (BA == aa)
                        {
                            txtBA.Background = Brushes.Green;
                        }
                        else if (BA == bb || BA == cc || BA == dd || BA == ee)
                        {
                            txtBA.Background = Brushes.Yellow;
                        }

                        if (BB == bb)
                        {
                            txtBB.Background = Brushes.Green;
                        }
                        else if (BB == aa || BB == cc || BB == dd || BB == ee)
                        {
                            txtBB.Background = Brushes.Yellow;
                        }

                        if (BC == cc)
                        {
                            txtBC.Background = Brushes.Green;
                        }
                        else if (BC == bb || BC == aa || BC == dd || BC == ee)
                        {
                            txtBC.Background = Brushes.Yellow;
                        }

                        if (BD == dd)
                        {
                            txtBD.Background = Brushes.Green;
                        }
                        else if (BD == bb || BD == cc || BD == aa || BD == ee)
                        {
                            txtBD.Background = Brushes.Yellow;
                        }

                        if (BE == ee)
                        {
                            txtBE.Background = Brushes.Green;
                        }
                        else if (BE == bb || BE == cc || BE == dd || BE == aa)
                        {
                            txtBE.Background = Brushes.Yellow;
                        }
                        theword = "";
                    }
                    else if (i == 1 && theword == chosenWord)
                    {
                        string secondword = theword;
                        txtBA.Content = secondword[0];
                        txtBB.Content = secondword[1];
                        txtBC.Content = secondword[2];
                        txtBD.Content = secondword[3];
                        txtBE.Content = secondword[4];

                        char BA = secondword[0];
                        char BB = secondword[1];
                        char BC = secondword[2];
                        char BD = secondword[3];
                        char BE = secondword[4];

                        if (BA == aa)
                        {
                            txtBA.Background = Brushes.Green;
                        }

                        if (BB == bb)
                        {
                            txtBB.Background = Brushes.Green;
                        }


                        if (BC == cc)
                        {
                            txtBC.Background = Brushes.Green;
                        }


                        if (BD == dd)
                        {
                            txtBD.Background = Brushes.Green;
                        }


                        if (BE == ee)
                        {
                            txtBE.Background = Brushes.Green;
                        }
                        theword = "";

                        TheWord.Foreground = Brushes.White;
                        Counter_strike++;
                        Point(Counter_strike);
                        Counter = 5;

                    }
                    else if (i == 2 && theword != chosenWord)
                    {
                        string thridword = theword;
                        txtCA.Content = thridword[0];
                        txtCB.Content = thridword[1];
                        txtCC.Content = thridword[2];
                        txtCD.Content = thridword[3];
                        txtCE.Content = thridword[4];

                        char CA = thridword[0];
                        char CB = thridword[1];
                        char CC = thridword[2];
                        char CD = thridword[3];
                        char CE = thridword[4];

                        if (CA == aa)
                        {
                            txtCA.Background = Brushes.Green;
                        }
                        else if (CA == bb || CA == cc || CA == dd || CA == ee)
                        {
                            txtCA.Background = Brushes.Yellow;
                        }

                        if (CB == bb)
                        {
                            txtCB.Background = Brushes.Green;
                        }
                        else if (CB == aa || CB == cc || CB == dd || CB == ee)
                        {
                            txtCB.Background = Brushes.Yellow;
                        }

                        if (CC == cc)
                        {
                            txtCC.Background = Brushes.Green;
                        }
                        else if (CC == bb || CC == aa || CC == dd || CC == ee)
                        {
                            txtCC.Background = Brushes.Yellow;
                        }

                        if (CD == dd)
                        {
                            txtCD.Background = Brushes.Green;
                        }
                        else if (CD == bb || CD == cc || CD == aa || CD == ee)
                        {
                            txtCD.Background = Brushes.Yellow;
                        }

                        if (CE == ee)
                        {
                            txtCE.Background = Brushes.Green;
                        }
                        else if (CE == bb || CE == cc || CE == dd || CE == aa)
                        {
                            txtCE.Background = Brushes.Yellow;
                        }
                        theword = "";
                    }
                    else if (i == 2 && theword == chosenWord)
                    {
                        string thridword = theword;
                        txtCA.Content = thridword[0];
                        txtCB.Content = thridword[1];
                        txtCC.Content = thridword[2];
                        txtCD.Content = thridword[3];
                        txtCE.Content = thridword[4];

                        char CA = thridword[0];
                        char CB = thridword[1];
                        char CC = thridword[2];
                        char CD = thridword[3];
                        char CE = thridword[4];


                        if (CA == aa)
                        {
                            txtCA.Background = Brushes.Green;
                        }

                        if (CB == bb)
                        {
                            txtCB.Background = Brushes.Green;
                        }


                        if (CC == cc)
                        {
                            txtCC.Background = Brushes.Green;
                        }


                        if (CD == dd)
                        {
                            txtCD.Background = Brushes.Green;
                        }


                        if (CE == ee)
                        {
                            txtCE.Background = Brushes.Green;
                        }
                        theword = "";

                        TheWord.Foreground = Brushes.White;
                        Counter_strike++;
                        Point(Counter_strike);
                        Counter = 5;
                    }
                    else if (i == 3 && theword != chosenWord)
                    {
                        string fourword = theword;
                        txtDA.Content = fourword[0];
                        txtDB.Content = fourword[1];
                        txtDC.Content = fourword[2];
                        txtDD.Content = fourword[3];
                        txtDE.Content = fourword[4];

                        char DA = fourword[0];
                        char DB = fourword[1];
                        char DC = fourword[2];
                        char DD = fourword[3];
                        char DE = fourword[4];

                        if (DA == aa)
                        {
                            txtDA.Background = Brushes.Green;
                        }
                        else if (DA == bb || DA == cc || DA == dd || DA == ee)
                        {
                            txtDA.Background = Brushes.Yellow;
                        }

                        if (DB == bb)
                        {
                            txtDB.Background = Brushes.Green;
                        }
                        else if (DB == aa || DB == cc || DB == dd || DB == ee)
                        {
                            txtDB.Background = Brushes.Yellow;
                        }

                        if (DC == cc)
                        {
                            txtDC.Background = Brushes.Green;
                        }
                        else if (DC == bb || DC == aa || DC == dd || DC == ee)
                        {
                            txtDC.Background = Brushes.Yellow;
                        }

                        if (DD == dd)
                        {
                            txtDD.Background = Brushes.Green;
                        }
                        else if (DD == bb || DD == cc || DD == aa || DD == ee)
                        {
                            txtDD.Background = Brushes.Yellow;
                        }

                        if (DE == ee)
                        {
                            txtDE.Background = Brushes.Green;
                        }
                        else if (DE == bb || DE == cc || DE == dd || DE == aa)
                        {
                            txtDE.Background = Brushes.Yellow;
                        }
                        theword = "";
                    }
                    else if (i == 3 && theword == chosenWord)
                    {
                        string fourword = theword;
                        txtDA.Content = fourword[0];
                        txtDB.Content = fourword[1];
                        txtDC.Content = fourword[2];
                        txtDD.Content = fourword[3];
                        txtDE.Content = fourword[4];

                        char DA = fourword[0];
                        char DB = fourword[1];
                        char DC = fourword[2];
                        char DD = fourword[3];
                        char DE = fourword[4];

                        if (DA == aa)
                        {
                            txtDA.Background = Brushes.Green;
                        }

                        if (DB == bb)
                        {
                            txtDB.Background = Brushes.Green;
                        }


                        if (DC == cc)
                        {
                            txtDC.Background = Brushes.Green;
                        }


                        if (DD == dd)
                        {
                            txtDD.Background = Brushes.Green;
                        }


                        if (DE == ee)
                        {
                            txtDE.Background = Brushes.Green;
                        }
                        theword = "";

                        TheWord.Foreground = Brushes.White;
                        Counter_strike++;
                        Point(Counter_strike);
                        Counter = 5;
                    }
                    else if (i == 4 && theword != chosenWord)
                    {
                        string fiveword = theword;
                        txtEA.Content = fiveword[0];
                        txtEB.Content = fiveword[1];
                        txtEC.Content = fiveword[2];
                        txtED.Content = fiveword[3];
                        txtEE.Content = fiveword[4];

                        char EA = fiveword[0];
                        char EB = fiveword[1];
                        char EC = fiveword[2];
                        char ED = fiveword[3];
                        char EE = fiveword[4];

                        if (EA == aa)
                        {
                            txtEA.Background = Brushes.Green;
                        }
                        else if (EA == bb || EA == cc || EA == dd || EA == ee)
                        {
                            txtEA.Background = Brushes.Yellow;
                        }

                        if (EB == bb)
                        {
                            txtEB.Background = Brushes.Green;
                        }
                        else if (EB == aa || EB == cc || EB == dd || EB == ee)
                        {
                            txtEB.Background = Brushes.Yellow;
                        }

                        if (EC == cc)
                        {
                            txtEC.Background = Brushes.Green;
                        }
                        else if (EC == bb || EC == aa || EC == dd || EC == ee)
                        {
                            txtEC.Background = Brushes.Yellow;
                        }

                        if (ED == dd)
                        {
                            txtED.Background = Brushes.Green;
                        }
                        else if (ED == bb || ED == cc || ED == aa || ED == ee)
                        {
                            txtED.Background = Brushes.Yellow;
                        }

                        if (EE == ee)
                        {
                            txtEE.Background = Brushes.Green;
                        }
                        else if (EE == bb || EE == cc || EE == dd || EE == aa)
                        {
                            txtEE.Background = Brushes.Yellow;
                        }
                        theword = "";

                        TheWord.Foreground = Brushes.White;
                        Strike.Content = "Strike Lost";
                        Strike.Foreground = Brushes.Red;
                        Counter_strike = 0;


                    }
                    else if (i == 4 && theword == chosenWord)
                    {
                        string fiveword = theword;
                        txtEA.Content = fiveword[0];
                        txtEB.Content = fiveword[1];
                        txtEC.Content = fiveword[2];
                        txtED.Content = fiveword[3];
                        txtEE.Content = fiveword[4];

                        char EA = fiveword[0];
                        char EB = fiveword[1];
                        char EC = fiveword[2];
                        char ED = fiveword[3];
                        char EE = fiveword[4];

                        if (EA == aa)
                        {
                            txtEA.Background = Brushes.Green;
                        }

                        if (EB == bb)
                        {
                            txtEB.Background = Brushes.Green;
                        }


                        if (EC == cc)
                        {
                            txtEC.Background = Brushes.Green;
                        }


                        if (ED == dd)
                        {
                            txtED.Background = Brushes.Green;
                        }


                        if (EE == ee)
                        {
                            txtEE.Background = Brushes.Green;
                        }
                        theword = "";

                        TheWord.Foreground = Brushes.White;
                        Counter_strike++;
                        Point(Counter_strike);
                        Counter = 5;
                    }
                    else if (i == 5)
                    {
                        string FilePath = "LastScore.txt";
                        if (File.Exists(FilePath))
                        {
                            var FileContent = File.ReadAllText(FilePath);
                            if (FileContent.Length > 0)
                            {
                                
                                File.Delete(FilePath);
                            }
                            else
                            {

                                return;
                            }
                        }
                        File.WriteAllText(FilePath, Convert.ToString("Ostatni wynik: "+ PointCase));

                        Clearing();
                    }

                }

            }
        }
        public void Score(int quantity)
        {
            switch (quantity)
            {
               
                case (int)ThePointStrike.StrikeOne:
                    PointCase += 10;
                    break;
                case (int)ThePointStrike.StrikeTwo:
                    PointCase += 15;
                    break;
                case (int)ThePointStrike.StrikeThree:
                    PointCase += 20;
                    break;
                case (int)ThePointStrike.StrikeFour:
                    PointCase += 50;
                    break;
                case (int)ThePointStrike.StrikeFive:
                    PointCase += 75;
                    break;
                default:
                    PointCase = (int)Math.Round(PointCase * 1.1, 0);
                    break;
            }   
        }
        private void MainWindowLoaded(object sender, RoutedEventArgs e)
        {
            Word.Focus();
            Word.SelectAll();
        }
        private void Bt_send_word_Click(object sender, EventArgs e)
        {
            ReadFromFile readFromFile = new ReadFromFile();
            Word.Focus();
            Word.SelectAll();
            if (Counter == 0)
            {
                
                chosenWord = readFromFile.RandomWord();
                TheWord.Content = chosenWord;
            }
            Working();

        }

        private void Btn_NewGame_Click(object sender, RoutedEventArgs e)
        {
            Counter_strike = 0;
            Clearing();
            MessageBox.Show("Gratuluję!!! Twój wynik: " + PointCase);
            PointCase = 0;

        }
        
        private void Word_Text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (Word.Text.Length == 5)
                {
                    Bt_send_word_Click(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Słowo musi zawierać 5 liter!");
                }
                    
            }
        }
    }
}

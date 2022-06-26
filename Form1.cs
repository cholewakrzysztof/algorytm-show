using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorytmShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] selekcje =new string[] {"brak","co2","co3","co5","co6","co7","co8","co9","co10"};
            string[] rozmiary = new string[] { "100","625","900","1600","3600","6400","10000","22500","62500","90000" };
            for(int i=0; i<selekcje.Length;i++)
            {
                listBox_Selekcje.Items.Add(selekcje[i]);
            }
            listBox_Selekcje.SelectedItem = listBox_Selekcje.Items[0];
            for (int i = 0; i < rozmiary.Length; i++)
            {
                listBox_Rozmiar.Items.Add(rozmiary[i]);
            }
            listBox_Rozmiar.SelectedItem = listBox_Rozmiar.Items[0];
            textBox_iloscOsobnikow.Text = "20";
            textBox_count.Text = "2";
        }

        int[] tab;
        int count = 0;

        private void button_genData_Click(object sender, EventArgs e)
        {
            int ilosc = Convert.ToInt32(textBox_count.Text);
            Graphics g =pictureBox.CreateGraphics();
            g.Clear(Color.Black);
            if (ilosc > 170)
                ilosc = 170;
            tab = generujLosowaTabele(ilosc, 0, 50);
            count = 0;

            label_items.Text = "Ilość danych: " + ilosc.ToString();
            label_count.Text = "Ilość operacji: " + count.ToString();

            rysujSlupki(tab);
        }

        public int[] generujLosowaTabele(int size,int from, int to)
        {
            int[] tab = new int[size];
            Random r = new Random();
            for (int i = 0; i < size; i++)
                tab[i] = r.Next(from, to);

            return tab;
        }

        public void rysujSlupki(int[] tab)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            Pen pen = new Pen(Brushes.Yellow);

            int distance = pictureBox.Width / tab.Length;
            int height = pictureBox.Height / maxValue(tab);

            for (int i = 0; i < tab.Length; i++)
            {
                int space = i * distance;
                graphics.DrawLine(Pens.Black, space, 0, space, pictureBox.Height);
                graphics.DrawLine(pen,space, 0, space, (Math.Abs(tab[i]))*height);
            }
        }

        public int maxValue(int[] tab)
        {
            int max = tab[0];
            for (int i = 0; i < tab.Length; i++)
                if (max < tab[i])
                    max = tab[i];
            return max;
        }

        private void button_bubbleSort_Click(object sender, EventArgs e)
        {
            count = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab.Length-1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        int tmp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = tmp;
                        rysujSlupki(tab);
                        Thread.Sleep(100);
                    }
                    count++;
                }
            }
            label_count.Text = "Ilość operacji: " + count.ToString();
        }

        private void button_SelectionSort_Click(object sender, EventArgs e)
        {
            count = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                int min = tab[i];
                int idx = i;
                for (int j = i; j < tab.Length; j++)
                {
                    if (tab[j] < min)
                    {
                        min = tab[j];
                        idx = j;
                    }
                    count++;
                }
                tab[idx] = tab[i];
                tab[i] = min;
                rysujSlupki(tab);
                Thread.Sleep(100);
            }
            label_count.Text = "Ilość operacji: " + count.ToString();
        }

        private void button_QuickSort_Click(object sender, EventArgs e)
        {
            count = 0;

            quickSort(0,tab.Length-1);


            label_count.Text = "Ilość operacji: " + count.ToString();
        }

        public void quickSort(int left,int right)
        {
            int i = left;
            int j = right;

            int x = tab[(left + right) >> 1];
            do
            {
                while (tab[i]<x) 
                    i++;
                while (tab[j] > x) 
                    j--;

                if (i <= j)
                {
                    int tmp = tab[i];
                    tab[i] = tab[j];
                    tab[j] = tmp;
                    i++; j--;
                }
                Thread.Sleep(100);
                rysujSlupki(tab);
                count++;
            }
            while (i < j);

            if (left < j) quickSort(left, j);
            if (right > i) quickSort(i, right);
        }

        private void button_StalinSort_Click(object sender, EventArgs e)
        {
            count = 0;

            int min = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] < min)
                    tab[i] = 0;
                else
                    min = tab[i];
                Thread.Sleep(100);
                rysujSlupki(tab);
                count++;
            }

            label_count.Text = "Ilość operacji: " + count.ToString();
        }

        private void button_IdiotSort_Click(object sender, EventArgs e)
        {
            count = 0;

            glupieSort();

            label_count.Text = "Ilość operacji: " + count.ToString();
        }

        public void glupieSort()
        {
            for (int i = 0; i < tab.Length-1; i++)
            {
                if (tab[i] > tab[i + 1])
                {
                    int tmp = tab[i];
                    tab[i] = tab[i + 1];
                    tab[i + 1] = tmp;
                    i = 0;
                }
                count++;
                rysujSlupki(tab);
                Thread.Sleep(100);
            }

            for (int i = 0; i < tab.Length - 1; i++)
            {
                if (tab[i] > tab[i + 1])
                    glupieSort();
                count++;
            }

            rysujSlupki(tab);
        }

        private void button_zwariowaneSort_Click(object sender, EventArgs e)
        {
            count = 0;

            zwariowaneSort();

            label_count.Text = "Ilość operacji: " + count.ToString();
        }

        public void zwariowaneSort()
        {
            Random r = new Random();

            List<int> newTab = new List<int>();

            while (newTab.Count() != tab.Length)
            {
                int idx = r.Next(0, tab.Length);
                if (tab[idx] != -1)
                {
                    newTab.Add(tab[idx]);
                    tab[idx] = -1;
                }
                count++;
            }

            tab = newTab.ToArray();

            rysujSlupki(tab);
            Thread.Sleep(100);

            for (int i = 0; i < tab.Length-1; i++)
            {
                if (tab[i] > tab[i + 1])
                    zwariowaneSort();
            }
        }

        Powierzchnia powierzchnia;

        private void button_GenerujPowierzchnie_Click(object sender, EventArgs e)
        {
            int rozmiar = Convert.ToInt32(listBox_Rozmiar.SelectedItem.ToString());
            int iloscosobnikow = Convert.ToInt32(textBox_iloscOsobnikow.Text);
            Graphics g = pictureBox_powierzchnia.CreateGraphics();
            powierzchnia = new Powierzchnia(iloscosobnikow,rozmiar, g);
            powierzchnia.rysujPowierzchnie();
            powierzchnia.ustawSelekcje(listBox_Selekcje.SelectedItem.ToString());
        }

        private void button_Symuluj_Click(object sender, EventArgs e)
        {
            powierzchnia.Symuluj();
            label_WynikSymulacji.Text ="WYNIK SYMULACJI: "+ powierzchnia.ilosc_powt.ToString();
        }

    }

    public class Powierzchnia
    {
        int[] tabPowierzchnia;
        int iloscOsobnikow = 0;
        Graphics graphics;
        int maxLiczbaOsobnikow;
        public int ilosc_powt = 0;
        public Selekcja selekcja = Selekcja.BRAK;
        public Powierzchnia(int iloscOsobnikow,int maxLiczbaOsobnikow,Graphics graphics)
        {
            this.maxLiczbaOsobnikow = maxLiczbaOsobnikow;
            tabPowierzchnia = new int[maxLiczbaOsobnikow];
            this.iloscOsobnikow = iloscOsobnikow;
            this.graphics = graphics;
            ustawOsobnikiNaPowierzchni(iloscOsobnikow);
        }

        public void ustawOsobnikiNaPowierzchni(int ilosc)
        {
            wyczyscPowierzchnie();
            iloscOsobnikow = ilosc;
            if (ilosc > maxLiczbaOsobnikow)
                ilosc = maxLiczbaOsobnikow;

            Random r = new Random();
            while (ilosc > 0)
            {
                int idx = r.Next(0, tabPowierzchnia.Length);
                if (tabPowierzchnia[idx] == 0)
                {
                    tabPowierzchnia[idx] = 1;
                    ilosc--;
                }
            }
        }

        public void wyczyscPowierzchnie()
        {
            iloscOsobnikow = 0;
            for (int i = 0; i < tabPowierzchnia.Length; i++)
                tabPowierzchnia[i] = 0;
        }

        public int ileOsobnikowDodac()
        {
            int dodac = 0;
            for (int i = 0; i < tabPowierzchnia.Length; i+=2)
                if (tabPowierzchnia[i] + tabPowierzchnia[i + 1] == 2)
                    dodac++;
            return dodac;
        }

        public void dokonajSelekcji()
        {
            int ileZabic = 0;
            if (selekcja == Selekcja.BRAK)
                return;
            if (selekcja == Selekcja.CO_DRUGI)
                ileZabic =  Convert.ToInt32(Math.Floor(Convert.ToDecimal(iloscOsobnikow / 2)));
            if (selekcja == Selekcja.CO_TRZECI)
                ileZabic =  Convert.ToInt32(Math.Floor(Convert.ToDecimal(iloscOsobnikow / 3)));
            if (selekcja == Selekcja.CO_PIATY)
                ileZabic =  Convert.ToInt32(Math.Floor(Convert.ToDecimal(iloscOsobnikow / 5)));
            if (selekcja == Selekcja.CO_SZOSTY)
                ileZabic =  Convert.ToInt32(Math.Floor(Convert.ToDecimal(iloscOsobnikow / 6)));
            if (selekcja == Selekcja.CO_SIODMY)
                ileZabic =  Convert.ToInt32(Math.Floor(Convert.ToDecimal(iloscOsobnikow / 7)));
            if (selekcja == Selekcja.CO_OSMY)
                ileZabic = Convert.ToInt32(Math.Floor(Convert.ToDecimal(iloscOsobnikow / 8)));
            if (selekcja == Selekcja.CO_DZIEWIATY)
                ileZabic = Convert.ToInt32(Math.Floor(Convert.ToDecimal(iloscOsobnikow / 9)));
            if (selekcja == Selekcja.CO_DZIESIATY)
                ileZabic =  Convert.ToInt32(Math.Floor(Convert.ToDecimal(iloscOsobnikow / 10)));

            iloscOsobnikow = iloscOsobnikow - ileZabic;

        }

        public void Symuluj()
        {
            while(czyWykonacSymulacje()) 
            {
                ilosc_powt++;
                int dzieci = ileOsobnikowDodac();
                ustawOsobnikiNaPowierzchni(iloscOsobnikow + dzieci);
                dokonajSelekcji();
                ustawOsobnikiNaPowierzchni(iloscOsobnikow);
                rysujPowierzchnie();
                Thread.Sleep(100);
            }
        }

        public bool czyWykonacSymulacje()
        {
            if (iloscOsobnikow >= maxLiczbaOsobnikow)
                return false;
            if (iloscOsobnikow <= 1)
                return false;

            if (iloscOsobnikow <= 3 && selekcja == Selekcja.CO_TRZECI)
                return false;
            if (iloscOsobnikow <= 5 && selekcja == Selekcja.CO_PIATY)
                return false;
            if (iloscOsobnikow <= 6 && selekcja == Selekcja.CO_SZOSTY)
                return false;
            if (iloscOsobnikow <= 7 && selekcja == Selekcja.CO_SIODMY)
                return false;
            if (iloscOsobnikow <= 8 && selekcja == Selekcja.CO_OSMY)
                return false;
            if (iloscOsobnikow <= 9 && selekcja == Selekcja.CO_DZIEWIATY)
               return false;
            if (iloscOsobnikow <= 10 && selekcja == Selekcja.CO_DZIESIATY)
                return false;

            return true;
        }

        public void rysujPowierzchnie()
        {
            graphics.Clear(Color.Black);
            for (int i = 0; i < tabPowierzchnia.Length; i++)
            {
                if (tabPowierzchnia[i] > 0)
                {
                    int wRzedzie = Convert.ToInt32(Math.Sqrt(maxLiczbaOsobnikow));
                    int x = i % wRzedzie;
                    int y = Convert.ToInt32(Math.Floor(Convert.ToDecimal(i / wRzedzie)));
                    graphics.FillRectangle(Brushes.White, x, y, 1, 1);
                }
            }
        }

        public void ustawSelekcje(string rodzaj) 
        {
            if (rodzaj == "brak")
                selekcja = Selekcja.BRAK;
            if (rodzaj == "co2")
                selekcja = Selekcja.CO_DRUGI;
            if (rodzaj == "co3")
                selekcja = Selekcja.CO_TRZECI;
            if (rodzaj == "co5")
                selekcja = Selekcja.CO_PIATY;
            if (rodzaj == "co6")
                selekcja = Selekcja.CO_SZOSTY;
            if (rodzaj == "co7")
                selekcja = Selekcja.CO_SIODMY;
            if (rodzaj == "co8")
                selekcja = Selekcja.CO_OSMY;
            if (rodzaj == "co9")
                selekcja = Selekcja.CO_DZIEWIATY;
            if (rodzaj == "co10")
                selekcja = Selekcja.CO_DZIESIATY;
        }
    }

    public enum Selekcja
    {
        BRAK,
        CO_DRUGI,
        CO_TRZECI,
        CO_PIATY,
        CO_SZOSTY,
        CO_SIODMY,
        CO_OSMY,
        CO_DZIEWIATY,
        CO_DZIESIATY
    }
}

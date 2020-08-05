using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Financial_App
{
    public partial class CashWatch : Form
    {
        public CashWatch()
        {
            InitializeComponent();
            ListRead(); //Zobrazení dat pro seznam
            Chart(); //Zobrazení dat pro graf
        }

        int total; //Celková částka
        int dayPlus = 0; //Součet za denní příjmy - Pro soubor
        int dayMinus = 0; //Součet za denní výdaje - Pro soubor
        int dayPlusTotal = 0; //Součet za denní příjmy - Sečtený výsledek
        int dayMinusTotal = 0; //Součet za denní výdaje - Sečtený výsledek

        string lineText; //Text pro výpis listu
        string path; //Cesta do správné složky
        string plusLine; //Řádek s cenou
        string minusLine; //Řádek s cenou
        string date; //Řádek s datem
        string lastDate = ""; //Datum posledního souboru pro kontrolu
        string plusFinal; //Součet za den
        string minusFinal; //Součet za den
        string word; //String pro kontrolu délky slova

        public void CheckedButtons()
        {
            if (incomeButt.Checked) path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MOVE_ME\income\"; //Plusová cesta
            if (outcomeButt.Checked) path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MOVE_ME\outcome\"; //Mínusová cesta
        }
            
        public void ListRead()
        {
            listTxt.Font = new Font(FontFamily.GenericMonospace, 9); //Font se stejně velkými znaky
            lineText = null;
            CheckedButtons(); //Získání cesty
            string[] filePaths = Directory.GetFiles(path); //Zapsání plusových souborů do pole
            for (int i = filePaths.Length - 1; i >= 0; i--) //Cyklus pro otevření každého souboru
            {
                using (StreamReader inputFile = new StreamReader(filePaths[i])) //Otevře každý soubor
                {
                    for (int o = 0; o < 4; o++) //Vytvoření mezer v listu
                    {
                        //word = null;
                        word = inputFile.ReadLine();
                        lineText += word;
                        while (o == 3) goto NewLine;
                        for (int e = 0; e < 13 - word.Length; e++) lineText += " ";
                    }
                }
            NewLine:
                lineText += "\r\n"; //Nový řádek pro další soubor
            }
            listTxt.Text = lineText; //Zapsání do text boxu
        }

        public void Chart()
        {
            total = 0;
            string[] plusFilePaths = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MOVE_ME\income\"); //Zapsání plusových souborů do pole
            for (int i = 0; i < plusFilePaths.Length; i++) //Cyklus pro otevření každého souboru
            {
                using (StreamReader inputFile = new StreamReader(plusFilePaths[i])) //Otevře každý soubor
                {
                    for (int o = 0; o < 2; o++) plusLine = inputFile.ReadLine(); //Přečte 2. řádek s cenou
                    for (int u = 0; u < 2; u++) date = inputFile.ReadLine();//Přečte 4. řádek s datem
                }
                if (lastDate == "") lastDate = date;//Přiřazení data pro porovnání
                dayPlus = Convert.ToInt32(plusLine); //Převede cenu do int
                total += dayPlus; //Přičte číslo k celku
                if (date == lastDate) dayPlusTotal += dayPlus; //Pokud jsou stejná data, přičte se cena do dne

                if (date != lastDate)
                {
                    plusFinal = Convert.ToString(dayPlusTotal);
                    chart.Series["Income"].Points.AddXY(lastDate, plusFinal); //Zapsání součtu předešlých souborů
                    dayPlusTotal = 0;
                    dayPlusTotal += dayPlus;
                }
                lastDate = date; //přepsání data pro další soubor
            }
            plusFinal = Convert.ToString(dayPlusTotal);
            chart.Series["Income"].Points.AddXY(lastDate, plusFinal);
            lastDate = "";

            string[] minusFilePaths = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MOVE_ME\outcome\"); //Zapsání mínusových souborů do pole
            for (int i = 0; i < minusFilePaths.Length; i++) //Cyklus pro otevření každého souboru
            {
                using (StreamReader inputFile = new StreamReader(minusFilePaths[i])) //Otevře každý soubor
                {
                    for (int o = 0; o < 2; o++) minusLine = inputFile.ReadLine(); //Přečte 2. řádek s cenou
                    for (int u = 0; u < 2; u++) date = inputFile.ReadLine(); //Přečte 4. řádek s datem
                }
                if (lastDate == "") lastDate = date; //Přiřazení data pro porovnání
                dayMinus = Convert.ToInt32(minusLine); //Převede cenu do int
                total -= dayMinus; //Odečte číslo od celku
                if (date == lastDate) dayMinusTotal += dayMinus; //Pokud jsou stejná data, přičte se cena do dne

                if (date != lastDate)
                {
                    minusFinal = Convert.ToString(dayMinusTotal);
                    chart.Series["Outcome"].Points.AddXY(lastDate, minusFinal); //Zapsání součtu předešlých souborů
                    dayMinusTotal = 0;
                    dayMinusTotal += dayMinus;
                }
                lastDate = date; //přepsání data pro další soubor
            }
            minusFinal = Convert.ToString(dayMinusTotal);
            chart.Series["Outcome"].Points.AddXY(lastDate, minusFinal);
            lastDate = "";

            sumLabel.Text = Convert.ToString(total) + ",-"; //Vypíše celkové číslo do labelu
        }

        private void PlusButt_Click(object sender, EventArgs e)
        {
            NewItem newItemForm = new NewItem(this);
            newItemForm.Show();
            this.Hide();
        }

        private void IncomeButt_CheckedChanged(object sender, EventArgs e)
        {
            ListRead();
        }

        private void OutcomeButt_CheckedChanged(object sender, EventArgs e)
        {
            ListRead();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            ListRead(); //Zobrazení dat pro seznam
            Chart(); //Zobrazení dat pro graf
        }
    }
}
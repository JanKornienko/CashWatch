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
    public partial class NewItem : Form
    {
        public NewItem(Form _form)
        {
            InitializeComponent();
            this.Location = _form.Location; //Parametr pro vykreslení okna
            ComboCategory(); //Načtení dat do combo boxu
        }

        int sum = 0; //Uložení ceny
        string name = ""; //Jméno transakce
        string date; //Datum uložení
        string category; //Kategorie
        string path; //Cesta pro uložení souborů
        string pathCat = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MOVE_ME\categories.txt";

        public void Operations()
        {
            try { sum = Convert.ToInt32(sumTxt.Text); } //Zkontrolování a následné zkonvertování čísla zadaného v text boxu pro cenu
            catch (Exception) { sum = 0; MessageBox.Show("Zadali jste špatnou hodnotu", "Chyba"); } //Nastavení ceny na 0 a zobrazení chybového okna
            date = DateTime.Now.ToString("dd.MM."); //Uložení data pro třídění
            name = nameTxt.Text; //Uložení jména transakce
            category = categoryBox.Text; //Uložení kategorie

            if (nameTxt.Text == "") name = "No Name"; //Pokud není zadané jméno, přiřadí se
            if (incomeButt.Checked) path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MOVE_ME\income\"; //určení cesty pro uložení, radio button
            if (outcomeButt.Checked) path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MOVE_ME\outcome\"; //určení cesty pro uložení, radio button
        }

        public void ComboCategory()
        {
            int lineCount = File.ReadAllLines(pathCat).Count(); //Spočítá počet řádků v souboru s kategoriemi
            categoryBox.Items.Clear(); //Vyčištění combo boxu
            //Postupný zápis do combo boxu
            FileStream fsCatRead = new FileStream(pathCat, FileMode.Open);
            StreamReader read = new StreamReader(fsCatRead);
            for (int i = 0; i < lineCount; i++) //Přečte každý řádek souboru
            {
                string catItems = read.ReadLine();
                categoryBox.Items.Add(catItems); //Přidání řádku do combo boxu
            }
            read.Close();
            fsCatRead.Close();
            try { categoryBox.SelectedIndex = 0; } //Zvolí první item jako defaultní
            catch (Exception) { categoryBox.Text = ""; }
        }

        public void TransactionFile()
        {
            Operations(); //Zavolání metody pro získání cesty a dat pro zápis
            string nameOfFile = path + DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss") + ".txt"; //Vytvoření jména pro soubour
            //Zápis dat do souboru
            FileStream fsFile = new FileStream(nameOfFile, FileMode.Create);
            StreamWriter write = new StreamWriter(fsFile);

            write.WriteLine(name); //Jméno
            write.WriteLine(sum); //Částka
            write.WriteLine(category); //Kategorie
            write.WriteLine(date); //Datum

            write.Close();
            fsFile.Close();
        }
        
        private void plusButt_Click(object sender, EventArgs e) //Přidávání hodnoty pomocí tlačítek
        {
            Operations(); //Získá zadanou cenu
            sum += 100; //Přičte k celku 100
            sumTxt.Text = Convert.ToString(sum); //Zobrazí v text boxu
        }

        private void minusButt_Click(object sender, EventArgs e) //Snižování hodnoty pomocí tlačítek
        {
            Operations(); //Získá zadanou cenu
            sum -= 100; //Odečte od celku 100
            if (sum < 0) sum = 0; //Zkontroluje zda hodnota nejde do mínusu
            sumTxt.Text = Convert.ToString(sum); //Zobrazí v text boxu
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            TransactionFile(); //Metoda pro zapsání do souboru
            CashWatch financialApp = new CashWatch();
            financialApp.Show(); //Zobrazení meny
            this.Close();
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            CashWatch financialApp = new CashWatch();
            financialApp.Show(); //Zobrazení meny
            this.Close();
        }

        private void catButt_Click(object sender, EventArgs e)
        {
            Categories categoriesForm = new Categories();
            categoriesForm.Show();
            this.Hide();
        }

        private void NewItem_Paint(object sender, PaintEventArgs e)
        {
            //Vykreslení okraje k txtBoxům
            Pen p = new Pen(Color.Blue);
            Graphics g = e.Graphics;
            int offset = 3;
            g.DrawRectangle(p, new Rectangle(nameTxt.Location.X - offset, nameTxt.Location.Y - offset, nameTxt.Width + offset, nameTxt.Height + offset));
            g.DrawRectangle(p, new Rectangle(sumTxt.Location.X - offset, sumTxt.Location.Y - offset, sumTxt.Width + offset, sumTxt.Height + offset));
        }
    }
}
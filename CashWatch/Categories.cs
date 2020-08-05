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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        string pathCat = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MOVE_ME\categories.txt";

        private void newButt_Click(object sender, EventArgs e)
        {
            NewItem newItem = new NewItem(this); //Vytvoření instance pro třídu NewItem
            //Uložení zadaného textu do souboru s kategoriemi
            using (StreamWriter write = File.AppendText(pathCat)) { write.WriteLine(catTxt.Text); }

            newItem.ComboCategory(); //Načtení metody v třídě NewItem, načte soubor do combo boxu
            newItem.Show(); //Zobrazení třídy
            this.Close(); //Ukončení této třídy
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            NewItem newItem = new NewItem(this); //Vytvoření instance pro třídu NewItem
            newItem.Show(); //Zobrazení třídy
            this.Close(); //Ukončení této třídy
        }

        private void Categories_Paint(object sender, PaintEventArgs e)
        {
            //Vykreslení okraje k txtBoxům
            Pen p = new Pen(Color.Blue);
            Graphics g = e.Graphics;
            int offset = 3;
            g.DrawRectangle(p, new Rectangle(catTxt.Location.X - offset, catTxt.Location.Y - offset, catTxt.Width + offset, catTxt.Height + offset));
        }
    }
}
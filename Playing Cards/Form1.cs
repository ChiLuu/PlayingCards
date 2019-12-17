using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playing_Cards
{
/*
 * char[] suitChar = {'\u2663', '\u2666', '\u2665', '\u2660']
                        club      diamond   hearts    spade
 
         */
    public partial class Form1 : Form
    {
        Deck deck = new Deck();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayDeck();
        }

        private void DisplayDeck()
        {
            foreach(Card card in deck.getDeck)
            {
                lstDeck.Items.Add(card); //implicit ToString method
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            deck.Shuffle();
            lstDeck.Items.Clear();
            DisplayDeck();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            deck = new Deck();
            lstDeck.Items.Clear();
            DisplayDeck();
        }
    }
}

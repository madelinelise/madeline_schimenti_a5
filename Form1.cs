using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace madeline_schimenti_a5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayingCards.Deck myDeck = new PlayingCards.Deck();

            PlayingCards.Card topOfDeck = new PlayingCards.Card(PlayingCards.CardSuits.Spade,
            PlayingCards.CardValues.Deuce);

            myDeck.Cards.Add(topOfDeck);

            PlayingCards.Card bottomOfDeck = new PlayingCards.Card(PlayingCards.CardSuits.Heart,
            PlayingCards.CardValues.Queen);

            myDeck.Cards.Add(bottomOfDeck);




            pictureBox1.Image = myDeck.Cards[1].FaceImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

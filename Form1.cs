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


            //pictureBox1.Image = myDeck.Cards[1].FaceImage;

            PictureBox pictureBoxCard = new PictureBox();

            pictureBoxCard.Image = myDeck.Cards[0].FaceImage;
            pictureBoxCard.Left = 30;
            pictureBoxCard.Top = 78;
            pictureBoxCard.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxCard.Parent = this;
            pictureBoxCard.Visible = true;


            PictureBox pictureBoxCard2 = new PictureBox();

            pictureBoxCard2.Image = myDeck.Cards[1].FaceImage;
            pictureBoxCard2.Left = 50;
            pictureBoxCard2.Top = 78;
            pictureBoxCard2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxCard2.Parent = this;
            pictureBoxCard2.Visible = true;
            



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

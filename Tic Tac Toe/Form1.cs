using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe

 
{
    public partial class Created : Form
    {
        bool turn = true; //true = X turn ; false = O turn

        int turn_count = 0;
        public Created()
        {
            InitializeComponent();
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Islam Tariq in 1st semster junoir programming contest (2015)","Tic Tac Toe About");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Created_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn_count++;
            turn = !turn;
            b.Enabled = false;

            winnercheck();

        }

        private void winnercheck()
        {
            bool therewinner = false;
            // Horizental winner check

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                therewinner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                therewinner = true;
            else if ((C1.Text == A2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                therewinner = true;

            // Vertical winner check

            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                therewinner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                therewinner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                therewinner = true;

            // Diagnol Winner check

            // Horizental winner check

            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                therewinner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                therewinner = true;


            if (therewinner)
            {

                End();

                string winner = "";
                if (turn)

                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " Win", "Congratulations");

            }

            else
            {
                if (turn_count == 9) 
                MessageBox.Show("Draw", "Ooh");
            }

        }// winner check


        
        private void End()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            } catch { }

        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

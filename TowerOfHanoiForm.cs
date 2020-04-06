using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerOfHanoi
{
    public partial class TowerOfHanoiForm : Form
    {
        /// <summary>
        /// The Tower instance
        /// </summary>
        private Tower Towers;
        /// <summary>
        /// Initializes a new instance of the <see cref="TowerOfHanoiForm"/> class.
        /// </summary>
        public TowerOfHanoiForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Displays the towers in each of the text box pole representations.
        /// </summary>
        private void DisplayTowers()
        {
            TowerTextBox0.Text = Towers.GetPole(0).ToString();
            TowerTextBox1.Text = Towers.GetPole(1).ToString();
            TowerTextBox2.Text = Towers.GetPole(2).ToString();
        }
        /// <summary>
        /// Handles the TextChanged event of the DiskNumInputBox control to only allow integer inputs.
        /// if non-integer is typed then text box changes back ground to red until only integers
        /// populate the text box
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DiskNumInputBox_TextChanged(object sender, EventArgs e)
        {
            List<Char> chars = new List<Char>(DiskNumInputBox.Text.ToCharArray());
            foreach (Char c in chars)
            {
                if (!Char.IsDigit(c))
                {
                    DiskNumInputBox.BackColor = Color.Red;
                    return;
                }
            }
            DiskNumInputBox.ResetBackColor();
            int NumDisks = int.Parse(DiskNumInputBox.Text);
        }
        /// <summary>
        /// Handles the Click event of the StartButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            Start();
        }
        /// <summary>
        /// Updates the current move status label.
        /// </summary>
        private void UpdateCurrentMove()
        {
            CurrentMoveLabel.Text = "Current Move: " + Towers.MovesDone;
        }

        private void NextMoveButton_Click(object sender, EventArgs e)
        {
            NextMove();
        }

        private void Start()
        {
            if (DiskNumInputBox.Equals(null) || DiskNumInputBox.BackColor == Color.Red)
                return;
            Towers = new Tower(int.Parse(DiskNumInputBox.Text));
            TotalMovesLabel.Text = "Total Number of Moves: "+Towers.MovesLeft();
            UpdateCurrentMove();
            NextMoveButton.Enabled = true;
            StartButton.Enabled = false;
            DisplayTowers();
        }

        private void NextMove()
        {
            Towers.NextMove();
            DisplayTowers();
            UpdateCurrentMove();
        }

        private void StartToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void NextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NextMove();
        }

        private void ResetToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            
        }

        private void QuitToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            new AboutTOH().Show();
        }
    }
}

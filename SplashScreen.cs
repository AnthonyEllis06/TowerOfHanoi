// //////////////////////////////////////////////////////////////////////////////////////
// Project:			TowerOfHanoi
// File Name: 		SplashScreen.cs
// Description: 	Splash Screen Command Class
// Course:			CSCI 2210-001 - Data Structures
// Author:			Anthony Ellis, ellisah@etsu.edu, East Tennessee State University
// Created:			04-05-2020
//
// ///////////////////////////////////////////////////////////////////////////////////////
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
    /// <summary>
    /// Partial Splash Screen Method Class.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class SplashScreen : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplashScreen"/> class.
        /// That dismisses when the timer hits 5 seconds.
        /// </summary>
        public SplashScreen()
        {
            InitializeComponent();
            DismissTimer.Start();
        }
        /// <summary>
        /// Handles the Tick event of the DismissTimer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DismissTimer_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}

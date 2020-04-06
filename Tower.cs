// //////////////////////////////////////////////////////////////////////////////////////
// Project:			TowerOfHanoi
// File Name: 		Tower.cs
// Description: 	Tower Class to Build and solve the tower of hanoi
// Course:			CSCI 2210-001 - Data Structures
// Author:			Anthony Ellis, ellisah@etsu.edu, East Tennessee State University
// Created:			04-05-2020
//
// ///////////////////////////////////////////////////////////////////////////////////////
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    /// <summary>
    /// Class Tower to build poles and solve the tower.
    /// </summary>
    class Tower
    {
        /// <summary>
        /// The Constant number of poles
        /// </summary>
        public const int NumberOfPoles = 3;
        /// <summary>
        /// The list of poles
        /// </summary>
        private List<Pole> Poles;
        /// <summary>
        /// The number of moves done
        /// </summary>
        public int MovesDone;
        /// <summary>
        /// Gets or sets the total number of disks in the tower
        /// </summary>
        /// <value>The number of disks in the tower</value>
        public int NumOfDisks { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Tower"/> class.
        /// using the default constructor with all poles empty.
        /// </summary>
        public Tower()
        {
            Poles = new List<Pole>();
            Poles.Add(new Pole());
            Poles.Add(new Pole());
            Poles.Add(new Pole());
            MovesDone = 0;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Tower"/> class.
        /// using the parameterized constructor to define number of disks in tower.
        /// </summary>
        /// <param name="NumberDisks">The number of disks to put in tower.</param>
        public Tower(int NumberDisks)
        {
            Poles = new List<Pole>();
            NumOfDisks = NumberDisks;
            Poles.Add(new Pole());
            Poles.Add(new Pole());
            Poles.Add(new Pole());
            Poles[0].SetUpStart(NumOfDisks);
            MovesDone = 0;
        }
        /// <summary>
        /// Boolean method to see if there are an even number of disks in the tower
        /// </summary>
        /// <returns><c>true</c> if even number of disks, <c>false</c> if odd number of disks</returns>
        public bool DisksEven()
        {
            if (NumOfDisks % 2 == 0)
                return true;
            else
                return true;
        }
        /// <summary>
        /// gets the total number of moves to solve the tower
        /// </summary>
        /// <returns>int representation of moves left</returns>
        public int MovesLeft()
        {
            return Convert.ToInt32(Math.Pow(2, NumOfDisks) - 1);
        }
        /// <summary>
        /// Gets the pole in the tower using an index
        /// </summary>
        /// <param name="index">The index of the tower that is to be returned.</param>
        /// <returns>the pole at the index specified</returns>
        public Pole GetPole(int index)
        {
            if (index != 0 && index != 1 && index != 2)
                return null;
            return Poles[index];
        }

        private Pole GetRight(Pole curr)
        {
            int index = Poles.IndexOf(curr);
            if (index == 2)
                index = 0;
            else
                index++;
            return Poles[index];
        }

        private Pole GetLeft(Pole curr)
        {
            int index = Poles.IndexOf(curr);
            if (index == 0)
                index = 2;
            else
                index--;
            return Poles[index];
        }
        private bool MoveRight(Pole Current)
        {
            Pole right = GetRight(Current);
            Pole rightRight = GetRight(right);
            if (isMoveValid(Current, right))
            {
                right.Push(Current.Pop());
                return true;
            }
            else if (isMoveValid(Current, rightRight))
            {
                rightRight.Push(Current.Pop());
                return true;
            }

            return false;
        }

        private bool MoveLeft(Pole Current)
        {
            Pole left = GetLeft(Current);
            Pole leftLeft = GetLeft(left);
            if (isMoveValid(Current, leftLeft))
            {
                leftLeft.Push(Current.Pop());
                return true;
            }
            else if (isMoveValid(Current, left))
            {
                left.Push(Current.Pop());
                return true;
            }

            return false;
        }
        /// <summary>
        /// Does the next move to solve the tower
        /// </summary>
        public void NextMove()
        {
            if (DisksEven())
            {
                if (MoveRight(Poles[0]))
                    MovesDone++;
                else if (MoveRight(Poles[1]))
                    MovesDone++;
                else if (MoveRight(Poles[2]))
                    MovesDone++;
                else
                    Console.WriteLine("No More Moves");
                        
            }
            else
            {
                if (MoveLeft(Poles[0]))
                    MovesDone++;
                else if (MoveLeft(Poles[2]))
                    MovesDone++;
                else if (MoveLeft(Poles[1]))
                    MovesDone++;
                else
                    Console.WriteLine("No More Moves");
            }
             
        }
        /// <summary>
        /// Determines whether if a move is valid.
        /// </summary>
        /// <param name="from">the pole the disk will come from</param>
        /// <param name="to">the pole the disk will go to</param>
        /// <returns><c>true</c> if the move is valid; otherwise, <c>false</c>.</returns>
        public bool isMoveValid(Pole from, Pole to)
        {
            if (to.CountOfDisks == 0)
                return true;
            if (from.CountOfDisks == 0)
                return false;
            if (from.Peek().Size < to.Peek().Size)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// Made to visualize the tower in the console
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents the current state of all 3 poles.</returns>
        public override string ToString()
        {
            return Poles[0].ToString() + "\n" + Poles[1].ToString() + "\n" + Poles[2].ToString();
        }
    }
}

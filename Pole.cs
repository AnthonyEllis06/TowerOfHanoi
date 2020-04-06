// //////////////////////////////////////////////////////////////////////////////////////
// Project:			TowerOfHanoi
// File Name: 		Pole.cs
// Description: 	Pole class to define and create poles with disks and start game
// Course:			CSCI 2210-001 - Data Structures
// Author:			Anthony Ellis, ellisah@etsu.edu, East Tennessee State University
// Created:			04-05-2020
//
// ///////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Stack;

namespace TowerOfHanoi
{

    /// <summary>
    /// Pole Class to create and manage disks on pole using stack methods
    /// </summary>
    class Pole
    {
        /// <summary>
        /// private stack of disks used to manage the disks on the stack
        /// </summary>
        private Stack<Disk> StackOfDisks;
        /// <summary>
        /// property to keep count of disks on the pole.
        /// </summary>
        /// <value>the number of disks on the pole</value>
        public int CountOfDisks { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pole"/> class with 0 disks
        /// </summary>
        public Pole()
        {
            StackOfDisks = new Stack<Disk>();
            CountOfDisks = 0;
        }
        /// <summary>
        /// pushes a disk onto the stack
        /// </summary>
        /// <param name="disk">The disk.</param>
        public void Push(Disk disk)
        {
            CountOfDisks++;
            StackOfDisks.Push(disk);
        }
        /// <summary>
        /// pops a disk off the stack
        /// </summary>
        /// <returns>the disk that was popped off</returns>
        public Disk Pop()
        {
            if (CountOfDisks == 0)
                return null;
            CountOfDisks--;
            return StackOfDisks.Pop();
        }
        /// <summary>
        /// Peeks at the stack to see the top most disk on the stack
        /// </summary>
        /// <returns>a copy of the disk on the top of the stack</returns>
        public Disk Peek()
        {
            if (CountOfDisks == 0)
                return new Disk(0);
            return StackOfDisks.Peek();
        }
        /// <summary>
        /// Creates a String representation of the pole with disks on it.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents the pole and the disks on it.</returns>
        public override string ToString()
        {
            if (CountOfDisks == 0)
                return "|";
            String PoleString = "|"+Environment.NewLine;
            Stack<Disk> temp = new Stack<Disk>();
            Disk current = StackOfDisks.Peek();
            while (StackOfDisks.Count>0 && StackOfDisks.Peek() != null)
            {
                current = StackOfDisks.Pop();
                PoleString = PoleString + current.ToString() +Environment.NewLine;
                temp.Push(current);
            }

            while (temp.Count != 0)
            {
                StackOfDisks.Push(temp.Pop());
            }
            return PoleString;
        }
        /// <summary>
        /// Sets up the first pole to be able to start the game
        /// </summary>
        /// <param name="NumberOfDisks">The number of disks on the pole to play the game with</param>
        public void SetUpStart(int NumberOfDisks)
        {
            for (int i = NumberOfDisks; i >= 1; i--)
            {
                Push(new Disk(i));
            }
        }
    }
}

// //////////////////////////////////////////////////////////////////////////////////////
// Project:			TowerOfHanoi
// File Name: 		Disk.cs
// Description: 	Disk Class to create and represent Disk Objects
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

namespace TowerOfHanoi
{
    /// <summary>
    /// Disk Class to define and create disks.
    /// </summary>
    class Disk
    {
        public int Size { get; set; }
        /// <summary>
        /// Default Constructor, sets size to 1.
        /// </summary>
        public Disk()
        {
            Size = 1;
        }
        /// <summary>
        /// parameterized constructor to create new disk
        /// </summary>
        /// <param name="sizeOfDisk">size of the new disk</param>
        public Disk(int sizeOfDisk)
        {
            Size = sizeOfDisk;
        }
        /// <summary>
        /// Copy constructor to create new disk of same size
        /// </summary>
        /// <param name="disk">Disk to copy</param>
        public Disk(Disk disk)
        {
            Size = disk.Size;
        }
        /// <summary>
        /// To String method to get string definition of Disk
        /// </summary>
        /// <returns>the string definition of disks, if disk is size zero then it returns null</returns>
        public override string ToString()
        {
            
            if (Size == 0)
                return null;
            String disk = "|"+ Size;
            for (int i = 1; i <= Size; i++)
                disk = disk + "_";
            disk = disk + "|";
            return disk;
        }
    }
}

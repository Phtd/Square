using System;
using System.Collections.Generic;
using System.Text;


namespace Square
{
    public class Square
    {
        private float a; // Makes a variable float named a
        private float b; // Makes a variable float named b
        private float c; // Makes a variable float named c
        public float A { get { return a; } set { a = value; } } // A get and set for the private variable ¨a¨, makes it possible to change its value later on
        public float B { get { return b; } set { b = value; } } // A get and set for the private variable ¨b¨, makes it possible to change its value later on
        public float C { get { return c; } set { c = value; } } // A get and set for the private variable ¨c¨, makes it possible to change its value later on

        public Square(float a, float b, float c) // The Constructor that declares the different variables
        {
            A = a; // Declares that A is a
            B = b; // Declares that B is b
            C = c; // Declares that C is c
        }
        /// <summary>
        /// A function that is named Omkreds, which will return a value based on its contents
        /// </summary>
        /// <returns></returns>
        public float Omkreds() 
        {
            return A * 4; // Gives the formulae that will be calculated when we ask for Omkreds
        }
        /// <summary>
        /// A Function that is named Area, which will return a value base on its contents
        /// </summary>
        /// <returns></returns>
        public float Area() 
        {
            return b * c; // Gives the formulae that will be calculated when we ask for Area
        }

    }
}

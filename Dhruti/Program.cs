﻿using System;

namespace Dhruti
{

    /**
   * This class is the driver class for our program 
   * 
   * @class Program
   */
    public class Program
	{
        /**
       * The main method for our driver class Program
       * 
       * @method main
       * @param {string[]} args
       */
        public static void Main ()
		{
			Hero hero = new Hero ("Dhruti");// Object for Hero is created and implemented
			hero.Show ();// Show method of Hero is called
			hero.Fight ();// Fight method of Hero is called
		}
	}
}
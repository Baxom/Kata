// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace TDD_Katas_project.FizzBuzzKata
{
    public class FizzBuzz
    {
        #region Public Methods
        
        public static readonly IEnumerable<Diviseur> Diviseurs = new List<Diviseur>() {
            new Diviseur(3, "Fizz"),
            new Diviseur(5, "Buzz"),
            new Diviseur(7, "Qix")
        };

        public FizzBuzz()
        {
            
        }

        public string PrintFizzBuzz(int number)
        {
            //multiple 3 => Fizz
            // multiple 5 => Buzz
            // pas multiple => chaine du nombre
            // Multiple 3 et 5 FizzBuzz
            var result = string.Empty;

            foreach(var diviseur in Diviseurs) { 
}
            if(isMultiple(number, 3))
            {
                result += "Fizz";
            }

            if (isMultiple(number, 5))
            {
                result += "Buzz";
            }

            if (isMultiple(number, 7))
            {
                result += "Qix";
            }
            if (string.IsNullOrEmpty(result))
                result= number.ToString();
            return result;
        }

        private static bool isMultiple(int number, int diviseur)
        {

            return (number % diviseur == 0);
        }
        #endregion
        
    }

    public class Diviseur
    {
        private readonly int _number;

        public int Nombre { get { return _number; } }
        public string PhraseRetour { get;  set; }

        public Diviseur(int n, string p)
        {
            _number = n;
            PhraseRetour = p;
        }
    }
}

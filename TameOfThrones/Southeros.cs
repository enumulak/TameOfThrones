﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TameOfThrones
{
    public sealed class Southeros
    {
        //Static method to provide access to the Singleton Instance of this class
        public static Southeros Instance { get; } = new Southeros();

        //Public Methods
        public void BeginShanConquest(string inputFile)
        {
            #region REQUIRED VARIABLES

            //For this scenario, we initialize the Space Kingdom as the Conqueror
            var conqueror = new Kingdom("Space", "Gorilla");

            //Then we initialize a list of remaining kingdoms
            List<Kingdom> allKingdoms = new List<Kingdom>
            {
                new Kingdom("Land", "Panda"),
                new Kingdom("Water", "Octopus"),
                new Kingdom("Ice", "Mammoth"),
                new Kingdom("Air", "Owl"),
                new Kingdom("Fire", "Dragon")
            };

            #endregion

            #region INPUT

            if (File.Exists(inputFile))
            {
                using (StreamReader sr = File.OpenText(inputFile))
                {
                    string s;

                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] lines = s.Split();

                        string messageToKingdom = "";

                        if (lines.Length > 2)
                        {
                            messageToKingdom = ConvertStringArrayToString(lines);
                        }
                        else
                        {
                            messageToKingdom = lines[1];
                        }

                        for (int i = 0; i < allKingdoms.Count; i++)
                        {
                            if (allKingdoms[i].GetKingdomName().ToLower() == lines[0].ToLower())
                            {
                                conqueror.SendMessage(messageToKingdom, allKingdoms[i]);
                            }
                        }
                    }
                }
            }

            #endregion

            #region OUTPUT

            //Request the Conqueror to display a list of his Aliies
            conqueror.DisplayAllies();

            #endregion
        }

        // Helper Methods
        public string ConvertStringArrayToString(string[] arr)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < arr.Length; i++)
            {
                sb.Append(arr[i]);
            }

            return sb.ToString();
        }
    }
}

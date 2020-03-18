using System;
using System.Collections.Generic;
using System.Text;

namespace TameOfThrones
{
    public class Seasar
    {
        private string AlphabetList;

        public Seasar()
        {
            AlphabetList = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        public string DecryptMessage(string msg, int key)
        {
            StringBuilder sb = new StringBuilder();

            string msgToDecrypt = msg.ToUpper();

            for (int i = 0; i < msgToDecrypt.Length; i++)
            {
                char temp = msgToDecrypt[i];
                int cIndex = AlphabetList.IndexOf(temp);
                int rIndex = cIndex - key;

                if (rIndex < 0)
                {
                    rIndex = AlphabetList.Length + rIndex;
                }

                sb.Append(AlphabetList[rIndex]);
            }

            return sb.ToString();
        }
    }
}

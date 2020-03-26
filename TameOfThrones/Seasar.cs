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
                
        public string MessageHandler(string msg, int key, CipherType cypherType)
        {
            StringBuilder sb = new StringBuilder();

            msg = msg.ToUpper();

            int rIndex = 0;

            for (int i = 0; i < msg.Length; i++)
            {
                char temp = msg[i];
                int cIndex = AlphabetList.IndexOf(temp);

                switch (cypherType)
                {
                    case CipherType.encryption:

                        rIndex = cIndex + key;

                        if (rIndex >= AlphabetList.Length)
                        {
                            rIndex = rIndex - AlphabetList.Length;
                        }
                        break;

                    case CipherType.decryption:

                        rIndex = cIndex - key;

                        if (rIndex < 0)
                        {
                            rIndex = AlphabetList.Length + rIndex;
                        }
                        break;

                    default:
                        break;
                }

                sb.Append(AlphabetList[rIndex]);
            }

            return sb.ToString();
        }

        public enum CipherType
        {
            encryption,
            decryption
        }
    }
}

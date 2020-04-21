using System.Linq;
using System.Text;

namespace TameOfThrones
{
    public sealed class MessageProcessor
    {
        //Private Variables - Two Kingdom objects that represent the message sender and receiver
        private Kingdom Sender;
        private Kingdom Receiver;

        private Seasar sCipher = new Seasar();

        //Static method to provide access to the Singleton Instance of this Class
        public static MessageProcessor Instance { get; } = new MessageProcessor();


        public void StartMessageProcessing(Kingdom sender, string msg, Kingdom receiver)
        {
            Sender = sender;
            Receiver = receiver;

            //Send the message to Seasar for decryption
            string dMsg = sCipher.MessageHandler(msg, receiver.GetEmblemCharCount(), Seasar.CipherType.decryption);

            ProcessMessageForKingdom(dMsg, Receiver);
        }

        private void ProcessMessageForKingdom(string msg, Kingdom r)
        {
            char[] emblem = r.GetEmblem().ToLower().ToCharArray();
            char[] message = msg.ToLower().ToCharArray();
                        
            var found = emblem.All(x => emblem.Count(y => y == x) <= message.Count(y => y == x));

            //var found = cArray1.GroupBy(c1 => c1).All(g => cArray2.Count(c2 => c2 == g.Key) >= g.Count())

            if (found)
            {
                //Transmit confirmation to the Receiver that its emblem was found in the Message, and then let it decide if it wants to be an Ally  of the sender or not...
                r.ProcessAllegiance(found, Sender);
            }
        }
    }
}

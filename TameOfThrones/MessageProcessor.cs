using System.Linq;

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

            string dMsg = sCipher.DecryptMessage(msg, receiver.GetEmblemCharCount());

            ProcessMessageForKingdom(dMsg, Receiver);
        }

        private void ProcessMessageForKingdom(string msg, Kingdom r)
        {
            var found = r.GetEmblem().ToCharArray().Select(c => char.ToUpper(c)).Distinct().All(c => msg.ToUpper().Contains(c));

            if (found)
            {
                //Transmit confirmation to the Receiver that its emblem was found in the Message, and then let it decide if it wants to be an Ally  of the sender or not...
                r.ProcessAllegiance(found, Sender);
            }
        }
    }
}

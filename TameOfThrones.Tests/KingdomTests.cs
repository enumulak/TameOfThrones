using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TameOfThrones.Tests
{
    [TestClass]
    public class KingdomTests
    {
        //This Method tests the following logic - A Kingdom becomes an Ally when it recieves a decrypted Message that contains its Symbol !!
        //This Test is expected to return a True - Message sent by KingdomOne contains the Emblem of KingdomTwo, and so KingdomTwo becomes an Ally of KingdomOne
        [TestMethod]
        public void KingdomBecomesAlly()
        {
            //Arrange
            
            var kingdomOne = new Kingdom("Space", "Gorilla");
            //var kingdomTwo = new Kingdom("Air", "Owl");
            var kingdomTwo = new Kingdom("Fire", "Dragon");

            //This message will be sent to the 'Air' kingdom and is encrypted. Our core logic will decrypt the message and that 
            //message will contain characters from the symbol of 'Air'
            var message = "DRAGONJXGMUT";

            string ally = "FIRE";

            //Act

            //Kingdom One sends the encrypted message to Kingdom Two
            kingdomOne.SendMessage(message, kingdomTwo);
            
            //We obtain the Ally name from the Allies List of Kingdom One
            string sAlly = kingdomOne.GetAllyName(0);
            

            //Assert
            Assert.AreEqual(ally, sAlly);
        }
    }
}

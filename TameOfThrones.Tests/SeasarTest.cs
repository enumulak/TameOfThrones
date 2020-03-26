using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TameOfThrones.Tests
{
    [TestClass]
    public class SeasarTest
    {
        //Method to test if Seasar is encrypting messages correctly
        [TestMethod]
        public void TestSeasarEncryption()
        {
            //Arrange
            var encryptedMessage = "ABC"; //This is our expected value - For this test, we move '3' letters forward for encryption
            var inputMessage = "xyz"; //This is the message that will be encrypted and will produce the above result

            //Act
            Seasar seasar = new Seasar();
            string output = seasar.MessageHandler(inputMessage, 3, Seasar.CipherType.encryption);

            //Assert
            Assert.AreEqual(output, encryptedMessage);
        }

        //Method to test if Seasar is decrypting messages correctly
        [TestMethod]
        public void TestSeasarDecryption()
        {
            //Arrange
            var decryptedMessage = "XYZ"; //This is our expected value - For this test, we move '3' letters backward for decryption
            var inputMessage = "abc"; //This is the message that will be decrypted and will produce the above result

            //Act
            Seasar seasar = new Seasar();
            string output = seasar.MessageHandler(inputMessage, 3, Seasar.CipherType.decryption);

            //Assert
            Assert.AreEqual(output, decryptedMessage);
        }
    }
}

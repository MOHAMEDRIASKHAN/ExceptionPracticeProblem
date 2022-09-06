using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace UserRegisterationUnitTesting

{
    [TestClass]
    public class UnitTesting
    {
        UserRegisteration user = new UserRegisteration();

        [TestMethod]
        public void FirstName()
        {
            // Arrange 
            bool expected = true;
            string name = "Riyas";
            UserRegisteration user = new UserRegisteration();

            // Act
            bool result = user.ValidateFirstName(name);

            // Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void LastName()
        {
            // Arrange 
            bool expected = true;
            string name = "Khan";
            UserRegisteration user = new UserRegisteration();

            // Act
            bool result = user.ValidateLastName(name);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Email()
        {
            // Arrange 
            bool expected = true;
            string email = "riyas@gmail.com";
            UserRegisteration user = new UserRegisteration();

            // Act
            bool result = user.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MobileNumber()
        {
            // Arrange 
            bool expected = true;
            string mobile = "123467908";
            UserRegisteration user = new UserRegisteration();

            // Act
            bool result = user.ValidateMobileNumber(mobile);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Password()
        {
            // Arrange 
            bool expected = true;
            string password = "Riyas@9";
            UserRegisteration user = new UserRegisteration();

            // Act
            bool result = user.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, result);
        }

    }

}
using System;
using Models;
using Xunit;

namespace RRTest
{
    public class CustomerModelTestCase
    {
        /// <summary>
        /// Will test if the CustomerName property will set with valid data
        /// valid data - anything with letters only
        /// </summary>
        [Fact] //Fact is a testcase that doesn't have any parameters and will only run once
        public void CustomerNameShouldSetValidData()
        {
            //Arrange
            Customer _omerTest = new Customer();
            string customername = "Howard";

            //Act
            _omerTest.CustomerName= customername;

            //Assert
            Assert.NotNull(_omerTest.CustomerName);
            Assert.Equal(_omerTest.CustomerName, customername);
        }

        /// <summary>
        /// Will test if city property gives exception if given invalid data
        /// invalid data - When you add anything beyond letters
        /// </summary>
        [Theory] //Change to Theory to create a parametrize test case
        [InlineData("12353HowardPoolHouse")] //InlineData will be the data being passed to the parameter of this method to be tested on
        [InlineData("12o3islkje")] //You can add more
        [InlineData("l5kae")]
        public void CustomerNameShouldFailIfSetWithInvalidData(string p_input)
        {
            //Arrange
            Customer _omerTest = new Customer();

            //Act & Assert
            //Throws method will only pass if the code you did will give some sort of an exception
            Assert.Throws<Exception>(() => _omerTest.CustomerName = p_input);
        }

        /// <summary>
        /// Will test if the StoreFrontAddress property will set with valid data
        /// valid data - anything with letters and numbers
        /// </summary>
        [Fact] //Fact is a testcase that doesn't have any parameters and will only run once
        public void CustomerAddressShouldSetValidData()
        {
            //Arrange
            Customer _omerTest = new Customer();
            string customeraddress = "456 Ronnie Road";

            //Act
            _omerTest.CustomerAddress= customeraddress;

            //Assert
            Assert.NotNull(_omerTest.CustomerAddress);
            Assert.Equal(_omerTest.CustomerAddress, customeraddress);
        }

        /// <summary>
        /// Will test if CustomerAddress property gives exception if given invalid data
        /// invalid data - Special Characters except comma, period, and single quote or empty string
        /// </summary>
        [Theory] //Change to Theory to create a parametrize test case
        [InlineData("3)4 H+d lane")] //InlineData will be the data being passed to the parameter of this method to be tested on
        [InlineData("222 *** Main Road")] //You can add more
        [InlineData("")]
        public void CustomerAddressShouldFailIfSetWithInvalidData(string p_input)
        {
            //Arrange
            Customer _omerTest = new Customer();

            //Act & Assert
            //Throws method will only pass if the code you did will give some sort of an exception
            Assert.Throws<Exception>(() => _omerTest.CustomerAddress = p_input);
        }

        /// <summary>
        /// Will test if the CustomerID property will set with valid data
        /// valid data - anything with only numbers
        /// </summary>
        [Fact] //Fact is a testcase that doesn't have any parameters and will only run once
        public void CustomerIDShouldSetValidData()
        {
            //Arrange
            Customer _omerTest = new Customer();
            string customerid = 5;

            //Act
            _omerTest.CustomerID= customerid;

            //Assert
            Assert.NotNull(_omerTest.CustomerID);
            Assert.Equal(_omerTest.CustomerID, customerid);
        }

        /// <summary>
        /// Will test if CustomerID property gives exception if given invalid data
        /// invalid data - any special characters or empty strings
        /// </summary>
        [Theory] //Change to Theory to create a parametrize test case
        [InlineData("U*#TR")] //InlineData will be the data being passed to the parameter of this method to be tested on
        [InlineData("W@!")] //You can add more
        [InlineData("")]
        public void CustomerIDShouldFailIfSetWithInvalidData(string p_input)
        {
            //Arrange
            Customer _omerTest = new Customer();

            //Act & Assert
            //Throws method will only pass if the code you did will give some sort of an exception
            Assert.Throws<Exception>(() => _omerTest.CustomerID = p_input);
        }

        /// <summary>
        /// Will test if the CustomerPhoneNumber property will set with valid data
        /// valid data - only numbers 
        /// </summary>
        [Fact] //Fact is a testcase that doesn't have any parameters and will only run once
        public void CustomerPhoneNumberShouldSetValidData()
        {
            //Arrange
            Customer _omerTest = new Customer();
            string customerphonenumber = 1235640121;

            //Act
            _omerTest.CustomerPhoneNumber= customerphonenumber;

            //Assert
            Assert.NotNull(_omerTest.CustomerPhoneNumber);
            Assert.Equal(_omerTest.CustomerPhoneNumber, customerphonenumber);
        }

        /// <summary>
        /// Will test if CustomerPhoneNumber property gives exception if given invalid data
        /// invalid data - any special characters, letters or empty strings
        /// </summary>
        [Theory] //Change to Theory to create a parametrize test case
        [InlineData("U*#TR")] //InlineData will be the data being passed to the parameter of this method to be tested on
        [InlineData("W@!")] //You can add more
        [InlineData("")]
        public void CustomerPhoneNumberShouldFailIfSetWithInvalidData(string p_input)
        {
            //Arrange
            Customer _omerTest = new Customer();

            //Act & Assert
            //Throws method will only pass if the code you did will give some sort of an exception
            Assert.Throws<Exception>(() => _omerTest.CustomerPhoneNumber = p_input);
        }


    }


}
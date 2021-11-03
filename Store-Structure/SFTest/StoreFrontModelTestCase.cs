using System;
using Models;
using Xunit;

namespace RRTest
{
    public class StoreFrontModelTestCase
    {
        /// <summary>
        /// Will test if the StoreFrontName property will set with valid data
        /// valid data - anything with letters only
        /// </summary>
        [Fact] //Fact is a testcase that doesn't have any parameters and will only run once
        public void StoreFrontNameShouldSetValidData()
        {
            //Arrange
            StoreFront _rontTest = new StoreFront();
            string storefrontname = "HowardPoolHouse";

            //Act
            _rontTest.StoreFrontName= storefrontname;

            //Assert
            Assert.NotNull(_rontTest.StoreFrontName);
            Assert.Equal(_rontTest.StoreFrontName, storefrontname);
        }

        /// <summary>
        /// Will test if city property gives exception if given invalid data
        /// invalid data - When you add anything beyond letters
        /// </summary>
        [Theory] //Change to Theory to create a parametrize test case
        [InlineData("12353HowardPoolHouse")] //InlineData will be the data being passed to the parameter of this method to be tested on
        [InlineData("12o3islkje")] //You can add more
        [InlineData("l5kae")]
        public void StoreFrontNameShouldFailIfSetWithInvalidData(string p_input)
        {
            //Arrange
            StoreFront _rontTest = new StoreFront();

            //Act & Assert
            //Throws method will only pass if the code you did will give some sort of an exception
            Assert.Throws<Exception>(() => _rontTest.StoreFrontName = p_input);
        }

        /// <summary>
        /// Will test if the StoreFrontAddress property will set with valid data
        /// valid data - anything with letters and numbers
        /// </summary>
        [Fact] //Fact is a testcase that doesn't have any parameters and will only run once
        public void StoreFrontAddressShouldSetValidData()
        {
            //Arrange
            StoreFront _rontTest = new StoreFront();
            string storefrontaddress = "456 Ronnie Road";

            //Act
            _rontTest.StoreFrontAddress= storefrontaddress;

            //Assert
            Assert.NotNull(_rontTest.StoreFrontAddress);
            Assert.Equal(_rontTest.StoreFrontAddress, storefrontaddress);
        }

        /// <summary>
        /// Will test if StoreFrontAddress property gives exception if given invalid data
        /// invalid data - Special Characters except comma, period, and single quote or empty string
        /// </summary>
        [Theory] //Change to Theory to create a parametrize test case
        [InlineData("3)4 H+d lane")] //InlineData will be the data being passed to the parameter of this method to be tested on
        [InlineData("222 *** Main Road")] //You can add more
        [InlineData("")]
        public void StoreFrontAddressShouldFailIfSetWithInvalidData(string p_input)
        {
            //Arrange
            StoreFront _rontTest = new StoreFront();

            //Act & Assert
            //Throws method will only pass if the code you did will give some sort of an exception
            Assert.Throws<Exception>(() => _rontTest.StoreFrontAddress = p_input);
        }

        /// <summary>
        /// Will test if the StoreFrontID property will set with valid data
        /// valid data - anything with only numbers
        /// </summary>
        [Fact] //Fact is a testcase that doesn't have any parameters and will only run once
        public void StoreFrontIDShouldSetValidData()
        {
            //Arrange
            StoreFront _rontTest = new StoreFront();
            string storefrontid = 5;

            //Act
            _rontTest.StoreFrontID= storefrontid;

            //Assert
            Assert.NotNull(_rontTest.StoreFrontID);
            Assert.Equal(_rontTest.StoreFrontID, storefrontproductsid);
        }

        /// <summary>
        /// Will test if StoreFrontOrders property gives exception if given invalid data
        /// invalid data - any letters or special characters
        /// </summary>
        [Theory] //Change to Theory to create a parametrize test case
        [InlineData("U*#TR")] //InlineData will be the data being passed to the parameter of this method to be tested on
        [InlineData("WERT")] //You can add more
        [InlineData("")]
        public void StoreFrontIDShouldFailIfSetWithInvalidData(string p_input)
        {
            //Arrange
            StoreFront _rontTest = new StoreFront();

            //Act & Assert
            //Throws method will only pass if the code you did will give some sort of an exception
            Assert.Throws<Exception>(() => _rontTest.StoreFrontID = p_input);
        }


    }


}
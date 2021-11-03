using Models;
using Xunit;

namespace RRTest
{
    public class ProductModelTestCase
    {
        /// <summary>
        /// Will test if the ProductName property will set with valid data
        /// valid data - anything with letters only
        /// </summary>
        [Fact] //Fact is a testcase that doesn't have any parameters and will only run once
        public void ProductNameShouldSetValidData()
        {
            //Arrange
            Product _ductTest = new Product();
            string productname = "CheekyDoll";

            //Act
            _ductTest.ProductName= productname;

            //Assert
            Assert.NotNull(_ductTest.ProductName);
            Assert.Equal(_ductTest.ProductName, productname);
        }

        /// <summary>
        /// Will test if ProductName property gives exception if given invalid data
        /// invalid data - When you add anything beyond letters
        /// </summary>
        [Theory] //Change to Theory to create a parametrize test case
        [InlineData("12353HowardPoolHouse")] //InlineData will be the data being passed to the parameter of this method to be tested on
        [InlineData("12o3islkje")] //You can add more
        [InlineData("l5kae")]
        public void ProductNameShouldFailIfSetWithInvalidData(string p_input)
        {
            //Arrange
            Product _ductTest = new Product();

            //Act & Assert
            //Throws method will only pass if the code you did will give some sort of an exception
            Assert.Throws<Exception>(() => _ductTest.ProductName = p_input);
        }

        /// <summary>
        /// Will test if the ProductID property will set with valid data
        /// valid data - anything with numbers only
        /// </summary>
        [Fact] //Fact is a testcase that doesn't have any parameters and will only run once
        public void ProductIDShouldSetValidData()
        {
            //Arrange
            Product _ductTest = new Product();
            string productid = 1;

            //Act
            _ductTest.ProductID= productid;

            //Assert
            Assert.NotNull(_ductTest.ProductID);
            Assert.Equal(_ductTest.ProductID, productid);
        }

        /// <summary>
        /// Will test if ProductID property gives exception if given invalid data
        /// invalid data - When you add anything beyond numbers
        /// </summary>
        [Theory] //Change to Theory to create a parametrize test case
        [InlineData("12353HowardPoolHouse")] //InlineData will be the data being passed to the parameter of this method to be tested on
        [InlineData("12o3islkje")] //You can add more
        [InlineData("l5kae")]
        public void ProductIDShouldFailIfSetWithInvalidData(string p_input)
        {
            //Arrange
            Product _ductTest = new Product();

            //Act & Assert
            //Throws method will only pass if the code you did will give some sort of an exception
            Assert.Throws<Exception>(() => _ductTest.ProductID = p_input);
        }

        /// <summary>
        /// Will test if the ProducCategory property will set with valid data
        /// valid data - anything with letters only
        /// </summary>
        [Fact] //Fact is a testcase that doesn't have any parameters and will only run once
        public void ProductCategoryShouldSetValidData()
        {
            //Arrange
            Product _ductTest = new Product();
            string productcategory = 1;

            //Act
            _ductTest.ProductCategory= productcategory;

            //Assert
            Assert.NotNull(_ductTest.ProductCategory);
            Assert.Equal(_ductTest.ProductCategory, productcategory);
        }

        /// <summary>
        /// Will test if ProductCategory property gives exception if given invalid data
        /// invalid data - When you add anything beyond numbers
        /// </summary>
        [Theory] //Change to Theory to create a parametrize test case
        [InlineData("12353HowardPoolHouse")] //InlineData will be the data being passed to the parameter of this method to be tested on
        [InlineData("12o3islkje")] //You can add more
        [InlineData("l5kae")]
        public void ProductCategoryShouldFailIfSetWithInvalidData(string p_input)
        {
            //Arrange
            Product _ductTest = new Product();

            //Act & Assert
            //Throws method will only pass if the code you did will give some sort of an exception
            Assert.Throws<Exception>(() => _ductTest.ProductCategory = p_input);
        }



    }


}
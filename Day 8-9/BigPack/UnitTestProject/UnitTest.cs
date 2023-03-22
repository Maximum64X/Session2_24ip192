using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class CostCalculatorTests
    {
        [TestMethod]
        public void CalculateCost_Returns_Correct_Cost()
        {
            // Arrange
            CostCalculator costCalculator = new CostCalculator();
            string minimalAmountString = "10";
            string priceString = "5";

            // Act
            string result = costCalculator.CalculateCost(minimalAmountString, priceString);

            // Assert
            Assert.AreEqual("50", result);
        }

        [TestMethod]
        public void CalculateCost_Returns_Zero_When_Input_Is_Empty()
        {
            // Arrange
            CostCalculator costCalculator = new CostCalculator();
            string minimalAmountString = "";
            string priceString = "";

            // Act
            string result = costCalculator.CalculateCost(minimalAmountString, priceString);

            // Assert
            Assert.AreEqual("0", result);
        }
    }
}

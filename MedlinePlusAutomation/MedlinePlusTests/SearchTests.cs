using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MedlinePlusAutomation;

namespace MedlinePlusTests
{
    [TestClass]
    public class SearchTests
    {
        [TestMethod]
        public void UserCanSearch()
        {
            HomePage.GoTo();
            //HomePage.SearchWith("aspirin").Search();
            //Part 1: First Test Creating...
            //Assert.IsTrue(HomePage.IsAt, "Failed to reach home page.");
        }
    }
}

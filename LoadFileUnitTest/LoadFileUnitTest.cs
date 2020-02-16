using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GartnerTestImportProducts.app;
using System.IO;

namespace LoadFileUnitTest
{
    [TestClass]
    public class LoadFileUnitTest
    {
        public static SoftwareAdvice sa;
        [ClassInitialize]
        public static void ClassInitialize()
        {
            string file = File.ReadAllText("SampleTestData.json");
            sa = new SoftwareAdvice(file);


        }
        [TestMethod]
        public void LoadJsonFileAndDisplayAllRecords()
        {
            //Arrange
            string file = File.ReadAllText("SampleTestData.json");
            //Act
            // SoftwareAdvice sa = new SoftwareAdvice();
            sa.LoadData(file);
            //Assert
            Assert.IsNotNull(null);
        }
        [TestCleanup]
        public void CleanData()
        {
        }
    }
}

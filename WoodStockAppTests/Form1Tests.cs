using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoodStockApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WoodStockApp.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void dvgStocklist_CellContentClickTest()
        {
            // Arrange
            var testInstance = new Form1();
            var testResult = testInstance.FindForm();

            // Act & Assert
            Assert.AreEqual(testResult, testInstance, "Expected testResult to mirror testInstance");
        }

        [TestMethod()]
        public void saveBtn_Click()
        {
            //Arrange

            SaveFileDialog sfd = new SaveFileDialog
            {
                FileName = "Stockfile.csv",
                Filter = "CSV (*.csv)|*.csv"
            };

            bool fileError = false;
            if (File.Exists(sfd.FileName))
            {

                // Act
                try
                {
                    File.Delete(sfd.FileName);
                }
                catch (IOException ex)
                {
                    // Assert
                    StringAssert.Contains(sfd.FileName, ex.Message);
                }
            }

                Assert.IsFalse(fileError);
        }
       
    }
}
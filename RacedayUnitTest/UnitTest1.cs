using Microsoft.VisualStudio.TestTools.UnitTesting;
using RaceDay;

namespace RacedayUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckPunterNamesAdded()
        {

            //test to see if all my punters are added
            Form1 myForm1 = new Form1();
            string[] expectedPunter = new string[3] { "Balbir", "Lucky", "Sameer" };
            string[] actual = myForm1.AddPuntersToList();

            CollectionAssert.AreEquivalent(expectedPunter, actual);

        }
    }
}

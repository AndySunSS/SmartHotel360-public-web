using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartHotel360.PublicWeb.Controllers;

namespace SmartHotel360.PublicWeb.Tests
{
    [TestClass]
    public class PetDocumentTest
    {
        [TestMethod]
        public void PetDocumentInitTest()
        {
            PetDocument pd = new PetDocument();
            Assert.IsNotNull(pd);
        }
        [TestMethod]
        public void PetDocumentNameTest()
        {
            PetDocument pd = new PetDocument();
            pd.PetName = "Snuffles";
            Assert.IsNotNull(pd.PetName);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartHotel360.PublicWeb.Controllers;
using SmartHotel360.PublicWeb.Services;
using SmartHotel360.PublicWeb.Models.Settings;

namespace SmartHotel360.PublicWeb.Tests
{
    [TestClass]
    public class PetsApiControllerTest
    {

        [TestMethod]
        public void UploadPetImageAsyncTest1()
        {
            // Arrange
            ServerSettings ss = new ServerSettings();
            SettingsService setService = new SettingsService(ss);
            PetsApiController petapi = new PetsApiController(setService);

            //Assert
            Assert.IsNotNull(petapi);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartHotel360.PublicWeb.Controllers;
using Microsoft.AspNetCore.Mvc;
using SmartHotel360.PublicWeb.Services;
using SmartHotel360.PublicWeb.Models.Settings;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Security.Principal;
using System;

namespace SmartHotel360.PublicWeb.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void ErrorNullReferenceTest()
        {
            // Arrange
            ServerSettings ss = new ServerSettings();
            SettingsService setService = new SettingsService(ss);
            HomeController controller = new HomeController(setService);

            //Assert
            Assert.ThrowsException<NullReferenceException>(controller.Error);
        }

        [TestMethod]
        public void Index()
        {
            // Arrange
            ServerSettings ss = new ServerSettings();
            SettingsService sests = new SettingsService(ss);
            HomeController controller = new HomeController(sests);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

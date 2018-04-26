using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartHotel360.PublicWeb.Controllers;
using Microsoft.AspNetCore.Mvc;
using SmartHotel360.PublicWeb.Services;
using SmartHotel360.PublicWeb.Models.Settings;
using System;


namespace SmartHotel360.PublicWeb.Tests
{
    [TestClass]
    public class IntegrationTests
    {
        [TestMethod]
        public void IntegrationA()
        {
            //Sleep to slow down Test run to demo pending and executing icons
            System.Threading.Thread.Sleep(1500);
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void IntegrationB()
        {
            // Sleep to slow down Test run to demo pending and executing icons
            System.Threading.Thread.Sleep(1500);
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void IntegrationAB()
        {
            //Sleep to slow down Test run to demo pending and executing icons
            System.Threading.Thread.Sleep(3000);
            Assert.IsTrue(true);
        }
    }
}

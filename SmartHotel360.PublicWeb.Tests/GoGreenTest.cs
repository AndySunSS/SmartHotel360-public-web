using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartHotel360.PublicWeb.Controllers;
using System;

namespace SmartHotel360.PublicWeb.Tests
{
    [TestClass]
    public class GoGreenTest
    {
        [TestMethod]
        public void GoGreenReqNullTest()
        {
            //Arrance
            DateTime checkIn = new DateTime(2018, 4, 20, 7, 47, 0);
            DateTime lastCleaning = new DateTime(2018, 4, 20, 7, 47, 0);
            DateTime ggRequest = checkIn.AddDays(2);
            GoGreen gg = new GoGreen();

            //Act
            GoGreenRequest ggr = new GoGreenRequest(gg, "Sally Sea", 113, checkIn, lastCleaning, "Best hotel ever!");

            //Assert
            Assert.IsNotNull(ggr);
        }
        [TestMethod]
        public void GoGreenReqInitTest()
        {
            //Arrange
            DateTime checkIn = new DateTime(2018, 4, 20, 7, 47, 0);
            DateTime lastCleaning = new DateTime(2018, 4, 20, 7, 47, 0);
            DateTime ggRequest = checkIn.AddDays(2);
            GoGreen gg = new GoGreen();

            //Act
            GoGreenRequest ggr = new GoGreenRequest(gg, "Sally Sea", 113, checkIn, lastCleaning, "Best hotel ever!");

            //Assert
            Assert.IsTrue(ggr.Under7Days());
        }
        [TestMethod]
        public void GoGreenReqOver7DaysTest()
        {
            DateTime checkIn = new DateTime(2018, 4, 01, 7, 47, 0);
            DateTime lastCleaning = DateTime.Today.AddDays(-8);
            DateTime ggRequest = checkIn.AddDays(8);
            GoGreen gg = new GoGreen();
            GoGreenRequest ggr = new GoGreenRequest(gg, "Sally Sea", 113, checkIn, lastCleaning, "Best hotel ever!");
            Assert.IsFalse(ggr.Under7Days());
        }
        [TestMethod]
        public void GoGreenReqNullMessageTest()
        {
            DateTime checkIn = new DateTime(2018, 4, 20, 7, 47, 0);
            DateTime ggRequest = checkIn.AddDays(2);
            GoGreen gg = new GoGreen();
            GoGreenRequest ggr = new GoGreenRequest(gg, "", 113, checkIn, null);
            Assert.IsNotNull(ggr.TextHouseKeeping(null));
        }

        [TestMethod]
        public void GoGreenReqNullCheckinTest()
        {
            DateTime checkIn = new DateTime(2018, 4, 20, 7, 47, 0);
            DateTime ggRequest = checkIn.AddDays(2);
            GoGreen gg = new GoGreen();
            GoGreenRequest ggr = new GoGreenRequest(gg, "Sally Sea", 113, checkIn, null);
            Assert.IsTrue(ggr.Under7Days());
        }

        [TestMethod]
        public void GoGreenReqDoNotDisturbTest()
        {
            DateTime checkIn = new DateTime(2018, 4, 20, 7, 47, 0);
            DateTime ggRequest = checkIn.AddDays(2);
            GoGreen gg = new GoGreen();
            GoGreenRequest ggr = new GoGreenRequest(gg, "Sally Sea", 113, checkIn, null);
            ggr.CheckDoNotDisturb("I'm good on towels. Thanks! Do not distrub.");
            bool t = gg.DoNotDisturbRooms.Contains(ggr.RoomNumber);
            Assert.IsTrue(t);
        }

        [TestMethod]
        public void GoGreenInitTest()
        {
            GoGreen gg = new GoGreen();
            Assert.IsNotNull(gg.DoNotDisturbRooms);

        }

    }
}

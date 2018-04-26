using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartHotel360.PublicWeb.Controllers;
using SmartHotel360.PublicWeb.Models.Settings;
using SmartHotel360.PublicWeb.Services;
using System;

namespace SmartHotel360.PublicWeb.Tests
{
    [TestClass]
    public class TestimonialsControllerTest
    {
        [TestMethod]
        public void CustomerTestimonialNullCheck()
        {
            CustomerTestimonial ct = new CustomerTestimonial();
            Assert.IsNotNull(ct);
        }
        [TestMethod]
        public void Testimonial()
        {
            CustomerTestimonial ct = new CustomerTestimonial();
            ct.CustomerName = "John Doe";
            ct.Text = "Best Hotel ever! Snuggles loved it!";
            Assert.IsNotNull(ct.Text);
            Assert.IsNotNull(ct.CustomerName);
        }
    }
}

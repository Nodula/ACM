﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Acme.Common;
using ACM.BL;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "fbagging@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                addressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden rake with steel hand",
                CurrentPrice = 6M
            };
            changedItems.Add(product);

            LoggingService.WriteToFile(changedItems);


        }
    }
}
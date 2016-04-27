﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingDbProject;

namespace Tests
{
    [TestClass]
    public class DbInitializer
    {
        [TestMethod]
        public void TestMethod()
        {
            List<FakeObject> objects = new List<FakeObject>();
            Random rnd = new Random();

            for (int i = 0; i < 2000000; i++)
            {
                objects.Add(new FakeObject()
                {
                    Age = rnd.Next(100),
                    City = Guid.NewGuid().ToString(),
                    Name = Guid.NewGuid().ToString(),
                    OnVacation = true,
                    Prop1 = rnd.Next(1000),
                    Prop2 = rnd.NextDouble(),
                    Prop3 = rnd.Next(200000),
                    Prop4 = rnd.Next(1500),
                    Prop5 = Guid.NewGuid().ToString(),
                    Prop6 = Guid.NewGuid().ToString()
                });
            }
            new BulkInsertToDb().BulkInsert(objects, 10000);
        }
    }
}

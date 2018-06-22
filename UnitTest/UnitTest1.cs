using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwaggerIO;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var pet = new Swagger();
            var myget = pet.Get(1);
            var getresult = "{\"id\":1,\"category\":{\"id\":0,\"name\":\"string\"},\"name\":\"2\",\"photoUrls\":[\"string\"],\"tags\":[{\"id\":0,\"name\":\"string\"}],\"status\":\"3\"}";
            Assert.AreEqual(myget, getresult);



        }
    }
}

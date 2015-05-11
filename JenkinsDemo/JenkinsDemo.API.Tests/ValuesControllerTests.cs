using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using JenkinsDemo.API.Controllers;

namespace JenkinsDemo.API.Tests
{
    [TestFixture]
    public class ValuesControllerTests
    {
        [Test]
        public void Get_WithoutParameters_ReturnsArrayOfStringWithTwoValues()
        {
            var controller = new ValuesController();

            var result = controller.Get();

            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.FirstOrDefault());
            Assert.AreEqual("value2", result.LastOrDefault());
        }

        [Test]
        public void Get_PassingId_ReturnsString()
        {
            var controller = new ValuesController();

            var result = controller.Get(1);

            Assert.AreEqual("value3", result);
        }
    }
}

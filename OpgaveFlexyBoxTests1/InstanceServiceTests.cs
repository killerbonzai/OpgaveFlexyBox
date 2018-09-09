using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpgaveFlexyBox;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace OpgaveFlexyBox.Tests
{
    [TestClass()]
    public class InstanceServiceTests
    {
        [TestMethod()]
        public void GetInstancesTest()
        {
            InstanceService<Vehicle> instanceService = new InstanceService<Vehicle>();
            var instances = instanceService.GetInstances();
            List<Type> expected = new List<Type>() { typeof(VehicleHotAirBalloon), typeof(VehicleSkateboard), typeof(VehicleTank), typeof(VehicleTeleporter) };
            if (instances.Count() != expected.Count)
            {
                Assert.IsFalse(true, "Incorrect number of results found");
                return;
            }
            foreach (Type item in instances)
            {
                if (!expected.Contains(item))
                {
                    Assert.IsFalse(true, "Found result not supposed to be there");
                    return;
                }
            }
            Assert.IsFalse(false, "All expected elements found");
        }
    }
}
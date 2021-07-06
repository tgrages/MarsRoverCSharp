using System;
using System.Collections.Generic;
using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTests
{    
    [TestClass]
    public class RoverTests
    {
        //8) Tests Constructor setting the Default Rover Position
        [TestMethod]
        public void ConstructorSetsDefaultPosition()
        {
            Rover roverPosition = new Rover(150);
            Assert.AreEqual(150, roverPosition.Position);
        }

        //9) Tests Constructor setting the Default Mode
        [TestMethod]
        public void ConstructorSetsDefaultMode()
        {
            Rover roverMode = new Rover(150);
            Assert.AreEqual("NORMAL", roverMode.Mode);
        }

        //10) Tests Constructor setting the Default Generator wattage
        [TestMethod]
        public void ConstructorSetsDefaultGeneratorWatts()
        {
            Rover roverGeneratorWatts = new Rover(150);
            Assert.AreEqual(110, roverGeneratorWatts.GeneratorWatts);
        }
    }
}

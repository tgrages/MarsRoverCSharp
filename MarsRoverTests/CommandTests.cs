using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;
using System;

namespace MarsRoverTests
{
    [TestClass]
    public class CommandTests
    {

        [TestMethod]
        public void ArgumentNullExceptionThrownIfCommandTypeIsNullOrEmpty()
        {
            try
            {
                new Command("");
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Command type required.", ex.Message);
            }
        }

        [TestMethod]
        public void ConstructorSetsCommandType()
        {
            Command newCommand = new Command("MOVE", 0);
            Assert.AreEqual(newCommand.CommandType, "MOVE");
        }
        //ConstructSetsCommandType: You can make the command anything since you are just testing AreEqual. Does not have to be "Move".
        [TestMethod]
        public void ConstructorSetsInitialNewPositionValue()
        {
            Command newCommand = new Command("MOVE", 20);
            Assert.AreEqual(newCommand.NewPosition, 20);
        }

        //4) Test is responsible for checking that the 3rd field on the Command Class, NewMode is set by a Command Constructor
        [TestMethod]
        public void ConstructorSetsInitialNewModeValue()
        {
            Command newCommand = new Command("MOVE", 0, "NORMAL");
            Assert.AreEqual(newCommand.NewMode, "NORMAL");
        }

    }
}

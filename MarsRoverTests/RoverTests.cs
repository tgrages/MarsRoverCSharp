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

        //11) Test to check that when a rover object receives a message that contains a "MODE_CHANGE" command, that rover's Mode field is updated. The rover has two modes that can be passed as values to a mode change command: "LOW_POWER" and "NORMAL".
        [TestMethod]
        public void RespondsCorrectlyToModeChangeCommand()
        {
            Command[] commands = 
            { 
                new Command("MODE_CHANGE", "NORMAL"),
                new Command("MODE_CHANGE", "LOW_POWER")
            };
            Message newMessage = new Message("UPDATE 1", commands);
            Rover newRover = new Rover();
            newRover.ReceiveMessage(newMessage);
            Assert.AreEqual(newRover.Mode, commands[commands.Length-1].NewMode);
        }

        //12) Test to confirm that the rover position does not change when sent a "MOVE" command in "LOW_POWER" mode."
        [TestMethod]
        public void DoesNotMoveInLowPower()
        {
            Command[] commands = { new Command("MOVE", "LOW_POWER") };
            Message newMessage = new Message("UPDATE 1", commands);
            Rover newRover = new Rover(0);

            newRover.ReceiveMessage(newMessage);

            Assert.AreEqual(newRover.Position, 0);
        }

        //13) Test to confirm a MOVE command will update the rover's position with the position value in the command
        [TestMethod]
        public void PositionChangesFromMoveCommand()
        {
            Command[] commands = { new Command("MODE_CHANGE", "LOW_POWER"), new Command("MOVE", 5) };
            Message newMessage = new Message("UPDATE 1", commands);
            Rover newRover = new Rover();
            newRover.ReceiveMessage(newMessage);
            Assert.AreEqual(newRover.Position, 5);           
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;

namespace MarsRoverTests
{
    [TestClass]
    public class MessageTests
    {
        Command[] commands = { new Command("foo", 0), new Command("bar", 20) };

        //5) Testing argument thrown if no name entered 
        [TestMethod]
        public void ArgumentNullExceptionThrownIfNameNotPassedToConstructor()
        {
            try
            {
                new Message("", commands);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Name required.", ex.Message);
            }
        }
        
        //6) Test confirms that the Constructor in Message class correctly sets the Name property in a new message object
        [TestMethod]
        public void ConstructorSetsName()
        {
            Message newName = new Message("", commands);
            Assert.AreEqual(newName.Name, "");
        }

        //7) Test confirms that the Commands property of a new message object contains data passed in from the Message(name, commands) call

        [TestMethod]
        public void ConstructorSetsCommandsField()
        {
            Message newMessage = new Message("foo", commands);
            Assert.AreEqual(commands, newMessage.Commands);
        }

        
    }
}

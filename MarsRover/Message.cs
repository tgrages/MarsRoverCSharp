using System;
namespace MarsRover
{
    public class Message
    {
        public string Name { get; set; }
        public Command[] Commands { get; set; }

        //public Message(string name, Command[] commands)
        //{            
        //    Name = name;
        //    if (String.IsNullOrEmpty(Name))
        //    {
        //        throw new ArgumentNullException(Name, "Name required.");
        //    }            
        //}

		//public Message(string newName)
		//{
		//	Name = newName;
		//	if (String.IsNullOrEmpty(Name))
		//	{
		//		throw new ArgumentNullException(Name, "Name required.");
		//	}			
		//}

        public Message(string name, Command[] commands)
        {
            Name = name;
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name required.");
            }
            Commands = commands;
        }


    }
}

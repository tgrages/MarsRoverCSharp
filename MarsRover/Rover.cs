using System;
namespace MarsRover
{
    public class Rover
    {
        public string Mode { get; set; }
        public int Position { get; set; }
        public int GeneratorWatts { get; set; }

        public Rover(int position)
        {
            //a position is a number representing the rover's position
            Position = position;
            Mode = "NORMAL";
            GeneratorWatts = 110;
        }

        public Rover()
        {
        
        }

        //Method ReceiveMessage handles updates to the Rover's properties (MOVE and MODE_CHANGE)
        public void ReceiveMessage(Message message)
        {
            for (int i = 0; i < message.Commands.Length; i++)
            {
                string commandType = message.Commands[i].CommandType;

                if (commandType == "MOVE")
                {
                    if (Mode != "LOW_POWER")
                    {
                        Position = message.Commands[i].NewPosition;
                    }
                }

                if (commandType == "MODE_CHANGE")
                {
                    Mode = message.Commands[i].NewMode;
                }

                else if (commandType != "MOVE" && commandType != "MODE_CHANGE")
                {
                   throw new ArgumentException("Please enter a valid command.");
                }
            }
        }

        public override string ToString()
        {
            return "Position: " + Position + " - Mode: " + Mode + " - GeneratorWatts: " + GeneratorWatts; 
        }

    }
}

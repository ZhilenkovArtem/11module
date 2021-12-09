﻿namespace Task_11_4.Commands
{
    public abstract class ChatTextCommandOption : AbstractCommand
    {
        public override bool CheckMessage(string message)
        {
            return message.StartsWith(CommandText);
        }

        public string ClearMessageFromCommand(string message)
        {
            return message.Substring(CommandText.Length + 1);
        }
    }
}

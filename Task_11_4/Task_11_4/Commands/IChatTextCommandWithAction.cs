namespace Task_11_4.Commands
{
    interface IChatTextCommandWithAction : IChatTextCommand
    {
        bool DoAction(Conversation chat);
    }
}

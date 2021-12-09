using Telegram.Bot.Types.ReplyMarkups;

namespace Task_11_4.Commands
{
    interface IKeyBoardCommand
    {
        InlineKeyboardMarkup ReturnKeyBoard();

        void AddCallBack(Conversation chat);

        string InformationalMessage();
    }
}

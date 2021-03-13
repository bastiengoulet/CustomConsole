namespace CustomConsole
{
    public class StringReader : Reader
    {
        public override object ReadFromUser(string message)
        {
            return ReadFirstInput(message);
        }
    }
}

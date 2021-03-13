namespace CustomConsole
{
    public abstract class Reader
    {
        protected string input;

        public abstract object ReadFromUser(string message);
    }
}

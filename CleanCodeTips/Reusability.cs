namespace CleanCodeTips
{
    public class Reusability
    {
        public delegate void Logoneventhandler(object sender, EventArgs e);
        public event Logoneventhandler LogonEvent;
        public void Method()
        {
            if (LogonEvent != null)
            {
                LogonEvent?.Invoke(this, EventArgs.Empty); //(“?” check for null) and improved performance a bit when you get rid of constructing new EventArgs.
            }
        }
    }
}
//https://servocode.com/blog/clean-code-principles-in-c-aka-how-to-write-projects-that-dont-suck
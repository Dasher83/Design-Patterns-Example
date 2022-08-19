namespace Proxy
{
    internal class Client
    {
        public void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }
}

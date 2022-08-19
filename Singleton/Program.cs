using Singleton;

Connection.Instance.Connect();
Connection.Instance.Disconnect();
bool isConnectionInstance = Connection.Instance.GetType() == typeof(Connection);
Console.WriteLine($"{isConnectionInstance}");
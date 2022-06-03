namespace api.Services;

public class CounterService : ICounterService {
    private readonly Dictionary<string,int> _counter;
    private readonly object _locker;

    public CounterService()
    {
        _counter = new Dictionary<string, int>();
        _locker = new object();
    }

    public int Increment(string client = "Anonymous")
    {
        lock (_locker)
        {
            if(!_counter.ContainsKey(client))
            {
                _counter.Add(client, 1);
                return 1;
            }
            _counter[client]++;
            Thread.Sleep(2000);
            return _counter[client];
        }
    }
}
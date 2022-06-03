using System.Collections.Generic;

namespace api.Services;

public class CounterService : ICounterService {
    private readonly Dictionary<string,int> _counter;

    public CounterService()
    {
        _counter = new Dictionary<string, int>();
    }

    public int Increment(string client = "Anonymous")
    {
        if(!_counter.ContainsKey(client))
        {
            _counter.Add(client, 1);
            return 1;
        }

        _counter[client]++;
        return _counter[client];
    }
}
using Microsoft.AspNetCore.Mvc;
using api.Services;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CounterController : ControllerBase
{
    private readonly ICounterService _counter;

    public CounterController(ICounterService counter)
    {
        _counter = counter;
    }

    [HttpGet("SeqNum")]
    public int Get()
    {
        return _counter.Increment();
    }

    [HttpGet("ClientSeqNum")]
    public int Get(string ClientID)
    {
        return _counter.Increment(ClientID);
    }
}

namespace api.Services;

public interface ICounterService {
    int Increment(string client = "");
}
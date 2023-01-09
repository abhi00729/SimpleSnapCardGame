
namespace SimpleSnap.Interfaces
{
    public interface ICard
    {
        int Suite { get; }
        int Value { get; }
        CardSuite ESuite { get; }
        CardValue EValue { get; }
    }
}

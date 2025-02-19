using Microsoft.Extensions.Logging;

namespace Please.Dont.Just.Copy.Paste.Actually.Use.Tdd.To.ReCreate.And.Fix.Bugs.I.Made.With.My.From.Memory.Copy.Paste.As.I.Am.Naughty.And.Didnt.Actually.Make.This.With.London.And.My.Testing.Was.Beyond.Minimal.Plus.Making.It.Crappy.Means.You.Will.Have.To.Write.Your.Own

public class FakeLogger : ILogger
{
    public readonly List<(LogLevel LogLevel, string Message, IReadOnlyList<KeyValuePair<string, object?>> State)> CallList = new();
    private readonly List<IReadOnlyList<KeyValuePair<string, object?>>> _scopeStateList = new();

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        IReadOnlyList<KeyValuePair<string, object?>> stateWithScopeState =
            [.._scopeStateList.SelectMany(l => l), ..(IReadOnlyList<KeyValuePair<string, object?>>)state!];

        CallList.Add((logLevel, formatter(state, exception), stateWithScopeState));
    }

    public bool IsEnabled(LogLevel logLevel) => true;

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull
    {
        var scopeState = (IReadOnlyList<KeyValuePair<string, object?>>)state;
        _scopeStateList.Add(scopeState);

        return new DisposableAction(() => _scopeStateList.Remove(scopeState));
    }
}

public class DisposableAction(Action onDispose) : IDisposable
{
    public void Dispose()
    {
        onDispose();
    }
}
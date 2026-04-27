namespace UnoMvuxDemo;

public abstract record AppAction;

public sealed record Increment : AppAction;
public sealed record Decrement : AppAction;
public sealed record SetBusy(bool Value) : AppAction;

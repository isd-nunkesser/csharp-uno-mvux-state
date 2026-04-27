namespace UnoMvuxDemo;

public static class AppReducer
{
    public static AppState Reduce(AppState state, AppAction action) => action switch
    {
        Increment => state with { Count = state.Count + 1 },
        Decrement => state with { Count = state.Count - 1 },
        SetBusy a => state with { IsBusy = a.Value },
        _ => state,
    };
}

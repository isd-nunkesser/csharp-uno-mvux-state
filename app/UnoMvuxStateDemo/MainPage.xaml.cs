namespace UnoMvuxStateDemo;

public sealed partial class MainPage : Page
{
    private int _count;

    public MainPage()
    {
        this.InitializeComponent();
    }

    private void OnIncrementClicked(object sender, RoutedEventArgs e)
    {
        _count++;
        UpdateCount();
    }

    private void OnDecrementClicked(object sender, RoutedEventArgs e)
    {
        _count--;
        UpdateCount();
    }

    private void OnResetClicked(object sender, RoutedEventArgs e)
    {
        _count = 0;
        UpdateCount();
    }

    private void UpdateCount()
    {
        CountText.Text = $"Count: {_count}";
    }
}

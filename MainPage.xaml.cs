namespace QuizMauiApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    } 

    private async void OnStartClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CategoriesPage));
    }
}
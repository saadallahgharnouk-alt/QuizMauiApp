namespace QuizMauiApp;

public partial class CategoriesPage : ContentPage
{
    public CategoriesPage()
    {
        InitializeComponent();
    }

    private async void OnCategoryClicked(object sender, EventArgs e)
    {
        if (sender is not Button button) return;

        string category = button.Text; // Récupère "Informatique", "Mathématiques", etc.

        // On passe le nom de la catégorie en paramètre
        await Shell.Current.GoToAsync($"{nameof(QuizPage)}?SelectedCategory={category}");
    }
}
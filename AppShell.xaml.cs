namespace QuizMauiApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            // Ces deux lignes sont obligatoires pour que GoToAsync fonctionne :
            Routing.RegisterRoute(nameof(CategoriesPage), typeof(CategoriesPage));
            Routing.RegisterRoute(nameof(QuizPage), typeof(QuizPage));
            Routing.RegisterRoute(nameof(ResultPage), typeof(ResultPage));
        }

    }
}

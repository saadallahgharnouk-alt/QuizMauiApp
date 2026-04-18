namespace QuizMauiApp;

[QueryProperty(nameof(Score), "score")]
[QueryProperty(nameof(TotalQuestions), "totalQuestions")]
public partial class ResultPage : ContentPage
{
    private int _score;
    public int Score 
    { 
        get => _score;
        set 
        {
            _score = value;
            UpdateResultLabel();
        }
    }

    private int _totalQuestions;
    public int TotalQuestions 
    { 
        get => _totalQuestions;
        set 
        {
            _totalQuestions = value;
            UpdateResultLabel();
        }
    }

    public ResultPage()
    {
        InitializeComponent();
    }

    private void UpdateResultLabel()
    {
        if (ResultLabel != null)
        {
            ResultLabel.Text = $"Votre score final : {Score} / {TotalQuestions}";
        }
    }

    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}
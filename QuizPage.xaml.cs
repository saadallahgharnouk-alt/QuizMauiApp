using System.Collections.ObjectModel;

namespace QuizMauiApp;

[QueryProperty(nameof(SelectedCategory), "SelectedCategory")]
public partial class QuizPage : ContentPage
{
    public string SelectedCategory { get; set; } // Propriété qui recevra le nom de la catégorie

    private List<QuizQuestion> questions;
    private int currentQuestionIndex = 0;
    private int score = 0;

    public QuizPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        currentQuestionIndex = 0;
        score = 0;
        LoadQuestionsByCategory();
        LoadQuestion();
    }

    private void LoadQuestionsByCategory()
    {
        if (SelectedCategory == "Informatique")
        {
            questions = new List<QuizQuestion>
            {
                new QuizQuestion("Quel est le cerveau de l'ordinateur ?", new List<string> { "RAM", "CPU", "Disque Dur", "GPU" }, "CPU"),
                new QuizQuestion("Que signifie HTML ?", new List<string> { "HyperText Markup Language", "High Tech Multi Language", "HyperLink Main Log", "Home Tool Main Line" }, "HyperText Markup Language")
            };
        }
        else if (SelectedCategory == "Mathématiques")
        {
            questions = new List<QuizQuestion>
            {
                new QuizQuestion("Combien font 7 x 8 ?", new List<string> { "54", "56", "64", "48" }, "56"),
                new QuizQuestion("Quelle est la racine carrée de 81 ?", new List<string> { "7", "8", "9", "10" }, "9")
            };
        }
        else 
        {
            questions = new List<QuizQuestion>
            {
                new QuizQuestion("Quelle est la capitale de la France ?", new List<string> { "Paris", "Londres", "Madrid", "Rome" }, "Paris"),
                new QuizQuestion("Qui a peint la Joconde ?", new List<string> { "Van Gogh", "Picasso", "De Vinci", "Monet" }, "De Vinci")
            };
        }
    }

    private async void LoadQuestion()
    {
        if (currentQuestionIndex < questions.Count)
        {
            QuizQuestion currentQuestion = questions[currentQuestionIndex];
            QuestionLabel.Text = currentQuestion.QuestionText;
            AnswerButton1.Text = currentQuestion.Answers[0];
            AnswerButton2.Text = currentQuestion.Answers[1];
            AnswerButton3.Text = currentQuestion.Answers[2];
            AnswerButton4.Text = currentQuestion.Answers[3];

            // Réinitialiser les couleurs et réactiver les boutons
            AnswerButton1.BackgroundColor = Colors.LightGray;
            AnswerButton2.BackgroundColor = Colors.LightGray;
            AnswerButton3.BackgroundColor = Colors.LightGray;
            AnswerButton4.BackgroundColor = Colors.LightGray;

            AnswerButton1.IsEnabled = true;
            AnswerButton2.IsEnabled = true;
            AnswerButton3.IsEnabled = true;
            AnswerButton4.IsEnabled = true;
        }
        else
        {
            var navParams = new Dictionary<string, object>
            {
                { "score", score },
                { "totalQuestions", questions.Count }
            };
            await Shell.Current.GoToAsync(nameof(ResultPage), navParams);
        }
    }

    private async void OnAnswerClicked(object sender, EventArgs e)
    {
        if (sender is not Button button)
            return;
        AnswerButton1.IsEnabled = false;
        AnswerButton2.IsEnabled = false;
        AnswerButton3.IsEnabled = false;
        AnswerButton4.IsEnabled = false;

        QuizQuestion currentQuestion = questions[currentQuestionIndex];

        if (button.Text == currentQuestion.CorrectAnswer)
        {
            score++;
            button.BackgroundColor = Colors.Green;
        }
        else
        {
            button.BackgroundColor = Colors.Red;Q
            if (AnswerButton1.Text == currentQuestion.CorrectAnswer) AnswerButton1.BackgroundColor = Colors.Green;
            if (AnswerButton2.Text == currentQuestion.CorrectAnswer) AnswerButton2.BackgroundColor = Colors.Green;
            if (AnswerButton3.Text == currentQuestion.CorrectAnswer) AnswerButton3.BackgroundColor = Colors.Green;
            if (AnswerButton4.Text == currentQuestion.CorrectAnswer) AnswerButton4.BackgroundColor = Colors.Green;
        }

        await Task.Delay(1000);

        currentQuestionIndex++;
        LoadQuestion();
    }
}Q
namespace QuizMauiApp
{
    public class QuizQuestion
    {
        public string QuestionText { get; set; }
        public List<string> Answers { get; set; }
        public string CorrectAnswer { get; set; }

        public QuizQuestion(string questionText, List<string> answers, string correctAnswer)
        {
            QuestionText = questionText;
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }
    }
}
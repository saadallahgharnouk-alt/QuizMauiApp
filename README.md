# QuizMauiApp

A French-language quiz app built with .NET MAUI, C#, and XAML. Choose a category, answer multiple-choice questions, and see your score at the end.

## How it works

1. Pick general knowledge, computer science, or mathematics.
2. Answer two questions per category. The app highlights the correct answer before advancing.
3. View your final score and return to the home screen to try another category.

The app uses MAUI Shell to pass the selected category to the quiz page and the score to the results page. Questions are bundled in the app, so the quiz works offline.

## Run locally

Install the .NET 10 SDK, the .NET MAUI workload, and the SDK for your target platform. For Android, have an emulator running or a configured device connected.

```bash
git clone https://github.com/saadallahgharnouk-alt/QuizMauiApp.git
cd QuizMauiApp
dotnet build QuizMauiApp.csproj -f net10.0-android -t:Run
```

You can also open `QuizMauiApp.csproj` in an IDE with .NET MAUI support and select an emulator or device. The project declares Android, iOS, Mac Catalyst, and Windows targets, with platform availability determined by your development machine.

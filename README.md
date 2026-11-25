# C# Practice

C# exercises from the Programming II course (1st year, Computer Engineering): console programs and WPF desktop apps, from the basics to delegates, LINQ and the command/MVVM pattern.

Each folder is a Visual Studio project (.NET Framework 4.7.2 / 4.8). Open the `.sln` or `.csproj` in Visual Studio 2022 and run it.

| Folder | Topics |
|---|---|
| `01_console_basics` | Classes, `ToString()` overrides, arrays, input validation, a stamp machine that returns change, a console calculator |
| `02_delegates_lambdas_and_events` | Delegates, multicast delegates, anonymous methods, lambdas, events |
| `03_extension_methods_threads_and_linq` | Extension methods (string reversal, prime numbers, GCD), threads, LINQ queries over lists of students and exams |
| `04_wpf_layouts_and_windows` | First WPF windows, grids and layouts, forms, multi-page apps, a discount calculator, an image viewer |
| `05_wpf_commands_mvvm` | `ICommand` / controller pattern: calculators, double-a-number, text tools, guess-the-number game, music players (`MediaPlayer`, `SoundPlayer`), multi-page app with a dice game and a stamp machine |

Folders ending in `_incomplete` are unfinished exercises that do not compile yet. The music player projects expect an audio/video file that is not included in the repository.

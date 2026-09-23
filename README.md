# StudentCabinetMVVM

Мобільний застосунок «Особистий кабінет студента» на .NET MAUI (патерн MVVM).

## Як запустити (Windows, Visual Studio 2022)

1. Встановити **Visual Studio 2022** (безкоштовна Community-версія): https://visualstudio.microsoft.com/
2. При встановленні у списку компонентів (Workloads) відмітити **".NET Multi-platform App UI development"** (.NET MAUI).
3. Відкрити файл `StudentCabinetMVVM.csproj` у Visual Studio (Файл → Відкрити → Проєкт/Рішення).
4. У верхній панелі поруч із кнопкою запуску вибрати ціль **Windows Machine**.
5. Натиснути **F5** (або кнопку "▶ Windows Machine") — застосунок збереться і запуститься.

Якщо потрібен запуск на Android-емуляторі — у тому ж списку цілей вибрати відповідний Android-емулятор (Visual Studio запропонує встановити його автоматично, якщо потрібно).

## Структура проєкту

- `Models/Student.cs` — модель даних студента
- `ViewModels/StudentViewModel.cs`, `ViewModels/RelayCommand.cs` — ViewModel з `INotifyPropertyChanged` та `ICommand`
- `Converters/HighScoreColorConverter.cs` — конвертер для кольорової індикації середнього балу
- `MainPage.xaml` / `MainPage.xaml.cs` — View з Data Binding (TwoWay/OneWay) та `CollectionView`

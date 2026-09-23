using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using StudentCabinetMVVM.Models;

namespace StudentCabinetMVVM.ViewModels;

public class StudentViewModel : INotifyPropertyChanged
{
    private Student _student = new();

    public string FullName
    {
        get => _student.FullName;
        set
        {
            if (_student.FullName != value)
            {
                _student.FullName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Greeting));
                ((RelayCommand)AddStudentCommand).RaiseCanExecuteChanged();
            }
        }
    }

    public string Group
    {
        get => _student.Group;
        set
        {
            if (_student.Group != value)
            {
                _student.Group = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Greeting));
            }
        }
    }

    public double AverageScore
    {
        get => _student.AverageScore;
        set
        {
            if (_student.AverageScore != value)
            {
                _student.AverageScore = value;
                OnPropertyChanged();
            }
        }
    }

    public string Greeting => $"Студент: {FullName}, група {Group}";

    public ObservableCollection<Student> Students { get; } = new();

    public ICommand AddStudentCommand { get; }

    public StudentViewModel()
    {
        AddStudentCommand = new RelayCommand(AddStudent, CanAddStudent);
    }

    private void AddStudent()
    {
        Students.Add(new Student
        {
            FullName = FullName,
            Group = Group,
            AverageScore = AverageScore
        });

        FullName = string.Empty;
        Group = string.Empty;
        AverageScore = 0;
    }

    private bool CanAddStudent() => !string.IsNullOrWhiteSpace(FullName);

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}

using System.Windows;

namespace FirstWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Student student = new Student
            {
                Name = "Islam",
                Surname = "Turmakhan",
                Age = 16,
                Group = "SDP-181"
            };

            nameLabel.Content = student.Name;
            surnameLabel.Content = student.Surname;
            ageLabel.Content = student.Age;
            groupLabel.Content = student.Group;
        }
    }
}

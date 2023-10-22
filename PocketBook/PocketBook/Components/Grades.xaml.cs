using PocketBook.ViewModel;

namespace PocketBook.Components;

public partial class Grades : ContentView
{

    public static readonly BindableProperty GradeProperty = BindableProperty.Create(nameof(Grade), typeof(int), typeof(Grades), null);

    List<StarViewModel> Stars { get; set; }

    public int Grade
    {
        get => (int)GetValue(Grades.GradeProperty);
        set => SetValue(Grades.GradeProperty, value);
    }
    public Grades()
	{
        Stars = new List<StarViewModel>();
        InitializeComponent();
        for (int i = 0; i < 5; i++)
        {
            if (i < Grade)
            {
                Stars.Add(new StarViewModel(i, "yellow"));
            }
            else
            {
                Stars.Add(new StarViewModel(i, "lightGray"));
            }
        }

        collectionView.ItemsSource = Stars;
	}
}
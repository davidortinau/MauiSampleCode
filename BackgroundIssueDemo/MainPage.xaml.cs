namespace BackgroundIssueDemo;

public partial class MainPage : ContentPage
{
    public List<int> DataList { get; set; }

	public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        DataList = new();

        for(int i = 1; i <= 100; i++)
        {
            DataList.Add(i);
        }

        BindingContext = this;
    }
}



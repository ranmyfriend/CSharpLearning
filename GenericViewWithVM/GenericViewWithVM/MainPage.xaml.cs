using GenericViewWithVM.DynamicView;

namespace GenericViewWithVM;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		var page = new GenericView<LoginPage,LoginPageViewModel>();
		//viewPage instance
		//viewModel instance
		page.ViewModel.Name = "Hello";
		Console.WriteLine("Page:",page);
		DisplayGenericModelOutput();
	}

	// A, B, C

	//new A()

	private void DisplayGenericModelOutput()
	{
		DynamicView<Apple> apple = new DynamicView<Apple>();
        DynamicView<Orange> orange = new DynamicView<Orange>();
        DynamicView<PineApple> pineApple = new DynamicView<PineApple>();
		DynamicView<Sharmila> sharmila = new DynamicView<Sharmila>();

        List<object> fruits = [
			apple.Instance.Name,
		orange.Instance.Name,
		pineApple.Instance.Name];

        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
	}
	

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


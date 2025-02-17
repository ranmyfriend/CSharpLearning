namespace GenericViewWithVM;


//appple getter
// can be accessed only for apple

//

public class GenericView<TPage, TPageViewModel> : ContentPage
     where TPage : IPageView, new()
     where TPageViewModel : IPageViewModel, new()
{
    public TPage View { get; private set; }
    public TPageViewModel ViewModel { get; private set; }

    public GenericView()
    {
        ViewModel = new TPageViewModel();
        View = new TPage();
        BindingContext = ViewModel;
    }

    public void Display()
    {
        Console.WriteLine($"Displaying view with ViewModel: {ViewModel.GetType().Name}");
    }
}
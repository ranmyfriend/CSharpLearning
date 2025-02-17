using System;

namespace GenericViewWithVM;

public interface IPageViewModel { }

public class LoginPageViewModel: IPageViewModel
{

    public string Name { get; set; }
}

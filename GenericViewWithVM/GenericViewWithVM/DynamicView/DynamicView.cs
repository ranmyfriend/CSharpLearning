using System;
using GenericViewWithVM.DynamicView;

namespace GenericViewWithVM;

public class DynamicView<TInstance> where TInstance : IInstance, new()
{
    public TInstance Instance;

    public DynamicView()
    {
        Instance = new TInstance();
    }
}

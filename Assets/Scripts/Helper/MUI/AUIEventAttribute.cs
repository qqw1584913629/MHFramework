using System;

[AttributeUsage(AttributeTargets.Class)]
public class AUIEventAttribute: BaseAttribute
{
    public WindowID WindowID
    {
        get;
    }

    public AUIEventAttribute(WindowID windowID)
    {
        this.WindowID = windowID;
    }
}
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class BaseAttribute: Attribute
{
		
}
public class ExampleClass{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized yet will cause an error
        int x = MyProperty; //Uncommon error: accessing an uninitialized property
    }
}
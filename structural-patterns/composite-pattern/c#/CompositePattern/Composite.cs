
// Composite
class Composite : Component
{
    private List<Component> _children = new List<Component>();

    public Composite(string name) : base(name) { }

    public void Add(Component component)
    {
        _children.Add(component);
    }

    public void Remove(Component component)
    {
        _children.Remove(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + Name);

        foreach (Component component in _children)
        {
            component.Display(depth + 2);
        }
    }
}

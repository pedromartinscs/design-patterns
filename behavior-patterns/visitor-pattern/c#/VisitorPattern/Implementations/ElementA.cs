
// Concrete Element A
public class ElementA : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

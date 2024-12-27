namespace TemplateMethodPattern
{
    abstract class AbstractClass
    {
        // Template method
        public void TemplateMethod()
        {
            BaseOperation1();
            RequiredOperation1();
            BaseOperation2();
            RequiredOperation2();
            Hook1();
            BaseOperation3();
            Hook2();
        }

        // These operations already have implementations.
        protected void BaseOperation1() => Console.WriteLine("AbstractClass says: I am doing the bulk of the work");
        protected void BaseOperation2() => Console.WriteLine("AbstractClass says: But I let subclasses override some operations");
        protected void BaseOperation3() => Console.WriteLine("AbstractClass says: But I am doing the bulk of the work anyway");

        // These operations have to be implemented in subclasses.
        protected abstract void RequiredOperation1();
        protected abstract void RequiredOperation2();

        // These are "hooks." Subclasses may override them, but it's not mandatory since the hooks already have default (but empty) implementation.
        protected virtual void Hook1() { }
        protected virtual void Hook2() { }
    }
}
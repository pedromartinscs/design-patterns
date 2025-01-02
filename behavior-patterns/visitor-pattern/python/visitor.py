class Element:
    def accept(self, visitor):
        pass

class ConcreteElementA(Element):
    def accept(self, visitor):
        visitor.visit_concrete_element_a(self)

    def operation_a(self):
        return "ConcreteElementA"

class ConcreteElementB(Element):
    def accept(self, visitor):
        visitor.visit_concrete_element_b(self)

    def operation_b(self):
        return "ConcreteElementB"

class Visitor:
    def visit_concrete_element_a(self, element):
        pass

    def visit_concrete_element_b(self, element):
        pass

class ConcreteVisitor1(Visitor):
    def visit_concrete_element_a(self, element):
        print(f"{element.operation_a()} visited by ConcreteVisitor1")

    def visit_concrete_element_b(self, element):
        print(f"{element.operation_b()} visited by ConcreteVisitor1")

class ConcreteVisitor2(Visitor):
    def visit_concrete_element_a(self, element):
        print(f"{element.operation_a()} visited by ConcreteVisitor2")

    def visit_concrete_element_b(self, element):
        print(f"{element.operation_b()} visited by ConcreteVisitor2")

if __name__ == "__main__":
    elements = [ConcreteElementA(), ConcreteElementB()]
    visitors = [ConcreteVisitor1(), ConcreteVisitor2()]

    for element in elements:
        for visitor in visitors:
            element.accept(visitor)
class State:
    def handle(self, context):
        raise NotImplementedError("Subclasses must implement this method")

class ConcreteStateA(State):
    def __init__(self):
        print("Transitioning to state A")

    def handle(self, context):
        print("State A handling request")

class ConcreteStateB(State):
    def __init__(self):
        print("Transitioning to state B")

    def handle(self, context):
        print("State B handling request")

class Context:
    def __init__(self, state: State):
        self.state = state

    def request(self):
        self.state.handle(self)
    
    def change_state(self, state: State):
        self.state = state

if __name__ == "__main__":
    initial_state = ConcreteStateA()
    context = Context(initial_state)
    
    context.request()                       # State A handling request
    context.request()                       # State A handling request again
    context.change_state(ConcreteStateB())  # Transitioning to state B
    context.request()                       # State B handling request
    context.change_state(ConcreteStateA())  # Transitioning to state A
    context.request()                       # State A handling request
    context.change_state(ConcreteStateB())  # Transitioning to state B
    context.request()                       # State B handling request
    context.request()                       # State B handling request again
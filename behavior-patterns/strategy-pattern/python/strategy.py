from abc import ABC, abstractmethod

# Strategy Interface
class Strategy(ABC):
    @abstractmethod
    def execute(self, data):
        pass

# Concrete Strategies
class ConcreteStrategyA(Strategy):
    def execute(self, data):
        return f"Strategy A: {data}"

class ConcreteStrategyB(Strategy):
    def execute(self, data):
        return f"Strategy B: {data}"

# Context
class Context:
    def __init__(self, strategy: Strategy):
        self._strategy = strategy
        print("Starting with strategy " + self._strategy.__class__.__name__)

    def set_strategy(self, strategy: Strategy):
        self._strategy = strategy
        print("Changing strategy to " + self._strategy.__class__.__name__)

    def execute_strategy(self, data):
        return self._strategy.execute(data)

# Usage
if __name__ == "__main__":
    context = Context(ConcreteStrategyA())
    print(context.execute_strategy("data"))

    context.set_strategy(ConcreteStrategyB())
    print(context.execute_strategy("data"))
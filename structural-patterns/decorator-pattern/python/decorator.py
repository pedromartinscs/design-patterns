from functools import wraps

# Component Interface
class Coffee:
    def cost(self):
        pass

# Concrete Component
class SimpleCoffee(Coffee):
    def cost(self):
        return 5

# Decorator
class CoffeeDecorator(Coffee):
    def __init__(self, coffee):
        self._coffee = coffee

    def cost(self):
        return self._coffee.cost()

# Concrete Decorators
class MilkDecorator(CoffeeDecorator):
    def __init__(self, coffee):
        super().__init__(coffee)

    def cost(self):
        return self._coffee.cost() + 2

class SugarDecorator(CoffeeDecorator):
    def __init__(self, coffee):
        super().__init__(coffee)

    def cost(self):
        return self._coffee.cost() + 1

# Usage
if __name__ == "__main__":
    my_coffee = SimpleCoffee()
    print(f"Cost of simple coffee: {my_coffee.cost()}")

    my_coffee_with_milk = MilkDecorator(my_coffee)
    print(f"Cost of coffee with milk: {my_coffee_with_milk.cost()}")

    my_coffee_with_milk_and_sugar = SugarDecorator(my_coffee_with_milk)
    print(f"Cost of coffee with milk and sugar: {my_coffee_with_milk_and_sugar.cost()}")
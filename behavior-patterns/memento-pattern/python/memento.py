"""
Memento Pattern

The Memento Pattern is a behavioral design pattern that allows an object to save its state so that it can be restored later. 
This pattern involves three main components:

1. Memento: This class stores the internal state of the Originator object. It provides a way to retrieve the stored state.
2. Originator: This class creates a Memento containing a snapshot of its current state and uses the Memento to restore its state.
3. Caretaker: This class is responsible for keeping track of the Memento objects. It can store and retrieve Mementos as needed.

In this example, the Originator class represents an object whose state needs to be saved and restored. 
The Caretaker class manages the saved states (Mementos) and can retrieve them when needed.
"""


class Memento:
    def __init__(self, state):
        self._state = state

    def get_state(self):
        return self._state


class Originator:
    def __init__(self):
        self._state = None

    def set_state(self, state):
        print(f"Setting state to {state}")
        self._state = state

    def get_state(self):
        return self._state

    def save_state_to_memento(self):
        print(f"Saving state to memento: {self._state}")
        return Memento(self._state)

    def get_state_from_memento(self, memento):
        self._state = memento.get_state()
        print(f"State restored from memento: {self._state}")


class Caretaker:
    def __init__(self):
        self._memento_list = []

    def add(self, state):
        self._memento_list.append(state)

    def get(self, index):
        return self._memento_list[index]


if __name__ == "__main__":
    originator = Originator()
    caretaker = Caretaker()

    originator.set_state("State #1")
    originator.set_state("State #2")
    caretaker.add(originator.save_state_to_memento())

    originator.set_state("State #3")
    caretaker.add(originator.save_state_to_memento())

    originator.set_state("State #4")

    print("Current State: " + originator.get_state())
    originator.get_state_from_memento(caretaker.get(0))
    print("First saved State: " + originator.get_state())
    originator.get_state_from_memento(caretaker.get(1))
    print("Second saved State: " + originator.get_state())
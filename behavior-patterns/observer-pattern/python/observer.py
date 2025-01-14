class Subject:
    def __init__(self):
        self._observers = []

    def attach(self, observer):
        if observer not in self._observers:
            self._observers.append(observer)

    def detach(self, observer):
        try:
            self._observers.remove(observer)
        except ValueError:
            pass

    def notify(self, message):
        for observer in self._observers:
            observer.update(message)


class Observer:
    def update(self, message):
        pass


class ConcreteObserver(Observer):
    def __init__(self, name):
        self._name = name

    def update(self, message):
        print(f'{self._name} received message: {message}')


if __name__ == "__main__":
    subject = Subject()

    observer1 = ConcreteObserver("Observer 1")
    observer2 = ConcreteObserver("Observer 2")

    subject.attach(observer1)
    subject.attach(observer2)

    subject.notify("Hello Observers!")

    subject.detach(observer1)

    subject.notify("Observer 1 has been detached.")
class Handler:
    def __init__(self, successor=None):
        self._successor = successor

    def handle(self, request):
        if self._successor:
            self._successor.handle(request)


class ConcreteHandler1(Handler):
    def handle(self, request):
        if request == "Request1":
            print("ConcreteHandler1 handled the request")
        else:
            super().handle(request)


class ConcreteHandler2(Handler):
    def handle(self, request):
        if request == "Request2":
            print("ConcreteHandler2 handled the request")
        else:
            super().handle(request)


class ConcreteHandler3(Handler):
    def handle(self, request):
        if request == "Request3":
            print("ConcreteHandler3 handled the request")
        else:
            super().handle(request)


if __name__ == "__main__":
    handler_chain = ConcreteHandler1(ConcreteHandler2(ConcreteHandler3()))

    requests = ["Request1", "Request2", "Request3", "UnknownRequest"]
    for request in requests:
        handler_chain.handle(request)
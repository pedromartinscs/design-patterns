class Iterator:
    def __init__(self, collection):
        self._collection = collection
        self._index = 0

    def __has_next__(self):
        return self._index < len(self._collection)

    def __next__(self):
        result = self._collection[self._index]
        self._index += 1
        return result

    def __iter__(self):
        return self

class Collection:
    def __init__(self):
        self._items = []

    def add_item(self, item):
        self._items.append(item)

    def __iter__(self):
        return Iterator(self._items)

if __name__ == "__main__":
    collection = Collection()
    collection.add_item(1)
    collection.add_item(2)
    collection.add_item(3)

    iterator = collection.__iter__()
    while iterator.__has_next__():
        print(iterator.__next__())
import random


class StringHandler:

    def sort_by_length(self, data, reverse: bool = False) -> None:
        data.sort(key=len, reverse=reverse)

    def sort_strings(self, data, reverse: bool = False) -> None:
        data.sort(reverse=reverse)

    def shuffle(self, data):
        random.shuffle(data, random.random)

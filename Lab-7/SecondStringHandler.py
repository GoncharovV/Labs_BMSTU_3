import random
from typing import List


class StringHandler:

    def __init__(self, input_file_path: str, output_file_path):
        self.data = self.__read_file(input_file_path)
        self.output_file_path = output_file_path

    def __read_file(self, file_path: str) -> List[str]:
        file = open(file_path, 'r')
        data = file.readlines()
        file.close()
        return data

    def sort_by_length(self, reverse: bool = False) -> None:
        self.data.sort(key=len, reverse=reverse)

    def sort_strings(self, reverse: bool = False) -> None:
        self.data.sort(reverse=reverse)

    def shuffle(self):
        random.shuffle(self.data, random.random)

    def write_file(self) -> None:
        print(*self.data)
        file = open(self.output_file_path, 'w')
        file.writelines(self.data)
        file.close()

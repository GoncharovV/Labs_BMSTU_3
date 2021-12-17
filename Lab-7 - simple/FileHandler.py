import random


class FileHandler:

    def __init__(self, input_file_path, output_file_path):
        self.read_file(input_file_path)
        self.output_file_path = output_file_path

    def read_file(self, file_path: str):
        file = open(file_path, 'r')
        self.data = file.readlines()
        file.close()

    def write_data_to_file(self):
        file = open(self.output_file_path, 'w')
        file.writelines(self.data)
        file.close()

    def shuffle(self):
        for i in range(20):
            inx1 = random.randint(0, len(self.data) - 1)
            inx2 = random.randint(0, len(self.data) - 1)

            temp = self.data[inx1]
            self.data[inx1] = self.data[inx2]
            self.data[inx2] = temp

    def sort_strings(self):
        self.data.sort()

    def sort_strings_reverse(self):
        self.data.sort(reverse=True)

    def sort_by_len(self):
        self.data.sort(key=len) # "abc" -> 3, "abcd" -> 4 ,   3,4

    def sort_by_len_reverse(self):
        self.data.sort(key=len, reverse=True) #4, 3 -> "abcd", "abc"



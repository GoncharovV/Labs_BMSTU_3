from FileHandler import FileHandler
import sys

if __name__ == '__main__':

    read_from_file = ""
    write_to_file = ""

    print(sys.argv)

    if len(sys.argv) == 3:
        read_from_file = sys.argv[1]
        write_to_file = sys.argv[2]
    else:
        read_from_file = input('Введите путь к файлу из которого читать: ')
        write_to_file = input('Введите путь к файлу в который записать:  ')

    print('Нажмите 1 чтобы отсортировать по буквам')
    print('Нажмите 2 чтобы отсортировать по буквам РЕВЕРС')
    print('Нажмите 3 чтобы отсортировать по длине')
    print('Нажмите 4 чтобы отсортировать по длине РЕВЕРС')
    print('Нажмите 5 чтобы перемешать')

    code = int(input())

    handler = FileHandler(read_from_file, write_to_file)

    if code == 1:
        handler.sort_strings()
    elif code == 2:
        handler.sort_strings_reverse()
    elif code == 3:
        handler.sort_by_len()
    elif code == 4:
        handler.sort_by_len_reverse()
    elif code == 5:
        handler.shuffle()
    else:
        print('Неверный код')

    handler.write_data_to_file()

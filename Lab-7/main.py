from StringHandler import StringHandler
import sys
from typing import List
from enum import Enum



class OperationCodes(Enum):
    SORT_STRINGS = 1
    SORT_STRINGS_REVERSE = 2
    SORT_BY_LENGTH = 3
    SORT_BY_LENGTH_REVERSE = 4
    SHUFFLE = 5

message = f"""
Select operation:
    Sort strings - ({OperationCodes.SORT_STRINGS.value})
    Sort strings reverse - ({OperationCodes.SORT_STRINGS_REVERSE.value})
    Sort by length - ({OperationCodes.SORT_BY_LENGTH.value})
    Sort by length reverse - ({OperationCodes.SORT_BY_LENGTH_REVERSE.value})
    Shuffle - ({OperationCodes.SHUFFLE.value})
    """


def read_file(file_path: str) -> List[str]:
    file = open(file_path, 'r')
    data = file.readlines()
    file.close()
    return data


def write_file(file_path, data) -> None:
    file = open(file_path, 'w')
    file.writelines(data)
    file.close()

if __name__ == '__main__':

    input_file_path = 'input.txt'
    output_file_path = 'output.txt'
    code = 0

    if len(sys.argv) == 4:
        input_file_path = sys.argv[1]
        output_file_path = sys.argv[2]
        code = OperationCodes(int(sys.argv[3]))
    else:
        print(message)
        code = OperationCodes(int(input()))

    data = read_file(input_file_path)

    opener = StringHandler()

    match code:
        case OperationCodes.SORT_BY_LENGTH:
            opener.sort_by_length(data, False)
        case OperationCodes.SORT_BY_LENGTH_REVERSE:
            opener.sort_by_length(data, True)
        case OperationCodes.SORT_STRINGS:
            opener.sort_strings(data, False)
        case OperationCodes.SORT_STRINGS_REVERSE:
            opener.sort_strings(data, True)
        case OperationCodes.SHUFFLE:
            opener.shuffle(data)
        case _:
            print('Wrong code')

    write_file(output_file_path, data)
    print(data)

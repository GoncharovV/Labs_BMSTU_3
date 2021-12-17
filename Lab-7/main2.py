from SecondStringHandler import StringHandler
import sys
from enum import Enum
from main import message


class OperationCodes(Enum):
    SORT_STRINGS = 1
    SORT_STRINGS_REVERSE = 2
    SORT_BY_LENGTH = 3
    SORT_BY_LENGTH_REVERSE = 4
    SHUFFLE = 5


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

    opener = StringHandler(input_file_path, output_file_path)

    match code:
        case OperationCodes.SORT_BY_LENGTH:
            opener.sort_by_length(False)
        case OperationCodes.SORT_BY_LENGTH_REVERSE:
            opener.sort_by_length(True)
        case OperationCodes.SORT_STRINGS:
            opener.sort_strings(False)
        case OperationCodes.SORT_STRINGS_REVERSE:
            opener.sort_strings(True)
        case OperationCodes.SHUFFLE:
            opener.shuffle()
        case _:
            print('Wrong code')

    opener.write_file()

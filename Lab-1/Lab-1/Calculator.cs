using System;

namespace Lab_1
{
    class Calculator
    {
        private readonly string[] _operands = { "", "" };
        private int _selectedOperand = 0;

        private string _memorizedValue = "";

        private Operations? _selectedOperation = null;

        public delegate void CalculatorEventHandler(string value);

        public event CalculatorEventHandler CalculatorValueChanged;
        public event CalculatorEventHandler CalculatorErrorOccrued;

        public enum Operations
        {
            Plus,
            Subtract,
            Multiply,
            Divide
        }

        public void ProcessNumber(int number)
        {
            if (_operands[_selectedOperand] == "0")
            {
                AddDot();
            }

            _operands[_selectedOperand] += number.ToString();
            CalculatorValueChanged.Invoke(_operands[_selectedOperand]);
        }

        public void ProcessOperation(Operations operation)
        {
            if (operation == Operations.Subtract && _operands[_selectedOperand] == "")
            {
                _operands[_selectedOperand] += "-";
                CalculatorValueChanged.Invoke(_operands[_selectedOperand]);
                return;
            }


            if (_operands[0] == "")
            {
                CalculatorErrorOccrued.Invoke("Первый операнд не указан");
                return;
            }

            if (_operands[1] != "")
            {
                Calc();
            }

            _selectedOperation = operation;

            _selectedOperand = 1;

            CalculatorValueChanged.Invoke("");
        }

        public void AddDot()
        {
            if (!_operands[_selectedOperand].Contains(","))
            {
                _operands[_selectedOperand] += ",";
            }

            CalculatorValueChanged.Invoke(_operands[_selectedOperand]);
        }

        public void Calc()
        {
            if (_operands[1] == "")
            {
                CalculatorErrorOccrued.Invoke("Второй операнд не указан");
                return;
            }

            float result;

            switch (_selectedOperation)
            {
                case Operations.Plus:
                    result = float.Parse(_operands[0]) + float.Parse(_operands[1]);
                    break;
                case Operations.Subtract:
                    result = float.Parse(_operands[0]) - float.Parse(_operands[1]);
                    break;
                case Operations.Multiply: 
                    result = float.Parse(_operands[0]) * float.Parse(_operands[1]);
                    break;
                case Operations.Divide:
                    if (float.Parse(_operands[1]) == 0)
                    {
                        CalculatorErrorOccrued.Invoke("Деление на ноль невозможно");
                        return;
                    }
                    result = float.Parse(_operands[0]) / float.Parse(_operands[1]);
                    break;
                default:
                    CalculatorErrorOccrued.Invoke("Операция не выбрана");
                    return;
            }

            _operands[0] = result.ToString();
            _operands[1] = "";
            _selectedOperation = null;
            _selectedOperand = 0;

            CalculatorValueChanged.Invoke(result.ToString());
        }

        public void Clear()
        {
            _operands[0] = "";
            _operands[1] = "";

            _selectedOperation = null;
            _selectedOperand = 0;

            CalculatorValueChanged.Invoke("");
        }

        public void Backspace()
        {
            if (_operands[_selectedOperand] == "")
            {
                return;
            }

            _operands[_selectedOperand] =
                _operands[_selectedOperand]
                .Substring(0, _operands[_selectedOperand].Length - 1);

            CalculatorValueChanged.Invoke(_operands[_selectedOperand]);
        }

        public void Sqrt()
        {
            if (_operands[1] != "")
            {
                CalculatorErrorOccrued.Invoke("Невозможно выполнить операцию. Очистите калькулятор");
                return;
            }

            float value = float.Parse(_operands[0]);

            if (value < 0)
            {
                CalculatorErrorOccrued.Invoke("Невозможно извлечь корень из отрицательного числа");
                return;
            }

            _operands[0] = Math.Sqrt(value).ToString();

            _selectedOperand = 0;
            _selectedOperation = null;

            CalculatorValueChanged.Invoke(_operands[0]);
        }

        public void AddToMemory ()
        {
            _memorizedValue = _operands[_selectedOperand];
        }

        public void GetFromMemory()
        {
            if (_memorizedValue == "")
            {
                CalculatorErrorOccrued.Invoke("Память пуста");
                return;
            }

            _operands[_selectedOperand] = _memorizedValue;
            CalculatorValueChanged.Invoke(_operands[_selectedOperand]);
        }

        public void ClearMemory()
        {
            _memorizedValue = "";
        }
    }
}
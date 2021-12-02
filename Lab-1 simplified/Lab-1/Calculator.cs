using System;

namespace Lab_1
{
    class Calculator
    {
        private string[] nums = { "", "" };
        private int selectedNumIndex = 0;

        private string selectedOperation;

        private string memory = "";

        public string ProcessNumber(int number)
        {
            if (nums[selectedNumIndex] == "0")
            {
                 AddDot();
            }

            nums[selectedNumIndex] += number.ToString();
            return nums[selectedNumIndex];
        }

        public string ProcessOperation(string operation)
        {
            if (operation == "-" && nums[selectedNumIndex] == "")
            {
                nums[selectedNumIndex] += "-";
                return nums[selectedNumIndex];
            }


            if (nums[0] == "")
            {
                return ("Первый операнд не указан");
            }

            if (nums[1] != "")
            {
                Calc();
            }

            selectedOperation = operation;

            selectedNumIndex = 1;

            return operation;
        }

        public string AddDot()
        {
            if (!nums[selectedNumIndex].Contains(",") && nums[selectedNumIndex] != "")
            {
                nums[selectedNumIndex] += ",";
            }

            return (nums[selectedNumIndex]);
        }

        public string Calc()
        {
            if (nums[1] == "")
            {
                return ("Второй операнд не указан");
            }

            float result = 0;

            switch (selectedOperation)
            { 
                case "+":
                    result = float.Parse(nums[0]) + float.Parse(nums[1]);
                    break;
                case "-":
                    result = float.Parse(nums[0]) - float.Parse(nums[1]);
                    break;
                case "*": 
                    result = float.Parse(nums[0]) * float.Parse(nums[1]);
                    break;
                case "/":
                    if (float.Parse(nums[1]) == 0)
                    {
                       return ("Деление на ноль невозможно");
                    }
                    result = float.Parse(nums[0]) / float.Parse(nums[1]);
                    break;
            }

            nums[0] = result.ToString();
            nums[1] = "";
            selectedOperation = "";
            selectedNumIndex = 0;

            return result.ToString();
        }

        public string Clear()
        {
            nums[0] = "";
            nums[1] = "";

            selectedOperation = null;
            selectedNumIndex = 0;

            return "";
        }

        public string Backspace()
        {
            if (nums[selectedNumIndex] == "")
            {
                return "";
            }

            nums[selectedNumIndex] =
                nums[selectedNumIndex]
                .Substring(0, nums[selectedNumIndex].Length - 1);

            return nums[selectedNumIndex];
        }

        public string Sqrt()
        {
            if (nums[1] != "")
            {
                return "Невозможно выполнить операцию. Очистите калькулятор";
            }

            float value = float.Parse(nums[0]);

            if (value < 0)
            {
                return "Невозможно извлечь корень из отрицательного числа";
            }

            nums[0] = Math.Sqrt(value).ToString();

            selectedNumIndex = 0;
            selectedOperation = null;

            return nums[0];
        }

        public void AddToMemory ()
        {
            memory = nums[selectedNumIndex];
        }

        public string GetFromMemory()
        {
            if (memory == "")
            {
                return "Память пуста";
            }

            nums[selectedNumIndex] = memory;
            return (nums[selectedNumIndex]);
        }

        public void ClearMemory()
        {
            memory = "";
        }
    }
}
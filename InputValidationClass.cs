using System.Text.RegularExpressions;

namespace InputValidation
{
     class Validation
     {
        //using InputValidation; above class, below namespace
        //string input = "";
        //Validation newValidation = new Validation()

        //mainValidation.___Validation("Please enter ...:\t);

        private string _input;
        public Validation() //string input
        {
            
        }

        public string StringValidation(string prompt)
        {
            do
            {
                Console.Write(prompt);
                _input = Console.ReadLine();
                if(!string.IsNullOrEmpty(_input))
                {
                    break;
                }
                Console.WriteLine("\tInvalid input, please enter something\n");
            }while (true);
            return _input;
        }
        public string StringLettersValidation(string prompt)
        {
            do
            {
                Console.Write(prompt);
                _input = Console.ReadLine();
                if (!string.IsNullOrEmpty(_input) && Regex.IsMatch(_input, @"^[a-z,A-Z]+$"))
                {
                    break;
                }
                Console.WriteLine("\tInvalid input, please enter letters only\n");
            } while (true);
            return _input;
        }
        public string StringSmallLettersValidation(string prompt)
        {
            do
            {
                Console.Write(prompt);
                _input = Console.ReadLine();
                if (!string.IsNullOrEmpty(_input) && Regex.IsMatch(_input, @"^[a-z]+$"))
                {
                    break;
                }
                Console.WriteLine("\tInvalid input, please enter lower case letter only\n");
            } while (true);
            return _input;
        }
        public string StringUpperLettersValidation(string prompt)
        {
            do
            {
                Console.Write(prompt);
                _input = Console.ReadLine();
                if (!string.IsNullOrEmpty(_input) && Regex.IsMatch(_input, @"^[A-Z]+$"))
                {
                    break;
                }
                Console.WriteLine("\tInvalid input, please enter capitalized letters only\n");
            } while (true);
            return _input;
        }
        public string StringNumValidation(string prompt)
        {
            do
            {
                Console.Write(prompt);
                _input = Console.ReadLine();
                if (!string.IsNullOrEmpty(_input) && Regex.IsMatch(_input, @"^[0-9]+$"))
                {
                    break;
                }
                Console.WriteLine("\tInvalid input, please enter numbers only\n");
            } while (true);
            return _input;
        }
        public int IntValidation(string prompt)
        {
            int num;
            do
            {
                Console.Write(prompt);
                _input = Console.ReadLine();
                if (int.TryParse(_input, out num))
                {
                    break;
                }
                Console.WriteLine("\tInvalid input, please enter an integer\n");
            } while (true);
            return num;
        }
        public int IntPositiveValidation(string prompt)
        {
            int num;
            do
            {
                Console.Write(prompt);
                _input = Console.ReadLine();
                if (int.TryParse(_input, out num) && num > 0)
                {
                    break;
                }
                Console.WriteLine("\tInvalid input, please enter a positive integer\n");
            } while (true);
            return num;
        }
        public int IntNegativeValidation(string prompt)
        {
            int num;
            do
            {
                Console.Write(prompt);
                _input = Console.ReadLine();
                if (int.TryParse(_input, out num) && num < 0)
                {
                    break;
                }
                Console.WriteLine("\tInvalid input, please enter a negative integer\n");
            } while (true);
            return num;
        }
        public double DoubleValidation(string prompt)
        {
            double num = 0;
            do
            {
                Console.Write(prompt);
                _input = Console.ReadLine();
                if (double.TryParse(_input, out num))
                {
                    break;
                }
                Console.WriteLine("\tInvalid input, please enter a rational number\n");
            } while (true);
            return Math.Round(num, 2);
        }
        public double DoublePositiveValidation(string prompt)
        {
            double num = 0;
            do
            {
                Console.Write(prompt);
                _input = Console.ReadLine();
                if (double.TryParse(_input, out num) && num > 0)
                {
                    break;
                }
                Console.WriteLine("\tInvalid input, please enter a positve rational number\n");
            } while (true);
            return Math.Round(num, 2);
        }
        public double DoubleNegativeValidation(string prompt)
        {
            double num = 0;
            do
            {
                Console.Write(prompt);
                _input = Console.ReadLine();
                if (double.TryParse(_input, out num) && num < 0)
                {
                    break;
                }
                Console.WriteLine("\tInvalid input, please enter a negative rational number\n");
            } while (true);
            return Math.Round(num, 2);
        }
        public double DoubleWholeValidation(string prompt)
        {
            double num = 0;
            do
            {
                Console.Write(prompt);
                _input = Console.ReadLine();
                if (double.TryParse(_input, out num))
                {
                    
                    break;
                }
                Console.WriteLine("\tInvalid input, please enter a rational number\n");
            } while (true);
            return Math.Round(num);
        }
        public double DoubleWholePositveValidation(string prompt)
        {
            double num = 0;
            do
            {
                Console.Write(prompt);
                _input = Console.ReadLine();
                if (double.TryParse(_input, out num) && num > 0)
                {
                    break;
                }
                Console.WriteLine("\tInvalid input, please enter a positve rational number\n");
            } while (true);
            return Math.Round(num);
        }
        public double DoubleWholeNegativeValidation(string prompt)
        {
            double num = 0;
            do
            {
                Console.Write(prompt);
                _input = Console.ReadLine();
                if (double.TryParse(_input, out num) && num < 0)
                {
                    break;
                }
                Console.WriteLine("\tInvalid input, please enter a negative rational number\n");
            } while (true);
            return Math.Round(num);
        }
        public float FloatValidation(string prompt)
        {
            float num = 0;
            do
            {
                Console.Write(prompt);
                _input = Console.ReadLine();
                if (float.TryParse(_input, out num))
                {
                    break;
                }
                Console.WriteLine("Please enter a valid input");
            } while (true);
            return num;
        }
     }
}
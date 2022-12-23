namespace EncryptoDecryptFuncs
{
    public class Class1
    {
        public char Encrypt(char input)
        {
            if (Char.IsDigit(input))
            {
                return input switch
                {
                    '1' => '!',
                    '2' => '@',
                    '3' => '#',
                    '4' => '$',
                    '5' => '%',
                    '6' => '^',
                    '7' => '&',
                    '8' => '*',
                    '9' => '(',
                    '0' => ')',
                };
            }

            if (Char.IsUpper(input)) return Char.ToLower(input);

            return char.ToUpper(input);
        }

        public char Decrypt(char input)
        {
            var numbers = new Dictionary<char, char>()
            {
                 {'!', '1'},
                 {'@', '2'},
                 {'#', '3'},
                 {'$', '4'},
                 {'%', '5'},
                 {'^', '6'},
                 {'&', '7'},
                 {'*', '8'},
                 {'(', '9'},
                 {')', '0'},
            };

            if (numbers.ContainsKey(input))
            {
                return numbers[input];
            }

            if (Char.IsUpper(input)) return Char.ToLower(input);

            return char.ToUpper(input);
        }
    }
}
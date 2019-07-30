using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    public enum SignCompare
    {
        MoreThan = 0,
        LessThan = 1,
        Equal = 2
    }

    public static class Compute
    {
        private static readonly char[] _Signs = new char[] { '+', '-', '*', '/', '(', ')' };

        public static int Run(string expression)
        {
            if (string.IsNullOrEmpty(expression))
            {
                return 0;
            }

            var numbers = new LinkStack<int>();
            var signs = new LinkStack<char>();
            var isLastNumber = false;
            for (int i = 0; i < expression.Length; i++)
            {
                var c = expression[i];
                if (IsSign(c))
                {
                    if (signs.IsEmpty())
                    {
                        signs.Push(c);
                    }
                    else
                    {
                        switch (GetSignCompare(signs.GetTop(), c))
                        {
                            case SignCompare.MoreThan:
                                var right = numbers.Pop();
                                var left = numbers.Pop();
                                var sign = signs.Pop();
                                var number = Count(left, sign, right);
                                numbers.Push(number);
                                i--;
                                break;
                            case SignCompare.LessThan:
                                signs.Push(c);
                                break;
                            case SignCompare.Equal:

                                break;
                        }
                    }
                    isLastNumber = false;
                }
                else
                {
                    var number = int.Parse(c.ToString());
                    if (isLastNumber)
                    {
                        numbers.Push(numbers.Pop() * 10 + number);
                    }
                    else
                    {
                        numbers.Push(number);
                    }
                    isLastNumber = true;
                }

            }
            while (signs.GetLength() > 0)
            {
                var right = numbers.Pop();
                var left = numbers.Pop();
                var sign = signs.Pop();
                var result = Count(left, sign, right);
                numbers.Push(result);
            }
            return numbers.Pop();
        }

        private static bool IsSign(char c)
        {
            return _Signs.Contains(c);
        }

        private static SignCompare GetSignCompare(char left, char right)
        {
            switch (left)
            {
                case '+':
                case '-':
                    if (right == '*' || right == '/')
                    {
                        return SignCompare.LessThan;
                    }
                    else
                    {
                        return SignCompare.MoreThan;
                    }
                case '*':
                case '/':
                    return SignCompare.MoreThan;
                case '(':
                    return SignCompare.MoreThan;
                case ')':
                    return SignCompare.MoreThan;
                default:
                    throw new Exception("Sign error");
            }
        }

        private static int Count(int left, char sign, int right)
        {
            switch (sign)
            {
                case '+':
                    return left + right;
                case '-':
                    return left - right;
                case '*':
                    return left * right;
                case '/':
                    return left / right;
                default:
                    throw new Exception("Error");
            }
        }

    }
}

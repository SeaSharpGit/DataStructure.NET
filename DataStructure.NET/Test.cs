using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DataStructure.NET
{
    public class EvaluateExpression
    {
        private static string Precede(string t1, string t2)    //根据表3.1，判断两符号的优先关系 
        {
            string f = string.Empty;
            switch (t2)
            {
                case "+":
                case "-":
                    if (t1 == "(" || t1 == "#")
                        f = "<";
                    else
                        f = ">";
                    break;

                case "*":
                case "/":
                    if (t1 == "*" || t1 == "/" || t1 == ")")
                        f = ">";
                    else
                        f = "<";
                    break;
                case "(":
                    if (t1 == ")")
                        throw new ArgumentOutOfRangeException("表达式错误");
                    else
                        f = "<";
                    break;
                case ")":
                    switch (t1)
                    {
                        case "(": f = "="; break;
                        case "#": throw new ArgumentOutOfRangeException("表达式错误");
                        default: f = ">"; break;
                    }
                    break;
                case "#":
                    switch (t1)
                    {
                        case "#": f = "="; break;
                        case "(": throw new ArgumentOutOfRangeException("表达式错误");
                        default: f = ">"; break;
                    }
                    break;
            }
            return f;
        }
        private static bool In(string c)    //判断c是否为运算符 
        {
            switch (c)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                case "(":
                case ")":
                case "#": return true;
                default: return false;
            }

        }

        private static int Operate(int a, string oper, int b)
        {
            int c = 0;
            switch (oper)
            {
                case "+": c = a + b; break;
                case "-": c = a - b; break;
                case "*": c = a * b; break;
                case "/": c = a / b; break;
            }
            return c;

        }

        public static int Calculate(string exp)   //算术表达式求值的算符优先算法。设OPTR和OPND分别为运算符栈和运算数栈 
        {

            expr S = new expr(exp);      //将传过来的表达式打包成一个类对象,便于计算
            string C = string.Empty;
            int oper1, oper2;
            string theta = string.Empty;

            Stack OPTR = new Stack();
            OPTR.Push("#");
            Stack OPND = new Stack();
            C = S.GetS();                 //取表达式里的分量    
            while (C != "#" || OPTR.Peek().ToString() != "#")
            {
                if (!In(C))       //不是运算符则进栈
                {
                    OPND.Push(C);
                    C = S.GetS();
                }
                else
                    switch (Precede(OPTR.Peek().ToString(), C))
                    {
                        case "<":         //栈顶元素优先权低
                            OPTR.Push(C);
                            C = S.GetS();
                            break;
                        case "=":       //脱括号并接收下一个字符
                            OPTR.Pop();
                            C = S.GetS();
                            break;
                        case ">":    //退栈并将运算结果入栈
                            theta = OPTR.Pop().ToString();
                            oper2 = Convert.ToInt32(OPND.Pop());
                            oper1 = Convert.ToInt32(OPND.Pop());
                            OPND.Push(Operate(oper1, theta, oper2).ToString());
                            break;
                    }//switch
            }//while
            return Convert.ToInt32(OPND.Peek());

        }

        private class expr       //表达式类, 用于取表达式里的各个分量
        {

            //成员
            private string exp;
            private int length;  //为GetS()方法服务

            //构造器

            public expr(string exp)
            {
                this.exp = exp;
                length = exp.Length;
                if (!IsRight()) { Console.WriteLine("表达式有错"); return; }
            }

            //方法
            public string GetS()          //取表达式里的字符串
            {
                string ch, token, f;
                ch = token = f = string.Empty;

                if (length == 0)
                    throw new ArgumentOutOfRangeException("表达式取完");

                while (length != 0)
                {
                    ch = exp.Substring(exp.Length - length, 1);


                    if (IsNumeric(ch))   //是数字   : 说明第一次取的就是数字
                    {
                        token += ch;
                        length--;

                    }
                    else                //不是数字
                    {
                        if (IsNumeric(token))
                        {
                            f = token;
                            break;
                        }
                        else                       //说明第一次取的就不是数字
                        {
                            if (ch == " ")
                            {
                                length--;
                                continue;
                            }

                            length--;             //如取的是非数字
                            f = ch;
                            break;
                        }
                    }

                }

                return f;
            }//GetS
            private bool IsRight()  //判断表达式是否合法: (1)两数字中间是否有空格
            {

                bool f = true;
                string ch = string.Empty;
                int i = 0;
                int j = 0;
                for (int p = 0; p < exp.Length; p++)
                {
                    ch = exp.Substring(p, 1);

                    if (IsNumeric(ch))
                    {
                        if (j == 1) return false;
                        i = 1;
                        continue;
                    }
                    if (ch == " ")
                    {
                        if (i == 1) j = 1; continue;
                    }

                    i = j = 0;


                }
                return f;


            }
            private bool IsNumeric(string input)         //判断字符串是否为数
            {
                bool flag = true;
                string pattern = (@"^\d+$");
                Regex validate = new Regex(pattern);
                if (!validate.IsMatch(input))
                {
                    flag = false;
                }
                return flag;

            }

        }//class:expr

    }
}
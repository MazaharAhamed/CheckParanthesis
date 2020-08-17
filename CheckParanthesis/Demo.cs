using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace CheckParanthesis
{
    class Demo
    {
        static void Main(string[] args)
        {
            String expression;

            Console.Write("Enter an expression: ");
            expression = Console.ReadLine();

            if ( (IsValid(expression) )
                Console.WriteLine("Valid Expression");
            else
                Console.WriteLine("Invalid Expression");

            static bool IsValid(String expr)
            {
                StackA st = new StackA();
                char ch;

                for (int i = 0; i < expr.Length; i++)
                {
                    if (expr[i] == '(' || expr[i] == '{' || expr[i] == '[')
                        st.Push(expr[i]);
                    if (expr[i] == ')' || expr[i] == '}' || expr[i] == ']')
                        if(st.isEmpty())
                        {
                            Console.WriteLine("Right Paranthesis are more than Left Paranthesis");
                            return false;
                        }
                    else
                        {
                            ch = st.Pop();
                            if (!MatchParantheses(ch, expr[i]))
                            {
                                Console.WriteLine("Mismatched Parantheses are: ");
                                Console.WriteLine(ch + "and" + expr[i]);
                                return false;
                            }
                        }
                }
                if (st.isEmpty())
                {
                    Console.WriteLine("Balanced Parantheses");
                    return true;
                }
                else
                {
                    Console.WriteLine("Left Parantheses are more than Right Parantheses");
                    return false;
                }
            }
            static bool MatchParantheses(char leftPar,char rightPar)
            {
                if (leftPar == '(' && rightPar == ')')
                    return true;
                if (leftPar == '{' && rightPar == '}')
                    return true;
                if (leftPar == '[' && rightPar == ']')
                    return true;
                return false;
            }
        }
    }
}

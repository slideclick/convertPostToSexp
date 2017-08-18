// 把后缀输入转为AST树也就是s表达式可以给scheme输入
using System;
using System.Text;
using weiss.Collections.Generic;
namespace GenerateAST
{
    public class Evaluator
    {
        private string post;
        BinaryTree<char> ast;
        public string GetPost() { return post; }
        public void GetPre()
        {
            ast.PrintPreOrder();
            Console.WriteLine();
        }
        public string GetSexpr() { return "GetSexpr"; }
        public Evaluator(string s)
        {
            post = s;
            Stack<BinaryTree<char>> opStack = new Stack<BinaryTree<char>>();
            foreach (char c in s)
            {
                if ((c == '+') || (c == '*') || (c == '/') || (c == '-'))
                {
                    BinaryTree<char> op = new BinaryTree<char>();
                    BinaryTree<char> or = opStack.Pop();
                    BinaryTree<char> ol = opStack.Pop();
                    op.Merge(c, ol, or);
                    opStack.Push(op);
                }
                else if (c == ' ')
                {
                    continue;
                }
                else
                {
                    BinaryTree<char> o1 = new BinaryTree<char>(c);
                    opStack.Push(o1);
                }
            }
            ast = opStack.Pop();
        }
    }
    class GenerateASTProgram
    {
        static void Main(string[] args)
        {
            string str;
            //test:
            str = "12+34*+";// 345+*612+/-
            new Evaluator(str).GetPre(); ;
            try
            {
                //Console.WriteLine( "Enter expressions, one per line:" );
                while ((str = Console.ReadLine()) != null)
                
                {
                    Evaluator ev = new Evaluator(str);
                    ev.GetPre();
                }
                //Console.ReadKey ();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                //throw e; 
            }
        }

    }

}

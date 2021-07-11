using System;
using System.Collections.Generic;
using System.Text;

namespace Quick_Sort_Algorithm
{
    class Class1
    {
        public int inOrder(Node node)
        {

            if (node.Left != null && node.Right != null)
            {
                int eval = inOrder(node.Left);
             
                    switch (node.Value)
                    {
                        case "+":
                            eval += inOrder(node.Right);
                            break;
                        case "*":
                            eval *= inOrder(node.Right);
                            break;
                        case "^":
                            eval ^= inOrder(node.Right);
                            break;

                    }

                    return eval;
               
            }
            else
                return node.value;
        }
    }

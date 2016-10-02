using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class Program
    {
        void MessageSeqNotFound()
        {
            Console.Write("The zeros sequence is not found.");
            Console.ReadKey();
        }

       void CalcSecPosition(string input, out int start, out int end)
        {
            start = input.IndexOf("10");
            end = input.IndexOf("01");
        }

        static void Main(string[] args)
        {
            // var declarations
            int longestSeqLength = 0;
            string longestSeq = String.Empty;
            int startSeqPos = 0;
            int endSeqPos = 0;
            Program bn = new Program();

            Console.Write("Enter a number between 0 and 2,147,483,647: ");
            string inputString = String.Empty;
            inputString = Console.ReadLine();
            int inputInt = Convert.ToInt32(inputString);
            string inputBinar = Convert.ToString(inputInt, 2);
            Console.WriteLine("The tested binary sequence is : {0}", inputBinar);
            Console.ReadKey();
            while (inputBinar.Length > 2)
            {
                bn.CalcSecPosition(inputBinar, out startSeqPos, out endSeqPos);
                                               
                if ((startSeqPos < endSeqPos) && (startSeqPos != -1) && (endSeqPos != -1))
                {
                    int seqLength = endSeqPos - startSeqPos;

                    if (longestSeqLength < seqLength)
                    {
                        longestSeq = inputBinar;
                        longestSeqLength = seqLength;
                        inputBinar = inputBinar.Substring(endSeqPos + 1);
                    }
                }
                else 
                    break;
            } // end of while
            if (longestSeqLength == 0)
                bn.MessageSeqNotFound();
            else
            {
                bn.CalcSecPosition(longestSeq, out startSeqPos, out endSeqPos);
                longestSeq = longestSeq.Substring(startSeqPos, longestSeqLength + 2);
                Console.Write("The length of the longest zeros sequence is : {0} --> {1}", longestSeqLength, longestSeq);
                Console.ReadKey();
            }
        }
        
    }
}

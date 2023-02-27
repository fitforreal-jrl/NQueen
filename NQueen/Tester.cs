using System;
using System.Collections.Generic;
using System.Text;

namespace NQueen
{
    class Tester
    {
        byte bMaxSize = 25;

        double[] aSumOfSolution = new double[25]{
                      1,
                      0,
                      0,
                      2,
                     10,
                      4,
                     40,
                     92,
                    352,
                    724,
                   2680,
                  14200,
                  73712,
                 365596,
                 2279184,
                14772512,
                95815104,
               666090624,
              4968057848,
             39029188884,
            314666222712,
           2691008701644,
          24233937684440,
         227514171973736,
        2207893435808352,
        };
        public void CheckSumSolutionCorrect(byte bNrOfQueen, byte bNrOfFoundSolution) 
        {
            string strResult = "";
            strResult = "Found " + bNrOfFoundSolution.ToString() + " Solutions in " + bNrOfQueen.ToString() + "x" + bNrOfQueen.ToString() + " board.";
            Console.WriteLine(strResult);

            if (blIfSumSolutionCorrect(bNrOfQueen, bNrOfFoundSolution))
            {
                Console.WriteLine("It is correct.");
            }
            else
            {
                Console.WriteLine("It is not correct. The correct number of solution is" + aSumOfSolution[bNrOfQueen - 1].ToString());
            }
        }
        /****************************************************************************************
         * @brief excutethe agorithm to find the posible solutionand generate the result.
         * @param[in]   bNbOfQueen: Number of Queen, bNrOfFoundSolution: total found solution
         * @param[out]  None.
         * @return      None.
         /****************************************************************************************/
        private bool blIfSumSolutionCorrect(byte bNrOfQueen, byte bNrOfFoundSolution)
        {
            if (bNrOfQueen > bMaxSize) 
                return false;

            if (aSumOfSolution[bNrOfQueen - 1] == bNrOfFoundSolution)
                return true;

            return false;
        }
    }
}

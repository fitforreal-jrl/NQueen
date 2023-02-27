using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NQueen
{
     /****************************************************************************************    
      * NQueen algorithm 
     * @file NQueen.cs
     * @copbRowright 
     * CopbRowright 2023
    /****************************************************************************************/
    class NQueen
    {
        List<bool> VaildRowIndex;           // |, if vaild set 1
        List<bool> VaildRightObliqueIndex;  // /
        List<bool> VaildLeftObliqueIndex;   // \
        List<string> Results;               //result of single tree
        List<List<string>> AllResults;

        /****************************************************************************************
         * @brief       Constractor
         * @param[in]   None. 
         * @param[out]  None. 
         * @return      None. 
        /****************************************************************************************/
        public NQueen()
        {

            AllResults = new List<List<string>>();
        }
        /****************************************************************************************
        * @brief       Check if the number of found solution is the correct.
        * @param[in]   bNbOfQueen: Number of Queen.
        * @param[out]  None.
        * @return      None.
        /****************************************************************************************/
        public void test(byte bTargetNrOfQueen) 
        {
            execute(bTargetNrOfQueen);
            Tester tester = new Tester();
            tester.CheckSumSolutionCorrect(bTargetNrOfQueen, (byte)AllResults.Count);                
        }
        /****************************************************************************************
         * @brief excutethe agorithm to find the posible solutionand generate the result.
         * @param[in]   bNbOfQueen: Number of Queen.
         * @param[out]  None.
         * @return      None.
         /****************************************************************************************/
        public void execute(byte bTargetNrOfQueen)
        {
            AllResults.Clear();
            char[] chars = Enumerable.Repeat((char)'.', bTargetNrOfQueen).ToArray();
            Results = Enumerable.Repeat(new string(chars), bTargetNrOfQueen).ToList();

            VaildRowIndex = Enumerable.Repeat((bool)false, bTargetNrOfQueen).ToList();
            VaildRightObliqueIndex = Enumerable.Repeat((bool)false, 2 * bTargetNrOfQueen - 1).ToList();
            VaildLeftObliqueIndex = Enumerable.Repeat((bool)false, 2 * bTargetNrOfQueen - 1).ToList();

            nqueens(bTargetNrOfQueen, 0);

            //PrintAllResults();
        }

        /****************************************************************************************
         * @brief       Print all collected results.
         * @param[in]   None.
         * @param[out]  None.
         * @return      None.
         /****************************************************************************************/
        private void PrintAllResults()
        {
            for (int i = 0; i < AllResults.Count; i++)
            {
                for (int j = 0; j < AllResults[i].Count; j++)
                {
                    Console.WriteLine(AllResults[i][j]);
                }
                Console.WriteLine();
            }
        }
        /****************************************************************************************
        * @brief       If this position is vaild for queen
        * @param[in]   bColumn: column, bRow row, bTargetNrOfQueen: number of queen.
        * @param[out]  None.
        * @return      None.
        /****************************************************************************************/
        private bool IsVaild(byte bColumn, byte bRow, byte bTargetNrOfQueen)
        {
            return !VaildRowIndex[bColumn]
                && !VaildRightObliqueIndex[bColumn + bRow]
                && !VaildLeftObliqueIndex[bColumn - bRow + bTargetNrOfQueen - 1];
        }
        /****************************************************************************************
        * @brief       Update the result
        * @param[in]   bColumn: column, bRow row, bTargetNrOfQueen: number of queen, blOccupied: set if occupied
        * @param[out]  None.
        * @return      None.
        /****************************************************************************************/
        private void updateResult(byte bColumn, byte bRow, byte bTargetNrOfQueen, bool blOccupied)
        {
            VaildRowIndex[bColumn] = blOccupied;
            VaildRightObliqueIndex[bColumn + bRow] = blOccupied;
            VaildLeftObliqueIndex[bColumn - bRow + bTargetNrOfQueen - 1] = blOccupied;
            if (blOccupied)
            {
                Results[bRow] = Results[bRow].Remove(bColumn, 1).Insert(bColumn, "Q");
            }
            else
            {
                Results[bRow] = Results[bRow].Remove(bColumn, 1).Insert(bColumn, ".");
            }
        }
        /****************************************************************************************
        * @brief       search all position
        * @param[in]   bRow row, bTargetNrOfQueen: number of queen.
        * @param[out]  None.
        * @return      None.
        /****************************************************************************************/
        private void nqueens(byte bTargetNrOfQueen, byte bRow)
        {
            if (bRow == bTargetNrOfQueen)
            {
                for (int j = 0; j < Results.Count; j++)
                {
                    Console.WriteLine(Results[j]);
                }
                Console.WriteLine();
                // found one solution, add to the ans set
                AllResults.Add(new List<string>(Results));
                return;
            }

            // TrbRow everbRow column
            for (byte bColumn = 0; bColumn < bTargetNrOfQueen; ++bColumn)
            {
                if (!IsVaild(bColumn, bRow, bTargetNrOfQueen)) continue;
                updateResult(bColumn, bRow, bTargetNrOfQueen, true);
                nqueens(bTargetNrOfQueen, (byte)(bRow + 1));
                updateResult(bColumn, bRow, bTargetNrOfQueen, false);
            }
        }
    }
}
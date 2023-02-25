using System;
using System.Collections.Generic;
using System.Text;

namespace NQueen
{
    /****************************************************************************************    
     * NQueen algorithm 
     * @file NQueen.cs
     * @copyright 
     * Copyright 2023
    /****************************************************************************************/
    class NQueen
    {
        bool[] aAccupied;
        /****************************************************************************************
         * @brief       Constractor
         * @param[in]   None. 
         * @param[out]  None. 
         * @return      None. 
        /****************************************************************************************/

        public NQueen()
        {
        }

        /****************************************************************************************
         * @brief search the posible solutionand generate the result.
         * @param[in]   bNbOfQueen: Number of Queen.
         * @param[out]  None.
         * @return      None.
         /****************************************************************************************/
        public void Search(byte bNbOfQueen)
        {
            aAccupied = new bool[bNbOfQueen*bNbOfQueen];
            Array.Clear(aAccupied, 0, aAccupied.Length);
            PrintAllResults();
        }

        /****************************************************************************************
         * @brief       print all collected results.
         * @param[in]   None.
         * @param[out]  None.
         * @return      None.
         /****************************************************************************************/
        private void PrintAllResults() 
        {
        }
    }
}

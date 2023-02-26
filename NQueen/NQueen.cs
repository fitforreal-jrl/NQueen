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
        enum STATE
        {
            ST_SEARCH_ROW = 0,
            ST_CHECK_NEXT_NODE,
            ST_ADD_RESULT
        };

        STATE state;
        byte bProcessingRow;
        byte bProcessingNrOfQueen;
        byte bTargetNrOfQueen;
        node ProcessingNode;
        bool blProcessCompleted;
        List<string> AllResults;
        //bool[] aAccupied;
        /****************************************************************************************
         * @brief       Constractor
         * @param[in]   None. 
         * @param[out]  None. 
         * @return      None. 
        /****************************************************************************************/
        public NQueen()
        {
            state = STATE.ST_SEARCH_ROW;
            bProcessingRow = 0;
            bProcessingNrOfQueen = 0;
            bTargetNrOfQueen = 0;
            blProcessCompleted = false;
            AllResults = new List<string>();
        }

        /****************************************************************************************
         * @brief search the posible solutionand generate the result.
         * @param[in]   bNbOfQueen: Number of Queen.
         * @param[out]  None.
         * @return      None.
         /****************************************************************************************/
        public void excute(byte bNbOfQueen)
        {
            while (!blProcessCompleted)
            {
                switch (state)
                {
                    case STATE.ST_SEARCH_ROW:
                        ProcessingNode = new node(0, bProcessingRow);
                        break;

                    case STATE.ST_CHECK_NEXT_NODE:
                        if (ProcessingNode.IsNextNodeVaild() == true)
                            ProcessingNode = ProcessingNode.GetNextNode();
                            bProcessingNrOfQueen++;

                        if (ProcessingNode.IsNextNodeVaild() == false &&
                            ProcessingNode.IsLastNodeVaild() == true)
                            ProcessingNode = ProcessingNode.GetLastNode();

                        if (bProcessingNrOfQueen == bTargetNrOfQueen)
                            state = STATE.ST_ADD_RESULT;
                        break;

                    case STATE.ST_ADD_RESULT:
                        AllResults.Add(ProcessingNode.GetResult());
                        break;
                }
            }           

            /*aAccupied = new bool[bNbOfQueen*bNbOfQueen];
            Array.Clear(aAccupied, 0, aAccupied.Length);*/
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
            for(int i=0; i< AllResults.Count; i++)
            {
                Console.WriteLine(AllResults[i]);
            }
            //Console.WriteLine("fadsf");
            /*QueenSolution queenSolution = new QueenSolution();
            queenSolution.AddQueen(5);
            queenSolution.PrintResult();*/
        }
    }
}

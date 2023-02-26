using System;
using System.Collections.Generic;
using System.Text;

namespace NQueen
{
    class node
    {
        byte bCuurentColum;
        byte bCurrentRow;
        List<byte> inVaildRowIndex;             // |
        List<byte> inVaildRightObliqueIndex;    // /
        List<byte> inVaildLeftObliqueIndex;     // \
        List<byte> VaildIndexInNextColumList;
        node LastNode;
        node NextNode;
        byte bProcessingIndexInNodeList;
        /****************************************************************************************
        * @brief       Constractor
        * @param[in]   None. 
        * @param[out]  None. 
        * @return      None. 
       /****************************************************************************************/
        public node(byte bColumn, byte bRow)
        {
            bCuurentColum = bColumn;
            bCurrentRow = bRow;
            VaildIndexInNextColumList = new List<byte>();
            LastNode = null;
            NextNode = null;
            bProcessingIndexInNodeList = 0;
        }
        /****************************************************************************************
         * @brief       get last node of this node
         * @param[in]   None.
         * @param[out]  None.
         * @return      None.
         /****************************************************************************************/
        public node GetLastNode()
        {
            LastNode = new node(0,0);
            return LastNode;
        }
        /****************************************************************************************
         * @brief       get next node of this node
         * @param[in]   None.
         * @param[out]  None.
         * @return      None.
         /****************************************************************************************/
        public node GetNextNode()
        {
            return NextNode;
        }
        /****************************************************************************************
        * @brief       Check if there is next node vaild
        * @param[in]   None.
        * @param[out]  None.
        * @return      None.
        /****************************************************************************************/
        public bool IsNextNodeVaild()
        {            
            return (NextNode != null);
        }
        /****************************************************************************************
       * @brief       Check if there is last node vaild
       * @param[in]   None.
       * @param[out]  None.
       * @return      None.
       /****************************************************************************************/
        public bool IsLastNodeVaild()
        {
            return (LastNode != null) ;
        }
        /****************************************************************************************
      * @brief       Get processing result of current node
      * @param[in]   None.
      * @param[out]  None.
      * @return      None.
      /****************************************************************************************/
        public string GetResult()
        {
            string strReulst = "";
            return strReulst;
        }
    }

}

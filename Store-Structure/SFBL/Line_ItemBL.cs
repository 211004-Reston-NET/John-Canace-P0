using System;
using System.Collections.Generic;
using SFDL;
using SFModels;

namespace SFBL
{


    public class Line_ItemBL :ILine_ItemBL
    {
        private ILRepository _repo;
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it this way because we can easily switch out which implementation details we will be using
        /// But later on the lecture, we can then switch our SFDL project to point to an actual database in the cloud and we don't have to touch anything else to
        /// have the implementation
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public Line_ItemBL(ILRepository p_repo)
        {
            _repo = p_repo;
        }

        public Line_Item AddLine_Item(Line_Item l_item)
        {
            return _repo.AddLine_Item(l_item);
        }

        public List<Line_Item> GetAllLine_Items()
        {
            //Maybe my business operation needs to capitalize every name of a storefront
            List<Line_Item> listOfLineItem = _repo.GetAllLine_Items();
            for (int i = 0; i < listOfLineItem.Count; i++)
            {
                listOfLineItem[i].lineItemProductNameID = listOfLineItem[i].lineItemProductNameID; 
            }

            return listOfLineItem;
        }
    }
}
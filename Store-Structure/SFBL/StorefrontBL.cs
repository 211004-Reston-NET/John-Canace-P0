using System;
using System.Collections.Generic;
using SFDL;
using System.Linq;
using SFModels;

namespace SFBL
{
    /// <summary>
    /// Handles all the business logic for the storefront application
    /// They are in charge of further processing/sanitizing/furthur validation of data
    /// Any Logic
    /// </summary>
    public class StoreFrontBL :IStoreFrontBL
    {
        private IRepository _repo;
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it this way because we can easily switch out which implementation details we will be using
        /// But later on the lecture, we can then switch our SFDL project to point to an actual database in the cloud and we don't have to touch anything else to
        /// have the implementation
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public StoreFrontBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public StoreFront AddStoreFront(StoreFront s_ront)
        {
            return _repo.AddStoreFront(s_ront);
        }

        public List<StoreFront> GetAllStoreFronts()
        {
            //Maybe my business operation needs to capitalize every name of a storefront
            List<StoreFront> listOfStoreFront = _repo.GetAllStoreFronts();
            for (int i = 0; i < listOfStoreFront.Count; i++)
            {
                listOfStoreFront[i].StoreFrontName = listOfStoreFront[i].StoreFrontName.ToLower(); 
            }

            return listOfStoreFront;
        }

        public StoreFront GetStoreFrontByID(int s_id)
        {
            StoreFront rontFound = _repo.GetStoreFrontByID(s_id);

            //return rontFound.Where(rontFound => rontFound.StoreFrontName.Contains(s_name)).ToList();

            if(rontFound == null)
            {
                throw new Exception("StoreFront was not found!");
            }
            return rontFound;
        }
    }

}
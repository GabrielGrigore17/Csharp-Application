﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TextConnection : IDataConnection
    {
        // TODO - WIre up  the CreatePrize for the text files.
        /// <summary>
        /// Saves a new prize to the text file/files
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information, including the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}

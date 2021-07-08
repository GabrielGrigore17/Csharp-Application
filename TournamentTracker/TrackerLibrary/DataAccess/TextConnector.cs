using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizeFile = "PrizeModels.csv";

        // TODO - WIre up  the CreatePrize for the text files.
        /// <summary>
        /// Saves a new prize to the text file/files
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information, including the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // load the text file
            // convert the text to list of prizemodel
            List<PrizeModel> prizes = PrizeFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // find the max id
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            // add the new record with the new id max +1
            prizes.Add(model);

            // convert the prizes to list<string>
            // save the list to the text file
            prizes.SaveToPrizeFile(PrizeFile);

            return model;
        }
    }
}

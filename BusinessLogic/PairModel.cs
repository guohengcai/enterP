using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class PairModel
    {
        //shortcut to make attribute+property combo = type propfull, hit tab twice, fill in the blanks

        private int pairID; //attribute

        public int PairID //property to manage attribute
        {
            get { return pairID; }
            set { pairID = value; }
        }

        private string pairName;

        public string PairName
        {
            get { return pairName; }
            set { pairName = value; }
        }

        public static PairModel Parse(MediaDS.TabGenreRow mediaRow)
        {
            if (mediaRow == null)
                return null;

            PairModel pair = new PairModel();
            pair.PairID = mediaRow.GID;
            pair.PairName = mediaRow.GenreName;

            return pair;
        }
        public static PairModel Parse(MediaDS.TabLanguageRow mediaRow)
        {
            if (mediaRow == null)
                return null;
            PairModel pair = new PairModel();
            pair.PairID = mediaRow.LID;
            pair.PairName = mediaRow.LanguageName;

            return pair;
            
        }
        public static PairModel Parse(MediaDS.TabDirectorRow mediaRow)
        {
            if (mediaRow == null)
                return null;
            PairModel pair = new PairModel();
            pair.PairID = mediaRow.DID;
            pair.PairName = mediaRow.DirectorName;

            return pair;

        }
       
        
    }
}

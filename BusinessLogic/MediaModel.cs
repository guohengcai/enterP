using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class MediaModel
    {
        #region attributes

        private int mediaId;
        private string mediaTitle;
        private int mediaPublishYear;
        private string mediaLanguageName;
        private string mediaGenreName;
        private string mediaDirectorName; 


        #endregion
        #region properties
        public int MediaID
        {
            set { mediaId = value; }
            get { return mediaId; }
        }
        public string MediaTitle
        {
            set { mediaTitle = value; }
            get { return mediaTitle; }
        }
        public int MediaPublishYear
        {
            set { mediaPublishYear = value; }
            get { return mediaPublishYear; }
        }

        public String MediaLanguageName
        {
            set { mediaLanguageName = value; }
            get { return mediaLanguageName; }
        }
        public String MediaGenreName
        {
            set { mediaGenreName = value; }
            get { return mediaGenreName; }
        }

        public String MediaDirectorName
        {
            set { mediaDirectorName = value; }
            get { return mediaDirectorName; }
        }


        #endregion

        public static MediaModel Parse(MediaDS.ViewMediaRow mediaRow)
        {
            if (mediaRow == null)
                return null;

            MediaModel media = new MediaModel();
            media.MediaID = mediaRow.MediaID;
            media.MediaTitle = mediaRow.Title;
            media.MediaPublishYear = mediaRow.PublishYear;
            media.MediaLanguageName = mediaRow.LanguageName;
            media.MediaGenreName = mediaRow.GenreName;
            media.MediaDirectorName = mediaRow.DirectorName;
            return media;
        }
    }
}

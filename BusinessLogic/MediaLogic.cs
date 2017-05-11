using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class MediaLogic
    {
        private MediaDAO mediaDAO;
        private MediaDS.ViewMediaDataTable mediaTable;
        private MediaDS.TabLanguageDataTable languageTable;
        private MediaDS.TabGenreDataTable genreTable;
        private MediaDS.TabDirectorDataTable directorTable;
        private MediaDS.TabMediaDataTable tabmediaTable;

        public MediaLogic()
        {
            mediaDAO = new MediaDAO();
            mediaTable = new MediaDS.ViewMediaDataTable();
            languageTable = new MediaDS.TabLanguageDataTable();
            genreTable = new MediaDS.TabGenreDataTable();
            tabmediaTable = new MediaDS.TabMediaDataTable();
        }

        public List<MediaModel> ListMedia()
        {
            List<MediaModel> medias = new List<MediaModel>();
            mediaTable = mediaDAO.ListMedia();

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }
        public List<MediaModel> ListMediaByPublishYear(int publishYear)
        {
            List<MediaModel> medias = new List<MediaModel>();
            mediaTable = mediaDAO.ListMediaByPublishYear(publishYear);

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }
        public List<MediaModel> ListMediaByLanguages(string languageName)
        {
            List<MediaModel> medias = new List<MediaModel>();
            mediaTable = mediaDAO.ListMediaByLanguage(languageName);

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }

        public List<MediaModel> ListMediaByGenre(string genreName)
        {
            List<MediaModel> medias = new List<MediaModel>();
            mediaTable = mediaDAO.ListMediaByGenre(genreName);

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }



        public List<PairModel> ListGenre()
        {
            List<PairModel> medias = new List<PairModel>();
            MediaDS.TabGenreDataTable genreTable = mediaDAO.ListGenre();

            foreach (MediaDS.TabGenreRow row in genreTable.Rows)
            {
                PairModel media = PairModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }

        public List<PairModel> ListLanguage()
        {
            List<PairModel> medias = new List<PairModel>();
            MediaDS.TabLanguageDataTable languageTable = mediaDAO.ListLanguage();

            foreach (MediaDS.TabLanguageRow row in languageTable.Rows)
            {
                PairModel media = PairModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }

        public List<PairModel> ListDirector()
        {
            List<PairModel> medias = new List<PairModel>();
            MediaDS.TabDirectorDataTable directorTable = mediaDAO.ListDirector();

            foreach (MediaDS.TabDirectorRow row in directorTable.Rows)
            {
                PairModel media = PairModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }






        public int InsertNewMedia(string Title, int Genre, int Director, int Language, int PublishYear, decimal Budget)
        {
            int result = 0;
            result=  mediaDAO.InsertMedia(Title, Genre, Director, Language, PublishYear, Budget);
            return result;
        }

        public int DeleteSelectedMedia(int MediaID)
        {
            int result = 0;

            try
            {
                result = mediaDAO.DeleteMedia(MediaID);
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public int UpdateSelectedMedia(string Title, int Genre, int Director, int Language, int PublishYear, decimal Budget, int MediaID)
        {
            int result = 0;

            try
            {
                result =mediaDAO.UpdateMedia(Title, Genre, Director, Language, PublishYear, Budget, MediaID);
        }
            catch (FormatException)
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
            }



        public List<MediaModel> searchmedaibyMediaID(int MediaID)
        {
            List<MediaModel> medias = new List<MediaModel>();
            mediaTable = mediaDAO.searchmediabyMediaID(MediaID); ;

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }




       /* public List<MediaModel> searchmedaibyMediaID(string p)
        {
            throw new NotImplementedException();
        }*/

        

        public int DeleteDirector(string directorname)
        {
            int result = 0;

            try
            {
                result = mediaDAO.DeleteDirector(directorname);
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public int InsertDirector(string directorname)
        {
            int result = 0;

            result = mediaDAO.InserDirector(directorname);

            return result;
        }

        public int DeleteGenre(string genrename)
        {
            int result = 0;

            try
            {
                result =mediaDAO.DeleteGenreName(genrename);
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public int InsertGenre(string genrename)
        {
            int result = 0;

            result = mediaDAO.InsertGenre(genrename);

            return result;
        }

        public int DeleteLanguage(string languagename)
        {
            int result = 0;

            try
            {
                result = mediaDAO.DeleteLanguage(languagename);
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public int InsertLanguage(string languagename)
        {
            int result = 0;

            result = mediaDAO.InsertLanguage(languagename);

            return result;
        }



    }
}

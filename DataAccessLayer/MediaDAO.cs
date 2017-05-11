using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.MediaDSTableAdapters;

namespace DataAccessLayer
{
    public class MediaDAO
    {
        private MediaDS mediaDataSet;
        private ViewMediaTableAdapter viewMediaAdapter;
        private TabLanguageTableAdapter languageTableAdapter;
        private TabGenreTableAdapter genreTableAdapter;
        private TabMediaTableAdapter mediaTableAdapter;
        private TabDirectorTableAdapter directorTableAdapter;
        //if we need TabMediaTableAdapter, we'll add it later :/

        public MediaDAO()
        {
            mediaDataSet = new MediaDS();
            viewMediaAdapter = new ViewMediaTableAdapter();
            languageTableAdapter = new TabLanguageTableAdapter();
            genreTableAdapter = new TabGenreTableAdapter();
            directorTableAdapter = new TabDirectorTableAdapter();
            mediaTableAdapter = new TabMediaTableAdapter();
        }

        public MediaDS.ViewMediaDataTable ListMedia()
        {
            viewMediaAdapter.Fill(mediaDataSet.ViewMedia);
            return mediaDataSet.ViewMedia;
        }
        public MediaDS.ViewMediaDataTable ListMediaByPublishYear(int publishYear)
        {
            viewMediaAdapter.FillByPublishYear(mediaDataSet.ViewMedia, publishYear);
            return mediaDataSet.ViewMedia;
        }

        public MediaDS.ViewMediaDataTable ListMediaByLanguage(string languageName)
        {
            viewMediaAdapter.FillByLanguageName(mediaDataSet.ViewMedia, languageName);
            return mediaDataSet.ViewMedia;
        }


        public MediaDS.ViewMediaDataTable ListMediaByGenre(string genreName)
        {
            viewMediaAdapter.FillByGenreName(mediaDataSet.ViewMedia, genreName);
            return mediaDataSet.ViewMedia;
        }



        public MediaDS.TabLanguageDataTable ListLanguage( )
        {
            languageTableAdapter.Fill(mediaDataSet.TabLanguage);
            return mediaDataSet.TabLanguage;
        }

        public MediaDS.TabGenreDataTable ListGenre( )
        {
            genreTableAdapter.Fill(mediaDataSet.TabGenre);
            return mediaDataSet.TabGenre;
        }

        public MediaDS.TabDirectorDataTable ListDirector()
        {
            directorTableAdapter.Fill(mediaDataSet.TabDirector);
            return mediaDataSet.TabDirector;
        }

        public int InsertMedia(string Title, int Genre, int Director, int Language, int PublishYear, decimal Budget)
        {
            return mediaTableAdapter.InsertMedia(Title, Genre, Director, Language, PublishYear, Budget);
        }

        public int DeleteMedia(int MediaID)
        {
            return mediaTableAdapter.DeleteMedia(MediaID);
        }

        public int UpdateMedia(string Title, int Genre, int Director, int Language, int PublishYear, decimal Budget, int MediaID)
        
        {
            return mediaTableAdapter.UpdateMedia(Title, Genre, Director, Language, PublishYear, Budget, MediaID);
        }


        public MediaDS.ViewMediaDataTable searchmediabyMediaID(int MediaID)
        {
            try
            {
                viewMediaAdapter.FillByMediaID(mediaDataSet.ViewMedia, MediaID);
                return mediaDataSet.ViewMedia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertGenre(string genre)
        {
            return genreTableAdapter.InsertGenre (genre);
        }

        public int DeleteGenreName(string genreName)
        {
            return genreTableAdapter.DeleteGenreName(genreName);
        }

        public int InsertLanguage(string languagename)
        {
            return languageTableAdapter.InsertLanguage(languagename);
        }

        public int DeleteLanguage(string languagename)
        {
            return languageTableAdapter.DeleteLanguage(languagename);
        }

        public int InserDirector(string directorname)
        {
            return directorTableAdapter.InsertDirector(directorname);
        }

        public int DeleteDirector(string directorname)
        {
            return directorTableAdapter.DeleteDirector(directorname);
        }
    }
}

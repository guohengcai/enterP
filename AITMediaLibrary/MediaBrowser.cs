using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace AITMediaLibrary
{
    public partial class MediaBrowser : Form
    {
        public MediaBrowser()
        {
            InitializeComponent();
        }

        private void MediaBrowser_Load(object sender, EventArgs e)
        {
            userDetailLbl.Text = CurrentUser.UserName + " userLevel: " + CurrentUser.UserLevel;
        }

        private void listMediaBtn_Click(object sender, EventArgs e)
        {
            MediaLogic mediaLogic = new MediaLogic();

            //set data source for data grid view
            mediaDataGridView.DataSource = mediaLogic.ListMedia();
        }

        private void mediaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //use the e arg to get info on which cell was clicked. I only care about the row
            int row = e.RowIndex;
            if (row >= 0)
            {
                MediaLogic mediaLogic = new MediaLogic();
                //using my media logic, i want to get the media in the media list at row whatever row was in e
                MediaModel media = mediaLogic.ListMedia().ElementAt<MediaModel>(row);
                //change label to show name of media
                mediaLbl.Text = media.MediaTitle;
            }
        }

        private void publishYearSearchBtn_Click(object sender, EventArgs e)
        {
            if (publishYearTxt.Text != "")
            {
                MediaLogic mediaLogic = new MediaLogic();
                try
                {
                    //find media based on whats typed into the publish year textbox
                    mediaDataGridView.DataSource = mediaLogic.ListMediaByPublishYear(Int32.Parse(publishYearTxt.Text));
                }
                catch (Exception ex)
                {
                    //if user typed in something that can't be parsed into an int e.g "sdfsdf" then- 
                    mediaDataGridView.DataSource = mediaLogic.ListMediaByPublishYear(0); //chuck in zero for the year
                }
            }
        }



       private void genreNameSearchBtn_Click(object sender, EventArgs e)
        {

            if (genreNameText.Text != "")
            {
                MediaLogic mediaLogic = new MediaLogic();
                try
                {

                    mediaDataGridView.DataSource = mediaLogic.ListMediaByGenre(genreNameText.Text);
                }
                catch (Exception ex)
                {
                    
                    mediaDataGridView.DataSource = ""; 
                }
            }
        }
       

        private void languageNameSearchBtn_Click(object sender, EventArgs e)
        {

            if (languageNameText.Text != "")
            {
                MediaLogic mediaLogic = new MediaLogic();
                try
                {
                    
                    mediaDataGridView.DataSource = mediaLogic.ListMediaByLanguages(languageNameText.Text);
                }
                catch (Exception ex)
                {
                   
                    mediaDataGridView.DataSource = ""; 
                }
            }
        }

        private void mediaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

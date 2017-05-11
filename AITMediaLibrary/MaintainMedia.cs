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
    public partial class MaintainMedia : Form
    {
        public MaintainMedia()
        {
            InitializeComponent();
        }

        private void MaintainMedia_Load(object sender, EventArgs e)
        {
            MediaLogic ml = new MediaLogic();

            combogenre.DataSource = ml.ListGenre();
            combogenre.DisplayMember = "PairName";
            combogenre.ValueMember = "PairID";

            combolanguage.DataSource = ml.ListLanguage();
            combolanguage.DisplayMember = "PairName";
            combolanguage.ValueMember = "PairID";

            combodirector.DataSource = ml.ListDirector();
            combodirector.DisplayMember = "PairName";
            combodirector.ValueMember = "PairID";

            MediadataGridView.DataSource = ml.ListMedia();

            txttitle.Text = "";
            txtmediaid.Text = "";
            txtpublishyear.Text = "";
            txtbudget.Text = "";
            
            combodirector.Text = "";
            combogenre.Text = "";
            combolanguage.Text = "";

      
           


        }

        private void btnaddmedia_Click(object sender, EventArgs e)
        {
            MediaLogic ml = new MediaLogic();

            if ( txttitle.Text == "")
            {
                MessageBox.Show("Please enter the title.");
            }
            else if (txtmediaid.Text == "")
            {
                MessageBox.Show("Please enter the media id.");
            }
            else if (txtpublishyear.Text == "")
            {
                MessageBox.Show("Please enter the publish year.");
            }
            else if ( txtbudget.Text == "")
            {
                MessageBox.Show("Please enter the budget.");
            }
            
            else if (combogenre.Text == "")
            {
                MessageBox.Show("Please select the genre.");
            }
            else if (combolanguage.Text == "")
            {
                MessageBox.Show("Please enter the language.");
            }
            else if (combodirector.Text == "")
            {
                MessageBox.Show("Please enter the director.");
            }
            else
            {
                //List<MediaModel> Media = ml.searchmedaibyMediaID(txtmediaid.Text);
                 List<MediaModel> Media = ml.searchmedaibyMediaID(Int32.Parse(txtmediaid.Text));
                if ( Media.Count > 0)
                {
                    MessageBox.Show("Already have a same Media id!!");
                }
                else
                {
                    int result = ml.InsertNewMedia(txttitle.Text, Int32.Parse(combogenre.SelectedValue.ToString()), Int32.Parse(combodirector.SelectedValue.ToString()), Int32.Parse(combolanguage.SelectedValue.ToString()), Int32.Parse(txtpublishyear.Text), Int32.Parse(txtbudget.Text));

                    MessageBox.Show(result.ToString() + " Media added.");

                    MaintainMedia_Load(sender, e);

                }
                
            }
        }

        private void btndeletemedia_Click(object sender, EventArgs e)
        {
            MediaLogic ml = new MediaLogic();
            int result = 0;
            result = ml.DeleteSelectedMedia(MediadataGridView.SelectedRows[0].Cells[0].Value);
            //result = ml.DeleteSelectedMedia(selectedMedia.mediaID);
           // selectedmedia = null;

            MessageBox.Show(result.ToString() + " media delete.");

            MaintainMedia_Load(sender, e);
        }


           private void MeidadataGridView_SelectionChanged(object sender, EventArgs e)
        {            
            try
            {
                txtmediaid.Text = MediadataGridView.SelectedRows[0].Cells[0].Value.ToString();
                txttitle.Text = MediadataGridView.SelectedRows[0].Cells[1].Value.ToString();
                combodirector.Text = MediadataGridView.SelectedRows[0].Cells[2].Value.ToString();
                combogenre.Text = MediadataGridView.SelectedRows[0].Cells[3].Value.ToString();
                combolanguage.Text = MediadataGridView.SelectedRows[0].Cells[4].Value.ToString();
                txtpublishyear.Text = MediadataGridView.SelectedRows[0].Cells[5].Value.ToString();
                txtbudget.Text= MediadataGridView.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception)
            {

            }
            
        }

           private void btnupdatemedia_Click(object sender, EventArgs e)
           {
               MediaLogic ml = new MediaLogic();

               int result = 0;

               result = ml.InsertNewMedia(txttitle.Text, Int32.Parse(combogenre.SelectedValue.ToString()), Int32.Parse(combodirector.SelectedValue.ToString()), Int32.Parse(combolanguage.SelectedValue.ToString()), Int32.Parse(txtpublishyear.Text), Int32.Parse(txtbudget.Text));

               if (result >= 1)
               {
                   MessageBox.Show(result.ToString() + " media update.");
               }
               else
               {
                   MessageBox.Show("Please select media and fill the box.");
               }

               MaintainMedia_Load(sender, e);
           }


        
        }
        }

        

        
       

      

        
    


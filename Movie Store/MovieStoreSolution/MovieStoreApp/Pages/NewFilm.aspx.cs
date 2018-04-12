using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieStoreApp.Models;

namespace MovieStoreApp.Pages
{
    public partial class NewFilm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGenres();
        }

        protected void btnAddMovie_Click(object sender, EventArgs e)
        {
            AddMovieToDb();

            txtMovieName.Text = "";
            txtDirectorName.Text = "";

        }

        /* ------------------------------------------------------------------------------- */
        // Lägg till Film Rad i tabelen
        private void AddMovieToDb()
        {
            using (var ctx = new MediaEntities())
            {
                if (!string.IsNullOrEmpty(txtMovieName.Text) &&
                    !string.IsNullOrEmpty(txtDirectorName.Text))
                {
                    LoadGenres();

                    Movy NewMovie = new Movy();
                    NewMovie.MovieName = txtMovieName.Text;
                    NewMovie.DirectorName = txtDirectorName.Text;
                    NewMovie.ReleaseDate = DateTime.Parse(txtReleaseDate.Text);
                    NewMovie.genreID = Convert.ToInt16(Genres.SelectedValue);

                    ctx.Movies.Add(NewMovie);
                    ctx.SaveChanges();
                }
            }

            // Printa ut resultat
            lblResult.Text = "Movie added successfully";

        }

        /* ------------------------------------------------------------------------------- */
        private void LoadGenres()
        {
            using (var ctx = new MediaEntities())
            {
                foreach (Genre G in ctx.Genres)
                {
                    ListItem newItem = new ListItem();
                    newItem.Text = G.Genre1;
                    newItem.Value = G.GenreID.ToString();
                    Genres.Items.Add(newItem);
                }
            }
        }
    }
}
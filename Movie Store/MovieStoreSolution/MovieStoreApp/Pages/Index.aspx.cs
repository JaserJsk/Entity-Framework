using MovieStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MovieStoreApp.Pages
{
    public class MovieListItem
    {
        public Movy Movy { get; set; }
        public bool IsRented { get; set; }
        public DateTime? RentedTo { get; set; }
    }

    public partial class Index : System.Web.UI.Page
    {
        MediaEntities MME = new MediaEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Skapa en instance av "MovieListItem" klassen i en lista
            IList<MovieListItem> movieItems = new List<MovieListItem>();

            // Sök i databasen och skapa ett nytt objekt av varje rad i databasen.
            foreach (var item in MME.Movies.ToList())
            {
                var movieListItem = new MovieListItem();
                movieListItem.Movy = item;

                var rentedMovie = MME.RentedMovies.FirstOrDefault(obj => obj.MovieID == item.MovieId);

                // Kolla ifall filmen är uthyrd
                if (rentedMovie != null)
                {
                    movieListItem.IsRented = true;
                    movieListItem.RentedTo = rentedMovie.RentedTo;

                }
                else
                {
                    movieListItem.IsRented = false;
                    movieListItem.RentedTo = null;
                }

                // Lägg till i listan
                movieItems.Add(movieListItem);
            }

            // Befolka Repeater-Tabelen med listan från databsen
            FilmsTable.DataSource = movieItems;
            FilmsTable.DataBind();
        }

        protected void Repeater1_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Return")
            {
                int MovieID = Convert.ToInt32(((Label)e.Item.FindControl("MovieID")).Text);

                // Get rented movie from DB so we can return it (remove from rented movies)
                RentedMovy RM = (from rm in MME.RentedMovies where rm.MovieID == MovieID select rm).First();

                //// Remove
                //MME.RentedMovies.Remove(RM);
                //// Save
                //MME.SaveChanges();

                //// Look up Movie name so we can display it in confirmation.
                //string MovieName = ((Label)e.Item.FindControl("MovieName")).Text;

                //// Display confirmation of return
                //lblResult.Text = string.Format("Movie '{0}' returned.", MovieName);
            }

        }
    }
}
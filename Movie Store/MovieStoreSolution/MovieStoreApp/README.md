
First make sure that the correct ```data source & initial catalog``` is configured.

``` Web.config
<connectionStrings>
    <add name="MediaEntities" connectionString="metadata=res://*/Models.Model.csdl|res://*/Models.Model.ssdl|res://*/Models.Model.msl;
    provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-LM7PGQ6;initial catalog=MyMedia;integrated security=True;
    MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
</connectionStrings>
```

The following code adds a new movie to the database.

``` NewFilm.aspx.cs 
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
​
            ctx.Movies.Add(NewMovie);
            ctx.SaveChanges();
        }
    }
    // Printa ut resultat
    lblResult.Text = "Movie added successfully";
}
```

The following code adds a new customer to the database.

``` NewCustomer.aspx.cs
private void AddCustomerToDb()
{
    using (var ctx = new MediaEntities())
    {
        if (!string.IsNullOrEmpty(txtName.Text) &&
        !string.IsNullOrEmpty(txtAddress.Text) &&
        !string.IsNullOrEmpty(txtPhone.Text))
        {
            Customer newCustomer = new Customer();
            newCustomer.CustomerName = txtName.Text;
            newCustomer.CustomerAdress = txtAddress.Text;
            newCustomer.CustomerPhone = txtPhone.Text;
​
            ctx.Customers.Add(newCustomer);
            ctx.SaveChanges();
        }
    }
    // Printa ut resultat
    lblResult.Text = "Customer added successfully";
}
```

The following code rents an existing movie to an existing customer.

``` Rent.aspx.cs
protected void btnRentMovie_Click(object sender, EventArgs e)
{
    using (var ctx = new MediaEntities())
    {
        int ID = Convert.ToInt32(Request.QueryString["MovieID"].ToString());
        Movy mov = (from m in ctx.Movies where m.MovieId == ID select m).First();
​
        foreach (Customer C in ctx.Customers)
        {
            ListItem newItem = new ListItem();
            newItem.Text = C.CustomerName;
            newItem.Value = C.CustomerID.ToString();
            Customers.Items.Add(newItem);
        }
​
        RentedMovy RM = new RentedMovy();
        RM.MovieID = mov.MovieId;
        RM.CustomerID = Convert.ToInt16(Customers.SelectedValue);
​
        try
        {
            // Try and confirm to date time. If not show error.
            RM.RentedTo = DateTime.Parse(RentTo.Text);
        }
        catch (Exception ex)
        {
            lblResult.Text = "Don't recognize the date format";
            return;
        }
​
        ctx.RentedMovies.Add(RM);
        ctx.SaveChanges();
​
        // Show confirmation to user that movie is saved
        lblResult.Text = "Movie rented successfully";
    }
}
```
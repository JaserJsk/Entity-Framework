
Först börjar jag med att se till att rätt ```data source & initial catalog``` är konfigurerad.

``` Web.config
<connectionStrings>
    <add name="MediaEntities" connectionString="metadata=res://*/Models.Model.csdl|res://*/Models.Model.ssdl|res://*/Models.Model.msl;
    provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-LM7PGQ6;initial catalog=MyMedia;integrated security=True;
    MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
</connectionStrings>
```

Nedanstående kod lägger till ny film i databasen.

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

Nedanstående kod lägger till ny kund i databasen.

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

Nedanstående kod hyr ut en existerande film till en  existerande kund.

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
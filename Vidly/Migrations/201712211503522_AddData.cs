namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (1,0,0,0)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (2,30,1,10)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (3,90,3,15)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (4,300,12,20)");

            Sql("UPDATE MembershipTypes SET Name = 'Pay As You Go' WHERE DurationInMonths = 0");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE DurationInMonths = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly' WHERE DurationInMonths = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Yearly' WHERE DurationInMonths = 12");

            Sql("INSERT INTO Genres (Id, Name) VALUES (1,'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2,'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3,'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4,'Romantic')");

            Sql("INSERT INTO Movies ( Name, GenreId, ReleaseDate, DateAdded, NumberInStock ) VALUES ('Hangover',1, 20-04-1999, 2, 1)");
            Sql("INSERT INTO Movies ( Name, GenreId, ReleaseDate, DateAdded, NumberInStock ) VALUES ('Die Hard',2, 20-04-1999, 2, 1)");
            Sql("INSERT INTO Movies ( Name, GenreId, ReleaseDate, DateAdded, NumberInStock ) VALUES ('Toy Story',3, 20-04-1999, 2, 1)");
            Sql("INSERT INTO Movies ( Name, GenreId, ReleaseDate, DateAdded, NumberInStock ) VALUES ('Birdman',1, 20-04-1999, 2, 1)");
            Sql("INSERT INTO Movies ( Name, GenreId, ReleaseDate, DateAdded, NumberInStock ) VALUES ('The Note Book',4, 20-04-1999, 2, 1)");
            Sql("INSERT INTO Movies ( Name, GenreId, ReleaseDate, DateAdded, NumberInStock ) VALUES ('The GodFather',2, 20-04-1999, 2, 1)");
        }
        
        public override void Down()
        {
        }
    }
}

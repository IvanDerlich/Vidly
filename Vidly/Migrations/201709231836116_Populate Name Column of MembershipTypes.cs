namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNameColumnofMembershipTypes : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 0, 0, 0)");
            Sql("UPDATE MembershipTypes SET Name = 'Pay As you go' WHERE id =1");
            //Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 30, 1, 10)");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE id =2");
            //Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 90, 3, 15)");
            Sql("UPDATE MembershipTypes SET Name = 'Anually' WHERE id =3");
            //Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 300, 12, 20)");
            Sql("UPDATE MembershipTypes SET Name = 'Yearly' WHERE id =4");

        }

        public override void Down()
        {
        }
    }
}

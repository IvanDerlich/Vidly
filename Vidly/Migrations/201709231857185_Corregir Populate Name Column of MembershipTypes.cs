namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorregirPopulateNameColumnofMembershipTypes : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 90, 3, 15)");
            //Sql("UPDATE MembershipTypes SET Name = 'Anually' WHERE id =3");
            Sql("UPDATE MembershipTypes SET Name = 'Quaterly' WHERE id =3");


            ////Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 300, 12, 20)");
            //Sql("UPDATE MembershipTypes SET Name = 'Yearly' WHERE id =4");
            Sql("UPDATE MembershipTypes SET Name = 'Annually' WHERE id =4");
        }

        public override void Down()
        {
        }
    }
}

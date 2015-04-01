namespace ASP_Tut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Rating_to_Movies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Rating", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Rating");
        }
    }
}

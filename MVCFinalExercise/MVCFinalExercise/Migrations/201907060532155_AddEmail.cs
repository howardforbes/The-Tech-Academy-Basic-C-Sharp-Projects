namespace MVCFinalExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rentals", "Email");
        }
    }
}

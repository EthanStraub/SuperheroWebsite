namespace SuperherosProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Superheroes", "AlterEgo", c => c.String());
            AddColumn("dbo.Superheroes", "PrimaryAbility", c => c.String());
            AddColumn("dbo.Superheroes", "SecondaryAbility", c => c.String());
            DropColumn("dbo.Superheroes", "Alter_Ego");
            DropColumn("dbo.Superheroes", "Primary_Ability");
            DropColumn("dbo.Superheroes", "Secondary_Ability");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Superheroes", "Secondary_Ability", c => c.String());
            AddColumn("dbo.Superheroes", "Primary_Ability", c => c.String());
            AddColumn("dbo.Superheroes", "Alter_Ego", c => c.String());
            DropColumn("dbo.Superheroes", "SecondaryAbility");
            DropColumn("dbo.Superheroes", "PrimaryAbility");
            DropColumn("dbo.Superheroes", "AlterEgo");
        }
    }
}

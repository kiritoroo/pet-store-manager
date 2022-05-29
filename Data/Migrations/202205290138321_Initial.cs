namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE animals ADD CONSTRAINT chk_animal_id CHECK (ID LIKE 'PET%')");
        }

        public override void Down()
        {
        }
    }
}

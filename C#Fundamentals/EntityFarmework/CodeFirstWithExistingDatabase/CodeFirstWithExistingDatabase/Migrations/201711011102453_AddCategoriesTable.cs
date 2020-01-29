namespace CodeFirstWithExistingDatabase.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddCategoriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            Sql("INSERT INTO Categories VALUES ('Web Development')");
            Sql("INSERT INTO Categories VALUES ('MVC')");
            Sql("INSERT INTO Categories VALUES ('Angular')");

        }

        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}

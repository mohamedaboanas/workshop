namespace CodeFirstWithExistingDatabase.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class DeleteCateogriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo._Categories",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            Sql("Insert into dbo._Categories (Name) Select Name from Categories");

            DropTable("dbo.Categories");
        }

        public override void Down()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            Sql("Insert into dbo.Categories (Name) Select Name from _Categories");

            DropTable("dbo._Categories");

        }
    }
}

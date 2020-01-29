namespace CodeFirstWithExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatePublisedFromCourseTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "DatePublised");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "DatePublised", c => c.DateTime());
        }
    }
}

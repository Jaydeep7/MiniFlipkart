namespace MiniFlipkart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRecordToCategroy : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Category (Name) values('Male')");
            Sql("insert into Category(Name) values('Female')");
        }
        
        public override void Down()
        {;
            Sql ("Delete from Category Where Category in ('Male',Female'')");
        }
    }
}

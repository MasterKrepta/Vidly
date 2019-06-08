namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNameToExistingRecordsMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes set Name = 'Pay as You Go' where ID = 1");
            Sql("update MembershipTypes set Name = 'Monthly' where ID = 2");
            Sql("update MembershipTypes set Name =  '3 Month' where ID = 3");
            Sql("update MembershipTypes set Name =  'Yearly' where ID = 4");
            
        }
        
        public override void Down()
        {
        }
    }
}

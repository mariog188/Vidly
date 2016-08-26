namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMembershiptype : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'PAY AS YOU GO' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'FREE' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'MONTHLY' WHERE Id = 3");
        }
        
        public override void Down()
        {
        }
    }
}

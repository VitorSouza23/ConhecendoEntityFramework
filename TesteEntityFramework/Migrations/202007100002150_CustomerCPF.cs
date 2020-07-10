namespace TesteEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerCPF : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CPF", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CPF");
        }
    }
}

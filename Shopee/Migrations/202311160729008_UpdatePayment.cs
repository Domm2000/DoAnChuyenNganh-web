namespace Shopee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePayment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Order", "Email", c => c.String());
            AddColumn("dbo.tb_Order", "TypePayment", c => c.Int(nullable: false));
            AlterColumn("dbo.tb_Order", "TotalAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Order", "TotalAmount", c => c.String());
            DropColumn("dbo.tb_Order", "TypePayment");
            DropColumn("dbo.tb_Order", "Email");
        }
    }
}

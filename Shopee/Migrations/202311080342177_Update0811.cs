﻿namespace Shopee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update0811 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Category", "Link", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Category", "Link");
        }
    }
}

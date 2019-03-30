namespace Luck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addaty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Aty", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Tegi", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Akesinin_aty", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Tugan_kuni", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Meken_zhai", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Tel_nomeri", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Tel_nomeri");
            DropColumn("dbo.AspNetUsers", "Meken_zhai");
            DropColumn("dbo.AspNetUsers", "Tugan_kuni");
            DropColumn("dbo.AspNetUsers", "Akesinin_aty");
            DropColumn("dbo.AspNetUsers", "Tegi");
            DropColumn("dbo.AspNetUsers", "Aty");
        }
    }
}

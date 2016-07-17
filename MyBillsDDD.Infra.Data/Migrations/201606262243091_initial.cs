namespace MyBillsDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bill",
                c => new
                    {
                        BillId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100, unicode: false),
                        PayDay = c.DateTime(nullable: false),
                        AutoPay = c.Boolean(nullable: false),
                        Payed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BillId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bill");
        }
    }
}

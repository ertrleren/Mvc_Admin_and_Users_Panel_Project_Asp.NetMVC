namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_addimage_file : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImageFiles",
                c => new
                    {
                        ImageID = c.Int(nullable: false, identity: true),
                        ImageName = c.String(maxLength: 100),
                        ImagePatch = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ImageID);
            
            AlterColumn("dbo.Abouts", "AboutDetails1", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Abouts", "AboutDetails2", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Abouts", "AboutImage1", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Abouts", "AboutImage1", c => c.String(maxLength: 100));
            AlterColumn("dbo.Abouts", "AboutDetails2", c => c.String(maxLength: 500));
            AlterColumn("dbo.Abouts", "AboutDetails1", c => c.String(maxLength: 500));
            DropTable("dbo.ImageFiles");
        }
    }
}

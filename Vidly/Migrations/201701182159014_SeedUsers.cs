namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'33fa1f03-a8f8-44a5-9d9b-877be337030d', N'admin@admin.com', 0, N'AAuoZM87ndB1PnPbyIC9XkrMWHKL2nEaAIU7o6vSywntfzzPO1Ltpq2HXiOdatA3yQ==', N'2ee0562c-9b49-434a-b669-2233a6b929df', NULL, 0, 0, NULL, 1, 0, N'admin@admin.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8aa81ff2-f81a-4d90-a44d-57051206efe8', N'guest@vidly.com', 0, N'AHEpJK9AvFAv+r+fC8OI5xeidMpjwMjs9ClXZN8MCpq9WUeURAz4f1unU3XWnsjB5w==', N'f611868a-656a-474e-addf-9decadb0fa13', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9de61140-fc3d-4345-829d-c92d4fc890c2', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'33fa1f03-a8f8-44a5-9d9b-877be337030d', N'9de61140-fc3d-4345-829d-c92d4fc890c2')

    
");
        }

        public override void Down()
        {
        }
    }
}

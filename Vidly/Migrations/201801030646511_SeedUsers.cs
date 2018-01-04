namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0a5ae73e-798e-471c-8722-9ced826cb8ce', N'guess@vidly.com', 0, N'AAARdVY2KA1x23hhA2tZfxJM0pwt7dw4Askqcar7102p8YFgeDS2ZdHlBavePWnabg==', N'cddda4dd-7ea5-4767-becc-1f85a5ee7051', NULL, 0, 0, NULL, 1, 0, N'guess@vidly.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9945f493-af7f-4501-9f01-c31412d1044a', N'admin2@vidly.com', 0, N'AAsRjre1V0ASajt38NceMGHGDR0A4+jDow270craFQv8diNb47VtkFwf8+pkiBp9Qw==', N'f41fd169-ad89-4cf1-9052-7649fe9b46e6', NULL, 0, 0, NULL, 1, 0, N'admin2@vidly.com')
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0dec1b47-d7e8-4ed6-a091-2724b87f467a', N'CanManageMovie')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9945f493-af7f-4501-9f01-c31412d1044a', N'0dec1b47-d7e8-4ed6-a091-2724b87f467a')
                ");
        }
        
        public override void Down()
        {
        }
    }
}

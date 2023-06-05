using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy_RelationsSite_HomeTask_.Migrations
{
    public partial class updateChefandChefSocialMediaandProfessionandTestimonialTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Testimonials_ChefId",
                table: "Testimonials");

            migrationBuilder.DropIndex(
                name: "IX_ChefSocialMedias_ChefId",
                table: "ChefSocialMedias");

            migrationBuilder.DropColumn(
                name: "Chefİd",
                table: "ChefSocialMedias");

            migrationBuilder.AddColumn<int>(
                name: "ProfessionId",
                table: "Testimonials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Chefs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Testimonials_ChefId",
                table: "Testimonials",
                column: "ChefId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Testimonials_ProfessionId",
                table: "Testimonials",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_ChefSocialMedias_ChefId",
                table: "ChefSocialMedias",
                column: "ChefId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Testimonials_Professions_ProfessionId",
                table: "Testimonials",
                column: "ProfessionId",
                principalTable: "Professions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Testimonials_Professions_ProfessionId",
                table: "Testimonials");

            migrationBuilder.DropIndex(
                name: "IX_Testimonials_ChefId",
                table: "Testimonials");

            migrationBuilder.DropIndex(
                name: "IX_Testimonials_ProfessionId",
                table: "Testimonials");

            migrationBuilder.DropIndex(
                name: "IX_ChefSocialMedias_ChefId",
                table: "ChefSocialMedias");

            migrationBuilder.DropColumn(
                name: "ProfessionId",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Chefs");

            migrationBuilder.AddColumn<int>(
                name: "Chefİd",
                table: "ChefSocialMedias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Testimonials_ChefId",
                table: "Testimonials",
                column: "ChefId");

            migrationBuilder.CreateIndex(
                name: "IX_ChefSocialMedias_ChefId",
                table: "ChefSocialMedias",
                column: "ChefId");
        }
    }
}

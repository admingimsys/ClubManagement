using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class firstMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnomalieGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LatinTitile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnomalieGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BodyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LatinTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CorrectiveActionGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LatinTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorrectiveActionGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IntroductionMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LatinTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntroductionMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SessionGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LatinTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecialDiseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LatinTitile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialDiseases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LatinTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LatinTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsFood = table.Column<bool>(type: "bit", nullable: true),
                    IsAnomali = table.Column<bool>(type: "bit", nullable: true),
                    IsAction = table.Column<bool>(type: "bit", nullable: true),
                    IsVitalSing = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LatinTitile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Anomalies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LatinTitile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Signs = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Reasons = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PreventionMethod = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AnomalieGroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anomalies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Anomalies_AnomalieGroups_AnomalieGroupId",
                        column: x => x.AnomalieGroupId,
                        principalTable: "AnomalieGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BodyTypeProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BodyTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyTypeProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BodyTypeProperties_BodyTypes_BodyTypeId",
                        column: x => x.BodyTypeId,
                        principalTable: "BodyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CorrectiveActions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreatDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CorrectiveActionGroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorrectiveActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CorrectiveActions_CorrectiveActionGroups_CorrectiveActionGroupId",
                        column: x => x.CorrectiveActionGroupId,
                        principalTable: "CorrectiveActionGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SessionGroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Packages_SessionGroups_SessionGroupId",
                        column: x => x.SessionGroupId,
                        principalTable: "SessionGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LatinTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SessionGroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_SessionGroups_SessionGroupId",
                        column: x => x.SessionGroupId,
                        principalTable: "SessionGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Referreds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Family = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    NationalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PassWord = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IsMarid = table.Column<bool>(type: "bit", nullable: true),
                    Job = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    IntroductionMethodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referreds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Referreds_IntroductionMethods_IntroductionMethodId",
                        column: x => x.IntroductionMethodId,
                        principalTable: "IntroductionMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Referreds_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VitalSigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LatinName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UnitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VitalSigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VitalSigns_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Family = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    MedicalSystemNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Evidence = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PassWord = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BioLink = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    RezumeFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_UserTypes_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "UserTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovementInterferences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CorrectiveActionId = table.Column<int>(type: "int", nullable: false),
                    AnomalieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementInterferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovementInterferences_Anomalies_AnomalieId",
                        column: x => x.AnomalieId,
                        principalTable: "Anomalies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovementInterferences_CorrectiveActions_CorrectiveActionId",
                        column: x => x.CorrectiveActionId,
                        principalTable: "CorrectiveActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalRecordFormFile = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DiseaseBackgrand = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    HadSurgery = table.Column<bool>(type: "bit", nullable: false),
                    DrugUsed = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    HasMetallInBody = table.Column<bool>(type: "bit", nullable: false),
                    HasPreviousDiet = table.Column<bool>(type: "bit", nullable: true),
                    HighestWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LowestWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SleepingTime = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Appetite = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    physicalActivityAmount = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReferredId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthInfos_Referreds_ReferredId",
                        column: x => x.ReferredId,
                        principalTable: "Referreds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    EssentialPhone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReferredId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalInfos_Referreds_ReferredId",
                        column: x => x.ReferredId,
                        principalTable: "Referreds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReferredDiseaseds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SpecialDiseaseId = table.Column<int>(type: "int", nullable: false),
                    ReferredId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferredDiseaseds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReferredDiseaseds_Referreds_ReferredId",
                        column: x => x.ReferredId,
                        principalTable: "Referreds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReferredDiseaseds_SpecialDiseases_SpecialDiseaseId",
                        column: x => x.SpecialDiseaseId,
                        principalTable: "SpecialDiseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VitalSignsResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CorrectiveActionId = table.Column<int>(type: "int", nullable: false),
                    VitalSignsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VitalSignsResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VitalSignsResults_CorrectiveActions_CorrectiveActionId",
                        column: x => x.CorrectiveActionId,
                        principalTable: "CorrectiveActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VitalSignsResults_VitalSigns_VitalSignsId",
                        column: x => x.VitalSignsId,
                        principalTable: "VitalSigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Examinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", maxLength: 50, nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", maxLength: 50, nullable: true),
                    RecoveryRate = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Hour = table.Column<TimeOnly>(type: "time", nullable: true),
                    MedicalRecordFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    BodyTypeId = table.Column<int>(type: "int", nullable: true),
                    ReferredId = table.Column<int>(type: "int", nullable: false),
                    ExportId = table.Column<int>(type: "int", nullable: false),
                    PackageId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Examinations_BodyTypes_BodyTypeId",
                        column: x => x.BodyTypeId,
                        principalTable: "BodyTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Examinations_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Examinations_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Examinations_Referreds_ReferredId",
                        column: x => x.ReferredId,
                        principalTable: "Referreds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Examinations_Users_ExportId",
                        column: x => x.ExportId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurrectionalProgramMaster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    EntranceHour = table.Column<TimeOnly>(type: "time", nullable: true),
                    LeavingHour = table.Column<TimeOnly>(type: "time", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SessionId = table.Column<int>(type: "int", nullable: false),
                    ExaminationId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrectionalProgramMaster", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrectionalProgramMaster_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CurrectionalProgramMaster_Examinations_ExaminationId",
                        column: x => x.ExaminationId,
                        principalTable: "Examinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrectionalProgramMaster_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExaminationAnomalies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AnomalieId = table.Column<int>(type: "int", nullable: false),
                    ExaminationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExaminationAnomalies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExaminationAnomalies_Anomalies_AnomalieId",
                        column: x => x.AnomalieId,
                        principalTable: "Anomalies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExaminationAnomalies_Examinations_ExaminationId",
                        column: x => x.ExaminationId,
                        principalTable: "Examinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurrectionalProgramDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SetCount = table.Column<int>(type: "int", nullable: false),
                    SetValue = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CorrectiveActionId = table.Column<int>(type: "int", nullable: false),
                    CurrectionalProgramMasterId = table.Column<int>(type: "int", nullable: false),
                    ExaminationAnomalieId = table.Column<int>(type: "int", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrectionalProgramDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrectionalProgramDetail_CorrectiveActions_CorrectiveActionId",
                        column: x => x.CorrectiveActionId,
                        principalTable: "CorrectiveActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CurrectionalProgramDetail_CurrectionalProgramMaster_CurrectionalProgramMasterId",
                        column: x => x.CurrectionalProgramMasterId,
                        principalTable: "CurrectionalProgramMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CurrectionalProgramDetail_ExaminationAnomalies_ExaminationAnomalieId",
                        column: x => x.ExaminationAnomalieId,
                        principalTable: "ExaminationAnomalies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CurrectionalProgramDetail_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anomalies_AnomalieGroupId",
                table: "Anomalies",
                column: "AnomalieGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyTypeProperties_BodyTypeId",
                table: "BodyTypeProperties",
                column: "BodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CorrectiveActions_CorrectiveActionGroupId",
                table: "CorrectiveActions",
                column: "CorrectiveActionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrectionalProgramDetail_CorrectiveActionId",
                table: "CurrectionalProgramDetail",
                column: "CorrectiveActionId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrectionalProgramDetail_CurrectionalProgramMasterId",
                table: "CurrectionalProgramDetail",
                column: "CurrectionalProgramMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrectionalProgramDetail_ExaminationAnomalieId",
                table: "CurrectionalProgramDetail",
                column: "ExaminationAnomalieId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrectionalProgramDetail_UnitId",
                table: "CurrectionalProgramDetail",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrectionalProgramMaster_BranchId",
                table: "CurrectionalProgramMaster",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrectionalProgramMaster_ExaminationId",
                table: "CurrectionalProgramMaster",
                column: "ExaminationId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrectionalProgramMaster_SessionId",
                table: "CurrectionalProgramMaster",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExaminationAnomalies_AnomalieId",
                table: "ExaminationAnomalies",
                column: "AnomalieId");

            migrationBuilder.CreateIndex(
                name: "IX_ExaminationAnomalies_ExaminationId",
                table: "ExaminationAnomalies",
                column: "ExaminationId");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_BodyTypeId",
                table: "Examinations",
                column: "BodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_BranchId",
                table: "Examinations",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_ExportId",
                table: "Examinations",
                column: "ExportId");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_PackageId",
                table: "Examinations",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_ReferredId",
                table: "Examinations",
                column: "ReferredId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthInfos_ReferredId",
                table: "HealthInfos",
                column: "ReferredId");

            migrationBuilder.CreateIndex(
                name: "IX_MovementInterferences_AnomalieId",
                table: "MovementInterferences",
                column: "AnomalieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovementInterferences_CorrectiveActionId",
                table: "MovementInterferences",
                column: "CorrectiveActionId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_SessionGroupId",
                table: "Packages",
                column: "SessionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInfos_ReferredId",
                table: "PersonalInfos",
                column: "ReferredId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferredDiseaseds_ReferredId",
                table: "ReferredDiseaseds",
                column: "ReferredId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferredDiseaseds_SpecialDiseaseId",
                table: "ReferredDiseaseds",
                column: "SpecialDiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Referreds_IntroductionMethodId",
                table: "Referreds",
                column: "IntroductionMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Referreds_StateId",
                table: "Referreds",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_SessionGroupId",
                table: "Sessions",
                column: "SessionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTypeId",
                table: "Users",
                column: "UserTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VitalSigns_UnitId",
                table: "VitalSigns",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_VitalSignsResults_CorrectiveActionId",
                table: "VitalSignsResults",
                column: "CorrectiveActionId");

            migrationBuilder.CreateIndex(
                name: "IX_VitalSignsResults_VitalSignsId",
                table: "VitalSignsResults",
                column: "VitalSignsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BodyTypeProperties");

            migrationBuilder.DropTable(
                name: "CurrectionalProgramDetail");

            migrationBuilder.DropTable(
                name: "HealthInfos");

            migrationBuilder.DropTable(
                name: "MovementInterferences");

            migrationBuilder.DropTable(
                name: "PersonalInfos");

            migrationBuilder.DropTable(
                name: "ReferredDiseaseds");

            migrationBuilder.DropTable(
                name: "VitalSignsResults");

            migrationBuilder.DropTable(
                name: "CurrectionalProgramMaster");

            migrationBuilder.DropTable(
                name: "ExaminationAnomalies");

            migrationBuilder.DropTable(
                name: "SpecialDiseases");

            migrationBuilder.DropTable(
                name: "CorrectiveActions");

            migrationBuilder.DropTable(
                name: "VitalSigns");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Anomalies");

            migrationBuilder.DropTable(
                name: "Examinations");

            migrationBuilder.DropTable(
                name: "CorrectiveActionGroups");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "AnomalieGroups");

            migrationBuilder.DropTable(
                name: "BodyTypes");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "Referreds");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "SessionGroups");

            migrationBuilder.DropTable(
                name: "IntroductionMethods");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "UserTypes");
        }
    }
}

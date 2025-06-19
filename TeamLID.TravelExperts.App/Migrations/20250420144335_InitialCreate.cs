using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lf_egypt.App.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Affiliations",
                columns: table => new
                {
                    AffilitationId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AffName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AffDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("aaaaaAffiliations_PK", x => x.AffilitationId);
                });

            migrationBuilder.CreateTable(
                name: "Agencies",
                columns: table => new
                {
                    AgencyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgncyAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AgncyCity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AgncyProv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AgncyPostal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AgncyCountry = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AgncyPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AgncyFax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencies", x => x.AgencyId);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassId = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    ClassName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ClassDesc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("aaaaaClasses_PK", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Fees",
                columns: table => new
                {
                    FeeId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FeeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FeeAmt = table.Column<decimal>(type: "money", nullable: false),
                    FeeDesc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("aaaaaFees_PK", x => x.FeeId);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    PackageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PkgName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PkgStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PkgEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PkgDesc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PkgBasePrice = table.Column<decimal>(type: "money", nullable: false),
                    PkgAgencyCommission = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("aaaaaPackages_PK", x => x.PackageId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("aaaaaProducts_PK", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    RegionId = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    RegionName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("aaaaaRegions_PK", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "Rewards",
                columns: table => new
                {
                    RewardId = table.Column<int>(type: "int", nullable: false),
                    RwdName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RwdDesc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("aaaaaRewards_PK", x => x.RewardId);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    SupName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("aaaaaSuppliers_PK", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "TripTypes",
                columns: table => new
                {
                    TripTypeId = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TTName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("aaaaaTripTypes_PK", x => x.TripTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    AgentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgtFirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AgtMiddleInitial = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    AgtLastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AgtBusPhone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AgtEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AgtPosition = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AgencyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.AgentId);
                    table.ForeignKey(
                        name: "FK_Agents_Agencies",
                        column: x => x.AgencyId,
                        principalTable: "Agencies",
                        principalColumn: "AgencyId");
                });

            migrationBuilder.CreateTable(
                name: "Products_Suppliers",
                columns: table => new
                {
                    ProductSupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    SupplierId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("aaaaaProducts_Suppliers_PK", x => x.ProductSupplierId);
                    table.ForeignKey(
                        name: "Products_Suppliers_FK00",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                    table.ForeignKey(
                        name: "Products_Suppliers_FK01",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId");
                });

            migrationBuilder.CreateTable(
                name: "SupplierContacts",
                columns: table => new
                {
                    SupplierContactId = table.Column<int>(type: "int", nullable: false),
                    SupConFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SupConLastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SupConCompany = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SupConAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SupConCity = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SupConProv = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SupConPostal = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SupConCountry = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SupConBusPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SupConFax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SupConEmail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SupConURL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AffiliationId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SupplierId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("aaaaaSupplierContacts_PK", x => x.SupplierContactId);
                    table.ForeignKey(
                        name: "SupplierContacts_FK00",
                        column: x => x.AffiliationId,
                        principalTable: "Affiliations",
                        principalColumn: "AffilitationId");
                    table.ForeignKey(
                        name: "SupplierContacts_FK01",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId");
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustFirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CustLastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CustAddress = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CustCity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustProv = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    CustPostal = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    CustCountry = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CustHomePhone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CustBusPhone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CustEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AgentId = table.Column<int>(type: "int", nullable: true),
                    username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("aaaaaCustomers_PK", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_Agents",
                        column: x => x.AgentId,
                        principalTable: "Agents",
                        principalColumn: "AgentId");
                });

            migrationBuilder.CreateTable(
                name: "Packages_Products_Suppliers",
                columns: table => new
                {
                    PackageId = table.Column<int>(type: "int", nullable: false),
                    ProductSupplierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("aaaaaPackages_Products_Suppliers_PK", x => new { x.PackageId, x.ProductSupplierId });
                    table.ForeignKey(
                        name: "Packages_Products_Supplie_FK00",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "PackageId");
                    table.ForeignKey(
                        name: "Packages_Products_Supplie_FK01",
                        column: x => x.ProductSupplierId,
                        principalTable: "Products_Suppliers",
                        principalColumn: "ProductSupplierId");
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    BookingNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TravelerCount = table.Column<double>(type: "float", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    TripTypeId = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    PackageId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("aaaaaBookings_PK", x => x.BookingId);
                    table.ForeignKey(
                        name: "Bookings_FK00",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "Bookings_FK01",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "PackageId");
                    table.ForeignKey(
                        name: "Bookings_FK02",
                        column: x => x.TripTypeId,
                        principalTable: "TripTypes",
                        principalColumn: "TripTypeId");
                });

            migrationBuilder.CreateTable(
                name: "CreditCards",
                columns: table => new
                {
                    CreditCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CCName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CCNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CCExpiry = table.Column<DateTime>(type: "datetime", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("aaaaaCreditCards_PK", x => x.CreditCardId);
                    table.ForeignKey(
                        name: "CreditCards_FK00",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                });

            migrationBuilder.CreateTable(
                name: "Customers_Rewards",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    RewardId = table.Column<int>(type: "int", nullable: false),
                    RwdNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("aaaaaCustomers_Rewards_PK", x => new { x.CustomerId, x.RewardId });
                    table.ForeignKey(
                        name: "Customers_Rewards_FK00",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "Customers_Rewards_FK01",
                        column: x => x.RewardId,
                        principalTable: "Rewards",
                        principalColumn: "RewardId");
                });

            migrationBuilder.CreateTable(
                name: "BookingDetails",
                columns: table => new
                {
                    BookingDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItineraryNo = table.Column<double>(type: "float", nullable: true),
                    TripStart = table.Column<DateTime>(type: "datetime", nullable: true),
                    TripEnd = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Destination = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BasePrice = table.Column<decimal>(type: "money", nullable: true),
                    AgencyCommission = table.Column<decimal>(type: "money", nullable: true),
                    BookingId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    RegionId = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    ClassId = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    FeeId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ProductSupplierId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("aaaaaBookingDetails_PK", x => x.BookingDetailId);
                    table.ForeignKey(
                        name: "FK_BookingDetails_Bookings",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingDetails_Classes",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId");
                    table.ForeignKey(
                        name: "FK_BookingDetails_Fees",
                        column: x => x.FeeId,
                        principalTable: "Fees",
                        principalColumn: "FeeId");
                    table.ForeignKey(
                        name: "FK_BookingDetails_Products_Suppliers",
                        column: x => x.ProductSupplierId,
                        principalTable: "Products_Suppliers",
                        principalColumn: "ProductSupplierId");
                    table.ForeignKey(
                        name: "FK_BookingDetails_Regions",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Affiliations_AffilitationId",
                table: "Affiliations",
                column: "AffilitationId")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "IX_Agents_AgencyId",
                table: "Agents",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "BookingsBookingDetails",
                table: "BookingDetails",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "ClassesBookingDetails",
                table: "BookingDetails",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "DestinationsBookingDetails",
                table: "BookingDetails",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "FeesBookingDetails",
                table: "BookingDetails",
                column: "FeeId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetails_BookingDetailId",
                table: "BookingDetails",
                column: "BookingDetailId")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "ProductSupplierId",
                table: "BookingDetails",
                column: "ProductSupplierId");

            migrationBuilder.CreateIndex(
                name: "CustomersBookings",
                table: "Bookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_BookingId",
                table: "Bookings",
                column: "BookingId")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "PackagesBookings",
                table: "Bookings",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "TripTypesBookings",
                table: "Bookings",
                column: "TripTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_ClassId",
                table: "Classes",
                column: "ClassId")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "CustomersCreditCards",
                table: "CreditCards",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditCards_CreditCardId",
                table: "CreditCards",
                column: "CreditCardId")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "EmployeesCustomers",
                table: "Customers",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "idx_username_notnull",
                table: "Customers",
                column: "username",
                unique: true,
                filter: "([username] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerId",
                table: "Customers",
                column: "CustomerId")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "CustomersCustomers_Rewards",
                table: "Customers_Rewards",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Rewards_CustomerId_RewardId",
                table: "Customers_Rewards",
                columns: new[] { "CustomerId", "RewardId" })
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "RewardsCustomers_Rewards",
                table: "Customers_Rewards",
                column: "RewardId");

            migrationBuilder.CreateIndex(
                name: "IX_Fees_FeeId",
                table: "Fees",
                column: "FeeId")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "IX_Packages_PackageId",
                table: "Packages",
                column: "PackageId")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "IX_Packages_Products_Suppliers_PackageId_ProductSupplierId",
                table: "Packages_Products_Suppliers",
                columns: new[] { "PackageId", "ProductSupplierId" })
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "PackagesPackages_Products_Suppliers",
                table: "Packages_Products_Suppliers",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "ProductSupplierId",
                table: "Packages_Products_Suppliers",
                column: "ProductSupplierId");

            migrationBuilder.CreateIndex(
                name: "ProductId",
                table: "Products",
                column: "ProductId")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "ProductsProducts_Suppliers1",
                table: "Products_Suppliers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "ProductSupplierId",
                table: "Products_Suppliers",
                column: "ProductSupplierId")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "SuppliersProducts_Suppliers1",
                table: "Products_Suppliers",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Regions_RegionId",
                table: "Regions",
                column: "RegionId")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "IX_Rewards_RewardId",
                table: "Rewards",
                column: "RewardId")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "AffiliationsSupCon",
                table: "SupplierContacts",
                column: "AffiliationId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierContacts_SupplierContactId",
                table: "SupplierContacts",
                column: "SupplierContactId")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "SuppliersSupCon",
                table: "SupplierContacts",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "SupplierId",
                table: "Suppliers",
                column: "SupplierId")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "IX_TripTypes_TripTypeId",
                table: "TripTypes",
                column: "TripTypeId")
                .Annotation("SqlServer:Clustered", false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingDetails");

            migrationBuilder.DropTable(
                name: "CreditCards");

            migrationBuilder.DropTable(
                name: "Customers_Rewards");

            migrationBuilder.DropTable(
                name: "Packages_Products_Suppliers");

            migrationBuilder.DropTable(
                name: "SupplierContacts");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Fees");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Rewards");

            migrationBuilder.DropTable(
                name: "Products_Suppliers");

            migrationBuilder.DropTable(
                name: "Affiliations");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "TripTypes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropTable(
                name: "Agencies");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Carpark.Database.Migrations
{
    /// <inheritdoc />
    public partial class seedWithRandomData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "LicensePlate", "Colour", "Comments", "ConstructionYear", "LentTo", "Status" },
                values: new object[,]
                {
                    { "BD842Z", "Beige", "Supervisor Coordinator Rufiyaa", 2023, null, 5 },
                    { "BK776K", "Red", "deliver Tennessee Credit Card Account", 2018, null, 5 },
                    { "BL223Z", "Blue", "conglomeration", 2021, null, 2 },
                    { "BT820R", "Purple", "Pike Washington Corporate", 2015, null, 5 },
                    { "BV280N", "Pink", "Auto Loan Account", 2019, null, 1 },
                    { "BX175H", "White", "3rd generation Greens", 2023, null, 5 },
                    { "FH318J", "Orange", "Indian Rupee B2B", 2021, null, 2 },
                    { "FK900N", "Black", "reinvent Brooks system-worthy", 2023, null, 5 },
                    { "FM847N", "White", "customized dynamic", 2021, null, 1 },
                    { "FN440J", "Brown", "Sleek Rubber Ball Small syndicate", 2018, null, 4 },
                    { "FS446K", "White", "best-of-breed methodologies withdrawal", 2015, null, 1 },
                    { "FX850D", "Brown", "calculate", 2016, null, 5 },
                    { "FY780P", "Yellow", "maximize hacking", 2023, null, 2 },
                    { "GB097V", "Pink", "SDD Eritrea", 2023, null, 2 },
                    { "GG863Z", "White", "mint green", 2019, null, 2 },
                    { "GH056G", "Black", "Avon", 2014, null, 1 },
                    { "GL021K", "Blue", "Fresh Cayman Islands Dollar", 2017, null, 5 },
                    { "GL738N", "Green", "redundant utilize", 2021, null, 2 },
                    { "HD962K", "Blue", "Savings Account Gorgeous Concrete Chips", 2018, null, 2 },
                    { "HF319B", "Black", "Credit Card Account Azerbaijan", 2013, null, 4 },
                    { "HF609X", "Blue", "Clothing & Electronics Tasty", 2014, null, 5 },
                    { "HT080S", "Yellow", "productize Licensed", 2022, null, 4 },
                    { "HW525J", "Black", "Oregon salmon", 2018, null, 5 },
                    { "JN759B", "Red", "Music, Toys & Computers", 2023, null, 2 },
                    { "JP680X", "Beige", "District Wisconsin Developer", 2014, null, 5 },
                    { "JV340J", "Brown", "Soft New York", 2020, null, 2 },
                    { "JW496R", "Beige", "Albania paradigm Rustic Fresh Cheese", 2020, null, 2 },
                    { "JY187Y", "Pink", "Meadows", 2015, null, 4 },
                    { "KV633J", "Blue", "markets Functionality", 2023, null, 1 },
                    { "KZ816W", "Purple", "Graphic Interface discrete solutions", 2016, null, 1 },
                    { "LJ662B", "Yellow", "Lebanese Pound synthesize mint green", 2021, null, 5 },
                    { "LN011Z", "Purple", "violet", 2014, null, 5 },
                    { "LY168M", "Brown", "Checking Account structure", 2019, null, 1 },
                    { "LZ723M", "White", "navigate Licensed", 2018, null, 4 },
                    { "MK225M", "Green", "invoice ability", 2022, null, 2 },
                    { "MR387J", "Blue", "Generic Concrete Chips payment", 2015, null, 1 },
                    { "MR565W", "Pink", "infrastructures Tools & Books interfaces", 2015, null, 5 },
                    { "NJ652X", "Brown", "interface", 2018, null, 1 },
                    { "NY941F", "Blue", "synthesizing", 2019, null, 4 },
                    { "NZ468K", "Black", "methodical Incredible Wooden Shirt", 2021, null, 5 },
                    { "PB210P", "Purple", "matrix out-of-the-box", 2016, null, 2 },
                    { "PN681M", "Green", "ADP emulation bifurcated", 2018, null, 4 },
                    { "PR512X", "Green", "Camp", 2014, null, 1 },
                    { "PZ799D", "Beige", "Soft upward-trending", 2020, null, 1 },
                    { "RD974L", "Yellow", "Usability content monitor", 2019, null, 5 },
                    { "RH901V", "Purple", "solution", 2023, null, 2 },
                    { "RJ756T", "Yellow", "e-tailers Administrator", 2017, null, 5 },
                    { "RK448V", "White", "embrace even-keeled", 2014, null, 2 },
                    { "RS259M", "Brown", "Borders invoice Cambridgeshire", 2019, null, 1 },
                    { "RT250X", "Orange", "5th generation", 2017, null, 5 },
                    { "SJ068Y", "Purple", "port", 2013, null, 1 },
                    { "SJ217F", "Purple", "integrate", 2014, null, 4 },
                    { "SJ306Y", "Yellow", "Steel", 2015, null, 1 },
                    { "SK966K", "Blue", "Practical Wooden Pizza end-to-end", 2014, null, 2 },
                    { "SV127B", "Pink", "Clothing & Automotive", 2022, null, 5 },
                    { "SX295F", "Beige", "Future Indiana", 2013, null, 2 },
                    { "TB587Z", "Beige", "compressing Gabon", 2022, null, 2 },
                    { "TD382Z", "Black", "withdrawal Namibia Dollar", 2021, null, 4 },
                    { "TG593F", "Green", "neural encompassing Refined Metal Bike", 2020, null, 5 },
                    { "TJ019N", "Brown", "Sleek proactive Frozen", 2020, null, 2 },
                    { "TT185J", "Blue", "SQL", 2017, null, 2 },
                    { "TX247J", "Beige", "framework Incredible Frozen Salad Credit Card Account", 2021, null, 2 },
                    { "VF445H", "Blue", "CSS quantify Operations", 2023, null, 5 },
                    { "VH186F", "Blue", "multi-byte structure programming", 2016, null, 2 },
                    { "VN364Y", "White", "Data robust Generic Frozen Shoes", 2020, null, 5 },
                    { "VS752K", "Purple", "haptic mesh", 2019, null, 4 },
                    { "VV679S", "Blue", "Response Practical Concrete Car Home Loan Account", 2022, null, 1 },
                    { "VV839K", "Green", "enhance Exclusive South Carolina", 2015, null, 4 },
                    { "VZ208H", "Green", "Automated Credit Card Account Russian Ruble", 2014, null, 2 },
                    { "WG207W", "Beige", "Handcrafted Proactive", 2019, null, 5 },
                    { "WJ824D", "Orange", "grow program Manors", 2019, null, 5 },
                    { "WL188Y", "Orange", "Berkshire", 2020, null, 5 },
                    { "WP000Z", "Beige", "Unbranded Plastic Pizza Metal Home", 2019, null, 1 },
                    { "WX719P", "Purple", "Algerian Dinar", 2016, null, 5 },
                    { "WY020M", "Black", "Visionary turquoise back up", 2022, null, 5 },
                    { "WZ984N", "White", "Borders Greenland Global", 2017, null, 5 },
                    { "XB682P", "Green", "Garden, Baby & Health", 2015, null, 5 },
                    { "XG710R", "Pink", "benchmark Right-sized", 2018, null, 4 },
                    { "XJ339K", "White", "Designer Robust", 2013, null, 5 },
                    { "XK093W", "Blue", "paradigms gold toolset", 2023, null, 2 },
                    { "XX251Z", "Blue", "Chief bandwidth", 2021, null, 5 },
                    { "XY701X", "Red", "Wall", 2021, null, 4 },
                    { "YB606L", "Beige", "Shoes & Music revolutionary", 2021, null, 2 },
                    { "YH774Z", "Green", "quantifying", 2020, null, 5 },
                    { "YJ334K", "Orange", "Ergonomic benchmark", 2014, null, 1 },
                    { "YM630P", "Orange", "Hungary alarm embrace", 2016, null, 5 },
                    { "YR816N", "White", "Gardens solid state Buckinghamshire", 2018, null, 1 },
                    { "YV353R", "Black", "Steel", 2018, null, 5 },
                    { "YX047S", "Orange", "mint green Handcrafted Concrete Shirt protocol", 2022, null, 1 },
                    { "YX469W", "Red", "Viaduct", 2021, null, 1 },
                    { "YX859X", "Orange", "Investor Mobility", 2015, null, 1 },
                    { "YY113P", "Green", "Brazil Representative Norfolk Island", 2016, null, 5 },
                    { "ZH055Y", "Green", "Soft Ergonomic Centralized", 2015, null, 1 },
                    { "ZH245H", "Red", "pixel withdrawal Corner", 2015, null, 2 },
                    { "ZH723S", "Red", "protocol", 2017, null, 1 },
                    { "ZJ663T", "Purple", "Forward Music & Baby", 2017, null, 1 },
                    { "ZP901Y", "Blue", "foreground", 2013, null, 1 },
                    { "ZT913Y", "White", "wireless", 2020, null, 1 },
                    { "ZV215Z", "Blue", "withdrawal", 2020, null, 5 },
                    { "ZX907J", "Black", "Unbranded Soft Salad matrix", 2018, null, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "BD842Z");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "BK776K");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "BL223Z");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "BT820R");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "BV280N");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "BX175H");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "FH318J");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "FK900N");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "FM847N");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "FN440J");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "FS446K");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "FX850D");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "FY780P");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "GB097V");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "GG863Z");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "GH056G");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "GL021K");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "GL738N");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "HD962K");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "HF319B");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "HF609X");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "HT080S");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "HW525J");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "JN759B");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "JP680X");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "JV340J");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "JW496R");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "JY187Y");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "KV633J");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "KZ816W");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "LJ662B");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "LN011Z");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "LY168M");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "LZ723M");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "MK225M");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "MR387J");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "MR565W");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "NJ652X");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "NY941F");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "NZ468K");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "PB210P");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "PN681M");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "PR512X");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "PZ799D");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "RD974L");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "RH901V");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "RJ756T");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "RK448V");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "RS259M");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "RT250X");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "SJ068Y");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "SJ217F");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "SJ306Y");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "SK966K");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "SV127B");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "SX295F");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "TB587Z");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "TD382Z");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "TG593F");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "TJ019N");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "TT185J");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "TX247J");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "VF445H");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "VH186F");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "VN364Y");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "VS752K");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "VV679S");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "VV839K");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "VZ208H");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "WG207W");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "WJ824D");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "WL188Y");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "WP000Z");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "WX719P");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "WY020M");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "WZ984N");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "XB682P");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "XG710R");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "XJ339K");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "XK093W");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "XX251Z");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "XY701X");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "YB606L");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "YH774Z");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "YJ334K");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "YM630P");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "YR816N");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "YV353R");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "YX047S");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "YX469W");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "YX859X");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "YY113P");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "ZH055Y");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "ZH245H");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "ZH723S");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "ZJ663T");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "ZP901Y");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "ZT913Y");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "ZV215Z");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "LicensePlate",
                keyValue: "ZX907J");
        }
    }
}

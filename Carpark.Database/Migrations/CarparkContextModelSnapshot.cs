﻿// <auto-generated />
using Carpark.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Carpark.Database.Migrations
{
    [DbContext(typeof(CarparkContext))]
    partial class CarparkContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("Carpark.Database.Entities.Car", b =>
                {
                    b.Property<string>("LicensePlate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ConstructionYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("LicensePlate");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            LicensePlate = "ZV215Z",
                            Colour = "Blue",
                            Comments = "withdrawal",
                            ConstructionYear = 2020,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "BL223Z",
                            Colour = "Blue",
                            Comments = "conglomeration",
                            ConstructionYear = 2021,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "TT185J",
                            Colour = "Blue",
                            Comments = "SQL",
                            ConstructionYear = 2017,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "NY941F",
                            Colour = "Blue",
                            Comments = "synthesizing",
                            ConstructionYear = 2019,
                            Status = 4
                        },
                        new
                        {
                            LicensePlate = "SX295F",
                            Colour = "Beige",
                            Comments = "Future Indiana",
                            ConstructionYear = 2013,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "RK448V",
                            Colour = "White",
                            Comments = "embrace even-keeled",
                            ConstructionYear = 2014,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "PZ799D",
                            Colour = "Beige",
                            Comments = "Soft upward-trending",
                            ConstructionYear = 2020,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "TG593F",
                            Colour = "Green",
                            Comments = "neural encompassing Refined Metal Bike",
                            ConstructionYear = 2020,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "GL021K",
                            Colour = "Blue",
                            Comments = "Fresh Cayman Islands Dollar",
                            ConstructionYear = 2017,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "VV679S",
                            Colour = "Blue",
                            Comments = "Response Practical Concrete Car Home Loan Account",
                            ConstructionYear = 2022,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "SJ068Y",
                            Colour = "Purple",
                            Comments = "port",
                            ConstructionYear = 2013,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "HW525J",
                            Colour = "Black",
                            Comments = "Oregon salmon",
                            ConstructionYear = 2018,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "KV633J",
                            Colour = "Blue",
                            Comments = "markets Functionality",
                            ConstructionYear = 2023,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "WZ984N",
                            Colour = "White",
                            Comments = "Borders Greenland Global",
                            ConstructionYear = 2017,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "YX469W",
                            Colour = "Red",
                            Comments = "Viaduct",
                            ConstructionYear = 2021,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "XX251Z",
                            Colour = "Blue",
                            Comments = "Chief bandwidth",
                            ConstructionYear = 2021,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "BT820R",
                            Colour = "Purple",
                            Comments = "Pike Washington Corporate",
                            ConstructionYear = 2015,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "ZH055Y",
                            Colour = "Green",
                            Comments = "Soft Ergonomic Centralized",
                            ConstructionYear = 2015,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "ZH723S",
                            Colour = "Red",
                            Comments = "protocol",
                            ConstructionYear = 2017,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "YX859X",
                            Colour = "Orange",
                            Comments = "Investor Mobility",
                            ConstructionYear = 2015,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "WG207W",
                            Colour = "Beige",
                            Comments = "Handcrafted Proactive",
                            ConstructionYear = 2019,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "VZ208H",
                            Colour = "Green",
                            Comments = "Automated Credit Card Account Russian Ruble",
                            ConstructionYear = 2014,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "GB097V",
                            Colour = "Pink",
                            Comments = "SDD Eritrea",
                            ConstructionYear = 2023,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "RJ756T",
                            Colour = "Yellow",
                            Comments = "e-tailers Administrator",
                            ConstructionYear = 2017,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "LJ662B",
                            Colour = "Yellow",
                            Comments = "Lebanese Pound synthesize mint green",
                            ConstructionYear = 2021,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "ZJ663T",
                            Colour = "Purple",
                            Comments = "Forward Music & Baby",
                            ConstructionYear = 2017,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "HF609X",
                            Colour = "Blue",
                            Comments = "Clothing & Electronics Tasty",
                            ConstructionYear = 2014,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "FM847N",
                            Colour = "White",
                            Comments = "customized dynamic",
                            ConstructionYear = 2021,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "KZ816W",
                            Colour = "Purple",
                            Comments = "Graphic Interface discrete solutions",
                            ConstructionYear = 2016,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "ZX907J",
                            Colour = "Black",
                            Comments = "Unbranded Soft Salad matrix",
                            ConstructionYear = 2018,
                            Status = 4
                        },
                        new
                        {
                            LicensePlate = "TJ019N",
                            Colour = "Brown",
                            Comments = "Sleek proactive Frozen",
                            ConstructionYear = 2020,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "XJ339K",
                            Colour = "White",
                            Comments = "Designer Robust",
                            ConstructionYear = 2013,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "YM630P",
                            Colour = "Orange",
                            Comments = "Hungary alarm embrace",
                            ConstructionYear = 2016,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "TD382Z",
                            Colour = "Black",
                            Comments = "withdrawal Namibia Dollar",
                            ConstructionYear = 2021,
                            Status = 4
                        },
                        new
                        {
                            LicensePlate = "MR387J",
                            Colour = "Blue",
                            Comments = "Generic Concrete Chips payment",
                            ConstructionYear = 2015,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "SK966K",
                            Colour = "Blue",
                            Comments = "Practical Wooden Pizza end-to-end",
                            ConstructionYear = 2014,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "WL188Y",
                            Colour = "Orange",
                            Comments = "Berkshire",
                            ConstructionYear = 2020,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "PR512X",
                            Colour = "Green",
                            Comments = "Camp",
                            ConstructionYear = 2014,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "XK093W",
                            Colour = "Blue",
                            Comments = "paradigms gold toolset",
                            ConstructionYear = 2023,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "VN364Y",
                            Colour = "White",
                            Comments = "Data robust Generic Frozen Shoes",
                            ConstructionYear = 2020,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "HF319B",
                            Colour = "Black",
                            Comments = "Credit Card Account Azerbaijan",
                            ConstructionYear = 2013,
                            Status = 4
                        },
                        new
                        {
                            LicensePlate = "FN440J",
                            Colour = "Brown",
                            Comments = "Sleek Rubber Ball Small syndicate",
                            ConstructionYear = 2018,
                            Status = 4
                        },
                        new
                        {
                            LicensePlate = "ZH245H",
                            Colour = "Red",
                            Comments = "pixel withdrawal Corner",
                            ConstructionYear = 2015,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "FH318J",
                            Colour = "Orange",
                            Comments = "Indian Rupee B2B",
                            ConstructionYear = 2021,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "VS752K",
                            Colour = "Purple",
                            Comments = "haptic mesh",
                            ConstructionYear = 2019,
                            Status = 4
                        },
                        new
                        {
                            LicensePlate = "XG710R",
                            Colour = "Pink",
                            Comments = "benchmark Right-sized",
                            ConstructionYear = 2018,
                            Status = 4
                        },
                        new
                        {
                            LicensePlate = "GH056G",
                            Colour = "Black",
                            Comments = "Avon",
                            ConstructionYear = 2014,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "ZT913Y",
                            Colour = "White",
                            Comments = "wireless",
                            ConstructionYear = 2020,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "LY168M",
                            Colour = "Brown",
                            Comments = "Checking Account structure",
                            ConstructionYear = 2019,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "SJ217F",
                            Colour = "Purple",
                            Comments = "integrate",
                            ConstructionYear = 2014,
                            Status = 4
                        },
                        new
                        {
                            LicensePlate = "PB210P",
                            Colour = "Purple",
                            Comments = "matrix out-of-the-box",
                            ConstructionYear = 2016,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "WJ824D",
                            Colour = "Orange",
                            Comments = "grow program Manors",
                            ConstructionYear = 2019,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "MK225M",
                            Colour = "Green",
                            Comments = "invoice ability",
                            ConstructionYear = 2022,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "YY113P",
                            Colour = "Green",
                            Comments = "Brazil Representative Norfolk Island",
                            ConstructionYear = 2016,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "XY701X",
                            Colour = "Red",
                            Comments = "Wall",
                            ConstructionYear = 2021,
                            Status = 4
                        },
                        new
                        {
                            LicensePlate = "BX175H",
                            Colour = "White",
                            Comments = "3rd generation Greens",
                            ConstructionYear = 2023,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "TB587Z",
                            Colour = "Beige",
                            Comments = "compressing Gabon",
                            ConstructionYear = 2022,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "FY780P",
                            Colour = "Yellow",
                            Comments = "maximize hacking",
                            ConstructionYear = 2023,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "GL738N",
                            Colour = "Green",
                            Comments = "redundant utilize",
                            ConstructionYear = 2021,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "LN011Z",
                            Colour = "Purple",
                            Comments = "violet",
                            ConstructionYear = 2014,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "XB682P",
                            Colour = "Green",
                            Comments = "Garden, Baby & Health",
                            ConstructionYear = 2015,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "FK900N",
                            Colour = "Black",
                            Comments = "reinvent Brooks system-worthy",
                            ConstructionYear = 2023,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "YH774Z",
                            Colour = "Green",
                            Comments = "quantifying",
                            ConstructionYear = 2020,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "YX047S",
                            Colour = "Orange",
                            Comments = "mint green Handcrafted Concrete Shirt protocol",
                            ConstructionYear = 2022,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "HT080S",
                            Colour = "Yellow",
                            Comments = "productize Licensed",
                            ConstructionYear = 2022,
                            Status = 4
                        },
                        new
                        {
                            LicensePlate = "BD842Z",
                            Colour = "Beige",
                            Comments = "Supervisor Coordinator Rufiyaa",
                            ConstructionYear = 2023,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "RT250X",
                            Colour = "Orange",
                            Comments = "5th generation",
                            ConstructionYear = 2017,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "VF445H",
                            Colour = "Blue",
                            Comments = "CSS quantify Operations",
                            ConstructionYear = 2023,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "BK776K",
                            Colour = "Red",
                            Comments = "deliver Tennessee Credit Card Account",
                            ConstructionYear = 2018,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "SV127B",
                            Colour = "Pink",
                            Comments = "Clothing & Automotive",
                            ConstructionYear = 2022,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "RH901V",
                            Colour = "Purple",
                            Comments = "solution",
                            ConstructionYear = 2023,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "WX719P",
                            Colour = "Purple",
                            Comments = "Algerian Dinar",
                            ConstructionYear = 2016,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "JY187Y",
                            Colour = "Pink",
                            Comments = "Meadows",
                            ConstructionYear = 2015,
                            Status = 4
                        },
                        new
                        {
                            LicensePlate = "LZ723M",
                            Colour = "White",
                            Comments = "navigate Licensed",
                            ConstructionYear = 2018,
                            Status = 4
                        },
                        new
                        {
                            LicensePlate = "GG863Z",
                            Colour = "White",
                            Comments = "mint green",
                            ConstructionYear = 2019,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "YV353R",
                            Colour = "Black",
                            Comments = "Steel",
                            ConstructionYear = 2018,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "MR565W",
                            Colour = "Pink",
                            Comments = "infrastructures Tools & Books interfaces",
                            ConstructionYear = 2015,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "JW496R",
                            Colour = "Beige",
                            Comments = "Albania paradigm Rustic Fresh Cheese",
                            ConstructionYear = 2020,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "FX850D",
                            Colour = "Brown",
                            Comments = "calculate",
                            ConstructionYear = 2016,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "JN759B",
                            Colour = "Red",
                            Comments = "Music, Toys & Computers",
                            ConstructionYear = 2023,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "YB606L",
                            Colour = "Beige",
                            Comments = "Shoes & Music revolutionary",
                            ConstructionYear = 2021,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "ZP901Y",
                            Colour = "Blue",
                            Comments = "foreground",
                            ConstructionYear = 2013,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "JP680X",
                            Colour = "Beige",
                            Comments = "District Wisconsin Developer",
                            ConstructionYear = 2014,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "WP000Z",
                            Colour = "Beige",
                            Comments = "Unbranded Plastic Pizza Metal Home",
                            ConstructionYear = 2019,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "NZ468K",
                            Colour = "Black",
                            Comments = "methodical Incredible Wooden Shirt",
                            ConstructionYear = 2021,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "NJ652X",
                            Colour = "Brown",
                            Comments = "interface",
                            ConstructionYear = 2018,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "FS446K",
                            Colour = "White",
                            Comments = "best-of-breed methodologies withdrawal",
                            ConstructionYear = 2015,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "SJ306Y",
                            Colour = "Yellow",
                            Comments = "Steel",
                            ConstructionYear = 2015,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "VV839K",
                            Colour = "Green",
                            Comments = "enhance Exclusive South Carolina",
                            ConstructionYear = 2015,
                            Status = 4
                        },
                        new
                        {
                            LicensePlate = "PN681M",
                            Colour = "Green",
                            Comments = "ADP emulation bifurcated",
                            ConstructionYear = 2018,
                            Status = 4
                        },
                        new
                        {
                            LicensePlate = "BV280N",
                            Colour = "Pink",
                            Comments = "Auto Loan Account",
                            ConstructionYear = 2019,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "JV340J",
                            Colour = "Brown",
                            Comments = "Soft New York",
                            ConstructionYear = 2020,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "TX247J",
                            Colour = "Beige",
                            Comments = "framework Incredible Frozen Salad Credit Card Account",
                            ConstructionYear = 2021,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "WY020M",
                            Colour = "Black",
                            Comments = "Visionary turquoise back up",
                            ConstructionYear = 2022,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "HD962K",
                            Colour = "Blue",
                            Comments = "Savings Account Gorgeous Concrete Chips",
                            ConstructionYear = 2018,
                            Status = 2
                        },
                        new
                        {
                            LicensePlate = "RD974L",
                            Colour = "Yellow",
                            Comments = "Usability content monitor",
                            ConstructionYear = 2019,
                            Status = 5
                        },
                        new
                        {
                            LicensePlate = "YR816N",
                            Colour = "White",
                            Comments = "Gardens solid state Buckinghamshire",
                            ConstructionYear = 2018,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "YJ334K",
                            Colour = "Orange",
                            Comments = "Ergonomic benchmark",
                            ConstructionYear = 2014,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "RS259M",
                            Colour = "Brown",
                            Comments = "Borders invoice Cambridgeshire",
                            ConstructionYear = 2019,
                            Status = 1
                        },
                        new
                        {
                            LicensePlate = "VH186F",
                            Colour = "Blue",
                            Comments = "multi-byte structure programming",
                            ConstructionYear = 2016,
                            Status = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

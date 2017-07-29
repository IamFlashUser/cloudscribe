﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using cloudscribe.Core.Storage.EFCore.pgsql;

namespace cloudscribe.Core.Storage.EFCore.pgsql.Migrations
{
    [DbContext(typeof(CoreDbContext))]
    partial class CoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:PostgresExtension:uuid-ossp", "'uuid-ossp', '', ''")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("cloudscribe.Core.Models.Geography.GeoCountry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ISOCode2")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("ISOCode3")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("ISOCode2");

                    b.ToTable("cs_GeoCountry");
                    
                });

            modelBuilder.Entity("cloudscribe.Core.Models.Geography.GeoZone", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<Guid>("CountryId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Code");

                    b.HasIndex("CountryId");

                    b.ToTable("cs_GeoZone");

                });

            modelBuilder.Entity("cloudscribe.Core.Models.SiteHost", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("HostName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<Guid>("SiteId");

                    b.HasKey("Id");

                    b.HasIndex("HostName");

                    b.HasIndex("SiteId");

                    b.ToTable("cs_SiteHost");

                });

            modelBuilder.Entity("cloudscribe.Core.Models.SiteRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NormalizedRoleName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("SiteId");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("NormalizedRoleName");

                    b.HasIndex("SiteId");

                    b.ToTable("cs_Role");

                });

            modelBuilder.Entity("cloudscribe.Core.Models.SiteSettings", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountApprovalEmailCsv");

                    b.Property<string>("AddThisDotComUsername")
                        .HasMaxLength(50);

                    b.Property<string>("AliasId")
                        .HasMaxLength(36);

                    b.Property<bool>("AllowDbFallbackWithLdap");

                    b.Property<bool>("AllowNewRegistration");

                    b.Property<bool>("AllowPersistentLogin");

                    b.Property<bool>("AutoCreateLdapUserOnFirstLogin");

                    b.Property<bool>("CaptchaOnLogin");

                    b.Property<bool>("CaptchaOnRegistration");

                    b.Property<string>("CompanyCountry")
                        .HasMaxLength(10);

                    b.Property<string>("CompanyFax")
                        .HasMaxLength(20);

                    b.Property<string>("CompanyLocality")
                        .HasMaxLength(200);

                    b.Property<string>("CompanyName")
                        .HasMaxLength(250);

                    b.Property<string>("CompanyPhone")
                        .HasMaxLength(20);

                    b.Property<string>("CompanyPostalCode")
                        .HasMaxLength(20);

                    b.Property<string>("CompanyPublicEmail")
                        .HasMaxLength(100);

                    b.Property<string>("CompanyRegion")
                        .HasMaxLength(200);

                    b.Property<string>("CompanyStreetAddress")
                        .HasMaxLength(250);

                    b.Property<string>("CompanyStreetAddress2")
                        .HasMaxLength(250);

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DefaultEmailFromAddress")
                        .HasMaxLength(100);

                    b.Property<string>("DefaultEmailFromAlias")
                        .HasMaxLength(100);

                    b.Property<bool>("DisableDbAuth");

                    b.Property<string>("DkimDomain")
                        .HasMaxLength(255);

                    b.Property<string>("DkimPrivateKey");

                    b.Property<string>("DkimPublicKey");

                    b.Property<string>("DkimSelector")
                        .HasMaxLength(128);

                    b.Property<bool>("EmailLdapDbFallback");

                    b.Property<string>("FacebookAppId")
                        .HasMaxLength(100);

                    b.Property<string>("FacebookAppSecret");

                    b.Property<string>("ForcedCulture")
                        .HasMaxLength(10);

                    b.Property<string>("ForcedUICulture")
                        .HasMaxLength(10);

                    b.Property<string>("GoogleAnalyticsProfileId")
                        .HasMaxLength(25);

                    b.Property<string>("GoogleClientId")
                        .HasMaxLength(100);

                    b.Property<string>("GoogleClientSecret");

                    b.Property<bool>("IsDataProtected");

                    b.Property<bool>("IsServerAdminSite");

                    b.Property<string>("LdapDomain")
                        .HasMaxLength(255);

                    b.Property<int>("LdapPort");

                    b.Property<string>("LdapRootDN")
                        .HasMaxLength(255);

                    b.Property<string>("LdapServer")
                        .HasMaxLength(255);

                    b.Property<string>("LdapUserDNKey")
                        .HasMaxLength(10);

                    b.Property<string>("LoginInfoBottom");

                    b.Property<string>("LoginInfoTop");

                    b.Property<int>("MaxInvalidPasswordAttempts");

                    b.Property<string>("MicrosoftClientId")
                        .HasMaxLength(100);

                    b.Property<string>("MicrosoftClientSecret");

                    b.Property<int>("MinRequiredPasswordLength");

                    b.Property<string>("OidConnectAppId")
                        .HasMaxLength(255);

                    b.Property<string>("OidConnectAppSecret")
                        .HasMaxLength(255);

                    b.Property<string>("OidConnectAuthority")
                        .HasMaxLength(255);

                    b.Property<string>("OidConnectDisplayName")
                        .HasMaxLength(150);

                    b.Property<string>("PreferredHostName")
                        .HasMaxLength(250);

                    b.Property<string>("PrivacyPolicy");

                    b.Property<bool>("ReallyDeleteUsers");

                    b.Property<string>("RecaptchaPrivateKey")
                        .HasMaxLength(255);

                    b.Property<string>("RecaptchaPublicKey")
                        .HasMaxLength(255);

                    b.Property<string>("RegistrationAgreement");

                    b.Property<string>("RegistrationPreamble");

                    b.Property<bool>("RequireApprovalBeforeLogin");

                    b.Property<bool>("RequireConfirmedEmail");

                    b.Property<bool>("RequireConfirmedPhone");

                    b.Property<bool>("RequiresQuestionAndAnswer");

                    b.Property<bool>("SignEmailWithDkim");

                    b.Property<string>("SiteFolderName")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("")
                        .HasMaxLength(50);

                    b.Property<bool>("SiteIsClosed");

                    b.Property<string>("SiteIsClosedMessage");

                    b.Property<string>("SiteName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("SmsClientId")
                        .HasMaxLength(255);

                    b.Property<string>("SmsFrom")
                        .HasMaxLength(100);

                    b.Property<string>("SmsSecureToken");

                    b.Property<string>("SmtpPassword");

                    b.Property<int>("SmtpPort");

                    b.Property<string>("SmtpPreferredEncoding")
                        .HasMaxLength(20);

                    b.Property<bool>("SmtpRequiresAuth");

                    b.Property<string>("SmtpServer")
                        .HasMaxLength(200);

                    b.Property<bool>("SmtpUseSsl");

                    b.Property<string>("SmtpUser")
                        .HasMaxLength(500);

                    b.Property<DateTime>("TermsUpdatedUtc");

                    b.Property<string>("Theme")
                        .HasMaxLength(100);

                    b.Property<string>("TimeZoneId")
                        .HasMaxLength(50);

                    b.Property<string>("TwitterConsumerKey")
                        .HasMaxLength(100);

                    b.Property<string>("TwitterConsumerSecret");

                    b.Property<bool>("UseEmailForLogin");

                    b.Property<bool>("UseInvisibleRecaptcha");

                    b.Property<bool>("UseLdapAuth");

                    b.HasKey("Id");

                    b.HasIndex("AliasId");

                    b.HasIndex("SiteFolderName");

                    b.ToTable("cs_Site");

                });

            modelBuilder.Entity("cloudscribe.Core.Models.SiteUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<bool>("AccountApproved");

                    b.Property<DateTime?>("AgreementAcceptedUtc");

                    b.Property<string>("AuthorBio");

                    b.Property<string>("AvatarUrl")
                        .HasMaxLength(255);

                    b.Property<bool>("CanAutoLockout");

                    b.Property<string>("Comment");

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<bool>("DisplayInMemberList");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime?>("EmailConfirmSentUtc");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100);

                    b.Property<string>("Gender");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsLockedOut");

                    b.Property<DateTime?>("LastLoginUtc");

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("LastName")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("LastPasswordChangeUtc");

                    b.Property<DateTime?>("LockoutEndDateUtc");

                    b.Property<bool>("MustChangePwd");

                    b.Property<string>("NewEmail")
                        .HasMaxLength(100);

                    b.Property<bool>("NewEmailApproved");

                    b.Property<string>("NormalizedEmail")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NormalizedUserName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50);

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<bool>("RolesChanged");

                    b.Property<string>("SecurityStamp")
                        .HasMaxLength(50);

                    b.Property<string>("Signature");

                    b.Property<Guid>("SiteId");

                    b.Property<string>("TimeZoneId")
                        .HasMaxLength(50);

                    b.Property<bool>("Trusted");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("WebSiteUrl")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("DisplayName");

                    b.HasIndex("NormalizedEmail");

                    b.HasIndex("NormalizedUserName");

                    b.HasIndex("SiteId");

                    b.ToTable("cs_User");

                });

            modelBuilder.Entity("cloudscribe.Core.Models.UserClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType")
                        .HasMaxLength(255);

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("SiteId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ClaimType");

                    b.HasIndex("SiteId");

                    b.HasIndex("UserId");

                    b.ToTable("cs_UserClaim");

                });

            modelBuilder.Entity("cloudscribe.Core.Models.UserLocation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CaptureCount");

                    b.Property<string>("City")
                        .HasMaxLength(255);

                    b.Property<string>("Continent")
                        .HasMaxLength(255);

                    b.Property<string>("Country")
                        .HasMaxLength(255);

                    b.Property<DateTime>("FirstCaptureUtc");

                    b.Property<string>("HostName")
                        .HasMaxLength(255);

                    b.Property<string>("IpAddress")
                        .HasMaxLength(50);

                    b.Property<long>("IpAddressLong");

                    b.Property<string>("Isp")
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastCaptureUtc");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Region")
                        .HasMaxLength(255);

                    b.Property<Guid>("SiteId");

                    b.Property<string>("TimeZone")
                        .HasMaxLength(255);

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("IpAddress");

                    b.HasIndex("UserId");

                    b.ToTable("cs_UserLocation");

                });

            modelBuilder.Entity("cloudscribe.Core.Models.UserLogin", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("SiteId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasMaxLength(100);

                    b.HasKey("UserId", "SiteId", "LoginProvider", "ProviderKey");

                    b.HasIndex("SiteId");

                    b.HasIndex("UserId");

                    b.ToTable("cs_UserLogin");

                });

            modelBuilder.Entity("cloudscribe.Core.Models.UserRole", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("cs_UserRole");

                });
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cloudscribe.Core.Storage.EFCore.SQLite;

#nullable disable

namespace cloudscribe.Core.Storage.EFCore.SQLite.Migrations
{
    [DbContext(typeof(CoreDbContext))]
    [Migration("20240829112402_cs-core-20240829")]
    partial class cscore20240829
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("cloudscribe.Core.Models.Geography.GeoCountry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ISOCode2")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.Property<string>("ISOCode3")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ISOCode2");

                    b.ToTable("cs_GeoCountry", (string)null);
                });

            modelBuilder.Entity("cloudscribe.Core.Models.Geography.GeoZone", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Code");

                    b.HasIndex("CountryId");

                    b.ToTable("cs_GeoZone", (string)null);
                });

            modelBuilder.Entity("cloudscribe.Core.Models.SiteHost", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("HostName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SiteId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("HostName");

                    b.HasIndex("SiteId");

                    b.ToTable("cs_SiteHost", (string)null);
                });

            modelBuilder.Entity("cloudscribe.Core.Models.SiteRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedRoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SiteId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("NormalizedRoleName");

                    b.HasIndex("SiteId");

                    b.ToTable("cs_Role", (string)null);
                });

            modelBuilder.Entity("cloudscribe.Core.Models.SiteSettings", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountApprovalEmailCsv")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddThisDotComUsername")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("AliasId")
                        .HasMaxLength(36)
                        .HasColumnType("TEXT");

                    b.Property<bool>("AllowNewRegistration")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AllowPersistentLogin")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AllowUserToChangeEmail")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CaptchaOnLogin")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CaptchaOnRegistration")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CompanyCountry")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyFax")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyLocality")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyPhone")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyPostalCode")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyPublicEmail")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyRegion")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyStreetAddress")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyStreetAddress2")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyWebsite")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("CookiePolicySummary")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedUtc")
                        .HasColumnType("TEXT");

                    b.Property<string>("DefaultEmailFromAddress")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("DefaultEmailFromAlias")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<bool>("DisableDbAuth")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DkimDomain")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("DkimPrivateKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("DkimPublicKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("DkimSelector")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailApiEndpoint")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailApiKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailSenderName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasDefaultValue("SmtpMailSender");

                    b.Property<string>("FacebookAppId")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("FacebookAppSecret")
                        .HasColumnType("TEXT");

                    b.Property<string>("FooterContent")
                        .HasColumnType("TEXT");

                    b.Property<string>("ForcedCulture")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("ForcedUICulture")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("GoogleAnalyticsProfileId")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("GoogleClientId")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("GoogleClientSecret")
                        .HasColumnType("TEXT");

                    b.Property<string>("HeaderContent")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDataProtected")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsServerAdminSite")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastModifiedUtc")
                        .HasColumnType("TEXT");

                    b.Property<string>("LdapDomain")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<int>("LdapPort")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LdapRootDN")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("LdapServer")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<bool>("LdapUseSsl")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LdapUserDNFormat")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("LdapUserDNKey")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginInfoBottom")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginInfoTop")
                        .HasColumnType("TEXT");

                    b.Property<string>("LogoUrl")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<int>("MaxInvalidPasswordAttempts")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaximumInactivityInMinutes")
                        .HasColumnType("TEXT");

                    b.Property<string>("MicrosoftClientId")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("MicrosoftClientSecret")
                        .HasColumnType("TEXT");

                    b.Property<int>("MinRequiredPasswordLength")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OidConnectAppId")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("OidConnectAppSecret")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("OidConnectAuthority")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("OidConnectDisplayName")
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("OidConnectScopesCsv")
                        .HasColumnType("TEXT");

                    b.Property<string>("PreferredHostName")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("PrivacyPolicy")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PwdRequireDigit")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("PwdRequireLowercase")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("PwdRequireNonAlpha")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("PwdRequireUppercase")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RecaptchaPrivateKey")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("RecaptchaPublicKey")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("RegRestrictionTld")
                        .HasColumnType("TEXT");

                    b.Property<string>("RegistrationAgreement")
                        .HasColumnType("TEXT");

                    b.Property<string>("RegistrationPreamble")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Require2FA")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("RequireApprovalBeforeLogin")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("RequireConfirmedEmail")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("RequireConfirmedPhone")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("RequireCookieConsent")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("RequiresQuestionAndAnswer")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ShowSiteNameLink")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SignEmailWithDkim")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SingleBrowserSessions")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SiteFolderName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<bool>("SiteIsClosed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SiteIsClosedMessage")
                        .HasColumnType("TEXT");

                    b.Property<string>("SiteName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("SmsClientId")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("SmsFrom")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("SmsSecureToken")
                        .HasColumnType("TEXT");

                    b.Property<string>("SmtpPassword")
                        .HasColumnType("TEXT");

                    b.Property<int>("SmtpPort")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SmtpPreferredEncoding")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<bool>("SmtpRequiresAuth")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SmtpServer")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<bool>("SmtpUseSsl")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SmtpUser")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TermsUpdatedUtc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Theme")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("TimeZoneId")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("TwitterConsumerKey")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("TwitterConsumerSecret")
                        .HasColumnType("TEXT");

                    b.Property<bool>("UseEmailForLogin")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("UseInvisibleRecaptcha")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AliasId");

                    b.HasIndex("SiteFolderName");

                    b.ToTable("cs_Site", (string)null);
                });

            modelBuilder.Entity("cloudscribe.Core.Models.SiteUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AccountApproved")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("AgreementAcceptedUtc")
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthorBio")
                        .HasColumnType("TEXT");

                    b.Property<string>("AvatarUrl")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("BrowserKey")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<bool>("CanAutoLockout")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedUtc")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<bool>("DisplayInMemberList")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EmailConfirmSentUtc")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLockedOut")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastLoginUtc")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastModifiedUtc")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastPasswordChangeUtc")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LockoutEndDateUtc")
                        .HasColumnType("TEXT");

                    b.Property<bool>("MustChangePwd")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NewEmail")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<bool>("NewEmailApproved")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("RolesChanged")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Signature")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SiteId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TimeZoneId")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("WebSiteUrl")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DisplayName");

                    b.HasIndex("NormalizedEmail");

                    b.HasIndex("NormalizedUserName");

                    b.HasIndex("SiteId");

                    b.ToTable("cs_User", (string)null);
                });

            modelBuilder.Entity("cloudscribe.Core.Models.UserClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimType")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SiteId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClaimType");

                    b.HasIndex("SiteId");

                    b.HasIndex("UserId");

                    b.ToTable("cs_UserClaim", (string)null);
                });

            modelBuilder.Entity("cloudscribe.Core.Models.UserLocation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("CaptureCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Continent")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FirstCaptureUtc")
                        .HasColumnType("TEXT");

                    b.Property<string>("HostName")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("IpAddress")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<long>("IpAddressLong")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Isp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastCaptureUtc")
                        .HasColumnType("TEXT");

                    b.Property<double>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<double>("Longitude")
                        .HasColumnType("REAL");

                    b.Property<string>("Region")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SiteId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TimeZone")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IpAddress");

                    b.HasIndex("UserId");

                    b.ToTable("cs_UserLocation", (string)null);
                });

            modelBuilder.Entity("cloudscribe.Core.Models.UserLogin", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SiteId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "SiteId", "LoginProvider", "ProviderKey");

                    b.HasIndex("SiteId");

                    b.HasIndex("UserId");

                    b.ToTable("cs_UserLogin", (string)null);
                });

            modelBuilder.Entity("cloudscribe.Core.Models.UserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("cs_UserRole", (string)null);
                });

            modelBuilder.Entity("cloudscribe.Core.Models.UserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SiteId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(450)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(450)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "SiteId", "LoginProvider", "Name");

                    b.HasIndex("SiteId");

                    b.HasIndex("UserId");

                    b.ToTable("cs_UserToken", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}

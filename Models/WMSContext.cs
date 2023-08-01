using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WorkerService1.Models
{
    public partial class WMSContext : DbContext
    {
        public WMSContext()
        {
        }

        public WMSContext(DbContextOptions<WMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adjustmentreason> Adjustmentreasons { get; set; } = null!;
        public virtual DbSet<AllStatus> AllStatuses { get; set; } = null!;
        public virtual DbSet<Batching> Batchings { get; set; } = null!;
        public virtual DbSet<Batchingitem> Batchingitems { get; set; } = null!;
        public virtual DbSet<Billingcode> Billingcodes { get; set; } = null!;
        public virtual DbSet<Billingfield> Billingfields { get; set; } = null!;
        public virtual DbSet<Carrier> Carriers { get; set; } = null!;
        public virtual DbSet<Carrierservice> Carrierservices { get; set; } = null!;
        public virtual DbSet<Carriertype> Carriertypes { get; set; } = null!;
        public virtual DbSet<CartInfo> CartInfos { get; set; } = null!;
        public virtual DbSet<Carttote> Carttotes { get; set; } = null!;
        public virtual DbSet<Clientcartonsize> Clientcartonsizes { get; set; } = null!;
        public virtual DbSet<Clientshipmethod> Clientshipmethods { get; set; } = null!;
        public virtual DbSet<Clientstafforderlog> Clientstafforderlogs { get; set; } = null!;
        public virtual DbSet<Clientstaffpolog> Clientstaffpologs { get; set; } = null!;
        public virtual DbSet<Clienttag> Clienttags { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Cyclecount> Cyclecounts { get; set; } = null!;
        public virtual DbSet<Cyclecounthistory> Cyclecounthistories { get; set; } = null!;
        public virtual DbSet<Cyclecounttracking> Cyclecounttrackings { get; set; } = null!;
        public virtual DbSet<Damagereason> Damagereasons { get; set; } = null!;
        public virtual DbSet<Defaultmessage> Defaultmessages { get; set; } = null!;
        public virtual DbSet<Deliverytrucktype> Deliverytrucktypes { get; set; } = null!;
        public virtual DbSet<Expiryreason> Expiryreasons { get; set; } = null!;
        public virtual DbSet<Fileupload> Fileuploads { get; set; } = null!;
        public virtual DbSet<Gridfilter> Gridfilters { get; set; } = null!;
        public virtual DbSet<Holidaylist> Holidaylists { get; set; } = null!;
        public virtual DbSet<Integrationcarriermapping> Integrationcarriermappings { get; set; } = null!;
        public virtual DbSet<Integrationchannel> Integrationchannels { get; set; } = null!;
        public virtual DbSet<Integrationdetail> Integrationdetails { get; set; } = null!;
        public virtual DbSet<Integrationmapping> Integrationmappings { get; set; } = null!;
        public virtual DbSet<Integrationproperty> Integrationproperties { get; set; } = null!;
        public virtual DbSet<Integrationtype> Integrationtypes { get; set; } = null!;
        public virtual DbSet<Job> Jobs { get; set; } = null!;
        public virtual DbSet<Kitlog> Kitlogs { get; set; } = null!;
        public virtual DbSet<Localization> Localizations { get; set; } = null!;
        public virtual DbSet<Manifest> Manifests { get; set; } = null!;
        public virtual DbSet<Manifestpackage> Manifestpackages { get; set; } = null!;
        public virtual DbSet<Manifestprintdatum> Manifestprintdata { get; set; } = null!;
        public virtual DbSet<Manifestskupackagedetail> Manifestskupackagedetails { get; set; } = null!;
        public virtual DbSet<Note> Notes { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Ordererrorlog> Ordererrorlogs { get; set; } = null!;
        public virtual DbSet<Orderimport> Orderimports { get; set; } = null!;
        public virtual DbSet<Orderitem> Orderitems { get; set; } = null!;
        public virtual DbSet<Orderitemshistory> Orderitemshistories { get; set; } = null!;
        public virtual DbSet<Orderitemstmp> Orderitemstmps { get; set; } = null!;
        public virtual DbSet<Orderprocessjob> Orderprocessjobs { get; set; } = null!;
        public virtual DbSet<Ordersearchlist> Ordersearchlists { get; set; } = null!;
        public virtual DbSet<Ordershipaddresslog> Ordershipaddresslogs { get; set; } = null!;
        public virtual DbSet<Ordersjob> Ordersjobs { get; set; } = null!;
        public virtual DbSet<Ordersjobitem> Ordersjobitems { get; set; } = null!;
        public virtual DbSet<OrderskuSerial> OrderskuSerials { get; set; } = null!;
        public virtual DbSet<Ordersshipment> Ordersshipments { get; set; } = null!;
        public virtual DbSet<Poissue> Poissues { get; set; } = null!;
        public virtual DbSet<Poschedule> Poschedules { get; set; } = null!;
        public virtual DbSet<Poupload> Pouploads { get; set; } = null!;
        public virtual DbSet<Property> Properties { get; set; } = null!;
        public virtual DbSet<Receivingcontainertype> Receivingcontainertypes { get; set; } = null!;
        public virtual DbSet<Return> Returns { get; set; } = null!;
        public virtual DbSet<Returnitem> Returnitems { get; set; } = null!;
        public virtual DbSet<Robilling> Robillings { get; set; } = null!;
        public virtual DbSet<Rochargecode> Rochargecodes { get; set; } = null!;
        public virtual DbSet<Roreceiving> Roreceivings { get; set; } = null!;
        public virtual DbSet<Roreceivingdetail> Roreceivingdetails { get; set; } = null!;
        public virtual DbSet<Roreceivinghistory> Roreceivinghistories { get; set; } = null!;
        public virtual DbSet<Rotracking> Rotrackings { get; set; } = null!;
        public virtual DbSet<Saleschannel> Saleschannels { get; set; } = null!;
        public virtual DbSet<Sku> Skus { get; set; } = null!;
        public virtual DbSet<Skuautofill> Skuautofills { get; set; } = null!;
        public virtual DbSet<Skubarcode> Skubarcodes { get; set; } = null!;
        public virtual DbSet<Skuinventorylocation> Skuinventorylocations { get; set; } = null!;
        public virtual DbSet<Skuinventorylocationlog> Skuinventorylocationlogs { get; set; } = null!;
        public virtual DbSet<Skukitmapping> Skukitmappings { get; set; } = null!;
        public virtual DbSet<Skulotcode> Skulotcodes { get; set; } = null!;
        public virtual DbSet<Skupackage> Skupackages { get; set; } = null!;
        public virtual DbSet<Skushippingbox> Skushippingboxes { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;
        public virtual DbSet<VOrdersource> VOrdersources { get; set; } = null!;
        public virtual DbSet<ViewOrderShipmentreport> ViewOrderShipmentreports { get; set; } = null!;
        public virtual DbSet<Warehouse> Warehouses { get; set; } = null!;
        public virtual DbSet<Whclient> Whclients { get; set; } = null!;
        public virtual DbSet<Whlocation> Whlocations { get; set; } = null!;
        public virtual DbSet<Whmodule> Whmodules { get; set; } = null!;
        public virtual DbSet<Whuser> Whusers { get; set; } = null!;
        public virtual DbSet<Whuserclient> Whuserclients { get; set; } = null!;
        public virtual DbSet<Whusermodule> Whusermodules { get; set; } = null!;
        public virtual DbSet<Whuserrefreshtoken> Whuserrefreshtokens { get; set; } = null!;
        public virtual DbSet<Whuserwarehouse> Whuserwarehouses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=209.209.40.79;Port=19392;User Id=BOLX2021;Password=bolx@@!!;Database=GLC");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adjustmentreason>(entity =>
            {
                entity.HasKey(e => e.Reasonid)
                    .HasName("pk_adjustmentreason");

                entity.ToTable("adjustmentreason");

                entity.Property(e => e.Reasonid)
                    .ValueGeneratedNever()
                    .HasColumnName("reasonid");

                entity.Property(e => e.Adjustmentreason1)
                    .HasMaxLength(75)
                    .HasColumnName("adjustmentreason");
            });

            modelBuilder.Entity<AllStatus>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("all_status_pkey");

                entity.ToTable("all_status");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .HasColumnName("email");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.StatusCode).HasColumnName("status_code");

                entity.Property(e => e.StatusFor)
                    .HasMaxLength(250)
                    .HasColumnName("status_for");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(250)
                    .HasColumnName("status_name");

                entity.Property(e => e.StatusSequence).HasColumnName("status_sequence");

                entity.Property(e => e.Statustype)
                    .HasColumnType("character varying")
                    .HasColumnName("statustype");

                entity.Property(e => e.Values)
                    .HasMaxLength(150)
                    .HasColumnName("values");
            });

            modelBuilder.Entity<Batching>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("batching_pkey");

                entity.ToTable("batching");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Linecount).HasColumnName("linecount");

                entity.Property(e => e.Shipviaid).HasColumnName("shipviaid");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Batchings)
                    .HasForeignKey(d => d.Clientid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientid_fk");

                entity.HasOne(d => d.Shipvia)
                    .WithMany(p => p.Batchings)
                    .HasForeignKey(d => d.Shipviaid)
                    .HasConstraintName("shipviaid_fk");
            });

            modelBuilder.Entity<Batchingitem>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("batchingitems_pkey");

                entity.ToTable("batchingitems");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Batchid).HasColumnName("batchid");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Skuid).HasColumnName("skuid");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.Batchingitems)
                    .HasForeignKey(d => d.Batchid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("batchid_fk");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.Batchingitems)
                    .HasForeignKey(d => d.Skuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("skuid_fk");
            });

            modelBuilder.Entity<Billingcode>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("billingcodes_pkey");

                entity.ToTable("billingcodes");

                entity.Property(e => e.Uniqueid).HasColumnName("uniqueid");

                entity.Property(e => e.Code)
                    .HasMaxLength(15)
                    .HasColumnName("code");

                entity.Property(e => e.Createddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("createddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasColumnName("description");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Type)
                    .HasColumnType("character varying")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Billingfield>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("billingfields_pkey");

                entity.ToTable("billingfields");

                entity.Property(e => e.Uniqueid).HasColumnName("uniqueid");

                entity.Property(e => e.Billingcode)
                    .HasColumnType("character varying")
                    .HasColumnName("billingcode");

                entity.Property(e => e.Billingtype)
                    .HasColumnType("character varying")
                    .HasColumnName("billingtype");

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Createddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("createddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Description)
                    .HasColumnType("character varying")
                    .HasColumnName("description");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Ordertype)
                    .HasColumnType("character varying")
                    .HasColumnName("ordertype");

                entity.Property(e => e.Packagetype)
                    .HasColumnType("character varying")
                    .HasColumnName("packagetype");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Billingfields)
                    .HasForeignKey(d => d.Clientid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientid_fk");
            });

            modelBuilder.Entity<Carrier>(entity =>
            {
                entity.ToTable("carriers");

                entity.Property(e => e.Carrierid)
                    .HasColumnName("carrierid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Carriername)
                    .HasMaxLength(200)
                    .HasColumnName("carriername");

                entity.Property(e => e.Intgrationtypeid).HasColumnName("intgrationtypeid");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Urltrackpostfix)
                    .HasMaxLength(250)
                    .HasColumnName("urltrackpostfix");

                entity.Property(e => e.Urltrackprefix)
                    .HasMaxLength(250)
                    .HasColumnName("urltrackprefix");

                entity.HasOne(d => d.Intgrationtype)
                    .WithMany(p => p.Carriers)
                    .HasForeignKey(d => d.Intgrationtypeid)
                    .HasConstraintName("fk_carriers_integrationtypes");
            });

            modelBuilder.Entity<Carrierservice>(entity =>
            {
                entity.HasKey(e => e.Shipviaid)
                    .HasName("shipmethods_pkey");

                entity.ToTable("carrierservice");

                entity.Property(e => e.Shipviaid)
                    .HasColumnName("shipviaid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1006L);

                entity.Property(e => e.Accountno)
                    .HasColumnType("character varying")
                    .HasColumnName("accountno");

                entity.Property(e => e.Carrierid).HasColumnName("carrierid");

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Isthirdparty).HasColumnName("isthirdparty");

                entity.Property(e => e.Shippriority).HasColumnName("shippriority");

                entity.Property(e => e.Shipvianame)
                    .HasMaxLength(100)
                    .HasColumnName("shipvianame");

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.Carrierservices)
                    .HasForeignKey(d => d.Carrierid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("carrierid_fk");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Carrierservices)
                    .HasForeignKey(d => d.Clientid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientid_fk");
            });

            modelBuilder.Entity<Carriertype>(entity =>
            {
                entity.ToTable("carriertype");

                entity.Property(e => e.Carriertypeid)
                    .HasColumnName("carriertypeid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Carrierid).HasColumnName("carrierid");

                entity.Property(e => e.Carriertypename)
                    .HasMaxLength(200)
                    .HasColumnName("carriertypename");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.Carriertypes)
                    .HasForeignKey(d => d.Carrierid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("carrierid_fk");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.Carriertypes)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");
            });

            modelBuilder.Entity<CartInfo>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("cart_info_pkey");

                entity.ToTable("cart_info");

                entity.Property(e => e.Uniqueid).HasColumnName("uniqueid");

                entity.Property(e => e.Cartname)
                    .HasMaxLength(50)
                    .HasColumnName("cartname");

                entity.Property(e => e.Cartsize).HasColumnName("cartsize");

                entity.Property(e => e.End).HasColumnName("end");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Isactive)
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Start).HasColumnName("start");
            });

            modelBuilder.Entity<Carttote>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("carttotes_pkey");

                entity.ToTable("carttotes");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Cartid).HasColumnName("cartid");

                entity.Property(e => e.Totename)
                    .HasMaxLength(25)
                    .HasColumnName("totename");

                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.Carttotes)
                    .HasForeignKey(d => d.Cartid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cartid_fk");
            });

            modelBuilder.Entity<Clientcartonsize>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("clientcartonsizes_pkey");

                entity.ToTable("clientcartonsizes");

                entity.Property(e => e.Uniqueid).HasColumnName("uniqueid");

                entity.Property(e => e.Cartontype)
                    .HasColumnType("character varying")
                    .HasColumnName("cartontype");

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Height)
                    .HasMaxLength(5)
                    .HasColumnName("height");

                entity.Property(e => e.Lbs).HasColumnName("lbs");

                entity.Property(e => e.Length)
                    .HasMaxLength(5)
                    .HasColumnName("length");

                entity.Property(e => e.Width)
                    .HasMaxLength(5)
                    .HasColumnName("width");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Clientcartonsizes)
                    .HasForeignKey(d => d.Clientid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientid_fk");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.Clientcartonsizes)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");
            });

            modelBuilder.Entity<Clientshipmethod>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("clientshipmethod_pkey");

                entity.ToTable("clientshipmethod");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Accountname)
                    .HasMaxLength(30)
                    .HasColumnName("accountname");

                entity.Property(e => e.Accountnumber)
                    .HasMaxLength(20)
                    .HasColumnName("accountnumber");

                entity.Property(e => e.Accounttype)
                    .HasMaxLength(100)
                    .HasColumnName("accounttype");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .HasColumnName("address");

                entity.Property(e => e.Carrierid).HasColumnName("carrierid");

                entity.Property(e => e.Carrierref1)
                    .HasMaxLength(70)
                    .HasColumnName("carrierref1");

                entity.Property(e => e.Carrierref2)
                    .HasMaxLength(70)
                    .HasColumnName("carrierref2");

                entity.Property(e => e.Carrierref3)
                    .HasMaxLength(70)
                    .HasColumnName("carrierref3");

                entity.Property(e => e.Carrierref4)
                    .HasMaxLength(70)
                    .HasColumnName("carrierref4");

                entity.Property(e => e.Carrierref5)
                    .HasMaxLength(70)
                    .HasColumnName("carrierref5");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .HasColumnName("city");

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Defaultaccount)
                    .HasColumnName("defaultaccount")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Integrationchannelid).HasColumnName("integrationchannelid");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Ordertype)
                    .HasMaxLength(5)
                    .HasColumnName("ordertype");

                entity.Property(e => e.Postalcode)
                    .HasMaxLength(15)
                    .HasColumnName("postalcode");

                entity.Property(e => e.State)
                    .HasMaxLength(15)
                    .HasColumnName("state");

                entity.Property(e => e.Useclientlogoonlabel).HasColumnName("useclientlogoonlabel");

                entity.Property(e => e.Usemai).HasColumnName("usemai");

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.Clientshipmethods)
                    .HasForeignKey(d => d.Carrierid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("carrierid_fk");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Clientshipmethods)
                    .HasForeignKey(d => d.Clientid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientid_fk");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.ClientshipmethodEntryusers)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");

                entity.HasOne(d => d.Integrationchannel)
                    .WithMany(p => p.Clientshipmethods)
                    .HasForeignKey(d => d.Integrationchannelid)
                    .HasConstraintName("fk_clientshipmethod_integrationchannel");

                entity.HasOne(d => d.Modifieduser)
                    .WithMany(p => p.ClientshipmethodModifiedusers)
                    .HasForeignKey(d => d.Modifieduserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("modifieduserid_fk");
            });

            modelBuilder.Entity<Clientstafforderlog>(entity =>
            {
                entity.HasKey(e => e.Csid)
                    .HasName("StaffOrderLog_pkey");

                entity.ToTable("clientstafforderlog");

                entity.Property(e => e.Csid)
                    .HasColumnName("csid")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Logdatetime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("logdatetime")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Manifestid).HasColumnName("manifestid");

                entity.Property(e => e.Staffid).HasColumnName("staffid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Clientstaffpolog>(entity =>
            {
                entity.HasKey(e => e.Csid)
                    .HasName("ClientStaffPOLog_pkey");

                entity.ToTable("clientstaffpolog");

                entity.Property(e => e.Csid)
                    .HasColumnName("csid")
                    .HasDefaultValueSql("nextval('\"ClientStaffPOLog_csid_seq\"'::regclass)");

                entity.Property(e => e.Logdatetime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("logdatetime")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Poid).HasColumnName("poid");

                entity.Property(e => e.Staffid).HasColumnName("staffid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Clienttag>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("clienttags_pkey");

                entity.ToTable("clienttags");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Tagname)
                    .HasColumnType("character varying")
                    .HasColumnName("tagname");

                entity.Property(e => e.Tagtype)
                    .HasColumnType("character varying")
                    .HasColumnName("tagtype");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Clienttags)
                    .HasForeignKey(d => d.Clientid)
                    .HasConstraintName("clientid_fk");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Country1)
                    .HasMaxLength(90)
                    .HasColumnName("country");
            });

            modelBuilder.Entity<Cyclecount>(entity =>
            {
                entity.ToTable("cyclecount");

                entity.Property(e => e.Cyclecountid)
                    .HasColumnName("cyclecountid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Ccby)
                    .HasMaxLength(15)
                    .HasColumnName("ccby");

                entity.Property(e => e.Cccompletedate).HasColumnName("cccompletedate");

                entity.Property(e => e.Ccdescription)
                    .HasMaxLength(100)
                    .HasColumnName("ccdescription");

                entity.Property(e => e.Ccno)
                    .HasMaxLength(15)
                    .HasColumnName("ccno");

                entity.Property(e => e.Ccstartdate).HasColumnName("ccstartdate");

                entity.Property(e => e.Cctype)
                    .HasMaxLength(15)
                    .HasColumnName("cctype");

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Status)
                    .HasMaxLength(15)
                    .HasColumnName("status");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Cyclecounts)
                    .HasForeignKey(d => d.Clientid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientid_fk");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.CyclecountEntryusers)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");

                entity.HasOne(d => d.Modifieduser)
                    .WithMany(p => p.CyclecountModifiedusers)
                    .HasForeignKey(d => d.Modifieduserid)
                    .HasConstraintName("modifieduserid_fk");
            });

            modelBuilder.Entity<Cyclecounthistory>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("cyclecounthistory_pkey");

                entity.ToTable("cyclecounthistory");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Cyclecountid).HasColumnName("cyclecountid");

                entity.Property(e => e.Cyclecountqty).HasColumnName("cyclecountqty");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Lotcode)
                    .HasMaxLength(50)
                    .HasColumnName("lotcode");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Onhandqty).HasColumnName("onhandqty");

                entity.Property(e => e.Palletid).HasColumnName("palletid");

                entity.Property(e => e.Skuid).HasColumnName("skuid");

                entity.HasOne(d => d.Cyclecount)
                    .WithMany(p => p.Cyclecounthistories)
                    .HasForeignKey(d => d.Cyclecountid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cyclecountid_fk");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.Cyclecounthistories)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.Cyclecounthistories)
                    .HasForeignKey(d => d.Skuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("skuid_fk");
            });

            modelBuilder.Entity<Cyclecounttracking>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("cyclecounttracking_pkey");

                entity.ToTable("cyclecounttracking");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.Cyclecountby)
                    .HasMaxLength(50)
                    .HasColumnName("cyclecountby");

                entity.Property(e => e.Cyclecountid).HasColumnName("cyclecountid");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Noofstaffused)
                    .HasColumnName("noofstaffused")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Taskdate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("taskdate");

                entity.Property(e => e.Totaltimeminutes)
                    .HasColumnName("totaltimeminutes")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.Cyclecount)
                    .WithMany(p => p.Cyclecounttrackings)
                    .HasForeignKey(d => d.Cyclecountid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cyclecountid_fk");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.CyclecounttrackingEntryusers)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");

                entity.HasOne(d => d.Modifieduser)
                    .WithMany(p => p.CyclecounttrackingModifiedusers)
                    .HasForeignKey(d => d.Modifieduserid)
                    .HasConstraintName("modifieduserid_fk");
            });

            modelBuilder.Entity<Damagereason>(entity =>
            {
                entity.HasKey(e => e.Damageid)
                    .HasName("pk_damagereason");

                entity.ToTable("damagereason");

                entity.Property(e => e.Damageid).HasColumnName("damageid");

                entity.Property(e => e.Damagecode)
                    .HasMaxLength(10)
                    .HasColumnName("damagecode");

                entity.Property(e => e.Description)
                    .HasMaxLength(90)
                    .HasColumnName("description");
            });

            modelBuilder.Entity<Defaultmessage>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("defaultmessages_pkey");

                entity.ToTable("defaultmessages");

                entity.Property(e => e.Uniqueid).HasColumnName("uniqueid");

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Subject)
                    .HasMaxLength(250)
                    .HasColumnName("subject");

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Deliverytrucktype>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("deliverytrucktype_pkey");

                entity.ToTable("deliverytrucktype");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Deliverytrucktype1)
                    .HasMaxLength(150)
                    .HasColumnName("deliverytrucktype");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");
            });

            modelBuilder.Entity<Expiryreason>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("expiryreasons");

                entity.Property(e => e.Reasonid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("reasonid")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Reasontype)
                    .HasMaxLength(150)
                    .HasColumnName("reasontype");
            });

            modelBuilder.Entity<Fileupload>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("fileupload_pkey");

                entity.ToTable("fileupload");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Filename)
                    .HasMaxLength(250)
                    .HasColumnName("filename");

                entity.Property(e => e.Manifestid).HasColumnName("manifestid");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(250)
                    .HasColumnName("purpose");

                entity.Property(e => e.Statuscode).HasColumnName("statuscode");

                entity.Property(e => e.Transactionid).HasColumnName("transactionid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<Gridfilter>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("gridfilters_pkey");

                entity.ToTable("gridfilters");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Page)
                    .HasColumnType("character varying")
                    .HasColumnName("page");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Gridfilters)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userid_fk");
            });

            modelBuilder.Entity<Holidaylist>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("holidaylist_pkey");

                entity.ToTable("holidaylist");

                entity.Property(e => e.Uniqueid).HasColumnName("uniqueid");

                entity.Property(e => e.Holidaydate)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("holidaydate");

                entity.Property(e => e.Holidayname)
                    .HasMaxLength(90)
                    .HasColumnName("holidayname");
            });

            modelBuilder.Entity<Integrationcarriermapping>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("integrationcarriermapping_pkey");

                entity.ToTable("integrationcarriermapping");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Integrationid).HasColumnName("integrationid");

                entity.Property(e => e.Mapping)
                    .HasMaxLength(100)
                    .HasColumnName("mapping");

                entity.Property(e => e.Shipviaid).HasColumnName("shipviaid");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Integrationcarriermappings)
                    .HasForeignKey(d => d.Clientid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientid_fk");

                entity.HasOne(d => d.Integration)
                    .WithMany(p => p.Integrationcarriermappings)
                    .HasForeignKey(d => d.Integrationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("integrationid_fk");

                entity.HasOne(d => d.Shipvia)
                    .WithMany(p => p.Integrationcarriermappings)
                    .HasForeignKey(d => d.Shipviaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("shipviaid_fk");
            });

            modelBuilder.Entity<Integrationchannel>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("channelintegration_pkey");

                entity.ToTable("integrationchannel");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Integrationtypeid).HasColumnName("integrationtypeid");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.PullInventory).HasColumnName("pull_inventory");

                entity.Property(e => e.PullOrder).HasColumnName("pull_order");

                entity.Property(e => e.PullRodata).HasColumnName("pull_rodata");

                entity.Property(e => e.PushInventory).HasColumnName("push_inventory");

                entity.Property(e => e.PushReturns).HasColumnName("push_returns");

                entity.Property(e => e.PushRodata).HasColumnName("push_rodata");

                entity.Property(e => e.PushTracking).HasColumnName("push_tracking");

                entity.Property(e => e.StoreTitle)
                    .HasMaxLength(250)
                    .HasColumnName("store_title");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Integrationchannels)
                    .HasForeignKey(d => d.Clientid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientid_fk");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.IntegrationchannelEntryusers)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");

                entity.HasOne(d => d.Integrationtype)
                    .WithMany(p => p.Integrationchannels)
                    .HasForeignKey(d => d.Integrationtypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("integrationtypeid_fk");

                entity.HasOne(d => d.Modifieduser)
                    .WithMany(p => p.IntegrationchannelModifiedusers)
                    .HasForeignKey(d => d.Modifieduserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("modifieduserid");
            });

            modelBuilder.Entity<Integrationdetail>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("integrationdetails_pkey");

                entity.ToTable("integrationdetails");

                entity.Property(e => e.Uniqueid).HasColumnName("uniqueid");

                entity.Property(e => e.Channelid).HasColumnName("channelid");

                entity.Property(e => e.Integrationpropertyid).HasColumnName("integrationpropertyid");

                entity.Property(e => e.Propertyvalue)
                    .HasMaxLength(255)
                    .HasColumnName("propertyvalue");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.Integrationdetails)
                    .HasForeignKey(d => d.Channelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("channelid_fk");

                entity.HasOne(d => d.Integrationproperty)
                    .WithMany(p => p.Integrationdetails)
                    .HasForeignKey(d => d.Integrationpropertyid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("integrationpropertyid_fk");
            });

            modelBuilder.Entity<Integrationmapping>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("channelintegration_customfields_pkey");

                entity.ToTable("integrationmapping");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Channelid).HasColumnName("channelid");

                entity.Property(e => e.Customtype)
                    .HasMaxLength(50)
                    .HasColumnName("customtype");

                entity.Property(e => e.From)
                    .HasMaxLength(100)
                    .HasColumnName("from");

                entity.Property(e => e.To)
                    .HasMaxLength(100)
                    .HasColumnName("to");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.Integrationmappings)
                    .HasForeignKey(d => d.Channelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("channelid_fk");
            });

            modelBuilder.Entity<Integrationproperty>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("properties_pkey");

                entity.ToTable("integrationproperties");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .HasDefaultValueSql("nextval('property_propertyid_seq'::regclass)");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Integrationdatatype)
                    .HasMaxLength(150)
                    .HasColumnName("integrationdatatype");

                entity.Property(e => e.Integrationdisplaytext)
                    .HasMaxLength(150)
                    .HasColumnName("integrationdisplaytext");

                entity.Property(e => e.Integrationpropertyname)
                    .HasMaxLength(150)
                    .HasColumnName("integrationpropertyname");

                entity.Property(e => e.Integrationtypeid).HasColumnName("integrationtypeid");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.HasOne(d => d.Integrationtype)
                    .WithMany(p => p.Integrationproperties)
                    .HasForeignKey(d => d.Integrationtypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("integrationtypeid_fk");
            });

            modelBuilder.Entity<Integrationtype>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("integrationtypes_pkey");

                entity.ToTable("integrationtypes");

                entity.Property(e => e.Uniqueid).HasColumnName("uniqueid");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Integrationname)
                    .HasMaxLength(150)
                    .HasColumnName("integrationname");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Type)
                    .HasColumnType("character varying")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("job_pkey");

                entity.ToTable("job");

                entity.HasIndex(e => e.Cartid, "fki_job_cart_fkey");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Cartid).HasColumnName("cartid");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status");

                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.Cartid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("job_cart_fkey");
            });

            modelBuilder.Entity<Kitlog>(entity =>
            {
                entity.HasKey(e => e.Kid)
                    .HasName("kitlog_pkey");

                entity.ToTable("kitlog");

                entity.Property(e => e.Kid).HasColumnName("kid");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Noofhours).HasColumnName("noofhours");

                entity.Property(e => e.Noofkitscomplete).HasColumnName("noofkitscomplete");

                entity.Property(e => e.Noofpeoples).HasColumnName("noofpeoples");

                entity.Property(e => e.Orderid).HasColumnName("orderid");
            });

            modelBuilder.Entity<Localization>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("localization_pkey");

                entity.ToTable("localization");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.English)
                    .HasColumnType("character varying")
                    .HasColumnName("english");

                entity.Property(e => e.Spanish)
                    .HasColumnType("character varying")
                    .HasColumnName("spanish");
            });

            modelBuilder.Entity<Manifest>(entity =>
            {
                entity.ToTable("manifest");

                entity.HasIndex(e => e.Manifeststatus, "indx_tbl_manifest_col_manifeststatus");

                entity.HasIndex(e => e.Postdate, "indx_tbl_manifest_col_postdate");

                entity.HasIndex(e => new { e.Manifestid, e.Manifeststatus }, "ix_manifest_manifestidmanifeststatus");

                entity.HasIndex(e => new { e.Manifeststatus, e.Manifestid, e.Postdate }, "ix_manifest_statusidpdate");

                entity.Property(e => e.Manifestid)
                    .HasColumnName("manifestid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(5001000L);

                entity.Property(e => e.Canceldate)
                    .HasColumnType("timestamp(3) without time zone")
                    .HasColumnName("canceldate");

                entity.Property(e => e.Canceluserid).HasColumnName("canceluserid");

                entity.Property(e => e.Carrieracct)
                    .HasMaxLength(15)
                    .HasColumnName("carrieracct");

                entity.Property(e => e.Carrierid).HasColumnName("carrierid");

                entity.Property(e => e.Carrierserviceid).HasColumnName("carrierserviceid");

                entity.Property(e => e.Cartonssent).HasColumnName("cartonssent");

                entity.Property(e => e.Comments)
                    .HasMaxLength(150)
                    .HasColumnName("comments");

                entity.Property(e => e.Createdate)
                    .HasColumnType("timestamp(3) without time zone")
                    .HasColumnName("createdate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Createuserid).HasColumnName("createuserid");

                entity.Property(e => e.Manifestsequence)
                    .HasColumnName("manifestsequence")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Manifeststatus)
                    .HasMaxLength(20)
                    .HasColumnName("manifeststatus");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Otherfreight)
                    .HasColumnType("character varying")
                    .HasColumnName("otherfreight");

                entity.Property(e => e.Packagessent).HasColumnName("packagessent");

                entity.Property(e => e.Palletssent).HasColumnName("palletssent");

                entity.Property(e => e.Postdate)
                    .HasColumnType("timestamp(3) without time zone")
                    .HasColumnName("postdate");

                entity.Property(e => e.Postuserid).HasColumnName("postuserid");

                entity.Property(e => e.Servicelevel)
                    .HasColumnType("character varying")
                    .HasColumnName("servicelevel");

                entity.Property(e => e.Shipdate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("shipdate");

                entity.Property(e => e.Unitssent).HasColumnName("unitssent");

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.Manifests)
                    .HasForeignKey(d => d.Carrierid)
                    .HasConstraintName("carrierid_fk");

                entity.HasOne(d => d.Carrierservice)
                    .WithMany(p => p.Manifests)
                    .HasForeignKey(d => d.Carrierserviceid)
                    .HasConstraintName("carrierserviceid_fk");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Manifests)
                    .HasForeignKey(d => d.Orderid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderid_fk");
            });

            modelBuilder.Entity<Manifestpackage>(entity =>
            {
                entity.HasKey(e => e.Packageid)
                    .HasName("manifestpackage_pkey");

                entity.ToTable("manifestpackage");

                entity.Property(e => e.Packageid)
                    .HasColumnName("packageid")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Cartonssent).HasColumnName("cartonssent");

                entity.Property(e => e.Cost)
                    .HasColumnType("money")
                    .HasColumnName("cost");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Isfulfilled)
                    .HasColumnName("isfulfilled")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Manifestid).HasColumnName("manifestid");

                entity.Property(e => e.Negotiatecost)
                    .HasColumnType("money")
                    .HasColumnName("negotiatecost");

                entity.Property(e => e.Packagenumber).HasColumnName("packagenumber");

                entity.Property(e => e.Packagessent).HasColumnName("packagessent");

                entity.Property(e => e.Palletssent).HasColumnName("palletssent");

                entity.Property(e => e.Servicelevel)
                    .HasColumnType("character varying")
                    .HasColumnName("servicelevel");

                entity.Property(e => e.Shipdate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("shipdate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Shipuserid).HasColumnName("shipuserid");

                entity.Property(e => e.Shipviaid).HasColumnName("shipviaid");

                entity.Property(e => e.Trackingnumber)
                    .HasMaxLength(40)
                    .HasColumnName("trackingnumber");

                entity.Property(e => e.Unitssent).HasColumnName("unitssent");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.Manifest)
                    .WithMany(p => p.Manifestpackages)
                    .HasForeignKey(d => d.Manifestid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("manifestid_fk");

                entity.HasOne(d => d.Shipvia)
                    .WithMany(p => p.Manifestpackages)
                    .HasForeignKey(d => d.Shipviaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("shipviaid_fk");
            });

            modelBuilder.Entity<Manifestprintdatum>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("manifestprintdata_pkey");

                entity.ToTable("manifestprintdata");

                entity.Property(e => e.Uniqueid).HasColumnName("uniqueid");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Labelid)
                    .HasMaxLength(100)
                    .HasColumnName("labelid");

                entity.Property(e => e.Manifestid).HasColumnName("manifestid");

                entity.Property(e => e.Printdata)
                    .HasColumnType("character varying")
                    .HasColumnName("printdata");

                entity.Property(e => e.Requesttype)
                    .HasMaxLength(10)
                    .HasColumnName("requesttype");

                entity.Property(e => e.Trackingnumber)
                    .HasMaxLength(40)
                    .HasColumnName("trackingnumber");
            });

            modelBuilder.Entity<Manifestskupackagedetail>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("manifestskupackagedetails_pkey");

                entity.ToTable("manifestskupackagedetails");

                entity.Property(e => e.Uniqueid).HasColumnName("uniqueid");

                entity.Property(e => e.Packageid).HasColumnName("packageid");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Skuid).HasColumnName("skuid");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.Manifestskupackagedetails)
                    .HasForeignKey(d => d.Packageid)
                    .HasConstraintName("packageid_fk");
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("notes_pkey");

                entity.ToTable("notes");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Statuscode).HasColumnName("statuscode");

                entity.Property(e => e.Transactionid).HasColumnName("transactionid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Apprefid)
                    .HasMaxLength(15)
                    .HasColumnName("apprefid");

                entity.Property(e => e.Batchid).HasColumnName("batchid");

                entity.Property(e => e.Batchjobdate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("batchjobdate");

                entity.Property(e => e.Batchjobid)
                    .HasMaxLength(90)
                    .HasColumnName("batchjobid");

                entity.Property(e => e.Carrierlabelref)
                    .HasColumnType("character varying")
                    .HasColumnName("carrierlabelref");

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.Completeshipment)
                    .IsRequired()
                    .HasColumnName("completeshipment")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Createddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("createddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Customerpo)
                    .HasMaxLength(50)
                    .HasColumnName("customerpo");

                entity.Property(e => e.Custorderid)
                    .HasColumnType("character varying")
                    .HasColumnName("custorderid");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Expectedshipdate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("expectedshipdate");

                entity.Property(e => e.Giftmessage).HasColumnName("giftmessage");

                entity.Property(e => e.Internalcomments)
                    .HasColumnType("character varying")
                    .HasColumnName("internalcomments");

                entity.Property(e => e.Isgiftorder).HasColumnName("isgiftorder");

                entity.Property(e => e.Ishold).HasColumnName("ishold");

                entity.Property(e => e.Iskitorder).HasColumnName("iskitorder");

                entity.Property(e => e.Isorderconfirmationsent).HasColumnName("isorderconfirmationsent");

                entity.Property(e => e.Ispartialkit).HasColumnName("ispartialkit");

                entity.Property(e => e.Ispriority).HasColumnName("ispriority");

                entity.Property(e => e.Jobid).HasColumnName("jobid");

                entity.Property(e => e.Kitcompletedqty).HasColumnName("kitcompletedqty");

                entity.Property(e => e.Kitqty).HasColumnName("kitqty");

                entity.Property(e => e.Masterskuid).HasColumnName("masterskuid");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Ordercompleteddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ordercompleteddate");

                entity.Property(e => e.Orderdate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("orderdate");

                entity.Property(e => e.Orderdiscount)
                    .HasColumnType("money")
                    .HasColumnName("orderdiscount");

                entity.Property(e => e.Ordershipcost)
                    .HasColumnType("money")
                    .HasColumnName("ordershipcost");

                entity.Property(e => e.Orderskucost)
                    .HasColumnType("money")
                    .HasColumnName("orderskucost");

                entity.Property(e => e.Orderstatus)
                    .HasMaxLength(20)
                    .HasColumnName("orderstatus")
                    .HasDefaultValueSql("'NEW'::character varying");

                entity.Property(e => e.Ordertax)
                    .HasColumnType("money")
                    .HasColumnName("ordertax");

                entity.Property(e => e.Ordertotal)
                    .HasColumnType("money")
                    .HasColumnName("ordertotal");

                entity.Property(e => e.Ordertype)
                    .HasMaxLength(10)
                    .HasColumnName("ordertype")
                    .HasDefaultValueSql("'B2C'::character varying");

                entity.Property(e => e.Originalorderid)
                    .HasMaxLength(20)
                    .HasColumnName("originalorderid");

                entity.Property(e => e.Preferredshipdate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("preferredshipdate");

                entity.Property(e => e.Saleschannelid).HasColumnName("saleschannelid");

                entity.Property(e => e.Storeid)
                    .HasMaxLength(50)
                    .HasColumnName("storeid");

                entity.Property(e => e.Toteid).HasColumnName("toteid");

                entity.Property(e => e.Vendororderid)
                    .HasMaxLength(20)
                    .HasColumnName("vendororderid");

                entity.Property(e => e.Whid).HasColumnName("whid");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Batchid)
                    .HasConstraintName("batchid_fk");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Clientid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientid_fk");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.OrderEntryusers)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");

                entity.HasOne(d => d.Mastersku)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Masterskuid)
                    .HasConstraintName("masterskuid_fk");

                entity.HasOne(d => d.Modifieduser)
                    .WithMany(p => p.OrderModifiedusers)
                    .HasForeignKey(d => d.Modifieduserid)
                    .HasConstraintName("modifieduserid_fk");

                entity.HasOne(d => d.Wh)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Whid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("whid_fk");
            });

            modelBuilder.Entity<Ordererrorlog>(entity =>
            {
                entity.ToTable("ordererrorlog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Customerorderid)
                    .HasMaxLength(50)
                    .HasColumnName("customerorderid");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Error).HasColumnName("error");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Ordersource).HasColumnName("ordersource");

                entity.Property(e => e.Process)
                    .HasMaxLength(15)
                    .HasColumnName("process");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Ordererrorlogs)
                    .HasForeignKey(d => d.Clientid)
                    .HasConstraintName("clientid_fk");

                entity.HasOne(d => d.OrdersourceNavigation)
                    .WithMany(p => p.Ordererrorlogs)
                    .HasForeignKey(d => d.Ordersource)
                    .HasConstraintName("ordersource_fk");
            });

            modelBuilder.Entity<Orderimport>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("orderimport_pkey");

                entity.ToTable("orderimport");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.BillToAddress1)
                    .HasMaxLength(255)
                    .HasColumnName("bill_to_address_1");

                entity.Property(e => e.BillToAddress2)
                    .HasMaxLength(255)
                    .HasColumnName("bill_to_address_2");

                entity.Property(e => e.BillToAttention)
                    .HasMaxLength(255)
                    .HasColumnName("bill_to_attention");

                entity.Property(e => e.BillToCity)
                    .HasMaxLength(255)
                    .HasColumnName("bill_to_city");

                entity.Property(e => e.BillToCompany)
                    .HasMaxLength(255)
                    .HasColumnName("bill_to_company");

                entity.Property(e => e.BillToCountry)
                    .HasMaxLength(255)
                    .HasColumnName("bill_to_country");

                entity.Property(e => e.BillToEmail)
                    .HasMaxLength(255)
                    .HasColumnName("bill_to_email");

                entity.Property(e => e.BillToFirstName)
                    .HasMaxLength(255)
                    .HasColumnName("bill_to_first_name");

                entity.Property(e => e.BillToLastName)
                    .HasMaxLength(255)
                    .HasColumnName("bill_to_last_name");

                entity.Property(e => e.BillToName)
                    .HasMaxLength(255)
                    .HasColumnName("bill_to_name");

                entity.Property(e => e.BillToPhone).HasColumnName("bill_to_phone");

                entity.Property(e => e.BillToPostal)
                    .HasMaxLength(255)
                    .HasColumnName("bill_to_postal");

                entity.Property(e => e.BillToRegion)
                    .HasMaxLength(255)
                    .HasColumnName("bill_to_region");

                entity.Property(e => e.BusinessRuleCode)
                    .HasMaxLength(255)
                    .HasColumnName("business_rule_code");

                entity.Property(e => e.Channel)
                    .HasMaxLength(255)
                    .HasColumnName("channel");

                entity.Property(e => e.ConsumerOrderNumber).HasColumnName("consumer_order_number");

                entity.Property(e => e.DscoCreateDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dsco_create_date");

                entity.Property(e => e.DscoItemId).HasColumnName("dsco_item_id");

                entity.Property(e => e.DscoLastUpdateDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dsco_last_update_date");

                entity.Property(e => e.DscoLifecycle)
                    .HasMaxLength(255)
                    .HasColumnName("dsco_lifecycle");

                entity.Property(e => e.DscoOrderId).HasColumnName("dsco_order_id");

                entity.Property(e => e.DscoOrderStatus)
                    .HasMaxLength(255)
                    .HasColumnName("dsco_order_status");

                entity.Property(e => e.DscoRetailerId).HasColumnName("dsco_retailer_id");

                entity.Property(e => e.DscoSupplierId).HasColumnName("dsco_supplier_id");

                entity.Property(e => e.DscoSupplierName)
                    .HasMaxLength(255)
                    .HasColumnName("dsco_supplier_name");

                entity.Property(e => e.DscoTradingPartnerId).HasColumnName("dsco_trading_partner_id");

                entity.Property(e => e.DscoTradingPartnerName)
                    .HasMaxLength(255)
                    .HasColumnName("dsco_trading_partner_name");

                entity.Property(e => e.DscoTradingPartnerParentId)
                    .HasMaxLength(255)
                    .HasColumnName("dsco_trading_partner_parent_id");

                entity.Property(e => e.LineItemConsumerPrice).HasColumnName("line_item_consumer_price");

                entity.Property(e => e.LineItemExpectedCost).HasColumnName("line_item_expected_cost");

                entity.Property(e => e.LineItemGiftFlag).HasColumnName("line_item_gift_flag");

                entity.Property(e => e.LineItemLineNumber).HasColumnName("line_item_line_number");

                entity.Property(e => e.LineItemPartnerSku).HasColumnName("line_item_partner_sku");

                entity.Property(e => e.LineItemQuantity).HasColumnName("line_item_quantity");

                entity.Property(e => e.LineItemRequestedShipDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("line_item_requested_ship_date");

                entity.Property(e => e.LineItemRetailerItemId1)
                    .HasMaxLength(255)
                    .HasColumnName("line_item_retailer_item_id_1");

                entity.Property(e => e.LineItemShipByDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("line_item_ship_by_date");

                entity.Property(e => e.LineItemSku)
                    .HasMaxLength(255)
                    .HasColumnName("line_item_sku");

                entity.Property(e => e.LineItemTaxAmount1).HasColumnName("line_item_tax_amount_1");

                entity.Property(e => e.LineItemTitle)
                    .HasMaxLength(255)
                    .HasColumnName("line_item_title");

                entity.Property(e => e.LineItemUpc).HasColumnName("line_item_upc");

                entity.Property(e => e.NumberOfLineItems).HasColumnName("number_of_line_items");

                entity.Property(e => e.OrderType)
                    .HasMaxLength(255)
                    .HasColumnName("order_type");

                entity.Property(e => e.PoNumber).HasColumnName("po_number");

                entity.Property(e => e.RetailerCreateDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("retailer_create_date");

                entity.Property(e => e.RetailerShipCarrier)
                    .HasMaxLength(255)
                    .HasColumnName("retailer_ship_carrier");

                entity.Property(e => e.RetailerShipMethod)
                    .HasMaxLength(255)
                    .HasColumnName("retailer_ship_method");

                entity.Property(e => e.RetailerShippingServiceLevelCode)
                    .HasMaxLength(255)
                    .HasColumnName("retailer_shipping_service_level_code");

                entity.Property(e => e.ShipAddress1)
                    .HasMaxLength(255)
                    .HasColumnName("ship_address_1");

                entity.Property(e => e.ShipAddress2)
                    .HasMaxLength(255)
                    .HasColumnName("ship_address_2");

                entity.Property(e => e.ShipAddress3)
                    .HasMaxLength(255)
                    .HasColumnName("ship_address_3");

                entity.Property(e => e.ShipAttention)
                    .HasMaxLength(255)
                    .HasColumnName("ship_attention");

                entity.Property(e => e.ShipCarrier)
                    .HasMaxLength(255)
                    .HasColumnName("ship_carrier");

                entity.Property(e => e.ShipCity)
                    .HasMaxLength(255)
                    .HasColumnName("ship_city");

                entity.Property(e => e.ShipCompany)
                    .HasMaxLength(255)
                    .HasColumnName("ship_company");

                entity.Property(e => e.ShipCountry)
                    .HasMaxLength(255)
                    .HasColumnName("ship_country");

                entity.Property(e => e.ShipEmail)
                    .HasMaxLength(255)
                    .HasColumnName("ship_email");

                entity.Property(e => e.ShipFirstName)
                    .HasMaxLength(255)
                    .HasColumnName("ship_first_name");

                entity.Property(e => e.ShipLastName)
                    .HasMaxLength(255)
                    .HasColumnName("ship_last_name");

                entity.Property(e => e.ShipMethod)
                    .HasMaxLength(255)
                    .HasColumnName("ship_method");

                entity.Property(e => e.ShipName)
                    .HasMaxLength(255)
                    .HasColumnName("ship_name");

                entity.Property(e => e.ShipPhone).HasColumnName("ship_phone");

                entity.Property(e => e.ShipPostal).HasColumnName("ship_postal");

                entity.Property(e => e.ShipRegion)
                    .HasMaxLength(255)
                    .HasColumnName("ship_region");

                entity.Property(e => e.ShipStoreNumber)
                    .HasMaxLength(255)
                    .HasColumnName("ship_store_number");

                entity.Property(e => e.ShippingServiceLevelCode)
                    .HasMaxLength(255)
                    .HasColumnName("shipping_service_level_code");
            });

            modelBuilder.Entity<Orderitem>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("orderitems_pkey");

                entity.ToTable("orderitems");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .HasDefaultValueSql("nextval('orderitems_uid_seq'::regclass)");

                entity.Property(e => e.Apprefid)
                    .HasMaxLength(15)
                    .HasColumnName("apprefid");

                entity.Property(e => e.Bkoqty).HasColumnName("bkoqty");

                entity.Property(e => e.Cancelqty).HasColumnName("cancelqty");

                entity.Property(e => e.Extitemcost)
                    .HasColumnType("money")
                    .HasColumnName("extitemcost");

                entity.Property(e => e.Itemcost)
                    .HasColumnType("money")
                    .HasColumnName("itemcost");

                entity.Property(e => e.Kitid)
                    .HasColumnType("character varying[]")
                    .HasColumnName("kitid");

                entity.Property(e => e.Kitqty)
                    .HasColumnType("character varying[]")
                    .HasColumnName("kitqty");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Manifestid).HasColumnName("manifestid");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Orderqty).HasColumnName("orderqty");

                entity.Property(e => e.Returnqty).HasColumnName("returnqty");

                entity.Property(e => e.Shipqty).HasColumnName("shipqty");

                entity.Property(e => e.Skuid).HasColumnName("skuid");

                entity.Property(e => e.Skulineno)
                    .HasMaxLength(10)
                    .HasColumnName("skulineno");

                entity.Property(e => e.Uom)
                    .HasColumnType("character varying")
                    .HasColumnName("uom");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Orderitems)
                    .HasForeignKey(d => d.Locationid)
                    .HasConstraintName("locationid_fk");

                entity.HasOne(d => d.Manifest)
                    .WithMany(p => p.Orderitems)
                    .HasForeignKey(d => d.Manifestid)
                    .HasConstraintName("manifestid_fk");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Orderitems)
                    .HasForeignKey(d => d.Orderid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderid_fkey");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.Orderitems)
                    .HasForeignKey(d => d.Skuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("skuid_fk");
            });

            modelBuilder.Entity<Orderitemshistory>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("orderitemshistory_pkey");

                entity.ToTable("orderitemshistory");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Isskip)
                    .HasColumnName("isskip")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Lotcode)
                    .HasMaxLength(50)
                    .HasColumnName("lotcode");

                entity.Property(e => e.Lotexpdate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("lotexpdate");

                entity.Property(e => e.Manifestid).HasColumnName("manifestid");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Orderitemsid).HasColumnName("orderitemsid");

                entity.Property(e => e.Packageid).HasColumnName("packageid");

                entity.Property(e => e.Pickeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("pickeddate");

                entity.Property(e => e.Pickeduserid).HasColumnName("pickeduserid");

                entity.Property(e => e.Pickqty).HasColumnName("pickqty");

                entity.Property(e => e.Qcdate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("qcdate");

                entity.Property(e => e.Qcdone).HasColumnName("qcdone");

                entity.Property(e => e.Qcqty).HasColumnName("qcqty");

                entity.Property(e => e.Qcuserid).HasColumnName("qcuserid");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Siluniqueid).HasColumnName("siluniqueid");

                entity.Property(e => e.Skuid).HasColumnName("skuid");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Orderitemshistories)
                    .HasForeignKey(d => d.Locationid)
                    .HasConstraintName("locationid_fk");

                entity.HasOne(d => d.Manifest)
                    .WithMany(p => p.Orderitemshistories)
                    .HasForeignKey(d => d.Manifestid)
                    .HasConstraintName("manifestid_fk");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Orderitemshistories)
                    .HasForeignKey(d => d.Orderid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderid_fkey");

                entity.HasOne(d => d.Orderitems)
                    .WithMany(p => p.Orderitemshistories)
                    .HasForeignKey(d => d.Orderitemsid)
                    .HasConstraintName("orderitemsid_fk");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.Orderitemshistories)
                    .HasForeignKey(d => d.Packageid)
                    .HasConstraintName("packageid_fk");

                entity.HasOne(d => d.Pickeduser)
                    .WithMany(p => p.OrderitemshistoryPickedusers)
                    .HasForeignKey(d => d.Pickeduserid)
                    .HasConstraintName("pickeduserid_fk");

                entity.HasOne(d => d.Qcuser)
                    .WithMany(p => p.OrderitemshistoryQcusers)
                    .HasForeignKey(d => d.Qcuserid)
                    .HasConstraintName("qcuserid_fk");

                entity.HasOne(d => d.Silunique)
                    .WithMany(p => p.Orderitemshistories)
                    .HasForeignKey(d => d.Siluniqueid)
                    .HasConstraintName("siluniqueid_fk");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.Orderitemshistories)
                    .HasForeignKey(d => d.Skuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("skuid_fk");
            });

            modelBuilder.Entity<Orderitemstmp>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("orderitemstmp_pkey");

                entity.ToTable("orderitemstmp");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Customerorderid)
                    .HasMaxLength(30)
                    .HasColumnName("customerorderid");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryunserid).HasColumnName("entryunserid");

                entity.Property(e => e.Noupdate)
                    .HasColumnName("noupdate")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Orderqty).HasColumnName("orderqty");

                entity.Property(e => e.Ordersubid)
                    .HasMaxLength(30)
                    .HasColumnName("ordersubid");

                entity.Property(e => e.Promoskucost)
                    .HasColumnType("money")
                    .HasColumnName("promoskucost");

                entity.Property(e => e.Sku)
                    .HasMaxLength(100)
                    .HasColumnName("sku");

                entity.Property(e => e.Skucost)
                    .HasColumnType("money")
                    .HasColumnName("skucost");

                entity.Property(e => e.Skuid).HasColumnName("skuid");

                entity.Property(e => e.Skulineno)
                    .HasMaxLength(50)
                    .HasColumnName("skulineno");

                entity.HasOne(d => d.SkuNavigation)
                    .WithMany(p => p.Orderitemstmps)
                    .HasForeignKey(d => d.Skuid)
                    .HasConstraintName("skuid_fk");
            });

            modelBuilder.Entity<Orderprocessjob>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("orderprocessjob_pkey");

                entity.ToTable("orderprocessjob");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Executetime)
                    .HasColumnType("character varying(150)[]")
                    .HasColumnName("executetime");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Skuid).HasColumnName("skuid");

                entity.Property(e => e.Sourceid).HasColumnName("sourceid");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Orderprocessjobs)
                    .HasForeignKey(d => d.Clientid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientid_fk");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.Orderprocessjobs)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");
            });

            modelBuilder.Entity<Ordersearchlist>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("ordersearchlist_pkey");

                entity.ToTable("ordersearchlist");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Carrierid).HasColumnName("carrierid");

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Enddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("enddate");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Manifestid)
                    .HasMaxLength(25)
                    .HasColumnName("manifestid");

                entity.Property(e => e.Manifeststatus)
                    .HasColumnType("character varying(150)[]")
                    .HasColumnName("manifeststatus");

                entity.Property(e => e.Orderprocesstype)
                    .HasMaxLength(10)
                    .HasColumnName("orderprocesstype");

                entity.Property(e => e.Orderstatus)
                    .HasColumnType("character varying(250)[]")
                    .HasColumnName("orderstatus");

                entity.Property(e => e.Ordertype)
                    .HasMaxLength(50)
                    .HasColumnName("ordertype");

                entity.Property(e => e.Ordertypetxt)
                    .HasMaxLength(70)
                    .HasColumnName("ordertypetxt");

                entity.Property(e => e.Searchby)
                    .HasMaxLength(20)
                    .HasColumnName("searchby");

                entity.Property(e => e.Searchtitle)
                    .HasMaxLength(150)
                    .HasColumnName("searchtitle");

                entity.Property(e => e.Shiptotext)
                    .HasMaxLength(70)
                    .HasColumnName("shiptotext");

                entity.Property(e => e.Shiptotype)
                    .HasMaxLength(50)
                    .HasColumnName("shiptotype");

                entity.Property(e => e.Skulist)
                    .HasColumnType("character varying(250)[]")
                    .HasColumnName("skulist");

                entity.Property(e => e.Startdate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("startdate");

                entity.Property(e => e.Trackingnum)
                    .HasMaxLength(200)
                    .HasColumnName("trackingnum");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Whid).HasColumnName("whid");
            });

            modelBuilder.Entity<Ordershipaddresslog>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("ordershipaddresslog_pkey");

                entity.ToTable("ordershipaddresslog");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Address1)
                    .HasMaxLength(250)
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .HasColumnName("address2");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .HasColumnName("city");

                entity.Property(e => e.Companyname)
                    .HasMaxLength(250)
                    .HasColumnName("companyname");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Manifestid).HasColumnName("manifestid");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .HasColumnName("state");

                entity.Property(e => e.Zip)
                    .HasMaxLength(15)
                    .HasColumnName("zip");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.Ordershipaddresslogs)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");

                entity.HasOne(d => d.Manifest)
                    .WithMany(p => p.Ordershipaddresslogs)
                    .HasForeignKey(d => d.Manifestid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("manifestid_fk");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Ordershipaddresslogs)
                    .HasForeignKey(d => d.Orderid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderid_fk");
            });

            modelBuilder.Entity<Ordersjob>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("ordersjob_pkey");

                entity.ToTable("ordersjob");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Completeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("completeddate");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Jobname)
                    .HasMaxLength(255)
                    .HasColumnName("jobname");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Nooforders).HasColumnName("nooforders");

                entity.Property(e => e.Startdate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("startdate");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.OrdersjobEntryusers)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");

                entity.HasOne(d => d.Modifieduser)
                    .WithMany(p => p.OrdersjobModifiedusers)
                    .HasForeignKey(d => d.Modifieduserid)
                    .HasConstraintName("modifieduserid_fk");
            });

            modelBuilder.Entity<Ordersjobitem>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("ordersjobitems_pkey");

                entity.ToTable("ordersjobitems");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1010L);

                entity.Property(e => e.Cartid).HasColumnName("cartid");

                entity.Property(e => e.Cartstatus).HasColumnName("cartstatus");

                entity.Property(e => e.Jobid).HasColumnName("jobid");

                entity.Property(e => e.Manifestid).HasColumnName("manifestid");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Totenumber)
                    .HasMaxLength(30)
                    .HasColumnName("totenumber");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.Ordersjobitems)
                    .HasForeignKey(d => d.Cartid)
                    .HasConstraintName("cartid_fk");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Ordersjobitems)
                    .HasForeignKey(d => d.Jobid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobid_fk");

                entity.HasOne(d => d.Manifest)
                    .WithMany(p => p.Ordersjobitems)
                    .HasForeignKey(d => d.Manifestid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("manifestid_fk");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Ordersjobitems)
                    .HasForeignKey(d => d.Orderid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderid_fk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Ordersjobitems)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userid_fk");
            });

            modelBuilder.Entity<OrderskuSerial>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("ordersku_serial_pkey");

                entity.ToTable("ordersku_serial");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Allocateddate)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("allocateddate");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Receiveddate)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("receiveddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Rodetailedid).HasColumnName("rodetailedid");

                entity.Property(e => e.Serialno)
                    .HasMaxLength(120)
                    .HasColumnName("serialno");

                entity.Property(e => e.Skuid).HasColumnName("skuid");

                entity.HasOne(d => d.Rodetailed)
                    .WithMany(p => p.OrderskuSerials)
                    .HasForeignKey(d => d.Rodetailedid)
                    .HasConstraintName("rodetailedid_fk");
            });

            modelBuilder.Entity<Ordersshipment>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("ordersshipment_pkey");

                entity.ToTable("ordersshipment");

                entity.Property(e => e.Uniqueid).HasColumnName("uniqueid");

                entity.Property(e => e.Billaddress1)
                    .HasMaxLength(300)
                    .HasColumnName("billaddress1");

                entity.Property(e => e.Billaddress2)
                    .HasMaxLength(300)
                    .HasColumnName("billaddress2");

                entity.Property(e => e.Billcity)
                    .HasMaxLength(150)
                    .HasColumnName("billcity");

                entity.Property(e => e.Billcompanyname)
                    .HasMaxLength(200)
                    .HasColumnName("billcompanyname");

                entity.Property(e => e.Billcountrycode)
                    .HasMaxLength(50)
                    .HasColumnName("billcountrycode");

                entity.Property(e => e.Billcustomername)
                    .HasMaxLength(150)
                    .HasColumnName("billcustomername");

                entity.Property(e => e.Billemail)
                    .HasMaxLength(150)
                    .HasColumnName("billemail");

                entity.Property(e => e.Billphone)
                    .HasMaxLength(100)
                    .HasColumnName("billphone");

                entity.Property(e => e.Billpostalcode)
                    .HasMaxLength(10)
                    .HasColumnName("billpostalcode");

                entity.Property(e => e.Billstate)
                    .HasMaxLength(150)
                    .HasColumnName("billstate");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Reqshipviaid).HasColumnName("reqshipviaid");

                entity.Property(e => e.Shipaddress1)
                    .HasMaxLength(300)
                    .HasColumnName("shipaddress1");

                entity.Property(e => e.Shipaddress2)
                    .HasMaxLength(300)
                    .HasColumnName("shipaddress2");

                entity.Property(e => e.Shipaddress3)
                    .HasMaxLength(200)
                    .HasColumnName("shipaddress3");

                entity.Property(e => e.Shipcity)
                    .HasMaxLength(150)
                    .HasColumnName("shipcity");

                entity.Property(e => e.Shipcompanyname)
                    .HasMaxLength(200)
                    .HasColumnName("shipcompanyname");

                entity.Property(e => e.Shipcountrycode)
                    .HasMaxLength(50)
                    .HasColumnName("shipcountrycode")
                    .HasDefaultValueSql("'USA'::character varying");

                entity.Property(e => e.Shipcustomername)
                    .HasMaxLength(150)
                    .HasColumnName("shipcustomername");

                entity.Property(e => e.Shipemail)
                    .HasMaxLength(150)
                    .HasColumnName("shipemail");

                entity.Property(e => e.Shipphone)
                    .HasMaxLength(100)
                    .HasColumnName("shipphone");

                entity.Property(e => e.Shippostalcode)
                    .HasMaxLength(10)
                    .HasColumnName("shippostalcode");

                entity.Property(e => e.Shipstate)
                    .HasMaxLength(150)
                    .HasColumnName("shipstate");

                entity.Property(e => e._3rdpartyaccno)
                    .HasMaxLength(20)
                    .HasColumnName("3rdpartyaccno");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Ordersshipments)
                    .HasForeignKey(d => d.Orderid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderid_fkey");

                entity.HasOne(d => d.Reqshipvia)
                    .WithMany(p => p.Ordersshipments)
                    .HasForeignKey(d => d.Reqshipviaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_shipviaid");
            });

            modelBuilder.Entity<Poissue>(entity =>
            {
                entity.ToTable("poissue");

                entity.Property(e => e.Poissueid).HasColumnName("poissueid");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .HasColumnName("comments");

                entity.Property(e => e.Description)
                    .HasMaxLength(90)
                    .HasColumnName("description");

                entity.Property(e => e.Podate)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("podate");

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(45)
                    .HasColumnName("ponumber");

                entity.Property(e => e.Rcdqty).HasColumnName("rcdqty");

                entity.Property(e => e.Sku)
                    .HasMaxLength(50)
                    .HasColumnName("sku");

                entity.Property(e => e.Skuid).HasColumnName("skuid");

                entity.Property(e => e.Skuissue)
                    .HasMaxLength(80)
                    .HasColumnName("skuissue");
            });

            modelBuilder.Entity<Poschedule>(entity =>
            {
                entity.ToTable("poschedule");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Carrierid).HasColumnName("carrierid");

                entity.Property(e => e.Carriertypeid).HasColumnName("carriertypeid");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Createddatetime).HasColumnName("createddatetime");

                entity.Property(e => e.Createduserid).HasColumnName("createduserid");

                entity.Property(e => e.Customerid).HasColumnName("customerid");

                entity.Property(e => e.Customername)
                    .HasMaxLength(150)
                    .HasColumnName("customername");

                entity.Property(e => e.Endtime).HasColumnName("endtime");

                entity.Property(e => e.Isrescheduled).HasColumnName("isrescheduled");

                entity.Property(e => e.Lastmodifieddate).HasColumnName("lastmodifieddate");

                entity.Property(e => e.Lastmodifiedtime).HasColumnName("lastmodifiedtime");

                entity.Property(e => e.Noofboxes).HasColumnName("noofboxes");

                entity.Property(e => e.Noofpacketsused).HasColumnName("noofpacketsused");

                entity.Property(e => e.Noofpallets).HasColumnName("noofpallets");

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(50)
                    .HasColumnName("ponumber");

                entity.Property(e => e.Schdate).HasColumnName("schdate");

                entity.Property(e => e.Schtime).HasColumnName("schtime");

                entity.Property(e => e.Starttime).HasColumnName("starttime");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'Scheduled'::character varying");

                entity.Property(e => e.Waittime)
                    .HasMaxLength(20)
                    .HasColumnName("waittime");

                entity.Property(e => e.Warehouseid).HasColumnName("warehouseid");
            });

            modelBuilder.Entity<Poupload>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("poupload");

                entity.Property(e => e.Badqty).HasColumnName("badqty");

                entity.Property(e => e.Damagecode)
                    .HasMaxLength(90)
                    .HasColumnName("damagecode");

                entity.Property(e => e.Errormsg)
                    .HasMaxLength(50)
                    .HasColumnName("errormsg");

                entity.Property(e => e.Expecteddate)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("expecteddate");

                entity.Property(e => e.Podate)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("podate");

                entity.Property(e => e.Pofilename)
                    .HasMaxLength(250)
                    .HasColumnName("pofilename");

                entity.Property(e => e.Poloaded).HasColumnName("poloaded");

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(90)
                    .HasColumnName("ponumber");

                entity.Property(e => e.Poquantity).HasColumnName("poquantity");

                entity.Property(e => e.Receivedby)
                    .HasMaxLength(40)
                    .HasColumnName("receivedby");

                entity.Property(e => e.Receiveddate)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("receiveddate");

                entity.Property(e => e.Receivedquantity).HasColumnName("receivedquantity");

                entity.Property(e => e.Receivingid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("receivingid");

                entity.Property(e => e.Recexists).HasColumnName("recexists");

                entity.Property(e => e.Recmoved)
                    .HasMaxLength(3)
                    .HasColumnName("recmoved")
                    .HasDefaultValueSql("'No'::character varying");

                entity.Property(e => e.Sku)
                    .HasMaxLength(90)
                    .HasColumnName("sku");

                entity.Property(e => e.Skuid).HasColumnName("skuid");

                entity.Property(e => e.Totalreceivedqty).HasColumnName("totalreceivedqty");
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.HasKey(e => e.Integrationpropertyid)
                    .HasName("integrationproperties_pkey");

                entity.ToTable("properties");

                entity.Property(e => e.Integrationpropertyid)
                    .HasColumnName("integrationpropertyid")
                    .HasIdentityOptions(100L);

                entity.Property(e => e.Integrationtypeid).HasColumnName("integrationtypeid");

                entity.Property(e => e.Propertyid).HasColumnName("propertyid");

                entity.Property(e => e.Propertyname)
                    .HasMaxLength(150)
                    .HasColumnName("propertyname");

                entity.HasOne(d => d.Integrationtype)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.Integrationtypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_integrationtype");
            });

            modelBuilder.Entity<Receivingcontainertype>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("receivingcontainertype");

                entity.Property(e => e.Containertype)
                    .HasMaxLength(90)
                    .HasColumnName("containertype");

                entity.Property(e => e.Containertypeid).HasColumnName("containertypeid");
            });

            modelBuilder.Entity<Return>(entity =>
            {
                entity.ToTable("returns");

                entity.Property(e => e.Returnid)
                    .HasColumnName("returnid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasColumnName("address");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .HasColumnName("city");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.Companyname)
                    .HasMaxLength(255)
                    .HasColumnName("companyname");

                entity.Property(e => e.Custorderid)
                    .HasColumnType("character varying")
                    .HasColumnName("custorderid");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .HasColumnName("firstname");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .HasColumnName("lastname");

                entity.Property(e => e.Orderdate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("orderdate");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Postalcode)
                    .HasMaxLength(15)
                    .HasColumnName("postalcode");

                entity.Property(e => e.Returndate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("returndate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Rmano)
                    .HasMaxLength(15)
                    .HasColumnName("rmano");

                entity.Property(e => e.State)
                    .HasMaxLength(25)
                    .HasColumnName("state");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<Returnitem>(entity =>
            {
                entity.ToTable("returnitems");

                entity.Property(e => e.Returnitemid)
                    .HasColumnName("returnitemid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Orderqty).HasColumnName("orderqty");

                entity.Property(e => e.Requestedexchange).HasColumnName("requestedexchange");

                entity.Property(e => e.Returnid).HasColumnName("returnid");

                entity.Property(e => e.Returnqty).HasColumnName("returnqty");

                entity.Property(e => e.Returnreason)
                    .HasMaxLength(50)
                    .HasColumnName("returnreason");

                entity.Property(e => e.Returnreasonid).HasColumnName("returnreasonid");

                entity.Property(e => e.Returntostock).HasColumnName("returntostock");

                entity.Property(e => e.Stockreturnreason)
                    .HasMaxLength(50)
                    .HasColumnName("stockreturnreason");

                entity.Property(e => e.Stockreturnreasonid).HasColumnName("stockreturnreasonid");
            });

            modelBuilder.Entity<Robilling>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("robilling_pkey");

                entity.ToTable("robilling");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Branch)
                    .HasMaxLength(100)
                    .HasColumnName("branch");

                entity.Property(e => e.Ccuniqueid).HasColumnName("ccuniqueid");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.Creditor)
                    .HasMaxLength(100)
                    .HasColumnName("creditor");

                entity.Property(e => e.Debitor)
                    .HasMaxLength(100)
                    .HasColumnName("debitor");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Localcost)
                    .HasColumnType("money")
                    .HasColumnName("localcost");

                entity.Property(e => e.Localsell)
                    .HasColumnType("money")
                    .HasColumnName("localsell");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("character varying")
                    .HasColumnName("modifieddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Noofpallets).HasColumnName("noofpallets");

                entity.Property(e => e.Pouniqueid).HasColumnName("pouniqueid");

                entity.HasOne(d => d.Ccunique)
                    .WithMany(p => p.Robillings)
                    .HasForeignKey(d => d.Ccuniqueid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ccuniqueid_fk");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.RobillingEntryusers)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");

                entity.HasOne(d => d.Modifieduser)
                    .WithMany(p => p.RobillingModifiedusers)
                    .HasForeignKey(d => d.Modifieduserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("modifieduserid_fk");

                entity.HasOne(d => d.Pounique)
                    .WithMany(p => p.Robillings)
                    .HasForeignKey(d => d.Pouniqueid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pouniqueid_fk");
            });

            modelBuilder.Entity<Rochargecode>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("rochargecodes_pkey");

                entity.ToTable("rochargecodes");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Calc)
                    .HasMaxLength(5)
                    .HasColumnName("calc");

                entity.Property(e => e.Code)
                    .HasMaxLength(15)
                    .HasColumnName("code");

                entity.Property(e => e.Createddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("createddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasColumnName("description");

                entity.Property(e => e.Expgroup)
                    .HasMaxLength(20)
                    .HasColumnName("expgroup");

                entity.Property(e => e.Group)
                    .HasMaxLength(5)
                    .HasColumnName("group");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Salesgroup)
                    .HasMaxLength(20)
                    .HasColumnName("salesgroup");
            });

            modelBuilder.Entity<Roreceiving>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("tmpreceiving_po_pkey");

                entity.ToTable("roreceiving");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .HasDefaultValueSql("nextval('tmpreceiving_po_uniqueid_seq'::regclass)");

                entity.Property(e => e.Arrivaldate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("arrivaldate");

                entity.Property(e => e.Bookingdate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("bookingdate");

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.Completeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("completeddate");

                entity.Property(e => e.Completeduserid).HasColumnName("completeduserid");

                entity.Property(e => e.Containerid)
                    .HasColumnType("character varying")
                    .HasColumnName("containerid");

                entity.Property(e => e.Containertype)
                    .HasMaxLength(50)
                    .HasColumnName("containertype");

                entity.Property(e => e.Createddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("createddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Createduserid).HasColumnName("createduserid");

                entity.Property(e => e.Deliveryapptglcd)
                    .HasColumnType("character varying")
                    .HasColumnName("deliveryapptglcd");

                entity.Property(e => e.Docketid)
                    .HasMaxLength(50)
                    .HasColumnName("docketid");

                entity.Property(e => e.Emptypickedup)
                    .HasColumnType("character varying")
                    .HasColumnName("emptypickedup");

                entity.Property(e => e.Endtime).HasColumnName("endtime");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Eta)
                    .HasColumnType("character varying")
                    .HasColumnName("eta");

                entity.Property(e => e.Finalizeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("finalizeddate");

                entity.Property(e => e.Floorloaded).HasColumnName("floorloaded");

                entity.Property(e => e.Goodshandlinginstructions)
                    .HasColumnType("character varying")
                    .HasColumnName("goodshandlinginstructions");

                entity.Property(e => e.Ismailsent).HasColumnName("ismailsent");

                entity.Property(e => e.Isrescheduled).HasColumnName("isrescheduled");

                entity.Property(e => e.Issamesku).HasColumnName("issamesku");

                entity.Property(e => e.Lfdtoreturn)
                    .HasColumnType("character varying")
                    .HasColumnName("lfdtoreturn");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate");

                entity.Property(e => e.Noofboxes).HasColumnName("noofboxes");

                entity.Property(e => e.Noofpallets).HasColumnName("noofpallets");

                entity.Property(e => e.Palletized).HasColumnName("palletized");

                entity.Property(e => e.Portappt)
                    .HasColumnType("character varying")
                    .HasColumnName("portappt");

                entity.Property(e => e.Portappttoreturn)
                    .HasColumnType("character varying")
                    .HasColumnName("portappttoreturn");

                entity.Property(e => e.Porteta)
                    .HasColumnType("character varying")
                    .HasColumnName("porteta");

                entity.Property(e => e.Portlfd)
                    .HasColumnType("character varying")
                    .HasColumnName("portlfd");

                entity.Property(e => e.Postatus)
                    .HasMaxLength(150)
                    .HasColumnName("postatus");

                entity.Property(e => e.Previousstatus)
                    .HasMaxLength(150)
                    .HasColumnName("previousstatus");

                entity.Property(e => e.Productcount).HasColumnName("productcount");

                entity.Property(e => e.Receiveref)
                    .HasMaxLength(70)
                    .HasColumnName("receiveref");

                entity.Property(e => e.Returned)
                    .HasColumnType("character varying")
                    .HasColumnName("returned");

                entity.Property(e => e.Returnnotified)
                    .HasColumnType("character varying")
                    .HasColumnName("returnnotified");

                entity.Property(e => e.Roacknowledgdate)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("roacknowledgdate");

                entity.Property(e => e.Roacknowledged).HasColumnName("roacknowledged");

                entity.Property(e => e.Roclosed).HasColumnName("roclosed");

                entity.Property(e => e.Rodate)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("rodate");

                entity.Property(e => e.Rofilename)
                    .HasMaxLength(250)
                    .HasColumnName("rofilename");

                entity.Property(e => e.Ronumber)
                    .HasMaxLength(50)
                    .HasColumnName("ronumber");

                entity.Property(e => e.Schdate).HasColumnName("schdate");

                entity.Property(e => e.Schtime).HasColumnName("schtime");

                entity.Property(e => e.Slahrs)
                    .HasColumnName("slahrs")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.Starttime).HasColumnName("starttime");

                entity.Property(e => e.Supplier)
                    .HasColumnType("character varying")
                    .HasColumnName("supplier");

                entity.Property(e => e.Totalexpected).HasColumnName("totalexpected");

                entity.Property(e => e.Totallineplts).HasColumnName("totallineplts");

                entity.Property(e => e.Totalreceived).HasColumnName("totalreceived");

                entity.Property(e => e.Totalunits).HasColumnName("totalunits");

                entity.Property(e => e.Transportco)
                    .HasColumnType("character varying")
                    .HasColumnName("transportco");

                entity.Property(e => e.Volume).HasColumnName("volume");

                entity.Property(e => e.Waittime)
                    .HasMaxLength(20)
                    .HasColumnName("waittime");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.Property(e => e.Whid).HasColumnName("whid");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Roreceivings)
                    .HasForeignKey(d => d.Clientid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientid_fk");

                entity.HasOne(d => d.Completeduser)
                    .WithMany(p => p.RoreceivingCompletedusers)
                    .HasForeignKey(d => d.Completeduserid)
                    .HasConstraintName("completeduserid_fk");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.RoreceivingEntryusers)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");
            });

            modelBuilder.Entity<Roreceivingdetail>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("tmpreceiving_pkey");

                entity.ToTable("roreceivingdetails");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .HasDefaultValueSql("nextval('tmpreceiving_uniqueid_seq'::regclass)");

                entity.Property(e => e.Badqty).HasColumnName("badqty");

                entity.Property(e => e.Expecteddate)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("expecteddate");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Iteminternalid)
                    .HasMaxLength(50)
                    .HasColumnName("iteminternalid");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Penqty).HasColumnName("penqty");

                entity.Property(e => e.Podate)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("podate");

                entity.Property(e => e.Pofilename)
                    .HasMaxLength(250)
                    .HasColumnName("pofilename");

                entity.Property(e => e.Poloaded).HasColumnName("poloaded");

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(50)
                    .HasColumnName("ponumber");

                entity.Property(e => e.Poquantity).HasColumnName("poquantity");

                entity.Property(e => e.Pouid).HasColumnName("pouid");

                entity.Property(e => e.Prevrcdqty).HasColumnName("prevrcdqty");

                entity.Property(e => e.Qcdone).HasColumnName("qcdone");

                entity.Property(e => e.Qcid).HasColumnName("qcid");

                entity.Property(e => e.Qcqty).HasColumnName("qcqty");

                entity.Property(e => e.Rcvcnt).HasColumnName("rcvcnt");

                entity.Property(e => e.Receiveddate)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("receiveddate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Recexists)
                    .HasColumnName("recexists")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Removeline)
                    .HasMaxLength(3)
                    .HasColumnName("removeline");

                entity.Property(e => e.Skuid).HasColumnName("skuid");

                entity.Property(e => e.Trcvid)
                    .HasMaxLength(140)
                    .HasColumnName("trcvid");

                entity.Property(e => e.Varianceid).HasColumnName("varianceid");

                entity.Property(e => e.Varianceqty).HasColumnName("varianceqty");

                entity.Property(e => e.Width).HasColumnName("width");

                entity.HasOne(d => d.Pou)
                    .WithMany(p => p.Roreceivingdetails)
                    .HasForeignKey(d => d.Pouid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("po_rec_details_FKey");
            });

            modelBuilder.Entity<Roreceivinghistory>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("rolotcodes_pkey");

                entity.ToTable("roreceivinghistory");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Expdate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("expdate");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Lotcode)
                    .HasMaxLength(70)
                    .HasColumnName("lotcode");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Palletid).HasColumnName("palletid");

                entity.Property(e => e.Putawayqty).HasColumnName("putawayqty");

                entity.Property(e => e.Recqty).HasColumnName("recqty");

                entity.Property(e => e.Rodetailsid).HasColumnName("rodetailsid");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.RoreceivinghistoryEntryusers)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.RoreceivinghistoryLocations)
                    .HasForeignKey(d => d.Locationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("locationid_fk");

                entity.HasOne(d => d.Modifieduser)
                    .WithMany(p => p.RoreceivinghistoryModifiedusers)
                    .HasForeignKey(d => d.Modifieduserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("modifieduserid_fk");

                entity.HasOne(d => d.Pallet)
                    .WithMany(p => p.RoreceivinghistoryPallets)
                    .HasForeignKey(d => d.Palletid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("palletid_fk");

                entity.HasOne(d => d.Rodetails)
                    .WithMany(p => p.Roreceivinghistories)
                    .HasForeignKey(d => d.Rodetailsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rodetailsid_fk");
            });

            modelBuilder.Entity<Rotracking>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("rotracking_pkey");

                entity.ToTable("rotracking");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.Containertype)
                    .HasMaxLength(50)
                    .HasColumnName("containertype");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Noofcases).HasColumnName("noofcases");

                entity.Property(e => e.Nooflabels).HasColumnName("nooflabels");

                entity.Property(e => e.Noofpallets).HasColumnName("noofpallets");

                entity.Property(e => e.Noofstaffused).HasColumnName("noofstaffused");

                entity.Property(e => e.Pouniqueid).HasColumnName("pouniqueid");

                entity.Property(e => e.Receivedby)
                    .HasMaxLength(100)
                    .HasColumnName("receivedby");

                entity.Property(e => e.Stockedby)
                    .HasMaxLength(100)
                    .HasColumnName("stockedby");

                entity.Property(e => e.Supplierasn)
                    .HasMaxLength(50)
                    .HasColumnName("supplierasn");

                entity.Property(e => e.Taskdate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("taskdate");

                entity.Property(e => e.Totaltimehours).HasColumnName("totaltimehours");

                entity.Property(e => e.Totaltimeminutes).HasColumnName("totaltimeminutes");

                entity.HasOne(d => d.Pounique)
                    .WithMany(p => p.Rotrackings)
                    .HasForeignKey(d => d.Pouniqueid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pouniqueid_fk");
            });

            modelBuilder.Entity<Saleschannel>(entity =>
            {
                entity.ToTable("saleschannel");

                entity.Property(e => e.Saleschannelid)
                    .HasColumnName("saleschannelid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1009L);

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Saleschannel1)
                    .HasMaxLength(50)
                    .HasColumnName("saleschannel");

                entity.Property(e => e.Saleschannelcode).HasColumnName("saleschannelcode");
            });

            modelBuilder.Entity<Sku>(entity =>
            {
                entity.ToTable("sku");

                entity.Property(e => e.Skuid)
                    .HasColumnName("skuid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(3000L);

                entity.Property(e => e.Alternateitemcode)
                    .HasMaxLength(100)
                    .HasColumnName("alternateitemcode");

                entity.Property(e => e.Alternateitemdescription)
                    .HasMaxLength(300)
                    .HasColumnName("alternateitemdescription");

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Cyclemonths)
                    .HasMaxLength(15)
                    .HasColumnName("cyclemonths");

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .HasColumnName("description");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp(3) without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Expdays)
                    .HasColumnName("expdays")
                    .HasDefaultValueSql("365");

                entity.Property(e => e.Expyears)
                    .HasMaxLength(25)
                    .HasColumnName("expyears");

                entity.Property(e => e.Gtin)
                    .HasMaxLength(15)
                    .HasColumnName("gtin");

                entity.Property(e => e.Hazmat)
                    .HasMaxLength(255)
                    .HasColumnName("hazmat");

                entity.Property(e => e.Hsncode)
                    .HasMaxLength(15)
                    .HasColumnName("hsncode");

                entity.Property(e => e.Imageurl)
                    .HasMaxLength(500)
                    .HasColumnName("imageurl");

                entity.Property(e => e.Iscyclecount).HasColumnName("iscyclecount");

                entity.Property(e => e.Isexpdate).HasColumnName("isexpdate");

                entity.Property(e => e.Ishazmat).HasColumnName("ishazmat");

                entity.Property(e => e.Iskititem).HasColumnName("iskititem");

                entity.Property(e => e.Islotcode).HasColumnName("islotcode");

                entity.Property(e => e.Isoversize).HasColumnName("isoversize");

                entity.Property(e => e.Isserialno).HasColumnName("isserialno");

                entity.Property(e => e.Itemcategory)
                    .HasMaxLength(20)
                    .HasColumnName("itemcategory");

                entity.Property(e => e.Itemtype)
                    .HasMaxLength(20)
                    .HasColumnName("itemtype")
                    .HasDefaultValueSql("'ITEM'::character varying");

                entity.Property(e => e.Manufacturervendor)
                    .HasMaxLength(255)
                    .HasColumnName("manufacturervendor");

                entity.Property(e => e.Maxorderqty).HasColumnName("maxorderqty");

                entity.Property(e => e.Minorderqty).HasColumnName("minorderqty");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp(3) without time zone")
                    .HasColumnName("modifieddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Mpncode)
                    .HasMaxLength(15)
                    .HasColumnName("mpncode");

                entity.Property(e => e.Originid).HasColumnName("originid");

                entity.Property(e => e.Photo).HasColumnName("photo");

                entity.Property(e => e.Purchasecost)
                    .HasPrecision(19, 4)
                    .HasColumnName("purchasecost");

                entity.Property(e => e.Reorderpoint).HasColumnName("reorderpoint");

                entity.Property(e => e.Safetystock).HasColumnName("safetystock");

                entity.Property(e => e.Sellcost).HasColumnName("sellcost");

                entity.Property(e => e.Sku1)
                    .HasMaxLength(50)
                    .HasColumnName("sku");

                entity.Property(e => e.Status)
                    .HasColumnType("character varying")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'Active'::character varying");

                entity.Property(e => e.Storagetype)
                    .HasMaxLength(25)
                    .HasColumnName("storagetype");

                entity.Property(e => e.Subitemcategory)
                    .HasMaxLength(20)
                    .HasColumnName("subitemcategory");

                entity.Property(e => e.Uom)
                    .HasMaxLength(50)
                    .HasColumnName("uom")
                    .HasDefaultValueSql("'UNIT'::character varying");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Skus)
                    .HasForeignKey(d => d.Clientid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientid_fk");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.SkuEntryusers)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");

                entity.HasOne(d => d.Modifieduser)
                    .WithMany(p => p.SkuModifiedusers)
                    .HasForeignKey(d => d.Modifieduserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("modifieduserid_fk");

                entity.HasOne(d => d.Origin)
                    .WithMany(p => p.Skus)
                    .HasForeignKey(d => d.Originid)
                    .HasConstraintName("country_fk");
            });

            modelBuilder.Entity<Skuautofill>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("skuchannel_pkey");

                entity.ToTable("skuautofill");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.ActivefromDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("activefrom_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ActivetoDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("activeto_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Channel)
                    .HasMaxLength(100)
                    .HasColumnName("channel");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Modifiedentrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifiedentrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Saleschannelid).HasColumnName("saleschannelid");

                entity.Property(e => e.Skuid).HasColumnName("skuid");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.SkuautofillEntryusers)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");

                entity.HasOne(d => d.Modifieduser)
                    .WithMany(p => p.SkuautofillModifiedusers)
                    .HasForeignKey(d => d.Modifieduserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("modifieduserid_fk");

                entity.HasOne(d => d.Saleschannel)
                    .WithMany(p => p.Skuautofills)
                    .HasForeignKey(d => d.Saleschannelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("skuchannel_saleschannelid_fkey");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.Skuautofills)
                    .HasForeignKey(d => d.Skuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("skuid_fk");
            });

            modelBuilder.Entity<Skubarcode>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("skubarcode_pkey");

                entity.ToTable("skubarcode");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Barcode)
                    .HasMaxLength(100)
                    .HasColumnName("barcode");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Packagetype)
                    .HasMaxLength(30)
                    .HasColumnName("packagetype");

                entity.Property(e => e.Skuid).HasColumnName("skuid");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.SkubarcodeEntryusers)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");

                entity.HasOne(d => d.Modifieduser)
                    .WithMany(p => p.SkubarcodeModifiedusers)
                    .HasForeignKey(d => d.Modifieduserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("modifieduserid_fk");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.Skubarcodes)
                    .HasForeignKey(d => d.Skuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("skuid_fk");
            });

            modelBuilder.Entity<Skuinventorylocation>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("skuinventorylocationkey_pkey");

                entity.ToTable("skuinventorylocation");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Allocatedqty).HasColumnName("allocatedqty");

                entity.Property(e => e.Availableqty).HasColumnName("availableqty");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Lotcode)
                    .HasMaxLength(50)
                    .HasColumnName("lotcode");

                entity.Property(e => e.Lotexp)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("lotexp");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Palletid).HasColumnName("palletid");

                entity.Property(e => e.Pouniqueid).HasColumnName("pouniqueid");

                entity.Property(e => e.Recpo)
                    .HasMaxLength(50)
                    .HasColumnName("recpo");

                entity.Property(e => e.Recqty).HasColumnName("recqty");

                entity.Property(e => e.Skuid).HasColumnName("skuid");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.SkuinventorylocationEntryusers)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.SkuinventorylocationLocations)
                    .HasForeignKey(d => d.Locationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("locationid_fk");

                entity.HasOne(d => d.Modifieduser)
                    .WithMany(p => p.SkuinventorylocationModifiedusers)
                    .HasForeignKey(d => d.Modifieduserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("modifieduserid_fk");

                entity.HasOne(d => d.Pallet)
                    .WithMany(p => p.SkuinventorylocationPallets)
                    .HasForeignKey(d => d.Palletid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("palletid_fk");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.Skuinventorylocations)
                    .HasForeignKey(d => d.Skuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("skuid_fk");
            });

            modelBuilder.Entity<Skuinventorylocationlog>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("skuinventorylocation_pkey");

                entity.ToTable("skuinventorylocationlog");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .HasColumnName("comments");

                entity.Property(e => e.Entryddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entryddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Filename)
                    .HasMaxLength(255)
                    .HasColumnName("filename");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Lotcode)
                    .HasColumnType("character varying")
                    .HasColumnName("lotcode");

                entity.Property(e => e.Lotexp)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("lotexp");

                entity.Property(e => e.Palletid).HasColumnName("palletid");

                entity.Property(e => e.Reasonid).HasColumnName("reasonid");

                entity.Property(e => e.Recpo)
                    .HasMaxLength(50)
                    .HasColumnName("recpo");

                entity.Property(e => e.Siluniqueid).HasColumnName("siluniqueid");

                entity.Property(e => e.Skuid).HasColumnName("skuid");

                entity.Property(e => e.Transqty).HasColumnName("transqty");

                entity.Property(e => e.Transtype)
                    .HasMaxLength(50)
                    .HasColumnName("transtype");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Skuinventorylocationlogs)
                    .HasForeignKey(d => d.Locationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("locationid_fk");

                entity.HasOne(d => d.Reason)
                    .WithMany(p => p.Skuinventorylocationlogs)
                    .HasForeignKey(d => d.Reasonid)
                    .HasConstraintName("reasonid_fk");

                entity.HasOne(d => d.Silunique)
                    .WithMany(p => p.Skuinventorylocationlogs)
                    .HasForeignKey(d => d.Siluniqueid)
                    .HasConstraintName("siluniqueid_fk");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.Skuinventorylocationlogs)
                    .HasForeignKey(d => d.Skuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("skuid_fk");
            });

            modelBuilder.Entity<Skukitmapping>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("skukitmapping_pkey");

                entity.ToTable("skukitmapping");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Componentskuid).HasColumnName("componentskuid");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Iteminclude)
                    .HasColumnName("iteminclude")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Kitskuid).HasColumnName("kitskuid");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Componentsku)
                    .WithMany(p => p.SkukitmappingComponentskus)
                    .HasForeignKey(d => d.Componentskuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("componentskuid_fk");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.SkukitmappingEntryusers)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");

                entity.HasOne(d => d.Kitsku)
                    .WithMany(p => p.SkukitmappingKitskus)
                    .HasForeignKey(d => d.Kitskuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("kitskuid_fk");

                entity.HasOne(d => d.Modifieduser)
                    .WithMany(p => p.SkukitmappingModifiedusers)
                    .HasForeignKey(d => d.Modifieduserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("modifieduserid_fk");
            });

            modelBuilder.Entity<Skulotcode>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("pk_skulotcode");

                entity.ToTable("skulotcode");

                entity.Property(e => e.Uniqueid).HasColumnName("uniqueid");

                entity.Property(e => e.Availqty).HasColumnName("availqty");

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Islotcodeactive)
                    .IsRequired()
                    .HasColumnName("islotcodeactive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Lotcode)
                    .HasMaxLength(90)
                    .HasColumnName("lotcode");

                entity.Property(e => e.Lotcodeexpdate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("lotcodeexpdate");

                entity.Property(e => e.Penqty).HasColumnName("penqty");

                entity.Property(e => e.Podate)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("podate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(90)
                    .HasColumnName("ponumber");

                entity.Property(e => e.Poqty).HasColumnName("poqty");

                entity.Property(e => e.Pouniqueid).HasColumnName("pouniqueid");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Skuid).HasColumnName("skuid");
            });

            modelBuilder.Entity<Skupackage>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("skupackage_pkey");

                entity.ToTable("skupackage");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .HasDefaultValueSql("nextval('skupackage_id_seq'::regclass)");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Hi)
                    .HasColumnName("hi")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Isitemwithbox).HasColumnName("isitemwithbox");

                entity.Property(e => e.Isprimaryuom).HasColumnName("isprimaryuom");

                entity.Property(e => e.Isstatus).HasColumnName("isstatus");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Packagetype)
                    .HasMaxLength(15)
                    .HasColumnName("packagetype");

                entity.Property(e => e.Parentpackagetype)
                    .HasMaxLength(15)
                    .HasColumnName("parentpackagetype");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Shippingboxid).HasColumnName("shippingboxid");

                entity.Property(e => e.Skuid).HasColumnName("skuid");

                entity.Property(e => e.Ti)
                    .HasColumnName("ti")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.Property(e => e.Width).HasColumnName("width");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.SkupackageEntryusers)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");

                entity.HasOne(d => d.Modifieduser)
                    .WithMany(p => p.SkupackageModifiedusers)
                    .HasForeignKey(d => d.Modifieduserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("modifieduserid_fk");

                entity.HasOne(d => d.Shippingbox)
                    .WithMany(p => p.Skupackages)
                    .HasForeignKey(d => d.Shippingboxid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("shippingboxid_fk");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.Skupackages)
                    .HasForeignKey(d => d.Skuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("skuid_fk");
            });

            modelBuilder.Entity<Skushippingbox>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("skushippingbox_pkey");

                entity.ToTable("skushippingbox");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .HasDefaultValueSql("nextval('skushippingbox_id_seq'::regclass)");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Shippingbox)
                    .HasMaxLength(100)
                    .HasColumnName("shippingbox");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("state");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Country)
                    .HasMaxLength(80)
                    .HasColumnName("country");

                entity.Property(e => e.State1)
                    .HasMaxLength(255)
                    .HasColumnName("state");

                entity.Property(e => e.Statename)
                    .HasMaxLength(255)
                    .HasColumnName("statename");
            });

            modelBuilder.Entity<VOrdersource>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("v_ordersource");

                entity.Property(e => e.Saleschannelid).HasColumnName("saleschannelid");
            });

            modelBuilder.Entity<ViewOrderShipmentreport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_order_shipmentreport");

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Companyname)
                    .HasMaxLength(200)
                    .HasColumnName("companyname");

                entity.Property(e => e.Cost)
                    .HasColumnType("money")
                    .HasColumnName("cost");

                entity.Property(e => e.Createddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("createddate");

                entity.Property(e => e.Customerid).HasColumnName("customerid");

                entity.Property(e => e.Customername)
                    .HasMaxLength(150)
                    .HasColumnName("customername");

                entity.Property(e => e.Orderdate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("orderdate");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Orderstatus)
                    .HasMaxLength(20)
                    .HasColumnName("orderstatus");

                entity.Property(e => e.Shipdate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("shipdate");

                entity.Property(e => e.Sku)
                    .HasMaxLength(50)
                    .HasColumnName("sku");

                entity.Property(e => e.Skuid).HasColumnName("skuid");

                entity.Property(e => e.Trackingnumber)
                    .HasMaxLength(40)
                    .HasColumnName("trackingnumber");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("warehouse_pkey");

                entity.ToTable("warehouse");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(null, 1000L);

                entity.Property(e => e.Address)
                    .HasColumnType("character varying")
                    .HasColumnName("address");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.Email)
                    .HasMaxLength(25)
                    .HasColumnName("email");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .HasColumnName("phone");

                entity.Property(e => e.Postalcode)
                    .HasMaxLength(10)
                    .HasColumnName("postalcode");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .HasColumnName("state");

                entity.Property(e => e.Whname)
                    .HasMaxLength(250)
                    .HasColumnName("whname");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.Warehouses)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");
            });

            modelBuilder.Entity<Whclient>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("whclient_pkey");

                entity.ToTable("whclient");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .HasColumnName("address2");

                entity.Property(e => e.Adjustmentsbccmail)
                    .HasMaxLength(300)
                    .HasColumnName("adjustmentsbccmail");

                entity.Property(e => e.Adjustmentsnotification).HasColumnName("adjustmentsnotification");

                entity.Property(e => e.Adjustmentstomail)
                    .HasMaxLength(300)
                    .HasColumnName("adjustmentstomail");

                entity.Property(e => e.Allowbackorders).HasColumnName("allowbackorders");

                entity.Property(e => e.Alternatebillingphone)
                    .HasMaxLength(20)
                    .HasColumnName("alternatebillingphone");

                entity.Property(e => e.Alternatecontactphone)
                    .HasMaxLength(20)
                    .HasColumnName("alternatecontactphone");

                entity.Property(e => e.B2bmindaystoexpire).HasColumnName("b2bmindaystoexpire");

                entity.Property(e => e.B2cmindaystoexpire).HasColumnName("b2cmindaystoexpire");

                entity.Property(e => e.Billcountry)
                    .HasMaxLength(50)
                    .HasColumnName("billcountry");

                entity.Property(e => e.Billingaddress1)
                    .HasMaxLength(255)
                    .HasColumnName("billingaddress1");

                entity.Property(e => e.Billingaddress2)
                    .HasMaxLength(255)
                    .HasColumnName("billingaddress2");

                entity.Property(e => e.Billingattn)
                    .HasMaxLength(100)
                    .HasColumnName("billingattn");

                entity.Property(e => e.Billingcity)
                    .HasMaxLength(150)
                    .HasColumnName("billingcity");

                entity.Property(e => e.Billingemail)
                    .HasMaxLength(100)
                    .HasColumnName("billingemail");

                entity.Property(e => e.Billingphone)
                    .HasMaxLength(20)
                    .HasColumnName("billingphone");

                entity.Property(e => e.Billingpostalcode)
                    .HasMaxLength(25)
                    .HasColumnName("billingpostalcode");

                entity.Property(e => e.Billingstate)
                    .HasMaxLength(25)
                    .HasColumnName("billingstate");

                entity.Property(e => e.City)
                    .HasMaxLength(150)
                    .HasColumnName("city");

                entity.Property(e => e.Clientcode)
                    .HasMaxLength(20)
                    .HasColumnName("clientcode");

                entity.Property(e => e.Clientlogo)
                    .HasMaxLength(250)
                    .HasColumnName("clientlogo");

                entity.Property(e => e.Clientname)
                    .HasMaxLength(250)
                    .HasColumnName("clientname");

                entity.Property(e => e.Contactemail)
                    .HasMaxLength(100)
                    .HasColumnName("contactemail");

                entity.Property(e => e.Contactname)
                    .HasMaxLength(100)
                    .HasColumnName("contactname");

                entity.Property(e => e.Contactphone)
                    .HasMaxLength(20)
                    .HasColumnName("contactphone");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .HasColumnName("country")
                    .HasDefaultValueSql("'USA'::character varying");

                entity.Property(e => e.Csmemail)
                    .HasMaxLength(150)
                    .HasColumnName("csmemail");

                entity.Property(e => e.Csmname)
                    .HasMaxLength(150)
                    .HasColumnName("csmname");

                entity.Property(e => e.Dayofmonth).HasColumnName("dayofmonth");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Errorbccemail)
                    .HasMaxLength(300)
                    .HasColumnName("errorbccemail");

                entity.Property(e => e.Errornotification).HasColumnName("errornotification");

                entity.Property(e => e.Errortoemail)
                    .HasMaxLength(300)
                    .HasColumnName("errortoemail");

                entity.Property(e => e.Foodalgorithm).HasColumnName("foodalgorithm");

                entity.Property(e => e.Gs1cmpprefix)
                    .HasColumnType("character varying")
                    .HasColumnName("gs1cmpprefix");

                entity.Property(e => e.Invallocateorderlevel).HasColumnName("invallocateorderlevel");

                entity.Property(e => e.Inventoryperiod)
                    .HasColumnType("character varying")
                    .HasColumnName("inventoryperiod");

                entity.Property(e => e.Inventoryreport).HasColumnName("inventoryreport");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Modifiedentrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifiedentrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Orderbccmail)
                    .HasMaxLength(300)
                    .HasColumnName("orderbccmail");

                entity.Property(e => e.Ordercutofftime)
                    .HasMaxLength(20)
                    .HasColumnName("ordercutofftime");

                entity.Property(e => e.Ordernotification).HasColumnName("ordernotification");

                entity.Property(e => e.Ordertomail)
                    .HasMaxLength(300)
                    .HasColumnName("ordertomail");

                entity.Property(e => e.Otherbccemail)
                    .HasMaxLength(300)
                    .HasColumnName("otherbccemail");

                entity.Property(e => e.Othernotification).HasColumnName("othernotification");

                entity.Property(e => e.Othertoemail)
                    .HasMaxLength(300)
                    .HasColumnName("othertoemail");

                entity.Property(e => e.Packaddress)
                    .HasMaxLength(250)
                    .HasColumnName("packaddress");

                entity.Property(e => e.Packaddresstype)
                    .HasMaxLength(40)
                    .HasColumnName("packaddresstype");

                entity.Property(e => e.Packcity)
                    .HasMaxLength(100)
                    .HasColumnName("packcity");

                entity.Property(e => e.Packpostalcode)
                    .HasMaxLength(25)
                    .HasColumnName("packpostalcode");

                entity.Property(e => e.Packstate)
                    .HasMaxLength(25)
                    .HasColumnName("packstate");

                entity.Property(e => e.Photo).HasColumnName("photo");

                entity.Property(e => e.Postalcode)
                    .HasMaxLength(25)
                    .HasColumnName("postalcode");

                entity.Property(e => e.Printcarrierlabel).HasColumnName("printcarrierlabel");

                entity.Property(e => e.Printreturnlabel).HasColumnName("printreturnlabel");

                entity.Property(e => e.Reorderbccemail)
                    .HasMaxLength(300)
                    .HasColumnName("reorderbccemail");

                entity.Property(e => e.Reordernotification).HasColumnName("reordernotification");

                entity.Property(e => e.Reordertoemail)
                    .HasMaxLength(300)
                    .HasColumnName("reordertoemail");

                entity.Property(e => e.Returnsbccmail)
                    .HasMaxLength(300)
                    .HasColumnName("returnsbccmail");

                entity.Property(e => e.Returnsnotification).HasColumnName("returnsnotification");

                entity.Property(e => e.Returnstomail)
                    .HasMaxLength(300)
                    .HasColumnName("returnstomail");

                entity.Property(e => e.Robccmail)
                    .HasMaxLength(300)
                    .HasColumnName("robccmail");

                entity.Property(e => e.Ronotification).HasColumnName("ronotification");

                entity.Property(e => e.Rotomail)
                    .HasMaxLength(300)
                    .HasColumnName("rotomail");

                entity.Property(e => e.Shippingbccmail)
                    .HasMaxLength(300)
                    .HasColumnName("shippingbccmail");

                entity.Property(e => e.Shippingnotification).HasColumnName("shippingnotification");

                entity.Property(e => e.Shippingtomail)
                    .HasMaxLength(300)
                    .HasColumnName("shippingtomail");

                entity.Property(e => e.State)
                    .HasMaxLength(25)
                    .HasColumnName("state");

                entity.Property(e => e.Supervisoremail)
                    .HasMaxLength(150)
                    .HasColumnName("supervisoremail");

                entity.Property(e => e.Supervisorname)
                    .HasMaxLength(150)
                    .HasColumnName("supervisorname");

                entity.Property(e => e.Templatename)
                    .HasMaxLength(500)
                    .HasColumnName("templatename");

                entity.Property(e => e.Whid)
                    .HasColumnName("whid")
                    .HasDefaultValueSql("9001");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.WhclientEntryusers)
                    .HasForeignKey(d => d.Entryuserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entryuserid_fk");

                entity.HasOne(d => d.Modifieduser)
                    .WithMany(p => p.WhclientModifiedusers)
                    .HasForeignKey(d => d.Modifieduserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("modifieduserid");

                entity.HasOne(d => d.Wh)
                    .WithMany(p => p.Whclients)
                    .HasForeignKey(d => d.Whid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("whid");
            });

            modelBuilder.Entity<Whlocation>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("whlocations_pkey");

                entity.ToTable("whlocations");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Aisle)
                    .HasMaxLength(30)
                    .HasColumnName("aisle")
                    .HasDefaultValueSql("'NA'::character varying");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(150)
                    .HasColumnName("barcode")
                    .HasDefaultValueSql("'NA'::character varying");

                entity.Property(e => e.Bin).HasColumnName("bin");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Fillfactor).HasColumnName("fillfactor");

                entity.Property(e => e.Inventorystored)
                    .HasMaxLength(30)
                    .HasColumnName("inventorystored")
                    .HasDefaultValueSql("'NA'::character varying");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Isbinlocation).HasColumnName("isbinlocation");

                entity.Property(e => e.Isliftassist).HasColumnName("isliftassist");

                entity.Property(e => e.Isreturnloc).HasColumnName("isreturnloc");

                entity.Property(e => e.Isrowrestricted).HasColumnName("isrowrestricted");

                entity.Property(e => e.Isscraploc).HasColumnName("isscraploc");

                entity.Property(e => e.Location)
                    .HasMaxLength(150)
                    .HasColumnName("location");

                entity.Property(e => e.Locationtype)
                    .HasMaxLength(30)
                    .HasColumnName("locationtype");

                entity.Property(e => e.Locheight).HasColumnName("locheight");

                entity.Property(e => e.Loclength).HasColumnName("loclength");

                entity.Property(e => e.Locmaxskus)
                    .HasColumnName("locmaxskus")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Locunits)
                    .HasColumnName("locunits")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locweight).HasColumnName("locweight");

                entity.Property(e => e.Locweightunits)
                    .HasMaxLength(10)
                    .HasColumnName("locweightunits")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locwidth).HasColumnName("locwidth");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Picklocation)
                    .IsRequired()
                    .HasColumnName("picklocation")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Pickseq)
                    .IsRequired()
                    .HasColumnName("pickseq")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Putawaystrategy)
                    .HasMaxLength(50)
                    .HasColumnName("putawaystrategy")
                    .HasDefaultValueSql("'NA'::character varying");

                entity.Property(e => e.Qrcode)
                    .HasMaxLength(500)
                    .HasColumnName("qrcode")
                    .HasDefaultValueSql("'NA'::character varying");

                entity.Property(e => e.Rack)
                    .HasMaxLength(30)
                    .HasColumnName("rack")
                    .HasDefaultValueSql("'NA'::character varying");

                entity.Property(e => e.Removalstrategy)
                    .HasMaxLength(50)
                    .HasColumnName("removalstrategy")
                    .HasDefaultValueSql("'NA'::character varying");

                entity.Property(e => e.Row)
                    .HasMaxLength(30)
                    .HasColumnName("row")
                    .HasDefaultValueSql("'NA'::character varying");

                entity.Property(e => e.Shelf)
                    .HasMaxLength(30)
                    .HasColumnName("shelf")
                    .HasDefaultValueSql("'NA'::character varying");

                entity.Property(e => e.Velocityrank)
                    .HasMaxLength(15)
                    .HasColumnName("velocityrank")
                    .HasDefaultValueSql("'NA'::character varying");

                entity.Property(e => e.Whid).HasColumnName("whid");

                entity.HasOne(d => d.Entryuser)
                    .WithMany(p => p.WhlocationEntryusers)
                    .HasForeignKey(d => d.Entryuserid)
                    .HasConstraintName("entryuserid");

                entity.HasOne(d => d.Modifieduser)
                    .WithMany(p => p.WhlocationModifiedusers)
                    .HasForeignKey(d => d.Modifieduserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("modifieduserid");

                entity.HasOne(d => d.Wh)
                    .WithMany(p => p.Whlocations)
                    .HasForeignKey(d => d.Whid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("whid_fk");
            });

            modelBuilder.Entity<Whmodule>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("whmodules_pkey");

                entity.ToTable("whmodules");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Modulename)
                    .HasMaxLength(200)
                    .HasColumnName("modulename");

                entity.Property(e => e.Parentid).HasColumnName("parentid");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.Parentid)
                    .HasConstraintName("parentid_fk");
            });

            modelBuilder.Entity<Whuser>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("whusers_pkey");

                entity.ToTable("whusers");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Allclientsaccess).HasColumnName("allclientsaccess");

                entity.Property(e => e.Allmodulesaccess).HasColumnName("allmodulesaccess");

                entity.Property(e => e.Allwarehousesaccess).HasColumnName("allwarehousesaccess");

                entity.Property(e => e.Companyname)
                    .HasMaxLength(100)
                    .HasColumnName("companyname");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Empid)
                    .HasMaxLength(50)
                    .HasColumnName("empid");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Entryuserid).HasColumnName("entryuserid");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .HasColumnName("fname");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .HasColumnName("lname");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(15)
                    .HasColumnName("mobile");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Photo).HasColumnName("photo");

                entity.Property(e => e.Picture)
                    .HasColumnType("character varying")
                    .HasColumnName("picture");

                entity.Property(e => e.Refreshtoken)
                    .HasColumnType("character varying")
                    .HasColumnName("refreshtoken");

                entity.Property(e => e.Refreshtokenexpirytime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("refreshtokenexpirytime")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Timezone)
                    .HasMaxLength(6)
                    .HasColumnName("timezone")
                    .HasDefaultValueSql("'CST'::character varying");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");

                entity.Property(e => e.Username)
                    .HasColumnType("character varying")
                    .HasColumnName("username");

                entity.Property(e => e.Usertype)
                    .HasMaxLength(100)
                    .HasColumnName("usertype");
            });

            modelBuilder.Entity<Whuserclient>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("whuseraccess_pkey");

                entity.ToTable("whuserclients");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Createddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("createddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Createduserid).HasColumnName("createduserid");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Whuserclients)
                    .HasForeignKey(d => d.Clientid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientid_fk");

                entity.HasOne(d => d.Createduser)
                    .WithMany(p => p.WhuserclientCreatedusers)
                    .HasForeignKey(d => d.Createduserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("createduserid_fk");

                entity.HasOne(d => d.Modifieduser)
                    .WithMany(p => p.WhuserclientModifiedusers)
                    .HasForeignKey(d => d.Modifieduserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("modifieduserid_fk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WhuserclientUsers)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userid_fk");
            });

            modelBuilder.Entity<Whusermodule>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("whusersmodules_pkey");

                entity.ToTable("whusermodules");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Accesslevel)
                    .IsRequired()
                    .HasColumnName("accesslevel")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Createduserid).HasColumnName("createduserid");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Moduleid).HasColumnName("moduleid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Createduser)
                    .WithMany(p => p.WhusermoduleCreatedusers)
                    .HasForeignKey(d => d.Createduserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("createuseridfk");

                entity.HasOne(d => d.Modifieduser)
                    .WithMany(p => p.WhusermoduleModifiedusers)
                    .HasForeignKey(d => d.Modifieduserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("modifieduserid_fk");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.Whusermodules)
                    .HasForeignKey(d => d.Moduleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("moduleid_fk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WhusermoduleUsers)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userid_fk");
            });

            modelBuilder.Entity<Whuserrefreshtoken>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("whuserrefreshtokens_pkey");

                entity.ToTable("whuserrefreshtokens");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Refreshtoken)
                    .HasMaxLength(250)
                    .HasColumnName("refreshtoken");

                entity.Property(e => e.Refreshtokenexpirytime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("refreshtokenexpirytime")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Whuserrefreshtokens)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userid_fk");
            });

            modelBuilder.Entity<Whuserwarehouse>(entity =>
            {
                entity.HasKey(e => e.Uniqueid)
                    .HasName("whuserwarehouses_pkey");

                entity.ToTable("whuserwarehouses");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1000L);

                entity.Property(e => e.Accesslevel)
                    .IsRequired()
                    .HasColumnName("accesslevel")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Createduserid).HasColumnName("createduserid");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifieduserid).HasColumnName("modifieduserid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Whid).HasColumnName("whid");

                entity.HasOne(d => d.Createduser)
                    .WithMany(p => p.WhuserwarehouseCreatedusers)
                    .HasForeignKey(d => d.Createduserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("createuseridfk");

                entity.HasOne(d => d.Modifieduser)
                    .WithMany(p => p.WhuserwarehouseModifiedusers)
                    .HasForeignKey(d => d.Modifieduserid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("modifieduserid_fk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WhuserwarehouseUsers)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userid_fk");

                entity.HasOne(d => d.Wh)
                    .WithMany(p => p.Whuserwarehouses)
                    .HasForeignKey(d => d.Whid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("whid_fk");
            });

            modelBuilder.HasSequence("billingfields_uniqueid_seq");

            modelBuilder.HasSequence("clientcartonsizes_uniqueid_seq");

            modelBuilder.HasSequence("ordererrorlog_id_seq");

            modelBuilder.HasSequence("orderitems_uid_seq")
                .HasMin(1000)
                .HasMax(2147483647);

            modelBuilder.HasSequence("orders_orderid_seq")
                .HasMin(1000)
                .HasMax(2147483647);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

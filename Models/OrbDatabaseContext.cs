using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ORB.API.Models;

public partial class OrbDatabaseContext : DbContext
{
    public OrbDatabaseContext()
    {
    }

    public OrbDatabaseContext(DbContextOptions<OrbDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Orb> Orbs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=/var/db/ORB_DATABASE.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Orb>(entity =>
        {
            entity.ToTable("ORB");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AssessorPwd).HasColumnName("assessor_pwd");
            entity.Property(e => e.AssessorUrl).HasColumnName("assessor_url");
            entity.Property(e => e.AssessorUser).HasColumnName("assessor_user");
            entity.Property(e => e.Comments).HasColumnName("comments");
            entity.Property(e => e.Copy).HasColumnName("copy");
            entity.Property(e => e.CopyFeeAmt).HasColumnName("copyFeeAmt");
            entity.Property(e => e.CopyPmtMethod).HasColumnName("copy_pmt_method");
            entity.Property(e => e.CopySource).HasColumnName("copy_source");
            entity.Property(e => e.County).HasColumnName("county");
            entity.Property(e => e.CountyHomepage).HasColumnName("county_homepage");
            entity.Property(e => e.CountyPwd).HasColumnName("county_pwd");
            entity.Property(e => e.CountyUser).HasColumnName("county_user");
            entity.Property(e => e.CourtImgDt).HasColumnName("courtImgDt");
            entity.Property(e => e.CourtIndexDt).HasColumnName("courtIndexDt");
            entity.Property(e => e.CourtPwd).HasColumnName("court_pwd");
            entity.Property(e => e.CourtUrl).HasColumnName("court_url");
            entity.Property(e => e.CourtUser).HasColumnName("court_user");
            entity.Property(e => e.DelinqTaxUrl).HasColumnName("delinq_tax_url");
            entity.Property(e => e.DtreeDesk).HasColumnName("dtree_desk");
            entity.Property(e => e.ForeclosureUrl).HasColumnName("foreclosure_url");
            entity.Property(e => e.ImgDate).HasColumnName("img_date");
            entity.Property(e => e.IndexDate).HasColumnName("index_date");
            entity.Property(e => e.IndexPmtMethod).HasColumnName("index_pmt_method");
            entity.Property(e => e.IndexSource).HasColumnName("index_source");
            entity.Property(e => e.Ins).HasColumnName("ins");
            entity.Property(e => e.LandPwd2).HasColumnName("land_pwd2");
            entity.Property(e => e.LandUrl).HasColumnName("land_url");
            entity.Property(e => e.LandUrl2).HasColumnName("land_url2");
            entity.Property(e => e.LandUser2).HasColumnName("land_user2");
            entity.Property(e => e.LastUpdate).HasColumnName("last_update");
            entity.Property(e => e.LoginReq).HasColumnName("login_req");
            entity.Property(e => e.MapUrl).HasColumnName("map_url");
            entity.Property(e => e.MuniCourtUrl).HasColumnName("muniCourt_url");
            entity.Property(e => e.MuniPwd).HasColumnName("muni_pwd");
            entity.Property(e => e.MuniUser).HasColumnName("muni_user");
            entity.Property(e => e.OtherPwd).HasColumnName("other_pwd");
            entity.Property(e => e.OtherUrl).HasColumnName("other_url");
            entity.Property(e => e.OtherUser).HasColumnName("other_user");
            entity.Property(e => e.PlatUrl).HasColumnName("plat_url");
            entity.Property(e => e.ProPwd).HasColumnName("pro_pwd");
            entity.Property(e => e.ProUser).HasColumnName("pro_user");
            entity.Property(e => e.ProbatePwd).HasColumnName("probate_pwd");
            entity.Property(e => e.ProbateUrl).HasColumnName("probate_url");
            entity.Property(e => e.ProbateUser).HasColumnName("probate_user");
            entity.Property(e => e.Props).HasColumnName("props");
            entity.Property(e => e.ProthonUrl).HasColumnName("prothon_url");
            entity.Property(e => e.Rv).HasColumnName("rv");
            entity.Property(e => e.SheriffUrl).HasColumnName("sheriff_url");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.SubFee).HasColumnName("subFee");
            entity.Property(e => e.SubNeed).HasColumnName("sub_need");
            entity.Property(e => e.SubTerm).HasColumnName("sub_term");
            entity.Property(e => e.Tap).HasColumnName("tap");
            entity.Property(e => e.Tax2Pwd).HasColumnName("tax2_pwd");
            entity.Property(e => e.Tax2Url).HasColumnName("tax2_url");
            entity.Property(e => e.Tax2User).HasColumnName("tax2_user");
            entity.Property(e => e.Tax3Pwd).HasColumnName("tax3_pwd");
            entity.Property(e => e.Tax3User).HasColumnName("tax3_user");
            entity.Property(e => e.TaxPwd).HasColumnName("tax_pwd");
            entity.Property(e => e.TaxUrl).HasColumnName("tax_url");
            entity.Property(e => e.TaxUser).HasColumnName("tax_user");
            entity.Property(e => e.UccUrl).HasColumnName("ucc_url");
            entity.Property(e => e.WeSubscribe).HasColumnName("we_subscribe");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

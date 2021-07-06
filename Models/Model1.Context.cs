﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LandeWebProjectV1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class test3Entities : DbContext
    {
        public test3Entities()
            : base("name=test3Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Aksesuar> Aksesuar { get; set; }
        public virtual DbSet<aksesuarDeger> aksesuarDeger { get; set; }
        public virtual DbSet<AksesuarGrubu> AksesuarGrubu { get; set; }
        public virtual DbSet<Analysis> Analysis { get; set; }
        public virtual DbSet<AuditDataItemPersistent> AuditDataItemPersistent { get; set; }
        public virtual DbSet<AuditedObjectWeakReference> AuditedObjectWeakReference { get; set; }
        public virtual DbSet<AydinlatmaMetni> AydinlatmaMetni { get; set; }
        public virtual DbSet<Banner> Banner { get; set; }
        public virtual DbSet<BasicUser> BasicUser { get; set; }
        public virtual DbSet<Boyut> Boyut { get; set; }
        public virtual DbSet<CerezPolitikasi> CerezPolitikasi { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<DashboardData> DashboardData { get; set; }
        public virtual DbSet<Degerler> Degerler { get; set; }
        public virtual DbSet<DegerTipleri> DegerTipleri { get; set; }
        public virtual DbSet<Departmanlar> Departmanlar { get; set; }
        public virtual DbSet<DigerDokumanlar> DigerDokumanlar { get; set; }
        public virtual DbSet<EmailListesi> EmailListesi { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<ExtendedSecurityRole> ExtendedSecurityRole { get; set; }
        public virtual DbSet<FileData> FileData { get; set; }
        public virtual DbSet<FiyatListesi> FiyatListesi { get; set; }
        public virtual DbSet<Fotograflar> Fotograflar { get; set; }
        public virtual DbSet<GizlilikPolitikasi> GizlilikPolitikasi { get; set; }
        public virtual DbSet<Haberler> Haberler { get; set; }
        public virtual DbSet<HakkimizdaAltGrup> HakkimizdaAltGrup { get; set; }
        public virtual DbSet<HakkimizdaVeAltBilgi> HakkimizdaVeAltBilgi { get; set; }
        public virtual DbSet<HCategory> HCategory { get; set; }
        public virtual DbSet<HeaderFooter> HeaderFooter { get; set; }
        public virtual DbSet<IDGeneratorTable> IDGeneratorTable { get; set; }
        public virtual DbSet<IK_VizyonPolitika> IK_VizyonPolitika { get; set; }
        public virtual DbSet<Iletisim> Iletisim { get; set; }
        public virtual DbSet<KaliteDokumanlari> KaliteDokumanlari { get; set; }
        public virtual DbSet<KapakOpsiyonDoc> KapakOpsiyonDoc { get; set; }
        public virtual DbSet<KapakOpsiyonlari> KapakOpsiyonlari { get; set; }
        public virtual DbSet<Kataloglar> Kataloglar { get; set; }
        public virtual DbSet<KataloglarSayfasi> KataloglarSayfasi { get; set; }
        public virtual DbSet<KlasorDokumanlari> KlasorDokumanlari { get; set; }
        public virtual DbSet<Klasorler> Klasorler { get; set; }
        public virtual DbSet<KpiDefinition> KpiDefinition { get; set; }
        public virtual DbSet<KpiHistoryItem> KpiHistoryItem { get; set; }
        public virtual DbSet<KpiInstance> KpiInstance { get; set; }
        public virtual DbSet<KpiScorecard> KpiScorecard { get; set; }
        public virtual DbSet<KpiScorecardScorecards_KpiInstanceIndicators> KpiScorecardScorecards_KpiInstanceIndicators { get; set; }
        public virtual DbSet<KurumsalLogoKullanimi> KurumsalLogoKullanimi { get; set; }
        public virtual DbSet<Logolar> Logolar { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<MediaDataObject> MediaDataObject { get; set; }
        public virtual DbSet<ModelDifference> ModelDifference { get; set; }
        public virtual DbSet<ModelDifferenceAspect> ModelDifferenceAspect { get; set; }
        public virtual DbSet<MontajKlavuzlari> MontajKlavuzlari { get; set; }
        public virtual DbSet<Note> Note { get; set; }
        public virtual DbSet<OnayBekleyenDokumanlar> OnayBekleyenDokumanlar { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<OtoKodTanim> OtoKodTanim { get; set; }
        public virtual DbSet<Ozellikler> Ozellikler { get; set; }
        public virtual DbSet<Parcalar> Parcalar { get; set; }
        public virtual DbSet<Party> Party { get; set; }
        public virtual DbSet<PermissionPolicyMemberPermissionsObject> PermissionPolicyMemberPermissionsObject { get; set; }
        public virtual DbSet<PermissionPolicyNavigationPermissionsObject> PermissionPolicyNavigationPermissionsObject { get; set; }
        public virtual DbSet<PermissionPolicyObjectPermissionsObject> PermissionPolicyObjectPermissionsObject { get; set; }
        public virtual DbSet<PermissionPolicyRole> PermissionPolicyRole { get; set; }
        public virtual DbSet<PermissionPolicyTypePermissionsObject> PermissionPolicyTypePermissionsObject { get; set; }
        public virtual DbSet<PermissionPolicyUser> PermissionPolicyUser { get; set; }
        public virtual DbSet<PermissionPolicyUserUsers_PermissionPolicyRoleRoles> PermissionPolicyUserUsers_PermissionPolicyRoleRoles { get; set; }
        public virtual DbSet<PersistentPermission> PersistentPermission { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumber { get; set; }
        public virtual DbSet<PhoneType> PhoneType { get; set; }
        public virtual DbSet<PropertyBag> PropertyBag { get; set; }
        public virtual DbSet<PropertyBagDescriptor> PropertyBagDescriptor { get; set; }
        public virtual DbSet<PropertyDescriptor> PropertyDescriptor { get; set; }
        public virtual DbSet<PropertyDescriptorPropertyDescriptors_PropertyBagDescriptorPropertyBags> PropertyDescriptorPropertyDescriptors_PropertyBagDescriptorPropertyBags { get; set; }
        public virtual DbSet<PropertyValue> PropertyValue { get; set; }
        public virtual DbSet<Reklamlar> Reklamlar { get; set; }
        public virtual DbSet<Renk> Renk { get; set; }
        public virtual DbSet<ReportData> ReportData { get; set; }
        public virtual DbSet<ReportDataV2> ReportDataV2 { get; set; }
        public virtual DbSet<Resource> Resource { get; set; }
        public virtual DbSet<ResourceResources_EventEvents> ResourceResources_EventEvents { get; set; }
        public virtual DbSet<Revizeler> Revizeler { get; set; }
        public virtual DbSet<RevizeNedenleri> RevizeNedenleri { get; set; }
        public virtual DbSet<RichTextMailMergeData> RichTextMailMergeData { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleBase> RoleBase { get; set; }
        public virtual DbSet<SecuritySystemMemberPermissionsObject> SecuritySystemMemberPermissionsObject { get; set; }
        public virtual DbSet<SecuritySystemObjectPermissionsObject> SecuritySystemObjectPermissionsObject { get; set; }
        public virtual DbSet<SecuritySystemRole> SecuritySystemRole { get; set; }
        public virtual DbSet<SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles> SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles { get; set; }
        public virtual DbSet<SecuritySystemTypePermissionsObject> SecuritySystemTypePermissionsObject { get; set; }
        public virtual DbSet<SecuritySystemUser> SecuritySystemUser { get; set; }
        public virtual DbSet<SecuritySystemUserUsers_SecuritySystemRoleRoles> SecuritySystemUserUsers_SecuritySystemRoleRoles { get; set; }
        public virtual DbSet<Sertifikalar> Sertifikalar { get; set; }
        public virtual DbSet<ServerPrefix> ServerPrefix { get; set; }
        public virtual DbSet<SimpleUser> SimpleUser { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Taglar> Taglar { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TeknikCizimler> TeknikCizimler { get; set; }
        public virtual DbSet<TeknikSartname> TeknikSartname { get; set; }
        public virtual DbSet<Update> Update { get; set; }
        public virtual DbSet<UretimDokumanlari> UretimDokumanlari { get; set; }
        public virtual DbSet<Urun_TeknikSartname> Urun_TeknikSartname { get; set; }
        public virtual DbSet<UrunAilesi> UrunAilesi { get; set; }
        public virtual DbSet<UrunDegerler> UrunDegerler { get; set; }
        public virtual DbSet<UrunGrubu> UrunGrubu { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
        public virtual DbSet<Urunlerurunler_Aksesuaraksesuar> Urunlerurunler_Aksesuaraksesuar { get; set; }
        public virtual DbSet<UrunSerisi> UrunSerisi { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserMid2> UserMid2 { get; set; }
        public virtual DbSet<UserUsers_RoleRoles> UserUsers_RoleRoles { get; set; }
        public virtual DbSet<VideolarSayfasi> VideolarSayfasi { get; set; }
        public virtual DbSet<WebFotograf> WebFotograf { get; set; }
        public virtual DbSet<XPObjectType> XPObjectType { get; set; }
        public virtual DbSet<XpoInstanceKey> XpoInstanceKey { get; set; }
        public virtual DbSet<XpoRunningWorkflowInstanceInfo> XpoRunningWorkflowInstanceInfo { get; set; }
        public virtual DbSet<XpoStartWorkflowRequest> XpoStartWorkflowRequest { get; set; }
        public virtual DbSet<XpoState> XpoState { get; set; }
        public virtual DbSet<XpoStateAppearance> XpoStateAppearance { get; set; }
        public virtual DbSet<XpoStateMachine> XpoStateMachine { get; set; }
        public virtual DbSet<XpoTrackingRecord> XpoTrackingRecord { get; set; }
        public virtual DbSet<XpoTransition> XpoTransition { get; set; }
        public virtual DbSet<XpoUserActivityVersion> XpoUserActivityVersion { get; set; }
        public virtual DbSet<XpoWorkflowDefinition> XpoWorkflowDefinition { get; set; }
        public virtual DbSet<XpoWorkflowInstance> XpoWorkflowInstance { get; set; }
        public virtual DbSet<XpoWorkflowInstanceControlCommandRequest> XpoWorkflowInstanceControlCommandRequest { get; set; }
        public virtual DbSet<XPWeakReference> XPWeakReference { get; set; }
        public virtual DbSet<XtraReportData> XtraReportData { get; set; }
        public virtual DbSet<Yetkilendirme> Yetkilendirme { get; set; }
        public virtual DbSet<YonetimKadrosu> YonetimKadrosu { get; set; }
        public virtual DbSet<YoutubeVideo> YoutubeVideo { get; set; }
        public virtual DbSet<Yukseklik> Yukseklik { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
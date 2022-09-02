//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityManagementEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityManagement file
/// </summary>
[Table("FacilityManagement", Schema = "Facilities")]
public partial class FacilityManagementEntity : EntityBase, IFacilityManagement
{
    #region "IFacilityManagement Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Facility")]
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Building Charter School Realty Access Type
    /// <para>
    /// The type of real estate vehicle through which a public charter school has access and control of its building space.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20846">Building Charter School Realty Access Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefBuildingCharterSchoolRealtyAccessType")]
    [Comment("The type of real estate vehicle through which a public charter school has access and control of its building space.")]
    public Guid? RefBuildingCharterSchoolRealtyAccessTypeId { get; set; }

    /// <summary>
    /// Building Cleaning Standard Type
    /// <para>
    /// The standard for cleanliness, and benchmarks for how much space can be assigned to one properly supplied custodian to meet these standards.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20847">Building Cleaning Standard Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefBuildingCleaningStandardType")]
    [Comment("The standard for cleanliness, and benchmarks for how much space can be assigned to one properly supplied custodian to meet these standards.")]
    public Guid? RefBuildingCleaningStandardTypeId { get; set; }

    /// <summary>
    /// Facility Capital Program Management Type
    /// <para>
    /// The type of management organization for planning, design, and construction of major capital projects.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20853">Facility Capital Program Management Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFacilityCapitalProgramMgmtType")]
    [Comment("The type of management organization for planning, design, and construction of major capital projects.")]
    public Guid? RefFacilityCapitalProgramMgmtTypeId { get; set; }

    /// <summary>
    /// Facility Compliance Agency Type
    /// <para>
    /// The type of agency that has ultimate responsibility for the compliance determination.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20848">Facility Compliance Agency Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFacilityComplianceAgencyType")]
    [Comment("The type of agency that has ultimate responsibility for the compliance determination.")]
    public Guid? RefFacilityComplianceAgencyTypeId { get; set; }

    /// <summary>
    /// Facility Operations Management Type
    /// <para>
    /// The type of management arrangements whereby a district oversees and manages its facilities operations.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20854">Facility Operations Management Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFacilityOperationsMgmtType")]
    [Comment("The type of management arrangements whereby a district oversees and manages its facilities operations.")]
    public Guid? RefFacilityOperationsMgmtTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual FacilityEntity FacilityEntity { get; set; }

    /// <summary>
    /// The type of real estate vehicle through which a public charter school has access and control of its building space.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20846">Building Charter School Realty Access Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingCharterSchoolRealtyAccessTypeEntity RefBuildingCharterSchoolRealtyAccessTypeEntity { get; set; }

    /// <summary>
    /// The standard for cleanliness, and benchmarks for how much space can be assigned to one properly supplied custodian to meet these standards.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20847">Building Cleaning Standard Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingCleaningStandardTypeEntity RefBuildingCleaningStandardTypeEntity { get; set; }

    /// <summary>
    /// The type of management organization for planning, design, and construction of major capital projects.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20853">Facility Capital Program Management Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefFacilityCapitalProgramMgmtTypeEntity RefFacilityCapitalProgramMgmtTypeEntity { get; set; }

    /// <summary>
    /// The type of agency that has ultimate responsibility for the compliance determination.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20848">Facility Compliance Agency Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefFacilityComplianceAgencyTypeEntity RefFacilityComplianceAgencyTypeEntity { get; set; }

    /// <summary>
    /// The type of management arrangements whereby a district oversees and manages its facilities operations.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20854">Facility Operations Management Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefFacilityOperationsMgmtTypeEntity RefFacilityOperationsMgmtTypeEntity { get; set; }

    #endregion
}

//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityManagementPlanEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityManagementPlan file
/// </summary>
[Table("FacilityManagementPlan", Schema = "Facilities")]
public partial class FacilityManagementPlanEntity : EntityBase, IFacilityManagementPlan
{
    #region "IFacilityManagementPlan Properties"
    /// <summary>
    /// Facilities Plan Description
    /// <para>
    /// A description of the management and accountability plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20863">Facilities Plan Description</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A description of the management and accountability plan.")]
    public System.String FacilitiesPlanDescription { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityManagement"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("FacilityManagement")]
    public Guid FacilityManagementId { get; set; }

    /// <summary>
    /// Facilities Management Emergency Type
    /// <para>
    /// The type of abnormal and urgent circumstances that disrupt the normal operation of the building, threaten the health and safety of the occupants, or require an emergency response.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20852">Facilities Management Emergency Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFacilitiesMgmtEmergencyType")]
    [Comment("The type of abnormal and urgent circumstances that disrupt the normal operation of the building, threaten the health and safety of the occupants, or require an emergency response.")]
    public Guid? RefFacilitiesMgmtEmergencyTypeId { get; set; }

    /// <summary>
    /// Facilities Plan Type
    /// <para>
    /// The type of management and accountability plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20864">Facilities Plan Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFacilitiesPlanType")]
    [Comment("The type of management and accountability plan.")]
    public Guid? RefFacilitiesPlanTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityManagement"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual FacilityManagementEntity FacilityManagementEntity { get; set; }

    /// <summary>
    /// The type of management and accountability plan.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20864">Facilities Plan Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefFacilitiesPlanTypeEntity? RefFacilitiesPlanTypeEntity { get; set; }

    /// <summary>
    /// The type of abnormal and urgent circumstances that disrupt the normal operation of the building, threaten the health and safety of the occupants, or require an emergency response.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20852">Facilities Management Emergency Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefFacilitiesMgmtEmergencyTypeEntity? RefFacilitiesMgmtEmergencyTypeEntity { get; set; }

    #endregion
}

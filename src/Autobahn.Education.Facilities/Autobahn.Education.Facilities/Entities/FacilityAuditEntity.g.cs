//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityAuditEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityAudit file
/// </summary>
[Table("FacilityAudit", Schema = "Facilities")]
public partial class FacilityAuditEntity : EntityBase, IFacilityAudit
{
    #region "IFacilityAudit Properties"
    /// <summary>
    /// Facility Audit Date
    /// <para>
    /// The month, day, and year of the systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20862">Facility Audit Date</a>
    /// </para>
    /// </summary>
    [Comment("The month, day, and year of the systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.")]
    public DateTime? FacilityAuditDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Facility")]
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Facility Audit Type
    /// <para>
    /// The type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20845">Facility Audit Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFacilityAuditType")]
    [Comment("The type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.")]
    public Guid? RefFacilityAuditTypeId { get; set; }

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
    /// The type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20845">Facility Audit Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefFacilityAuditTypeEntity RefFacilityAuditTypeEntity { get; set; }

    #endregion
}

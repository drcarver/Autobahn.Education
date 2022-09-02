//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12programOrServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12programOrService file
/// </summary>
[Table("K12programOrService", Schema = "K12")]
public partial class K12programOrServiceEntity : EntityBase, IK12programOrService
{
    #region "IK12programOrService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    public Boolean? ProgramInMultiplePurposeFacility { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefKindergartenDailyLength"/> model
    /// </summary>
    [Obsolete("The RefKindergartenDailyLength property is obsolete and will be removed in a later version")]
    [ForeignKey("RefKindergartenDailyLength")]
    public Guid? RefKindergartenDailyLengthId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefMepProjectType"/> model
    /// </summary>
    [ForeignKey("RefMepProjectType")]
    public Guid? RefMepProjectTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefMepSessionType"/> model
    /// </summary>
    [ForeignKey("RefMepSessionType")]
    public Guid? RefMepSessionTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPrekindergartenDailyLength"/> model
    /// </summary>
    [Obsolete("The RefPrekindergartenDailyLength property is obsolete and will be removed in a later version")]
    [ForeignKey("RefPrekindergartenDailyLength")]
    public Guid? RefPrekindergartenDailyLengthId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProgramGiftedEligibility"/> model
    /// </summary>
    [ForeignKey("RefProgramGiftedEligibility")]
    public Guid? RefProgramGiftedEligibilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIinstructionalServices"/> model
    /// </summary>
    [Obsolete("The RefTitleIinstructionalServices property is obsolete and will be removed in a later version")]
    [ForeignKey("RefTitleIinstructionalServices")]
    public Guid? RefTitleIinstructionalServicesId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIprogramType"/> model
    /// </summary>
    [ForeignKey("RefTitleIprogramType")]
    public Guid? RefTitleIprogramTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefProgramGiftedEligibility"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefProgramGiftedEligibilityEntity RefProgramGiftedEligibilityEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefMepSessionType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefMepSessionTypeEntity RefMepSessionTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefMepProjectType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefMepProjectTypeEntity RefMepProjectTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefTitleIprogramType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefTitleIprogramTypeEntity RefTitleIprogramTypeEntity { get; set; }

    #endregion
}

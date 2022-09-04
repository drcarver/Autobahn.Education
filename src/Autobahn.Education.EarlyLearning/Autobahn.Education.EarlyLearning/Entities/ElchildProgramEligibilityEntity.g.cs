//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElchildProgramEligibilityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElchildProgramEligibility file
/// </summary>
[Table("ElchildProgramEligibility", Schema = "EarlyLearning")]
public partial class ElchildProgramEligibilityEntity : EntityBase, IElchildProgramEligibility
{
    #region "IElchildProgramEligibility Properties"
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElprogramEligibilityStatus"/> model
    /// </summary>
    [ForeignKey("RefElprogramEligibilityStatus")]
    public Guid? RefElprogramEligibilityStatusId { get; set; }

    public DateTime? StatusDate { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefElprogramEligibilityStatus"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual RefElprogramEligibilityStatusEntity? RefElprogramEligibilityStatusEntity { get; set; }

    #endregion
}

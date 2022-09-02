//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElchildProgramEligibilityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElchildProgramEligibility file
/// </summary>
public partial class ElchildProgramEligibilityModel : AutobahnBaseModel, IElchildProgramEligibility
{
    #region "IElchildProgramEligibility Properties"
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElprogramEligibilityStatus"/> model
    /// </summary>
    public Guid? RefElprogramEligibilityStatusId { get; set; }

    public DateTime? StatusDate { get; set; }

    #endregion
}

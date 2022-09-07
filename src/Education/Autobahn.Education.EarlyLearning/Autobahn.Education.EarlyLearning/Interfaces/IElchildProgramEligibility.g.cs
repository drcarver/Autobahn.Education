//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   IElchildProgramEligibility.g.cs
//***************************************************************************

/// <summary>
/// The IElchildProgramEligibility file
/// </summary>
public partial interface IElchildProgramEligibility
{
    #region "IElchildProgramEligibility Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElprogramEligibilityStatus"/> model
    /// </summary>
    Guid? RefElprogramEligibilityStatusId { get; set; }

    DateTime? StatusDate { get; set; }

    #endregion
}

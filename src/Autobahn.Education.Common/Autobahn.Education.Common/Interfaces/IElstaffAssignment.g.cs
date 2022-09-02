//***************************************************************************
//* DomainName: Common Models
//* FileName:   IElstaffAssignment.g.cs
//***************************************************************************

/// <summary>
/// The IElstaffAssignment file
/// </summary>
public partial interface IElstaffAssignment
{
    #region "IElstaffAssignment Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    System.Boolean ItinerantProvider { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    #endregion
}

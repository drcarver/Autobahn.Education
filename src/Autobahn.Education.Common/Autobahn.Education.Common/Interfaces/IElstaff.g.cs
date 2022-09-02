//***************************************************************************
//* DomainName: Common Models
//* FileName:   IElstaff.g.cs
//***************************************************************************

/// <summary>
/// The IElstaff file
/// </summary>
public partial interface IElstaff
{
    #region "IElstaff Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefChildDevelopmentAssociateType"/> model
    /// </summary>
    Guid? RefChildDevelopmentAssociateTypeId { get; set; }

    #endregion
}

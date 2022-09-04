//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   IElorganization.g.cs
//***************************************************************************

/// <summary>
/// The IElorganization file
/// </summary>
public partial interface IElorganization
{
    #region "IElorganization Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProfitStatus"/> model
    /// </summary>
    Guid? RefProfitStatusId { get; set; }

    #endregion
}

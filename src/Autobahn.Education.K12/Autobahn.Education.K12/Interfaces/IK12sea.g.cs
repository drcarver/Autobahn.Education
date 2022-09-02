//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12sea.g.cs
//***************************************************************************

/// <summary>
/// The IK12sea file
/// </summary>
public partial interface IK12sea
{
    #region "IK12sea Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefStateAnsicode"/> model
    /// </summary>
    Guid? RefStateAnsicodeId { get; set; }

    #endregion
}

//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12seaEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12sea file
/// </summary>
public partial class K12seaModel : AutobahnBaseModel, IK12sea
{
    #region "IK12sea Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefStateAnsicode"/> model
    /// </summary>
    public Guid? RefStateAnsicodeId { get; set; }

    #endregion
}

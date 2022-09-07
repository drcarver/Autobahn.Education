//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElorganizationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElorganization file
/// </summary>
public partial class ElorganizationModel : AutobahnBaseModel, IElorganization
{
    #region "IElorganization Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProfitStatus"/> model
    /// </summary>
    public Guid? RefProfitStatusId { get; set; }

    #endregion
}

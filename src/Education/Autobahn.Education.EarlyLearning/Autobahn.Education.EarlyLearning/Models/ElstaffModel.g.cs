//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElstaffEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElstaff file
/// </summary>
public partial class ElstaffModel : AutobahnBaseModel, IElstaff
{
    #region "IElstaff Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefChildDevelopmentAssociateType"/> model
    /// </summary>
    public Guid? RefChildDevelopmentAssociateTypeId { get; set; }

    #endregion
}

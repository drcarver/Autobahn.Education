//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElstaffAssignmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElstaffAssignment file
/// </summary>
public partial class ElstaffAssignmentModel : AutobahnBaseModel, IElstaffAssignment
{
    #region "IElstaffAssignment Properties"
    public System.Boolean ItinerantProvider { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    #endregion
}

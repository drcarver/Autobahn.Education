//***************************************************************************
//* DomainName: Person Models
//* FileName:   OrganizationPersonRoleApplicationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationPersonRoleApplication file
/// </summary>
public partial class OrganizationPersonRoleApplicationModel : AutobahnBaseModel, IOrganizationPersonRoleApplication
{
    #region "IOrganizationPersonRoleApplication Properties"
    /// <summary>
    /// Application Date
    /// <para>
    /// The year, month and day on which an individual  application is received by the organization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19323">Application Date</a>
    /// </para>
    /// </summary>
    public System.DateTime ApplicationDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    #endregion
}

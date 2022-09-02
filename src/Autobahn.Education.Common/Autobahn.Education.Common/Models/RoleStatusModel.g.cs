//***************************************************************************
//* DomainName: Common Models
//* FileName:   RoleStatusEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRoleStatus file
/// </summary>
public partial class RoleStatusModel : AutobahnBaseModel, IRoleStatus
{
    #region "IRoleStatus Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Enrollment Status
    /// <para>
    /// An indication as to whether a student's name was, is, or will be officially registered on the roll of a school or schools.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19094">Enrollment Status</a>
    /// </para>
    /// </summary>
    public Guid? RefRoleStatusId { get; set; }

    /// <summary>
    /// Employment End Date
    /// <para>
    /// The year, month and day on which a person ended self-employment or employment with an organization or institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19794">Employment End Date</a>
    /// </para>
    /// </summary>
    public DateTime? StatusEndDate { get; set; }

    /// <summary>
    /// Employment Start Date
    /// <para>
    /// The year, month and day on which a person began self-employment or employment with an organization or institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19345">Employment Start Date</a>
    /// </para>
    /// </summary>
    public System.DateTime StatusStartDate { get; set; }

    #endregion
}

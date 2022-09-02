//***************************************************************************
//* DomainName: Common Models
//* FileName:   IOrganizationPersonRoleApplication.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationPersonRoleApplication file
/// </summary>
public partial interface IOrganizationPersonRoleApplication
{
    #region "IOrganizationPersonRoleApplication Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Application Date
    /// <para>
    /// The year, month and day on which an individual  application is received by the organization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19323">Application Date</a>
    /// </para>
    /// </summary>
    System.DateTime ApplicationDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    #endregion
}

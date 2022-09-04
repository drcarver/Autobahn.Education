//***************************************************************************
//* DomainName: Person Models
//* FileName:   OrganizationPersonRoleApplicationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationPersonRoleApplication file
/// </summary>
[Table("OrganizationPersonRoleApplication", Schema = "Autobahn.Core.Person")]
public partial class OrganizationPersonRoleApplicationEntity : EntityBase, IOrganizationPersonRoleApplication
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
    [Required(ErrorMessage="{0} is required.")]
    [Comment("The year, month and day on which an individual  application is received by the organization.")]
    public System.DateTime ApplicationDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}

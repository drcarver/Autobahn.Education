//***************************************************************************
//* DomainName: Common Models
//* FileName:   RoleStatusEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRoleStatus file
/// </summary>
[Table("RoleStatus", Schema = "Common")]
public partial class RoleStatusEntity : EntityBase, IRoleStatus
{
    #region "IRoleStatus Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
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
    [ForeignKey("RefRoleStatus")]
    [Comment("An indication as to whether a student's name was, is, or will be officially registered on the roll of a school or schools.")]
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
    [Comment("The year, month and day on which a person ended self-employment or employment with an organization or institution.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [Comment("The year, month and day on which a person began self-employment or employment with an organization or institution.")]
    public System.DateTime StatusStartDate { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// An indication as to whether a student's name was, is, or will be officially registered on the roll of a school or schools.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19094">Enrollment Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefRoleStatusEntity RefRoleStatusEntity { get; set; }

    #endregion
}

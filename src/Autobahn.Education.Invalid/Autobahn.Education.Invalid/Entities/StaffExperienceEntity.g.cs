//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   StaffExperienceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IStaffExperience file
/// </summary>
[Table("StaffExperience", Schema = "Invalid")]
public partial class StaffExperienceEntity : EntityBase, IStaffExperience
{
    #region "IStaffExperience Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    public Decimal? YearsOfPriorAeteachingExperience { get; set; }

    /// <summary>
    /// Years of Prior Teaching Experience
    /// <para>
    /// The total number of years prior to this job that a person has previously held a teaching position in one or more education institutions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19302">Years of Prior Teaching Experience</a>
    /// </para>
    /// </summary>
    [Comment("The total number of years prior to this job that a person has previously held a teaching position in one or more education institutions.")]
    public Decimal? YearsOfPriorTeachingExperience { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}

//***************************************************************************
//* DomainName: Common Models
//* FileName:   StaffExperienceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IStaffExperience file
/// </summary>
public partial class StaffExperienceModel : AutobahnBaseModel, IStaffExperience
{
    #region "IStaffExperience Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
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
    public Decimal? YearsOfPriorTeachingExperience { get; set; }

    #endregion
}

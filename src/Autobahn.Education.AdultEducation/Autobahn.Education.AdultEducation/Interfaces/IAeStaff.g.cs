//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   IAeStaff.g.cs
//***************************************************************************

/// <summary>
/// The IAeStaff file
/// </summary>
public partial interface IAeStaff
{
    #region "IAeStaff Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Adult Education Staff Classification
    /// <para>
    /// The titles of employment, official status, or rank of adult education staff.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19770">Adult Education Staff Classification</a>
    /// </para>
    /// </summary>
    Guid? RefAeStaffClassificationId { get; set; }

    /// <summary>
    /// Adult Education Staff Employment Status
    /// <para>
    /// The condition under which a person has agreed to serve as an employee.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19771">Adult Education Staff Employment Status</a>
    /// </para>
    /// </summary>
    Guid? RefAeStaffEmploymentStatusId { get; set; }

    /// <summary>
    /// Years of Prior Adult Education Teaching Experience
    /// <para>
    /// The total number of years that a person has previously held a teaching position in one or more adult education programs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19774">Years of Prior Adult Education Teaching Experience</a>
    /// </para>
    /// </summary>
    Decimal? YearsOfPriorAeTeachingExperience { get; set; }

    #endregion
}

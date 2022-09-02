//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   IPsStudentCohort.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentCohort file
/// </summary>
public partial interface IPsStudentCohort
{
    #region "IPsStudentCohort Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Cohort Graduation Year
    /// <para>
    /// The year the cohort is expected to graduate.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19577">Cohort Graduation Year</a>
    /// </para>
    /// </summary>
    System.String CohortGraduationYear { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    #endregion
}

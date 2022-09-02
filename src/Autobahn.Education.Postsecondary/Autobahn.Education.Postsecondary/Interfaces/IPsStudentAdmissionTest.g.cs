//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   IPsStudentAdmissionTest.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentAdmissionTest file
/// </summary>
public partial interface IPsStudentAdmissionTest
{
    #region "IPsStudentAdmissionTest Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Standardized Admission Test Type
    /// <para>
    /// The type of test prepared and administered by an agency that is independent of any postsecondary education institution and is typically used for admissions purposes. Tests provide information about prospective students and their academic qualifications relative to a national sample.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19266">Standardized Admission Test Type</a>
    /// </para>
    /// </summary>
    Guid RefStandardizedAdmissionTestId { get; set; }

    /// <summary>
    /// Standardized Admission Test Score
    /// <para>
    /// The quantitative score on a standardized admission test reported to a postsecondary institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19265">Standardized Admission Test Score</a>
    /// </para>
    /// </summary>
    Decimal? StandardizedAdmissionTestScore { get; set; }

    #endregion
}

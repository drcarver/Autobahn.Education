//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   IPsStudentEmployment.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentEmployment file
/// </summary>
public partial interface IPsStudentEmployment
{
    #region "IPsStudentEmployment Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Employment NAICS Code
    /// <para>
    /// The North American Industry Classification System (NAICS) code associated with an individual's employment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20070">Employment NAICS Code</a>
    /// </para>
    /// </summary>
    System.String EmploymentNaicsCode { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Employed After Exit
    /// <para>
    /// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, after exiting secondary, postsecondary, or adult education or workforce programs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19990">Employed After Exit</a>
    /// </para>
    /// </summary>
    Guid? RefEmployedAfterExitId { get; set; }

    /// <summary>
    /// Employed While Enrolled
    /// <para>
    /// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, and at the same time is enrolled in secondary, postsecondary, or adult education or workforce programs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19989">Employed While Enrolled</a>
    /// </para>
    /// </summary>
    Guid? RefEmployedWhileEnrolledId { get; set; }

    /// <summary>
    /// Employment Status While Enrolled
    /// <para>
    /// An indication of the individual's employment status while enrolled.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20310">Employment Status While Enrolled</a>
    /// </para>
    /// </summary>
    Guid? RefEmploymentStatusWhileEnrolledId { get; set; }

    #endregion
}

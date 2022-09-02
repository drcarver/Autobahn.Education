//***************************************************************************
//* DomainName: Common Models
//* FileName:   IOrganizationAccreditation.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationAccreditation file
/// </summary>
public partial interface IOrganizationAccreditation
{
    #region "IOrganizationAccreditation Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Accreditation Agency Name
    /// <para>
    /// The full name of an agency that accredited a school.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20500">Accreditation Agency Name</a>
    /// </para>
    /// </summary>
    System.String AccreditationAgencyName { get; set; }

    /// <summary>
    /// Accreditation Award Date
    /// <para>
    /// The year, month and day when an accreditation was awarded.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19840">Accreditation Award Date</a>
    /// </para>
    /// </summary>
    DateTime? AccreditationAwardDate { get; set; }

    /// <summary>
    /// Accreditation Expiration Date
    /// <para>
    /// The year, month and day when an accreditation expires.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19841">Accreditation Expiration Date</a>
    /// </para>
    /// </summary>
    DateTime? AccreditationExpirationDate { get; set; }

    Boolean? AccreditationStatus { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Accreditation Agency
    /// <para>
    /// The agency that accredited a program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19983">Accreditation Agency</a>
    /// </para>
    /// </summary>
    Guid? RefAccreditationAgencyId { get; set; }

    /// <summary>
    /// Higher Education Institution Accreditation Status
    /// <para>
    /// An indication of the accreditation status of a higher education institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19817">Higher Education Institution Accreditation Status</a>
    /// </para>
    /// </summary>
    Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

    /// <summary>
    /// Organization Seeking Accreditation Date
    /// <para>
    /// The date in which accreditation process was started (but not officially approved or denied)
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20388">Organization Seeking Accreditation Date</a>
    /// </para>
    /// </summary>
    DateTime? SeekingAccreditationDate { get; set; }

    #endregion
}

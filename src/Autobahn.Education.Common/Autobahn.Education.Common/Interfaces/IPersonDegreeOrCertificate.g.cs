//***************************************************************************
//* DomainName: Common Models
//* FileName:   IPersonDegreeOrCertificate.g.cs
//***************************************************************************

/// <summary>
/// The IPersonDegreeOrCertificate file
/// </summary>
public partial interface IPersonDegreeOrCertificate
{
    #region "IPersonDegreeOrCertificate Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Diploma or Credential Award Date
    /// <para>
    /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19081">Diploma or Credential Award Date</a>
    /// </para>
    /// </summary>
    DateTime? AwardDate { get; set; }

    /// <summary>
    /// Degree or Certificate Title or Subject
    /// <para>
    /// The name of the degree or certificate earned by a person. This includes honorary degrees conferred upon an individual.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19341">Degree or Certificate Title or Subject</a>
    /// </para>
    /// </summary>
    System.String DegreeOrCertificateTitleOrSubject { get; set; }

    /// <summary>
    /// Name of Institution
    /// <para>
    /// The full legally accepted name of the institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19191">Name of Institution</a>
    /// </para>
    /// </summary>
    System.String NameOfInstitution { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    Guid PersonId { get; set; }

    /// <summary>
    /// Degree or Certificate Type
    /// <para>
    /// The type of degree or certificate earned by a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19342">Degree or Certificate Type</a>
    /// </para>
    /// </summary>
    Guid? RefDegreeOrCertificateTypeId { get; set; }

    /// <summary>
    /// Education Verification Method
    /// <para>
    /// The method by which the formal education is verified.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20586">Education Verification Method</a>
    /// </para>
    /// </summary>
    Guid? RefEducationVerificationMethodId { get; set; }

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

    #endregion
}

//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   IAeStudentAcademicRecord.g.cs
//***************************************************************************

/// <summary>
/// The IAeStudentAcademicRecord file
/// </summary>
public partial interface IAeStudentAcademicRecord
{
    #region "IAeStudentAcademicRecord Properties"
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
    System.String DiplomaOrCredentialAwardDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// High School Diploma Type
    /// <para>
    /// The type of diploma/credential that is awarded to a person in recognition of his/her completion of the curricular requirements.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19138">High School Diploma Type</a>
    /// </para>
    /// </summary>
    Guid? RefHighSchoolDiplomaTypeId { get; set; }

    /// <summary>
    /// Professional or Technical Credential Conferred
    /// <para>
    /// An indicator of the category of credential conferred by a state occupational licensing entity or industry organization for competency in a specific area measured by a set of pre-established standards.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19780">Professional or Technical Credential Conferred</a>
    /// </para>
    /// </summary>
    Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

    #endregion
}

//***************************************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   ICteStudentAcademicRecord.g.cs
//***************************************************************************

/// <summary>
/// The ICteStudentAcademicRecord file
/// </summary>
public partial interface ICteStudentAcademicRecord
{
    #region "ICteStudentAcademicRecord Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Credits Attempted Cumulative
    /// <para>
    /// The cumulative number of credits a person attempts to earn by taking courses during their enrollment in their current education institution as well as those credits transferred from an education institution in which the person had been previously enrolled.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19073">Credits Attempted Cumulative</a>
    /// </para>
    /// </summary>
    Decimal? CreditsAttemptedCumulative { get; set; }

    /// <summary>
    /// Credits Earned Cumulative
    /// <para>
    /// The cumulative number of credits a person earns by completing courses or examinations during their enrollment in the current education institution as well as those credits transferred from an education institution in which the person had been previously enrolled.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19074">Credits Earned Cumulative</a>
    /// </para>
    /// </summary>
    Decimal? CreditsEarnedCumulative { get; set; }

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

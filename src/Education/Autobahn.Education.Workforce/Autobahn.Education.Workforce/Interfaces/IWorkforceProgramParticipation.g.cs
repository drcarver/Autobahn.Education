//***************************************************************************
//* DomainName: Workforce
//* FileName:   IWorkforceProgramParticipation.g.cs
//***************************************************************************

/// <summary>
/// The IWorkforceProgramParticipation file
/// </summary>
public partial interface IWorkforceProgramParticipation
{
    #region "IWorkforceProgramParticipation Properties"
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
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    Guid PersonProgramParticipationId { get; set; }

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

    /// <summary>
    /// Workforce Program Type
    /// <para>
    /// The type of workforce and employment development program that an individual is participating in.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20000">Workforce Program Type</a>
    /// </para>
    /// </summary>
    Guid? RefWfProgramParticipationId { get; set; }

    #endregion
}

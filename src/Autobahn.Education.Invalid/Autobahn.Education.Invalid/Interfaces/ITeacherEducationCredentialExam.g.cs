//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ITeacherEducationCredentialExam.g.cs
//***************************************************************************

/// <summary>
/// The ITeacherEducationCredentialExam file
/// </summary>
public partial interface ITeacherEducationCredentialExam
{
    #region "ITeacherEducationCredentialExam Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProgramParticipationTeacherPrep"/> model
    /// </summary>
    Guid ProgramParticipationTeacherPrepId { get; set; }

    /// <summary>
    /// Teacher Education Credential Exam Type
    /// <para>
    /// The type of examination used to assess teacher candidate's knowledge and skills.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19756">Teacher Education Credential Exam Type</a>
    /// </para>
    /// </summary>
    Guid? RefTeacherEducationCredentialExamId { get; set; }

    /// <summary>
    /// Teacher Education Credential Exam Score Type
    /// <para>
    /// An indication of the type of credential exam associated with a given exam score.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19757">Teacher Education Credential Exam Score Type</a>
    /// </para>
    /// </summary>
    Guid? RefTeacherEducationExamScoreTypeId { get; set; }

    /// <summary>
    /// Teacher Education Test Company
    /// <para>
    /// The name of the company that provides the examination used in the teacher education program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19748">Teacher Education Test Company</a>
    /// </para>
    /// </summary>
    Guid? RefTeacherEducationTestCompanyId { get; set; }

    #endregion
}

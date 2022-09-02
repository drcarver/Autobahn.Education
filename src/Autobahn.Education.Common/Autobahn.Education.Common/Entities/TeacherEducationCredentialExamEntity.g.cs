//***************************************************************************
//* DomainName: Common Models
//* FileName:   TeacherEducationCredentialExamEntity.g.cs
//***************************************************************************

/// <summary>
/// The ITeacherEducationCredentialExam file
/// </summary>
[Table("TeacherEducationCredentialExam", Schema = "Common")]
public partial class TeacherEducationCredentialExamEntity : EntityBase, ITeacherEducationCredentialExam
{
    #region "ITeacherEducationCredentialExam Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IProgramParticipationTeacherPrep"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("ProgramParticipationTeacherPrep")]
    public Guid ProgramParticipationTeacherPrepId { get; set; }

    /// <summary>
    /// Teacher Education Credential Exam Type
    /// <para>
    /// The type of examination used to assess teacher candidate's knowledge and skills.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19756">Teacher Education Credential Exam Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefTeacherEducationCredentialExam")]
    [Comment("The type of examination used to assess teacher candidate's knowledge and skills.")]
    public Guid? RefTeacherEducationCredentialExamId { get; set; }

    /// <summary>
    /// Teacher Education Credential Exam Score Type
    /// <para>
    /// An indication of the type of credential exam associated with a given exam score.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19757">Teacher Education Credential Exam Score Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefTeacherEducationExamScoreType")]
    [Comment("An indication of the type of credential exam associated with a given exam score.")]
    public Guid? RefTeacherEducationExamScoreTypeId { get; set; }

    /// <summary>
    /// Teacher Education Test Company
    /// <para>
    /// The name of the company that provides the examination used in the teacher education program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19748">Teacher Education Test Company</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefTeacherEducationTestCompany")]
    [Comment("The name of the company that provides the examination used in the teacher education program.")]
    public Guid? RefTeacherEducationTestCompanyId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The type of examination used to assess teacher candidate's knowledge and skills.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19756">Teacher Education Credential Exam Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefTeacherEducationCredentialExamEntity RefTeacherEducationCredentialExamEntity { get; set; }

    /// <summary>
    /// An indication of the type of credential exam associated with a given exam score.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19757">Teacher Education Credential Exam Score Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefTeacherEducationExamScoreTypeEntity RefTeacherEducationExamScoreTypeEntity { get; set; }

    /// <summary>
    /// The name of the company that provides the examination used in the teacher education program.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19748">Teacher Education Test Company</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefTeacherEducationTestCompanyEntity RefTeacherEducationTestCompanyEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProgramParticipationTeacherPrep"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual ProgramParticipationTeacherPrepEntity ProgramParticipationTeacherPrepEntity { get; set; }

    #endregion
}

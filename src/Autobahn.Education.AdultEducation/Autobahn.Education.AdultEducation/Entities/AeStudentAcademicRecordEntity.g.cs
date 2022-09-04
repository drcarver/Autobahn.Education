//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStudentAcademicRecordEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAeStudentAcademicRecord file
/// </summary>
[Table("AeStudentAcademicRecord", Schema = "AdultEducation")]
public partial class AeStudentAcademicRecordEntity : EntityBase, IAeStudentAcademicRecord
{
    #region "IAeStudentAcademicRecord Properties"
    /// <summary>
    /// Diploma or Credential Award Date
    /// <para>
    /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19081">Diploma or Credential Award Date</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(7,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.")]
    public System.String DiplomaOrCredentialAwardDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// High School Diploma Type
    /// <para>
    /// The type of diploma/credential that is awarded to a person in recognition of his/her completion of the curricular requirements.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19138">High School Diploma Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefHighSchoolDiplomaType")]
    [Comment("The type of diploma/credential that is awarded to a person in recognition of his/her completion of the curricular requirements.")]
    public Guid? RefHighSchoolDiplomaTypeId { get; set; }

    /// <summary>
    /// Professional or Technical Credential Conferred
    /// <para>
    /// An indicator of the category of credential conferred by a state occupational licensing entity or industry organization for competency in a specific area measured by a set of pre-established standards.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19780">Professional or Technical Credential Conferred</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefProfessionalTechnicalCredentialType")]
    [Comment("An indicator of the category of credential conferred by a state occupational licensing entity or industry organization for competency in a specific area measured by a set of pre-established standards.")]
    public Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The type of diploma/credential that is awarded to a person in recognition of his/her completion of the curricular requirements.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19138">High School Diploma Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the AdultEducation domain
    /// </remarks>
    /// </summary>
    public virtual RefHighSchoolDiplomaTypeEntity? RefHighSchoolDiplomaTypeEntity { get; set; }

    /// <summary>
    /// An indicator of the category of credential conferred by a state occupational licensing entity or industry organization for competency in a specific area measured by a set of pre-established standards.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19780">Professional or Technical Credential Conferred</a>
    /// </para>
    /// <remarks>
    /// This entity is in the AdultEducation domain
    /// </remarks>
    /// </summary>
    public virtual RefProfessionalTechnicalCredentialTypeEntity? RefProfessionalTechnicalCredentialTypeEntity { get; set; }

    #endregion
}

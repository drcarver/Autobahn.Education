//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonDegreeOrCertificateEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonDegreeOrCertificate file
/// </summary>
[Table("PersonDegreeOrCertificate", Schema = "Person")]
public partial class PersonDegreeOrCertificateEntity : EntityBase, IPersonDegreeOrCertificate
{
    #region "IPersonDegreeOrCertificate Properties"
    /// <summary>
    /// Diploma or Credential Award Date
    /// <para>
    /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19081">Diploma or Credential Award Date</a>
    /// </para>
    /// </summary>
    [Comment("The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.")]
    public DateTime? AwardDate { get; set; }

    /// <summary>
    /// Degree or Certificate Title or Subject
    /// <para>
    /// The name of the degree or certificate earned by a person. This includes honorary degrees conferred upon an individual.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19341">Degree or Certificate Title or Subject</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(45,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name of the degree or certificate earned by a person. This includes honorary degrees conferred upon an individual.")]
    public System.String DegreeOrCertificateTitleOrSubject { get; set; }

    /// <summary>
    /// Name of Institution
    /// <para>
    /// The full legally accepted name of the institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19191">Name of Institution</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The full legally accepted name of the institution.")]
    public System.String NameOfInstitution { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Degree or Certificate Type
    /// <para>
    /// The type of degree or certificate earned by a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19342">Degree or Certificate Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefDegreeOrCertificateType")]
    [Comment("The type of degree or certificate earned by a person.")]
    public Guid? RefDegreeOrCertificateTypeId { get; set; }

    /// <summary>
    /// Education Verification Method
    /// <para>
    /// The method by which the formal education is verified.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20586">Education Verification Method</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefEducationVerificationMethod")]
    [Comment("The method by which the formal education is verified.")]
    public Guid? RefEducationVerificationMethodId { get; set; }

    /// <summary>
    /// Higher Education Institution Accreditation Status
    /// <para>
    /// An indication of the accreditation status of a higher education institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19817">Higher Education Institution Accreditation Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefHigherEducationInstitutionAccreditationStatus")]
    [Comment("An indication of the accreditation status of a higher education institution.")]
    public Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The type of degree or certificate earned by a person.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19342">Degree or Certificate Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Person domain
    /// </remarks>
    /// </summary>
    public virtual RefDegreeOrCertificateTypeEntity? RefDegreeOrCertificateTypeEntity { get; set; }

    /// <summary>
    /// An indication of the accreditation status of a higher education institution.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19817">Higher Education Institution Accreditation Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Person domain
    /// </remarks>
    /// </summary>
    public virtual RefHigherEducationInstitutionAccreditationStatusEntity? RefHigherEducationInstitutionAccreditationStatusEntity { get; set; }

    /// <summary>
    /// The method by which the formal education is verified.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20586">Education Verification Method</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Person domain
    /// </remarks>
    /// </summary>
    public virtual RefEducationVerificationMethodEntity? RefEducationVerificationMethodEntity { get; set; }

    #endregion
}

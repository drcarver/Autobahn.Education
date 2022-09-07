//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   StaffCredentialEntity.g.cs
//***************************************************************************

/// <summary>
/// The IStaffCredential file
/// </summary>
[Table("StaffCredential", Schema = "Invalid")]
public partial class StaffCredentialEntity : EntityBase, IStaffCredential
{
    #region "IStaffCredential Properties"
    /// <summary>
    /// Cardiopulmonary Resuscitation Certification Expiration Date
    /// <para>
    /// The date an individual's cardiopulmonary resuscitation (CPR) training certification expires.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20065">Cardiopulmonary Resuscitation Certification Expiration Date</a>
    /// </para>
    /// </summary>
    [Comment("The date an individual's cardiopulmonary resuscitation (CPR) training certification expires.")]
    public DateTime? CardiopulmonaryResuscitationCertification { get; set; }

    public Boolean? CteinstructorIndustryCertification { get; set; }

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
    /// First Aid Certification Expiration Date
    /// <para>
    /// The date an individual's first aid training certification expires.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20066">First Aid Certification Expiration Date</a>
    /// </para>
    /// </summary>
    [Comment("The date an individual's first aid training certification expires.")]
    public DateTime? FirstAidCertification { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonCredential"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("PersonCredential")]
    public Guid PersonCredentialId { get; set; }

    /// <summary>
    /// Adult Education Certification Type
    /// <para>
    /// An indication of the category of the adult education certification a person holds.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19775">Adult Education Certification Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAeCertificationType")]
    [Comment("An indication of the category of the adult education certification a person holds.")]
    public Guid? RefAeCertificationTypeId { get; set; }

    /// <summary>
    /// Child Development Associate Type
    /// <para>
    /// Type of Child Development Associate credential as defined by options.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19805">Child Development Associate Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefChildDevAssociateType")]
    [Comment("Type of Child Development Associate credential as defined by options.")]
    public Guid? RefChildDevAssociateTypeId { get; set; }

    /// <summary>
    /// Paraprofessional Qualification Status
    /// <para>
    /// An indication of whether paraprofessionals are classified as qualified for their assignment according to state definition.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19207">Paraprofessional Qualification Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefParaprofessionalQualification")]
    [Comment("An indication of whether paraprofessionals are classified as qualified for their assignment according to state definition.")]
    public Guid? RefParaprofessionalQualificationId { get; set; }

    /// <summary>
    /// Program Sponsor Type
    /// <para>
    /// A type of organization providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19692">Program Sponsor Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefProgramSponsorType")]
    [Comment("A type of organization providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.")]
    public Guid? RefProgramSponsorTypeId { get; set; }

    /// <summary>
    /// Teaching Credential Basis
    /// <para>
    /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19277">Teaching Credential Basis</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefTeachingCredentialBasis")]
    [Comment("An indication of the pre-determined criteria for granting the teaching credential that a person holds.")]
    public Guid? RefTeachingCredentialBasisId { get; set; }

    /// <summary>
    /// Teaching Credential Type
    /// <para>
    /// An indication of the category of a legal document giving authorization to perform teaching assignment services.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19278">Teaching Credential Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefTeachingCredentialType")]
    [Comment("An indication of the category of a legal document giving authorization to perform teaching assignment services.")]
    public Guid? RefTeachingCredentialTypeId { get; set; }

    /// <summary>
    /// Technology Skills Standards Met
    /// <para>
    /// An indication that the person has achieved acceptable performance on a standards-based profile of technology user skills as defined by the state.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19537">Technology Skills Standards Met</a>
    /// </para>
    /// </summary>
    [Comment("An indication that the person has achieved acceptable performance on a standards-based profile of technology user skills as defined by the state.")]
    public Boolean? TechnologySkillsStandardsMet { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonCredential"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual PersonCredentialEntity PersonCredentialEntity { get; set; }

    /// <summary>
    /// An indication of the category of a legal document giving authorization to perform teaching assignment services.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19278">Teaching Credential Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefTeachingCredentialTypeEntity? RefTeachingCredentialTypeEntity { get; set; }

    /// <summary>
    /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19277">Teaching Credential Basis</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefTeachingCredentialBasisEntity? RefTeachingCredentialBasisEntity { get; set; }

    /// <summary>
    /// An indication of whether paraprofessionals are classified as qualified for their assignment according to state definition.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19207">Paraprofessional Qualification Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefParaprofessionalQualificationEntity? RefParaprofessionalQualificationEntity { get; set; }

    /// <summary>
    /// A type of organization providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19692">Program Sponsor Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefProgramSponsorTypeEntity? RefProgramSponsorTypeEntity { get; set; }

    /// <summary>
    /// An indication of the category of the adult education certification a person holds.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19775">Adult Education Certification Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefAeCertificationTypeEntity? RefAeCertificationTypeEntity { get; set; }

    #endregion
}

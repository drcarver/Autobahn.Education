//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonDetailEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonDetail file
/// </summary>
[Table("PersonDetail", Schema = "Common")]
public partial class PersonDetailEntity : EntityBase, IPersonDetail
{
    #region "IPersonDetail Properties"
    /// <summary>
    /// Birthdate
    /// <para>
    /// The year, month and day on which a person was born.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19033">Birthdate</a>
    /// </para>
    /// </summary>
    [Comment("The year, month and day on which a person was born.")]
    public DateTime? Birthdate { get; set; }

    /// <summary>
    /// Birthdate Verification
    /// <para>
    /// The evidence by which a child's date of birth is confirmed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19418">Birthdate Verification</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The evidence by which a child's date of birth is confirmed.")]
    public System.String BirthdateVerification { get; set; }

    /// <summary>
    /// First Name
    /// <para>
    /// The full legal first name given to a person at birth, baptism, or through legal change.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19115">First Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(75,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The full legal first name given to a person at birth, baptism, or through legal change.")]
    public System.String FirstName { get; set; }

    /// <summary>
    /// Generation Code or Suffix
    /// <para>
    /// An appendage, if any, used to denote a person's generation in his family (e.g., Jr., Sr., III).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19121">Generation Code or Suffix</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(10,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("An appendage, if any, used to denote a person's generation in his family (e.g., Jr., Sr., III).")]
    public System.String GenerationCode { get; set; }

    /// <summary>
    /// Hispanic or Latino Ethnicity
    /// <para>
    /// An indication that the person traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central and South America, and other Spanish cultures, regardless of race.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19144">Hispanic or Latino Ethnicity</a>
    /// </para>
    /// </summary>
    [Comment("An indication that the person traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central and South America, and other Spanish cultures, regardless of race.")]
    public Boolean? HispanicLatinoEthnicity { get; set; }

    /// <summary>
    /// Last or Surname
    /// <para>
    /// The full legal last name borne in common by members of a family.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19172">Last or Surname</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(75,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The full legal last name borne in common by members of a family.")]
    public System.String LastName { get; set; }

    /// <summary>
    /// Middle Name
    /// <para>
    /// A full legal middle name given to a person at birth, baptism, or through legal change.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19184">Middle Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(75,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A full legal middle name given to a person at birth, baptism, or through legal change.")]
    public System.String MiddleName { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Personal Title or Prefix
    /// <para>
    /// An appellation, if any, used to denote rank, placement, or status (e.g., Mr., Ms., Reverend, Sister, Dr., Colonel).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19212">Personal Title or Prefix</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("An appellation, if any, used to denote rank, placement, or status (e.g., Mr., Ms., Reverend, Sister, Dr., Colonel).")]
    public System.String Prefix { get; set; }

    /// <summary>
    /// Highest Level of Education Completed
    /// <para>
    /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19141">Highest Level of Education Completed</a>
    /// </para>
    /// </summary>
    [Obsolete("The RefHighestEducationLevelCompleted property is obsolete and will be removed in a later version")]
    [ForeignKey("RefHighestEducationLevelCompleted")]
    [Comment("The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).")]
    public Guid? RefHighestEducationLevelCompletedId { get; set; }

    /// <summary>
    /// Proof of Residency Type
    /// <para>
    /// An accepted form of proof of residency in the district/county/other locality.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19305">Proof of Residency Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefProofOfResidencyType")]
    [Comment("An accepted form of proof of residency in the district/county/other locality.")]
    public Guid? RefProofOfResidencyTypeId { get; set; }

    /// <summary>
    /// Sex
    /// <para>
    /// The concept describing the biological traits that distinguish the males and females of a species.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19255">Sex</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefSex")]
    [Comment("The concept describing the biological traits that distinguish the males and females of a species.")]
    public Guid? RefSexId { get; set; }

    /// <summary>
    /// State of Residence
    /// <para>
    /// An person's permanent address as determined by such evidence as a driver's license or voter registration. For entering freshmen, state of residence may be the legal state of residence of a parent or guardian.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19268">State of Residence</a>
    /// </para>
    /// </summary>
    [Obsolete("The RefStateOfResidence property is obsolete and will be removed in a later version")]
    [ForeignKey("RefStateOfResidence")]
    [Comment("An person's permanent address as determined by such evidence as a driver's license or voter registration. For entering freshmen, state of residence may be the legal state of residence of a parent or guardian.")]
    public Guid? RefStateOfResidenceId { get; set; }

    /// <summary>
    /// Tribal Affiliation
    /// <para>
    /// The Native American tribal entity recognized and eligible to receive services from the United States Bureau of Indian Affairs to which a person is affiliated.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20638">Tribal Affiliation</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefTribalAffiliation")]
    [Comment("The Native American tribal entity recognized and eligible to receive services from the United States Bureau of Indian Affairs to which a person is affiliated.")]
    public Guid? RefTribalAffiliationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefUscitizenshipStatus"/> model
    /// </summary>
    [ForeignKey("RefUscitizenshipStatus")]
    public Guid? RefUscitizenshipStatusId { get; set; }

    /// <summary>
    /// Visa Type
    /// <para>
    /// An indicator of a non-US citizen's Visa type.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19196">Visa Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefVisaType")]
    [Comment("An indicator of a non-US citizen's Visa type.")]
    public Guid? RefVisaTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The concept describing the biological traits that distinguish the males and females of a species.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19255">Sex</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefSexEntity RefSexEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefUscitizenshipStatus"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefUscitizenshipStatusEntity RefUscitizenshipStatusEntity { get; set; }

    /// <summary>
    /// An indicator of a non-US citizen's Visa type.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19196">Visa Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefVisaTypeEntity RefVisaTypeEntity { get; set; }

    /// <summary>
    /// An accepted form of proof of residency in the district/county/other locality.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19305">Proof of Residency Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefProofOfResidencyTypeEntity RefProofOfResidencyTypeEntity { get; set; }

    /// <summary>
    /// The Native American tribal entity recognized and eligible to receive services from the United States Bureau of Indian Affairs to which a person is affiliated.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20638">Tribal Affiliation</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefTribalAffiliationEntity RefTribalAffiliationEntity { get; set; }

    #endregion
}

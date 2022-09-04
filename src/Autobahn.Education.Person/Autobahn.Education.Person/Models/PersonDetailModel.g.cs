//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonDetailEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonDetail file
/// </summary>
public partial class PersonDetailModel : AutobahnBaseModel, IPersonDetail
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
    public System.String MiddleName { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
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
    public Guid? RefTribalAffiliationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefUscitizenshipStatus"/> model
    /// </summary>
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
    public Guid? RefVisaTypeId { get; set; }

    #endregion
}

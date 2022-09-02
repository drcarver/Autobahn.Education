//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   PersonModel.cs
//***************************************************************************

/// <summary>
/// A human being regarded as an individual
/// </summary>
public partial class PersonModel : AutobahnBaseModel, IPerson
{
    #region "IPerson Properties"
    /// <summary>
    /// Birthdate
    /// <para>
    /// The year, month and day on which a person was born.
    /// </para>
    /// </summary>
    public DateTime? Birthdate { get; set; }

    /// <summary>
    /// Deathdate
    /// <para>
    /// The year, month and day on which a person died.
    /// </para>
    /// </summary>
    public DateTime? Deathdate { get; set; }

    /// <summary>
    /// First Name
    /// <para>
    /// The full legal first name given to a person at birth, 
    /// baptism, or through legal change.
    /// </para>
    /// </summary>
    public System.String? FirstName { get; set; }

    /// <summary>
    /// Generation Code or Suffix
    /// <para>
    /// An appendage, if any, used to denote a person's generation 
    /// in his family (e.g., Jr., Sr., III).
    /// </para>
    /// </summary>
    public System.String? GenerationCode { get; set; }

    /// <summary>
    /// Last or Surname
    /// <para>
    /// The full legal last name borne in common by members of a family.
    /// </para>
    /// </summary>
    public System.String? LastName { get; set; }

    /// <summary>
    /// Middle Name
    /// <para>
    /// A full legal middle name given to a person at birth, baptism, or through legal change.
    /// </para>
    /// </summary>
    public System.String? MiddleName { get; set; }

    /// <summary>
    /// Personal Title or Prefix
    /// <para>
    /// An appellation, if any, used to denote rank, placement, or status (e.g., Mr., Ms., Reverend, Sister, Dr., Colonel).
    /// </para>
    /// </summary>
    public System.String? Prefix { get; set; }

    /// <summary>
    /// Sex
    /// <para>
    /// The concept describing the biological traits that distinguish the males and females of a species.
    /// </para>
    /// </summary>
    public Guid? RefSexId { get; set; }
    #endregion
}
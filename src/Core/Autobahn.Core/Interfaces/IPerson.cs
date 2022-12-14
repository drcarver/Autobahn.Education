//**********************************************************
//* DomainName: Common models used in multiple domains.
//* FileName:   IPerson.cs
//***************************************************************************

/// <summary>
/// A human being regarded as an individual
/// </summary>
public interface IPerson
{
    /// <summary>
    /// The primary key of the model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Birthdate
    /// <para>
    /// The year, month and day on which a person was born.
    /// </para>
    /// </summary>
    DateTime? Birthdate { get; set; }

    /// <summary>
    /// Deathdate
    /// <para>
    /// The year, month and day on which a person died.
    /// </para>
    /// </summary>
    DateTime? Deathdate { get; set; }

    /// <summary>
    /// First Name
    /// <para>
    /// The full legal first name given to a person at birth, 
    /// baptism, or through legal change.
    /// </para>
    /// </summary>
    System.String FirstName { get; set; }

    /// <summary>
    /// Generation Code or Suffix
    /// <para>
    /// An appendage, if any, used to denote a person's generation 
    /// in his family (e.g., Jr., Sr., III).
    /// </para>
    /// </summary>
    System.String GenerationCode { get; set; }

    /// <summary>
    /// Last or Surname
    /// <para>
    /// The full legal last name borne in common by members of a family.
    /// </para>
    /// </summary>
    System.String LastName { get; set; }

    /// <summary>
    /// Middle Name
    /// <para>
    /// A full legal middle name given to a person at birth, baptism, 
    /// or through legal change.
    /// </para>
    /// </summary>
    System.String MiddleName { get; set; }

    /// <summary>
    /// Personal Title or Prefix
    /// <para>
    /// An appellation, if any, used to denote rank, placement, or 
    /// status (e.g., Mr., Ms., Reverend, Sister, Dr., Colonel).
    /// </para>
    /// </summary>
    System.String Prefix { get;  set; }

    /// <summary>
    /// Sex
    /// <para>
    /// The concept describing the biological traits that distinguish 
    /// the males and females of a species.
    /// </para>
    /// </summary>
    Guid? RefSexId { get; set; }
}
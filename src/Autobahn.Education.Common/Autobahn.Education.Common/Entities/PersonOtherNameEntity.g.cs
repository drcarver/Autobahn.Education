//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonOtherNameEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonOtherName file
/// </summary>
[Table("PersonOtherName", Schema = "Common")]
public partial class PersonOtherNameEntity : EntityBase, IPersonOtherName
{
    #region "IPersonOtherName Properties"
    /// <summary>
    /// Other First Name
    /// <para>
    /// A first name given to a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20486">Other First Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(35,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A first name given to a person.")]
    public System.String FirstName { get; set; }

    /// <summary>
    /// Other Last Name
    /// <para>
    /// A last name given to a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20485">Other Last Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(35,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A last name given to a person.")]
    public System.String LastName { get; set; }

    /// <summary>
    /// Other Middle Name
    /// <para>
    /// A middle name given to a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20487">Other Middle Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(35,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A middle name given to a person.")]
    public System.String MiddleName { get; set; }

    /// <summary>
    /// Other Name
    /// <para>
    /// Previous, alternate or other names or aliases associated with the person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19206">Other Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("Previous, alternate or other names or aliases associated with the person.")]
    public System.String OtherName { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Other Name Type
    /// <para>
    /// The types of previous, alternate or other names for a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19627">Other Name Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefOtherNameType")]
    [Comment("The types of previous, alternate or other names for a person.")]
    public Guid? RefOtherNameTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The types of previous, alternate or other names for a person.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19627">Other Name Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefOtherNameTypeEntity RefOtherNameTypeEntity { get; set; }

    #endregion
}

//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonBirthplaceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonBirthplace file
/// </summary>
[Table("PersonBirthplace", Schema = "Autobahn.Core.Person")]
public partial class PersonBirthplaceEntity : EntityBase, IPersonBirthplace
{
    #region "IPersonBirthplace Properties"
    /// <summary>
    /// City of Birth
    /// <para>
    ///  The name of the city in which a person was born.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19416">City of Birth</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment(" The name of the city in which a person was born.")]
    public System.String City { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Country of Birth Code
    /// <para>
    /// The unique two digit International Organization for Standardization (ISO) code for the country in which a person is born.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19051">Country of Birth Code</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCountry")]
    [Comment("The unique two digit International Organization for Standardization (ISO) code for the country in which a person is born.")]
    public Guid? RefCountryId { get; set; }

    /// <summary>
    /// State of Birth Abbreviation
    /// <para>
    /// The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a person was born.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19417">State of Birth Abbreviation</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefState")]
    [Comment("The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a person was born.")]
    public Guid? RefStateId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a person was born.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19417">State of Birth Abbreviation</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Autobahn.Core.Person domain
    /// </remarks>
    /// </summary>
    public virtual RefStateEntity? RefStateEntity { get; set; }

    /// <summary>
    /// The unique two digit International Organization for Standardization (ISO) code for the country in which a person is born.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19051">Country of Birth Code</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Autobahn.Core.Person domain
    /// </remarks>
    /// </summary>
    public virtual RefCountryEntity? RefCountryEntity { get; set; }

    #endregion
}

//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonLanguageEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonLanguage file
/// </summary>
[Table("PersonLanguage", Schema = "Autobahn.Core.Person")]
public partial class PersonLanguageEntity : EntityBase, IPersonLanguage
{
    #region "IPersonLanguage Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// ISO 639-2 Language Code
    /// <para>
    /// The code for the specific language or dialect that a person uses to communicate.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19317">ISO 639-2 Language Code</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefLanguage")]
    [Comment("The code for the specific language or dialect that a person uses to communicate.")]
    public Guid RefLanguageId { get; set; }

    /// <summary>
    /// Language Type
    /// <para>
    /// An indication of the function and context in which a person uses a language to communicate.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19316">Language Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefLanguageUseType")]
    [Comment("An indication of the function and context in which a person uses a language to communicate.")]
    public Guid RefLanguageUseTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The code for the specific language or dialect that a person uses to communicate.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19317">ISO 639-2 Language Code</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Autobahn.Core.Person domain
    /// </remarks>
    /// </summary>
    public virtual RefLanguageEntity RefLanguageEntity { get; set; }

    /// <summary>
    /// An indication of the function and context in which a person uses a language to communicate.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19316">Language Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Autobahn.Core.Person domain
    /// </remarks>
    /// </summary>
    public virtual RefLanguageUseTypeEntity RefLanguageUseTypeEntity { get; set; }

    #endregion
}

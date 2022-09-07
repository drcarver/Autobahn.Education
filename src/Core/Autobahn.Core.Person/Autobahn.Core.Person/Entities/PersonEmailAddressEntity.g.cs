//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonEmailAddressEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonEmailAddress file
/// </summary>
[Table("PersonEmailAddress", Schema = "Person")]
public partial class PersonEmailAddressEntity : EntityBase, IPersonEmailAddress
{
    #region "IPersonEmailAddress Properties"
    /// <summary>
    /// Do Not Publish Indicator
    /// <para>
    /// An indication that the record should not be published.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20905">Do Not Publish Indicator</a>
    /// </para>
    /// </summary>
    [Comment("An indication that the record should not be published.")]
    public Boolean? DoNotPublishIndicator { get; set; }

    /// <summary>
    /// Electronic Mail Address
    /// <para>
    /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19088">Electronic Mail Address</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(128,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.")]
    public System.String EmailAddress { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Electronic Mail Address Type
    /// <para>
    /// The type of electronic mail (e-mail) address listed for a person or organization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19089">Electronic Mail Address Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefEmailType")]
    [Comment("The type of electronic mail (e-mail) address listed for a person or organization.")]
    public Guid? RefEmailTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The type of electronic mail (e-mail) address listed for a person or organization.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19089">Electronic Mail Address Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Person domain
    /// </remarks>
    /// </summary>
    public virtual RefEmailTypeEntity? RefEmailTypeEntity { get; set; }

    #endregion
}

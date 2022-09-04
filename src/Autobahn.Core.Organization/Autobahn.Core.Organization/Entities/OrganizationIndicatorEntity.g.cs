//***************************************************************************
//* DomainName: Organization Models
//* FileName:   OrganizationIndicatorEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationIndicator file
/// </summary>
[Table("OrganizationIndicator", Schema = "Autobahn.Core.Organization")]
public partial class OrganizationIndicatorEntity : EntityBase, IOrganizationIndicator
{
    #region "IOrganizationIndicator Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(50,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String IndicatorValue { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Ability Grouping Status
    /// <para>
    /// An indication of whether the school has students who are ability grouped for classroom instruction in mathematics or English/reading/language arts.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19000">Ability Grouping Status</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefOrganizationIndicator")]
    [Comment("An indication of whether the school has students who are ability grouped for classroom instruction in mathematics or English/reading/language arts.")]
    public Guid RefOrganizationIndicatorId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// An indication of whether the school has students who are ability grouped for classroom instruction in mathematics or English/reading/language arts.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19000">Ability Grouping Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Autobahn.Core.Organization domain
    /// </remarks>
    /// </summary>
    public virtual RefOrganizationIndicatorEntity RefOrganizationIndicatorEntity { get; set; }

    #endregion
}

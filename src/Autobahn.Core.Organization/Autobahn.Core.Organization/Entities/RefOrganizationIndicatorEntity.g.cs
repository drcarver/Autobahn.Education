//***************************************************************************
//* DomainName: Organization Models
//* FileName:   RefOrganizationIndicatorEntity.g.cs
//* Name:       Ability Grouping Status
//* Definition: An indication of whether the school has students who are ability grouped for classroom instruction in mathematics or English/reading/language arts.
//***************************************************************************

/// <summary>
/// Ability Grouping Status <see cref="RefOrganizationIndicator"/>
/// <para>
/// An indication of whether the school has students who are ability grouped for classroom instruction in mathematics or English/reading/language arts.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19000">Ability Grouping Status</a>
/// </para>
/// </summary>
[Table("RefOrganizationIndicator", Schema = "Autobahn.Core.Organization")]
[Comment("An indication of whether the school has students who are ability grouped for classroom instruction in mathematics or English/reading/language arts.")]
public partial class RefOrganizationIndicatorEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefOrganizationIndicator Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOrganizationType"/> model
    /// </summary>
    [ForeignKey("RefOrganizationType")]
    public Guid? RefOrganizationTypeId { get; set; }

    #endregion
}

//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefOrganizationTypeEntity.g.cs
//* Name:       Adult Education Provider Type
//* Definition: The type of institution responsible for providing adult education instructional services.
//***************************************************************************

/// <summary>
/// Adult Education Provider Type <see cref="RefOrganizationType"/>
/// <para>
/// The type of institution responsible for providing adult education instructional services.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19779">Adult Education Provider Type</a>
/// </para>
/// </summary>
[Table("RefOrganizationType", Schema = "Common")]
[Comment("The type of institution responsible for providing adult education instructional services.")]
public partial class RefOrganizationTypeEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefOrganizationType Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOrganizationElementType"/> model
    /// </summary>
    [ForeignKey("RefOrganizationElementType")]
    public Guid? RefOrganizationElementTypeId { get; set; }

    #endregion
}

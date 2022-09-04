//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefEmploymentSeparationTypeEntity.g.cs
//* Name:       Employment Separation Type
//* Definition: A designation of the type of separation occurring between a person and the organization.
//***************************************************************************

/// <summary>
/// Employment Separation Type <see cref="RefEmploymentSeparationType"/>
/// <para>
/// A designation of the type of separation occurring between a person and the organization.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19614">Employment Separation Type</a>
/// </para>
/// </summary>
[Table("RefEmploymentSeparationType", Schema = "Invalid")]
[Comment("A designation of the type of separation occurring between a person and the organization.")]
public partial class RefEmploymentSeparationTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}

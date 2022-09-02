//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefContentStandardTypeEntity.g.cs
//* Name:       Assessment Content Standard Type
//* Definition: An indication as to whether an assessment conforms to a standard.
//***************************************************************************

/// <summary>
/// Assessment Content Standard Type <see cref="RefContentStandardType"/>
/// <para>
/// An indication as to whether an assessment conforms to a standard.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19598">Assessment Content Standard Type</a>
/// </para>
/// </summary>
[Table("RefContentStandardType", Schema = "Common")]
[Comment("An indication as to whether an assessment conforms to a standard.")]
public partial class RefContentStandardTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}

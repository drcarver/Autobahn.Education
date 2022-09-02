//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefAssessmentItemTypeEntity.g.cs
//* Name:       Assessment Item Type
//* Definition: The specific type of assessment item.
//***************************************************************************

/// <summary>
/// Assessment Item Type <see cref="RefAssessmentItemType"/>
/// <para>
/// The specific type of assessment item.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19382">Assessment Item Type</a>
/// </para>
/// </summary>
[Table("RefAssessmentItemType", Schema = "Common")]
[Comment("The specific type of assessment item.")]
public partial class RefAssessmentItemTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}

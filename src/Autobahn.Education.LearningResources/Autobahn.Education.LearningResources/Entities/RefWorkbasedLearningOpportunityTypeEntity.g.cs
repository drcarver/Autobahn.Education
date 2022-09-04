//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   RefWorkbasedLearningOpportunityTypeEntity.g.cs
//* Name:       Work-based Learning Opportunity Type
//* Definition: The type of work-based learning opportunity a student participated in.
//***************************************************************************

/// <summary>
/// Work-based Learning Opportunity Type <see cref="RefWorkbasedLearningOpportunityType"/>
/// <para>
/// The type of work-based learning opportunity a student participated in.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20471">Work-based Learning Opportunity Type</a>
/// </para>
/// </summary>
[Table("RefWorkbasedLearningOpportunityType", Schema = "LearningResources")]
[Comment("The type of work-based learning opportunity a student participated in.")]
public partial class RefWorkbasedLearningOpportunityTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}

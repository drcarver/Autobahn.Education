//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefAssessmentAccommodationCategoryEntity.g.cs
//* Name:       Assessment Accommodation Category
//* Definition: A category of accommodations needed for a given assessment.
//***************************************************************************

/// <summary>
/// Assessment Accommodation Category <see cref="RefAssessmentAccommodationCategory"/>
/// <para>
/// A category of accommodations needed for a given assessment.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19374">Assessment Accommodation Category</a>
/// </para>
/// </summary>
[Table("RefAssessmentAccommodationCategory", Schema = "Common")]
[Comment("A category of accommodations needed for a given assessment.")]
public partial class RefAssessmentAccommodationCategoryEntity : ReferenceBaseEntity, IReferenceBase
{
}

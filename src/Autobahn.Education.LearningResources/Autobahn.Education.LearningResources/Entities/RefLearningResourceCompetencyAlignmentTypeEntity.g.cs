//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   RefLearningResourceCompetencyAlignmentTypeEntity.g.cs
//* Name:       Learning Resource Competency Alignment Type
//* Definition: The alignment relationship between the resource and a competency definition object.
//***************************************************************************

/// <summary>
/// Learning Resource Competency Alignment Type <see cref="RefLearningResourceCompetencyAlignmentType"/>
/// <para>
/// The alignment relationship between the resource and a competency definition object.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19879">Learning Resource Competency Alignment Type</a>
/// </para>
/// </summary>
[Table("RefLearningResourceCompetencyAlignmentType", Schema = "LearningResources")]
[Comment("The alignment relationship between the resource and a competency definition object.")]
public partial class RefLearningResourceCompetencyAlignmentTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}

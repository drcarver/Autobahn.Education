//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   RefLearningResourceAccessModeTypeEntity.g.cs
//* Name:       Learning Resource Access Mode Type
//* Definition: An access mode through which the intellectual content of a described learning resource or adaptation is communicated; if adaptations for the resource are known, the access modes of those adaptations are not included.
//***************************************************************************

/// <summary>
/// Learning Resource Access Mode Type <see cref="RefLearningResourceAccessModeType"/>
/// <para>
/// An access mode through which the intellectual content of a described learning resource or adaptation is communicated; if adaptations for the resource are known, the access modes of those adaptations are not included.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20360">Learning Resource Access Mode Type</a>
/// </para>
/// </summary>
[Table("RefLearningResourceAccessModeType", Schema = "LearningResources")]
[Comment("An access mode through which the intellectual content of a described learning resource or adaptation is communicated; if adaptations for the resource are known, the access modes of those adaptations are not included.")]
public partial class RefLearningResourceAccessModeTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}

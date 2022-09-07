//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   RefLearningResourceMediaFeatureTypeEntity.g.cs
//* Name:       Learning Resource Media Feature Type
//* Definition: Accessible content features included with the learning resource.
//***************************************************************************

/// <summary>
/// Learning Resource Media Feature Type <see cref="RefLearningResourceMediaFeatureType"/>
/// <para>
/// Accessible content features included with the learning resource.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20368">Learning Resource Media Feature Type</a>
/// </para>
/// </summary>
[Table("RefLearningResourceMediaFeatureType", Schema = "LearningResources")]
[Comment("Accessible content features included with the learning resource.")]
public partial class RefLearningResourceMediaFeatureTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}

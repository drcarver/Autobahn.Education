//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   RefLearningResourceTypeEntity.g.cs
//* Name:       Learning Resource Type
//* Definition: The predominate type or kind characterizing the learning resource.
//***************************************************************************

/// <summary>
/// Learning Resource Type <see cref="RefLearningResourceType"/>
/// <para>
/// The predominate type or kind characterizing the learning resource.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19929">Learning Resource Type</a>
/// </para>
/// </summary>
[Table("RefLearningResourceType", Schema = "LearningResources")]
[Comment("The predominate type or kind characterizing the learning resource.")]
public partial class RefLearningResourceTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}

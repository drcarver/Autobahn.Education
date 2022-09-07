//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   RefLearningResourcePhysicalMediaTypeEntity.g.cs
//* Name:       Learning Resource Physical Media Type
//* Definition: A type of physical media on which the Learning Resource is delivered or available.
//***************************************************************************

/// <summary>
/// Learning Resource Physical Media Type <see cref="RefLearningResourcePhysicalMediaType"/>
/// <para>
/// A type of physical media on which the Learning Resource is delivered or available.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20370">Learning Resource Physical Media Type</a>
/// </para>
/// </summary>
[Table("RefLearningResourcePhysicalMediaType", Schema = "LearningResources")]
[Comment("A type of physical media on which the Learning Resource is delivered or available.")]
public partial class RefLearningResourcePhysicalMediaTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}

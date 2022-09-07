//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   RefLearningResourceInteractionModeEntity.g.cs
//* Name:       Learning Resource Interaction Mode
//* Definition: The primary type of interaction, synchronous or asynchronous, defined for the learning resource.
//***************************************************************************

/// <summary>
/// Learning Resource Interaction Mode <see cref="RefLearningResourceInteractionMode"/>
/// <para>
/// The primary type of interaction, synchronous or asynchronous, defined for the learning resource.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20543">Learning Resource Interaction Mode</a>
/// </para>
/// </summary>
[Table("RefLearningResourceInteractionMode", Schema = "LearningResources")]
[Comment("The primary type of interaction, synchronous or asynchronous, defined for the learning resource.")]
public partial class RefLearningResourceInteractionModeEntity : ReferenceBaseEntity, IReferenceBase
{
}

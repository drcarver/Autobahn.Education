//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefLearningResourceInteractivityTypeEntity.g.cs
//* Name:       Learning Resource Interactivity Type
//* Definition: The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed.
//***************************************************************************

/// <summary>
/// Learning Resource Interactivity Type <see cref="RefLearningResourceInteractivityType"/>
/// <para>
/// The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19928">Learning Resource Interactivity Type</a>
/// </para>
/// </summary>
[Table("RefLearningResourceInteractivityType", Schema = "Common")]
[Comment("The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed.")]
public partial class RefLearningResourceInteractivityTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}

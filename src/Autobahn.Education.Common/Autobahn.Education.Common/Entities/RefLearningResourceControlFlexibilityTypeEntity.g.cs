//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefLearningResourceControlFlexibilityTypeEntity.g.cs
//* Name:       Learning Resource Control Flexibility Type
//* Definition: Identifies a single input method that is sufficient to control the described learning resource.
//***************************************************************************

/// <summary>
/// Learning Resource Control Flexibility Type <see cref="RefLearningResourceControlFlexibilityType"/>
/// <para>
/// Identifies a single input method that is sufficient to control the described learning resource.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20364">Learning Resource Control Flexibility Type</a>
/// </para>
/// </summary>
[Table("RefLearningResourceControlFlexibilityType", Schema = "Common")]
[Comment("Identifies a single input method that is sufficient to control the described learning resource.")]
public partial class RefLearningResourceControlFlexibilityTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}

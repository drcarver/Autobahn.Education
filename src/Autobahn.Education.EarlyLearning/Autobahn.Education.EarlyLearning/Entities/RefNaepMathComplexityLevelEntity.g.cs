//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   RefNaepMathComplexityLevelEntity.g.cs
//* Name:       NAEP Mathematical Complexity Level
//* Definition: Complexity levels defined by the National Assessment of Educational Progress (NAEP 2005a Framework).
//***************************************************************************

/// <summary>
/// NAEP Mathematical Complexity Level <see cref="RefNaepMathComplexityLevel"/>
/// <para>
/// Complexity levels defined by the National Assessment of Educational Progress (NAEP 2005a Framework).
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20072">NAEP Mathematical Complexity Level</a>
/// </para>
/// </summary>
[Table("RefNaepMathComplexityLevel", Schema = "EarlyLearning")]
[Comment("Complexity levels defined by the National Assessment of Educational Progress (NAEP 2005a Framework).")]
public partial class RefNaepMathComplexityLevelEntity : ReferenceBaseEntity, IReferenceBase
{
}

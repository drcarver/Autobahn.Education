//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   RefIncreasedLearningTimeTypeEntity.g.cs
//* Name:       Increased Learning Time Type
//* Definition: The types of increased learning time provided.
//***************************************************************************

/// <summary>
/// Increased Learning Time Type <see cref="RefIncreasedLearningTimeType"/>
/// <para>
/// The types of increased learning time provided.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19164">Increased Learning Time Type</a>
/// </para>
/// </summary>
[Table("RefIncreasedLearningTimeType", Schema = "LearningResources")]
[Comment("The types of increased learning time provided.")]
public partial class RefIncreasedLearningTimeTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}

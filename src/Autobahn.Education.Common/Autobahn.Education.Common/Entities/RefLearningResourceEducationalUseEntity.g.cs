//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefLearningResourceEducationalUseEntity.g.cs
//* Name:       Learning Resource Educational Use
//* Definition: The purpose of the work in the context of education.
//***************************************************************************

/// <summary>
/// Learning Resource Educational Use <see cref="RefLearningResourceEducationalUse"/>
/// <para>
/// The purpose of the work in the context of education.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20005">Learning Resource Educational Use</a>
/// </para>
/// </summary>
[Table("RefLearningResourceEducationalUse", Schema = "Common")]
[Comment("The purpose of the work in the context of education.")]
public partial class RefLearningResourceEducationalUseEntity : ReferenceBaseEntity, IReferenceBase
{
}

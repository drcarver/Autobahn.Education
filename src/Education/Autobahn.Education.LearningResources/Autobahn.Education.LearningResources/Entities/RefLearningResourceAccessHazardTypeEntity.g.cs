//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   RefLearningResourceAccessHazardTypeEntity.g.cs
//* Name:       Learning Resource Access Hazard Type
//* Definition: A characteristic of the described learning resource that is physiologically dangerous to some users.
//***************************************************************************

/// <summary>
/// Learning Resource Access Hazard Type <see cref="RefLearningResourceAccessHazardType"/>
/// <para>
/// A characteristic of the described learning resource that is physiologically dangerous to some users.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20359">Learning Resource Access Hazard Type</a>
/// </para>
/// </summary>
[Table("RefLearningResourceAccessHazardType", Schema = "LearningResources")]
[Comment("A characteristic of the described learning resource that is physiologically dangerous to some users.")]
public partial class RefLearningResourceAccessHazardTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}

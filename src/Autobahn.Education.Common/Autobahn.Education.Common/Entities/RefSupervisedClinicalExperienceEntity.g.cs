//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefSupervisedClinicalExperienceEntity.g.cs
//* Name:       Supervised Clinical Experience
//* Definition: An indication of whether a person is enrolled in a supervised clinical experience (including student teaching) as part of a teacher preparation program.
//***************************************************************************

/// <summary>
/// Supervised Clinical Experience <see cref="RefSupervisedClinicalExperience"/>
/// <para>
/// An indication of whether a person is enrolled in a supervised clinical experience (including student teaching) as part of a teacher preparation program.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19754">Supervised Clinical Experience</a>
/// </para>
/// </summary>
[Table("RefSupervisedClinicalExperience", Schema = "Common")]
[Comment("An indication of whether a person is enrolled in a supervised clinical experience (including student teaching) as part of a teacher preparation program.")]
public partial class RefSupervisedClinicalExperienceEntity : ReferenceBaseEntity, IReferenceBase
{
}

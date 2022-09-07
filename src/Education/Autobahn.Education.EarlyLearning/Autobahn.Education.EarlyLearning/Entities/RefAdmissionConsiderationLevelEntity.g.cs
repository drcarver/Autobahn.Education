//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   RefAdmissionConsiderationLevelEntity.g.cs
//* Name:       Admission Consideration Level
//* Definition: The level of consideration given a type of admission criteria used at an institution during the selection process.
//***************************************************************************

/// <summary>
/// Admission Consideration Level <see cref="RefAdmissionConsiderationLevel"/>
/// <para>
/// The level of consideration given a type of admission criteria used at an institution during the selection process.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20558">Admission Consideration Level</a>
/// </para>
/// </summary>
[Table("RefAdmissionConsiderationLevel", Schema = "EarlyLearning")]
[Comment("The level of consideration given a type of admission criteria used at an institution during the selection process.")]
public partial class RefAdmissionConsiderationLevelEntity : ReferenceBaseEntity, IReferenceBase
{
}

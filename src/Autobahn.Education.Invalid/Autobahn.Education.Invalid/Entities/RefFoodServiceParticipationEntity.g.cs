//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefFoodServiceParticipationEntity.g.cs
//* Name:       Participation in School Food Service Programs
//* Definition: An indication of a student's participation in free, reduced price, full price breakfast, lunch, snack, supper, and milk programs.
//***************************************************************************

/// <summary>
/// Participation in School Food Service Programs <see cref="RefFoodServiceParticipation"/>
/// <para>
/// An indication of a student's participation in free, reduced price, full price breakfast, lunch, snack, supper, and milk programs.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19325">Participation in School Food Service Programs</a>
/// </para>
/// </summary>
[Table("RefFoodServiceParticipation", Schema = "Invalid")]
[Comment("An indication of a student's participation in free, reduced price, full price breakfast, lunch, snack, supper, and milk programs.")]
public partial class RefFoodServiceParticipationEntity : ReferenceBaseEntity, IReferenceBase
{
}

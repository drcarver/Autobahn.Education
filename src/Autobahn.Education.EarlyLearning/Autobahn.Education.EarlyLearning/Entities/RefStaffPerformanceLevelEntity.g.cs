//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   RefStaffPerformanceLevelEntity.g.cs
//* Name:       Faculty and Administration Performance Level
//* Definition: The levels used in district evaluation systems for assigning teacher or principal performance ratings.
//***************************************************************************

/// <summary>
/// Faculty and Administration Performance Level <see cref="RefStaffPerformanceLevel"/>
/// <para>
/// The levels used in district evaluation systems for assigning teacher or principal performance ratings.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19582">Faculty and Administration Performance Level</a>
/// </para>
/// </summary>
[Table("RefStaffPerformanceLevel", Schema = "EarlyLearning")]
[Comment("The levels used in district evaluation systems for assigning teacher or principal performance ratings.")]
public partial class RefStaffPerformanceLevelEntity : ReferenceBaseEntity, IReferenceBase
{
}

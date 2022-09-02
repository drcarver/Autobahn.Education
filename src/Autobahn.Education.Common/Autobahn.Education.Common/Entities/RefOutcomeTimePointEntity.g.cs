//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefOutcomeTimePointEntity.g.cs
//* Name:       Early Learning Outcome Time Point
//* Definition: The point in time for which the result is used for an outcome measure.
//***************************************************************************

/// <summary>
/// Early Learning Outcome Time Point <see cref="RefOutcomeTimePoint"/>
/// <para>
/// The point in time for which the result is used for an outcome measure.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20475">Early Learning Outcome Time Point</a>
/// </para>
/// </summary>
[Table("RefOutcomeTimePoint", Schema = "Common")]
[Comment("The point in time for which the result is used for an outcome measure.")]
public partial class RefOutcomeTimePointEntity : ReferenceBaseEntity, IReferenceBase
{
}

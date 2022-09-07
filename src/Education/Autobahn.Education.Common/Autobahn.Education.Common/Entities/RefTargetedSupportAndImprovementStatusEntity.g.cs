//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefTargetedSupportAndImprovementStatusEntity.g.cs
//* Name:       Targeted Support and Improvement Status
//* Definition: The designation given to a school by the state for targeted support and improvement as part of its statewide system of annual meaningful differentiation.
//***************************************************************************

/// <summary>
/// Targeted Support and Improvement Status <see cref="RefTargetedSupportAndImprovementStatus"/>
/// <para>
/// The designation given to a school by the state for targeted support and improvement as part of its statewide system of annual meaningful differentiation.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20910">Targeted Support and Improvement Status</a>
/// </para>
/// </summary>
[Table("RefTargetedSupportAndImprovementStatus", Schema = "Common")]
[Comment("The designation given to a school by the state for targeted support and improvement as part of its statewide system of annual meaningful differentiation.")]
public partial class RefTargetedSupportAndImprovementStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}

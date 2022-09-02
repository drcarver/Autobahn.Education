//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefFacilitySystemOrComponentConditionEntity.g.cs
//* Name:       Facility System or Component Condition
//* Definition: The rating of the system or component functions under the demands of its regular operation.
//***************************************************************************

/// <summary>
/// Facility System or Component Condition <see cref="RefFacilitySystemOrComponentCondition"/>
/// <para>
/// The rating of the system or component functions under the demands of its regular operation.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20774">Facility System or Component Condition</a>
/// </para>
/// </summary>
[Table("RefFacilitySystemOrComponentCondition", Schema = "Facilities")]
[Comment("The rating of the system or component functions under the demands of its regular operation.")]
public partial class RefFacilitySystemOrComponentConditionEntity : ReferenceBaseEntity, IReferenceBase
{
}

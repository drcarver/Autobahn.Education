//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefSigInterventionTypeEntity.g.cs
//* Name:       School Improvement Grant Intervention Type
//* Definition: The type of intervention used by the school under the School Improvement Grant (SIG).
//***************************************************************************

/// <summary>
/// School Improvement Grant Intervention Type <see cref="RefSigInterventionType"/>
/// <para>
/// The type of intervention used by the school under the School Improvement Grant (SIG).
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19239">School Improvement Grant Intervention Type</a>
/// </para>
/// </summary>
[Table("RefSigInterventionType", Schema = "Common")]
[Comment("The type of intervention used by the school under the School Improvement Grant (SIG).")]
public partial class RefSigInterventionTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}

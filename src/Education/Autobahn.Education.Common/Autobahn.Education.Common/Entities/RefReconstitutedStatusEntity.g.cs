//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefReconstitutedStatusEntity.g.cs
//* Name:       Reconstituted Status
//* Definition: An indication that the school was restructured, transformed or otherwise changed as a consequence of the state's accountability system under ESEA or as a result of School Improvement Grants (SIG).
//***************************************************************************

/// <summary>
/// Reconstituted Status <see cref="RefReconstitutedStatus"/>
/// <para>
/// An indication that the school was restructured, transformed or otherwise changed as a consequence of the state's accountability system under ESEA or as a result of School Improvement Grants (SIG).
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19230">Reconstituted Status</a>
/// </para>
/// </summary>
[Table("RefReconstitutedStatus", Schema = "Common")]
[Comment("An indication that the school was restructured, transformed or otherwise changed as a consequence of the state's accountability system under ESEA or as a result of School Improvement Grants (SIG).")]
public partial class RefReconstitutedStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}

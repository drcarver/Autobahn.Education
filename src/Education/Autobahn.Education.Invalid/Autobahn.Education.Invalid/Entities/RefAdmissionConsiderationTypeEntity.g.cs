//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefAdmissionConsiderationTypeEntity.g.cs
//* Name:       Admission Consideration Type
//* Definition: The type of admission consideration used at an institution during the selection process.
//***************************************************************************

/// <summary>
/// Admission Consideration Type <see cref="RefAdmissionConsiderationType"/>
/// <para>
/// The type of admission consideration used at an institution during the selection process.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20559">Admission Consideration Type</a>
/// </para>
/// </summary>
[Table("RefAdmissionConsiderationType", Schema = "Invalid")]
[Comment("The type of admission consideration used at an institution during the selection process.")]
public partial class RefAdmissionConsiderationTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}

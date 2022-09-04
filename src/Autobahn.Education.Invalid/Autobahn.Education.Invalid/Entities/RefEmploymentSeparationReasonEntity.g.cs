//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefEmploymentSeparationReasonEntity.g.cs
//* Name:       Employment Separation Reason
//* Definition: The primary reason for the termination of the employment relationship.
//***************************************************************************

/// <summary>
/// Employment Separation Reason <see cref="RefEmploymentSeparationReason"/>
/// <para>
/// The primary reason for the termination of the employment relationship.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19613">Employment Separation Reason</a>
/// </para>
/// </summary>
[Table("RefEmploymentSeparationReason", Schema = "Invalid")]
[Comment("The primary reason for the termination of the employment relationship.")]
public partial class RefEmploymentSeparationReasonEntity : ReferenceBaseEntity, IReferenceBase
{
}

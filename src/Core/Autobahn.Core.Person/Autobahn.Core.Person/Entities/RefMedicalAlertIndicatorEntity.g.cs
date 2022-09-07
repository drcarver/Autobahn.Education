//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefMedicalAlertIndicatorEntity.g.cs
//* Name:       Medical Alert Indicator
//* Definition: Alert indicator for a medical/health condition.
//***************************************************************************

/// <summary>
/// Medical Alert Indicator <see cref="RefMedicalAlertIndicator"/>
/// <para>
/// Alert indicator for a medical/health condition.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19429">Medical Alert Indicator</a>
/// </para>
/// </summary>
[Table("RefMedicalAlertIndicator", Schema = "Person")]
[Comment("Alert indicator for a medical/health condition.")]
public partial class RefMedicalAlertIndicatorEntity : ReferenceBaseEntity, IReferenceBase
{
}

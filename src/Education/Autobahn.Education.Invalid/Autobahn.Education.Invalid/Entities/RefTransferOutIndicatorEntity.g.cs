//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefTransferOutIndicatorEntity.g.cs
//* Name:       Transfer-out Indicator
//* Definition: An indicator of whether the student has transferred to another institution.
//***************************************************************************

/// <summary>
/// Transfer-out Indicator <see cref="RefTransferOutIndicator"/>
/// <para>
/// An indicator of whether the student has transferred to another institution.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20610">Transfer-out Indicator</a>
/// </para>
/// </summary>
[Table("RefTransferOutIndicator", Schema = "Invalid")]
[Comment("An indicator of whether the student has transferred to another institution.")]
public partial class RefTransferOutIndicatorEntity : ReferenceBaseEntity, IReferenceBase
{
}

//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefPreAndPostTestIndicatorEntity.g.cs
//* Name:       Pre and Post Test Indicator
//* Definition: An indication of whether students took both a pre-test and a post-test to measure academic improvement.
//***************************************************************************

/// <summary>
/// Pre and Post Test Indicator <see cref="RefPreAndPostTestIndicator"/>
/// <para>
/// An indication of whether students took both a pre-test and a post-test to measure academic improvement.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19563">Pre and Post Test Indicator</a>
/// </para>
/// </summary>
[Table("RefPreAndPostTestIndicator", Schema = "Invalid")]
[Comment("An indication of whether students took both a pre-test and a post-test to measure academic improvement.")]
public partial class RefPreAndPostTestIndicatorEntity : ReferenceBaseEntity, IReferenceBase
{
}

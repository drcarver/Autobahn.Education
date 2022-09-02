//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefInternetPerformanceInResidenceEntity.g.cs
//* Name:       Internet Performance In Residence
//* Definition: An indication of whether the student can complete the full range of learning activities, including video streaming and assignment upload, without interruptions caused by poor internet performance in their primary place of residence.
//***************************************************************************

/// <summary>
/// Internet Performance In Residence <see cref="RefInternetPerformanceInResidence"/>
/// <para>
/// An indication of whether the student can complete the full range of learning activities, including video streaming and assignment upload, without interruptions caused by poor internet performance in their primary place of residence.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20939">Internet Performance In Residence</a>
/// </para>
/// </summary>
[Table("RefInternetPerformanceInResidence", Schema = "Common")]
[Comment("An indication of whether the student can complete the full range of learning activities, including video streaming and assignment upload, without interruptions caused by poor internet performance in their primary place of residence.")]
public partial class RefInternetPerformanceInResidenceEntity : ReferenceBaseEntity, IReferenceBase
{
}

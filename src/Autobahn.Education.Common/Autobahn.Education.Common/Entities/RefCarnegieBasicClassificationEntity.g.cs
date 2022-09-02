//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCarnegieBasicClassificationEntity.g.cs
//* Name:       Carnegie Basic Classification
//* Definition: The Basic Classification is an update of the traditional classification framework developed by the Carnegie Commission on Higher Education in 1970 to support its research program, and later published in 1973 for use by other researchers.
//***************************************************************************

/// <summary>
/// Carnegie Basic Classification <see cref="RefCarnegieBasicClassification"/>
/// <para>
/// The Basic Classification is an update of the traditional classification framework developed by the Carnegie Commission on Higher Education in 1970 to support its research program, and later published in 1973 for use by other researchers.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19038">Carnegie Basic Classification</a>
/// </para>
/// </summary>
[Table("RefCarnegieBasicClassification", Schema = "Common")]
[Comment("The Basic Classification is an update of the traditional classification framework developed by the Carnegie Commission on Higher Education in 1970 to support its research program, and later published in 1973 for use by other researchers.")]
public partial class RefCarnegieBasicClassificationEntity : ReferenceBaseEntity, IReferenceBase
{
}

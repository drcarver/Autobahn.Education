//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefSingleSexClassStatusEntity.g.cs
//* Name:       Course Section Single Sex Class Status
//* Definition: Section in a co-educational school where only male or only female students are permitted to take the course.
//***************************************************************************

/// <summary>
/// Course Section Single Sex Class Status <see cref="RefSingleSexClassStatus"/>
/// <para>
/// Section in a co-educational school where only male or only female students are permitted to take the course.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19258">Course Section Single Sex Class Status</a>
/// </para>
/// </summary>
[Table("RefSingleSexClassStatus", Schema = "Common")]
[Comment("Section in a co-educational school where only male or only female students are permitted to take the course.")]
public partial class RefSingleSexClassStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}

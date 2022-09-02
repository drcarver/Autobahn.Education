//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCareerClusterEntity.g.cs
//* Name:       Career Cluster
//* Definition: The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
//***************************************************************************

/// <summary>
/// Career Cluster <see cref="RefCareerCluster"/>
/// <para>
/// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20254">Career Cluster</a>
/// </para>
/// </summary>
[Table("RefCareerCluster", Schema = "Common")]
[Comment("The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.")]
public partial class RefCareerClusterEntity : ReferenceBaseEntity, IReferenceBase
{
}

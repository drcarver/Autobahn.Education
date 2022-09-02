//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefDependencyStatusEntity.g.cs
//* Name:       Dependency Status
//* Definition: A person's classification as dependent or independent with regards to eligibility for Title IV Federal Student aid.
//***************************************************************************

/// <summary>
/// Dependency Status <see cref="RefDependencyStatus"/>
/// <para>
/// A person's classification as dependent or independent with regards to eligibility for Title IV Federal Student aid.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19079">Dependency Status</a>
/// </para>
/// </summary>
[Table("RefDependencyStatus", Schema = "Common")]
[Comment("A person's classification as dependent or independent with regards to eligibility for Title IV Federal Student aid.")]
public partial class RefDependencyStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}

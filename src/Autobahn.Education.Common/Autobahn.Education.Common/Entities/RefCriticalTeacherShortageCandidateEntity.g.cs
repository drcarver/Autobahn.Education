//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCriticalTeacherShortageCandidateEntity.g.cs
//* Name:       Critical Teacher Shortage Area Candidate
//* Definition: An indication of whether a person is pursuing licensure/certification in a field designated as a shortage area as defined by Title II.
//***************************************************************************

/// <summary>
/// Critical Teacher Shortage Area Candidate <see cref="RefCriticalTeacherShortageCandidate"/>
/// <para>
/// An indication of whether a person is pursuing licensure/certification in a field designated as a shortage area as defined by Title II.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19753">Critical Teacher Shortage Area Candidate</a>
/// </para>
/// </summary>
[Table("RefCriticalTeacherShortageCandidate", Schema = "Common")]
[Comment("An indication of whether a person is pursuing licensure/certification in a field designated as a shortage area as defined by Title II.")]
public partial class RefCriticalTeacherShortageCandidateEntity : ReferenceBaseEntity, IReferenceBase
{
}

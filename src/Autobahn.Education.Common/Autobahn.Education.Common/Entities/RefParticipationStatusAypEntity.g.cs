//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefParticipationStatusAypEntity.g.cs
//* Name:       Participation Status for Math
//* Definition: An indication of whether the school or district met the 95 percent participation requirement in the mathematics assessment in accordance with state definition for the purposes of determining AYP.
//***************************************************************************

/// <summary>
/// Participation Status for Math <see cref="RefParticipationStatusAyp"/>
/// <para>
/// An indication of whether the school or district met the 95 percent participation requirement in the mathematics assessment in accordance with state definition for the purposes of determining AYP.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19208">Participation Status for Math</a>
/// </para>
/// </summary>
[Table("RefParticipationStatusAyp", Schema = "Common")]
[Comment("An indication of whether the school or district met the 95 percent participation requirement in the mathematics assessment in accordance with state definition for the purposes of determining AYP.")]
public partial class RefParticipationStatusAypEntity : ReferenceBaseEntity, IReferenceBase
{
}

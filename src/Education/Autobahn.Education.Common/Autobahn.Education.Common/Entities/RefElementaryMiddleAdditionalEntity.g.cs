//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefElementaryMiddleAdditionalEntity.g.cs
//* Name:       Elementary-Middle Additional Indicator Status
//* Definition:  An indication of whether the school or district met the Elementary/Middle Additional Indicator requirement in accordance with state definition for the purpose of determining Adequate Yearly Progress (AYP).
//***************************************************************************

/// <summary>
/// Elementary-Middle Additional Indicator Status <see cref="RefElementaryMiddleAdditional"/>
/// <para>
///  An indication of whether the school or district met the Elementary/Middle Additional Indicator requirement in accordance with state definition for the purpose of determining Adequate Yearly Progress (AYP).
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19091">Elementary-Middle Additional Indicator Status</a>
/// </para>
/// </summary>
[Table("RefElementaryMiddleAdditional", Schema = "Common")]
[Comment(" An indication of whether the school or district met the Elementary/Middle Additional Indicator requirement in accordance with state definition for the purpose of determining Adequate Yearly Progress (AYP).")]
public partial class RefElementaryMiddleAdditionalEntity : ReferenceBaseEntity, IReferenceBase
{
}

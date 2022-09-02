//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefTechnicalAssistanceTypeEntity.g.cs
//* Name:       Technical Assistance Type
//* Definition: The type of technical assistance provided.
//***************************************************************************

/// <summary>
/// Technical Assistance Type <see cref="RefTechnicalAssistanceType"/>
/// <para>
/// The type of technical assistance provided.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20467">Technical Assistance Type</a>
/// </para>
/// </summary>
[Table("RefTechnicalAssistanceType", Schema = "Common")]
[Comment("The type of technical assistance provided.")]
public partial class RefTechnicalAssistanceTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}

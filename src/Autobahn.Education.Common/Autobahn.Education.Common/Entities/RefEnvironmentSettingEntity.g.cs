//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefEnvironmentSettingEntity.g.cs
//* Name:       Early Childhood Setting
//* Definition: The site or setting in which  early childhood care, education, and/or services are provided.
//***************************************************************************

/// <summary>
/// Early Childhood Setting <see cref="RefEnvironmentSetting"/>
/// <para>
/// The site or setting in which  early childhood care, education, and/or services are provided.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19355">Early Childhood Setting</a>
/// </para>
/// </summary>
[Table("RefEnvironmentSetting", Schema = "Common")]
[Comment("The site or setting in which  early childhood care, education, and/or services are provided.")]
public partial class RefEnvironmentSettingEntity : ReferenceBaseEntity, IReferenceBase
{
}

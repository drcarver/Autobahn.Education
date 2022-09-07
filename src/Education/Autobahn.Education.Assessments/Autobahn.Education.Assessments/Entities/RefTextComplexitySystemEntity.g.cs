//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefTextComplexitySystemEntity.g.cs
//* Name:       Assessment Item Text Complexity System
//* Definition: The scaling system used to specify the text complexity of an assessment item.
//***************************************************************************

/// <summary>
/// Assessment Item Text Complexity System <see cref="RefTextComplexitySystem"/>
/// <para>
/// The scaling system used to specify the text complexity of an assessment item.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19907">Assessment Item Text Complexity System</a>
/// </para>
/// </summary>
[Table("RefTextComplexitySystem", Schema = "Assessments")]
[Comment("The scaling system used to specify the text complexity of an assessment item.")]
public partial class RefTextComplexitySystemEntity : ReferenceBaseEntity, IReferenceBase
{
}

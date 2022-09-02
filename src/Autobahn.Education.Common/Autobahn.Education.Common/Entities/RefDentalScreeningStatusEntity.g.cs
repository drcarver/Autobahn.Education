//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefDentalScreeningStatusEntity.g.cs
//* Name:       Dental Screening Status
//* Definition: The condition of a person's mouth or oral cavity; more specifically the condition of the hard tissues (i.e., teeth and jaws) and the soft tissues (i.e., gums, tongue, lips, palate, mouth floor, and inner cheeks). Good oral health denotes the absence of clinically manifested disease or abnormalities of the oral cavity.
//***************************************************************************

/// <summary>
/// Dental Screening Status <see cref="RefDentalScreeningStatus"/>
/// <para>
/// The condition of a person's mouth or oral cavity; more specifically the condition of the hard tissues (i.e., teeth and jaws) and the soft tissues (i.e., gums, tongue, lips, palate, mouth floor, and inner cheeks). Good oral health denotes the absence of clinically manifested disease or abnormalities of the oral cavity.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19310">Dental Screening Status</a>
/// </para>
/// </summary>
[Table("RefDentalScreeningStatus", Schema = "Common")]
[Comment("The condition of a person's mouth or oral cavity; more specifically the condition of the hard tissues (i.e., teeth and jaws) and the soft tissues (i.e., gums, tongue, lips, palate, mouth floor, and inner cheeks). Good oral health denotes the absence of clinically manifested disease or abnormalities of the oral cavity.")]
public partial class RefDentalScreeningStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}

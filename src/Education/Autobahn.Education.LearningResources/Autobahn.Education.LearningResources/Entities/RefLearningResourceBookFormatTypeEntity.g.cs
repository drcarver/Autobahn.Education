//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   RefLearningResourceBookFormatTypeEntity.g.cs
//* Name:       Learning Resource Book Format Type
//* Definition: Specifies the format for a learning resource that is a book.  Other options may be considered for inclusion in the option set.
//***************************************************************************

/// <summary>
/// Learning Resource Book Format Type <see cref="RefLearningResourceBookFormatType"/>
/// <para>
/// Specifies the format for a learning resource that is a book.  Other options may be considered for inclusion in the option set.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20363">Learning Resource Book Format Type</a>
/// </para>
/// </summary>
[Table("RefLearningResourceBookFormatType", Schema = "LearningResources")]
[Comment("Specifies the format for a learning resource that is a book.  Other options may be considered for inclusion in the option set.")]
public partial class RefLearningResourceBookFormatTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}

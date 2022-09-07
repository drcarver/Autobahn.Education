//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   RefLearningResourceDigitalMediaTypeEntity.g.cs
//* Name:       Learning Resource Digital Media Type
//* Definition: The media or file type of the digital resource being based on the media types defined by the Internet Assigned Numbers Authority (AINA) at http://www.iana.org/assignments/media-types.
//***************************************************************************

/// <summary>
/// Learning Resource Digital Media Type <see cref="RefLearningResourceDigitalMediaType"/>
/// <para>
/// The media or file type of the digital resource being based on the media types defined by the Internet Assigned Numbers Authority (AINA) at http://www.iana.org/assignments/media-types.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20366">Learning Resource Digital Media Type</a>
/// </para>
/// </summary>
[Table("RefLearningResourceDigitalMediaType", Schema = "LearningResources")]
[Comment("The media or file type of the digital resource being based on the media types defined by the Internet Assigned Numbers Authority (AINA) at http://www.iana.org/assignments/media-types.")]
public partial class RefLearningResourceDigitalMediaTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}

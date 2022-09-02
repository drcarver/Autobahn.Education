//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefProgramSponsorTypeEntity.g.cs
//* Name:       Program Sponsor Type
//* Definition: A type of organization providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.
//***************************************************************************

/// <summary>
/// Program Sponsor Type <see cref="RefProgramSponsorType"/>
/// <para>
/// A type of organization providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19692">Program Sponsor Type</a>
/// </para>
/// </summary>
[Table("RefProgramSponsorType", Schema = "Common")]
[Comment("A type of organization providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.")]
public partial class RefProgramSponsorTypeEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefProgramSponsorType Properties"
    public Int32? RefJurisdiction { get; set; }

    #endregion
}

//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   RefPsEnrollmentActionEntity.g.cs
//* Name:       Postsecondary Enrollment Action
//* Definition: The action taken with respect to postsecondary enrollment by the student who graduated from the school, LEA or state in the past two years.
//***************************************************************************

/// <summary>
/// Postsecondary Enrollment Action <see cref="RefPsEnrollmentAction"/>
/// <para>
/// The action taken with respect to postsecondary enrollment by the student who graduated from the school, LEA or state in the past two years.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19579">Postsecondary Enrollment Action</a>
/// </para>
/// </summary>
[Table("RefPsEnrollmentAction", Schema = "K12")]
[Comment("The action taken with respect to postsecondary enrollment by the student who graduated from the school, LEA or state in the past two years.")]
public partial class RefPsEnrollmentActionEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefPsEnrollmentAction Properties"
    public Int32? RefJurisdiction { get; set; }

    #endregion
}

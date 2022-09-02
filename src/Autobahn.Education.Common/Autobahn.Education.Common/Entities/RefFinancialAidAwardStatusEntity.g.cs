//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefFinancialAidAwardStatusEntity.g.cs
//* Name:       Financial Aid Award Status
//* Definition: An indication of whether the financial aid type being reported is aid that has been awarded, accepted or dispersed.
//***************************************************************************

/// <summary>
/// Financial Aid Award Status <see cref="RefFinancialAidAwardStatus"/>
/// <para>
/// An indication of whether the financial aid type being reported is aid that has been awarded, accepted or dispersed.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19362">Financial Aid Award Status</a>
/// </para>
/// </summary>
[Table("RefFinancialAidAwardStatus", Schema = "Common")]
[Comment("An indication of whether the financial aid type being reported is aid that has been awarded, accepted or dispersed.")]
public partial class RefFinancialAidAwardStatusEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefFinancialAidAwardStatus Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefFinancialAidStatus"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefFinancialAidStatus property is obsolete and will be removed in a later version")]
    [ForeignKey("RefFinancialAidStatus")]
    public Guid RefFinancialAidStatusId { get; set; }

    #endregion
}

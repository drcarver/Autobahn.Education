//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefSchoolImprovementFundEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefSchoolImprovementFund file
/// </summary>
[Table("RefSchoolImprovementFund", Schema = "Common")]
public partial class RefSchoolImprovementFundEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefSchoolImprovementFund Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolImprovementFunds"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefSchoolImprovementFunds property is obsolete and will be removed in a later version")]
    [ForeignKey("RefSchoolImprovementFunds")]
    public Guid RefSchoolImprovementFundsId { get; set; }

    #endregion
}

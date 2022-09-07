//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefSchoolImprovementFundEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefSchoolImprovementFund file
/// </summary>
[Table("RefSchoolImprovementFund", Schema = "Invalid")]
public partial class RefSchoolImprovementFundEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefSchoolImprovementFund Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolImprovementFunds"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefSchoolImprovementFunds")]
    public Guid RefSchoolImprovementFundsId { get; set; }

    #endregion
}

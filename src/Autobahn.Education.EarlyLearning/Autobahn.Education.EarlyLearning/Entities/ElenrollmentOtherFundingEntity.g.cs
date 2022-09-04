//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElenrollmentOtherFundingEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElenrollmentOtherFunding file
/// </summary>
[Table("ElenrollmentOtherFunding", Schema = "EarlyLearning")]
public partial class ElenrollmentOtherFundingEntity : EntityBase, IElenrollmentOtherFunding
{
    #region "IElenrollmentOtherFunding Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElotherFederalFundingSources"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefElotherFederalFundingSources")]
    public Guid RefElotherFederalFundingSourcesId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}

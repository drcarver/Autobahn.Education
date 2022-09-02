//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElenrollmentOtherFundingEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElenrollmentOtherFunding file
/// </summary>
[Table("ElenrollmentOtherFunding", Schema = "Common")]
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
    [Obsolete("The RefElotherFederalFundingSources property is obsolete and will be removed in a later version")]
    [ForeignKey("RefElotherFederalFundingSources")]
    public Guid RefElotherFederalFundingSourcesId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}

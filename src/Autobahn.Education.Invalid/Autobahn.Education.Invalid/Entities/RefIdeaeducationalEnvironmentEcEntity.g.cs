//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefIdeaeducationalEnvironmentEcEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefIdeaeducationalEnvironmentEc file
/// </summary>
[Table("RefIdeaeducationalEnvironmentEc", Schema = "Invalid")]
public partial class RefIdeaeducationalEnvironmentEcEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefIdeaeducationalEnvironmentEc Properties"
    [Required(ErrorMessage="{0} is required.")]
    public System.Int32 RefIdeaeducationalEnvironmentEcid { get; set; }

    #endregion
}

//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefIdeaeducationalEnvironmentEcEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefIdeaeducationalEnvironmentEc file
/// </summary>
[Table("RefIdeaeducationalEnvironmentEc", Schema = "Common")]
public partial class RefIdeaeducationalEnvironmentEcEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefIdeaeducationalEnvironmentEc Properties"
    [Required(ErrorMessage="{0} is required.")]
    public System.Int32 RefIdeaeducationalEnvironmentEcid { get; set; }

    #endregion
}

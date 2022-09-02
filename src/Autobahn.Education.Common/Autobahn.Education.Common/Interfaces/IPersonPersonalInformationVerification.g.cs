//***************************************************************************
//* DomainName: Common Models
//* FileName:   IPersonPersonalInformationVerification.g.cs
//***************************************************************************

/// <summary>
/// The IPersonPersonalInformationVerification file
/// </summary>
public partial interface IPersonPersonalInformationVerification
{
    #region "IPersonPersonalInformationVerification Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonAddress"/> model
    /// </summary>
    Guid? PersonAddressId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonDetail"/> model
    /// </summary>
    Guid? PersonDetailId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonTelephone"/> model
    /// </summary>
    Guid? PersonTelephoneId { get; set; }

    /// <summary>
    /// Personal Information Type
    /// <para>
    /// The type of personal information verified through the Personal Information Verification evidence.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20951">Personal Information Type</a>
    /// </para>
    /// </summary>
    Guid? RefPersonalInformationTypeId { get; set; }

    /// <summary>
    /// Personal Information Verification
    /// <para>
    /// The evidence by which a persons name, address, date of birth, etc. is confirmed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19611">Personal Information Verification</a>
    /// </para>
    /// </summary>
    Guid? RefPersonalInformationVerificationId { get; set; }

    #endregion
}

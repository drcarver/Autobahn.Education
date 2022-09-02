//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefMethodOfServiceDeliveryEntity.g.cs
//* Name:       Method of Service Delivery
//* Definition: The method by which the services will be provided.
//***************************************************************************

/// <summary>
/// Method of Service Delivery <see cref="RefMethodOfServiceDelivery"/>
/// <para>
/// The method by which the services will be provided.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20482">Method of Service Delivery</a>
/// </para>
/// </summary>
[Table("RefMethodOfServiceDelivery", Schema = "Common")]
[Comment("The method by which the services will be provided.")]
public partial class RefMethodOfServiceDeliveryEntity : ReferenceBaseEntity, IReferenceBase
{
}
